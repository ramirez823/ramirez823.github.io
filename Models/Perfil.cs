namespace Portafolio.Models;

/// <summary>
/// Datos estáticos del perfil. Se cargan una vez desde PerfilSeed.
/// </summary>
public class Perfil
{
    public string Nombre { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string SobreMi { get; set; } = string.Empty;
    public string Ubicacion { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string CurriculumUrl { get; set; } = string.Empty;
    public string FotoUrl { get; set; } = string.Empty;
}
