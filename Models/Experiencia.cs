namespace Portafolio.Models;

/// <summary>
/// Entrada de experiencia laboral o académica.
/// Tipo: "laboral" | "educacion" | "certificacion".
/// </summary>
public class Experiencia
{
    public string Titulo { get; set; } = string.Empty;
    public string Organizacion { get; set; } = string.Empty;
    public string Periodo { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public string Tipo { get; set; } = "laboral";
    public string? Ubicacion { get; set; }
}
