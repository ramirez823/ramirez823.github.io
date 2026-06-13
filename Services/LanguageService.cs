using Microsoft.JSInterop;
using Portafolio.Data;

namespace Portafolio.Services;

/// <summary>
/// Servicio singleton que mantiene el idioma actual y notifica a los
/// componentes cuando cambia. Persiste en localStorage.
/// Detecta el idioma del navegador en la primera visita.
/// </summary>
public class LanguageService
{
    private readonly IJSRuntime _js;
    private Lang _current = Lang.En;
    private bool _initialized = false;

    public event Action? OnChange;

    public Lang Current => _current;
    public bool IsEnglish => _current == Lang.En;

    public LanguageService(IJSRuntime js)
    {
        _js = js;
    }

    /// <summary>
    /// Llamar desde el layout al iniciar. Lee localStorage;
    /// si no hay, detecta del navegador.
    /// </summary>
    public async Task InitAsync()
    {
        if (_initialized) return;
        _initialized = true;

        try
        {
            // Intentar leer preferencia guardada
            var saved = await _js.InvokeAsync<string?>("localStorage.getItem", "portafolio.lang");
            if (!string.IsNullOrEmpty(saved) && Enum.TryParse<Lang>(saved, true, out var parsed))
            {
                _current = parsed;
                return;
            }

            // Detectar idioma del navegador
            var browserLang = await _js.InvokeAsync<string>("navigator.language");
            if (!string.IsNullOrEmpty(browserLang) && browserLang.StartsWith("es", StringComparison.OrdinalIgnoreCase))
            {
                _current = Lang.Es;
            }
        }
        catch
        {
            // Si JS no está listo o localStorage falla, mantener EN por defecto
        }
    }

    public async Task ToggleAsync()
    {
        _current = _current == Lang.En ? Lang.Es : Lang.En;
        try
        {
            await _js.InvokeVoidAsync("localStorage.setItem", "portafolio.lang", _current.ToString());
        }
        catch { /* ignore */ }
        OnChange?.Invoke();
    }

    public string T(string key) => Translations.T(_current, key);
    public string T(string key, params object[] args) => Translations.Format(_current, key, args);

    public void NotifyChanged() => OnChange?.Invoke();
}
