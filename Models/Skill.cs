namespace Portafolio.Models;

/// <summary>
/// Habilidad técnica con nivel.
/// Nivel: "avanzado" | "intermedio" | "basico".
/// Categoria: "Backend" | "Frontend" | "Database" | "DevOps" | "Tools" | "Lenguajes".
/// </summary>
public class Skill
{
    public string Nombre { get; set; } = string.Empty;
    public string Nivel { get; set; } = "intermedio";
    public string Categoria { get; set; } = "Backend";
    public string? Icono { get; set; }
}
