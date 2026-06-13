namespace Portafolio.Models;

/// <summary>
/// Modelo de un proyecto del portafolio.
/// La lista de proyectos vive en Data/ProyectosSeed.cs.
/// Cada proyecto es un repo separado, este portafolio es solo la vitrina.
/// </summary>
public class Proyecto
{
    public string Id { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string DescripcionCorta { get; set; } = string.Empty;
    public string DescripcionLarga { get; set; } = string.Empty;

    /// <summary>URL del repo en GitHub.</summary>
    public string UrlRepositorio { get; set; } = string.Empty;

    /// <summary>URL del deploy en vivo (opcional).</summary>
    public string? UrlDemo { get; set; }

    /// <summary>Ruta a la imagen principal (wwwroot/images/...).</summary>
    public string Imagen { get; set; } = string.Empty;

    /// <summary>Tecnologías usadas (para badges).</summary>
    public List<string> Stack { get; set; } = new();

    /// <summary>Tu rol específico en el proyecto.</summary>
    public string Rol { get; set; } = string.Empty;

    /// <summary>Estado: "completed" | "wip" | "archived".</summary>
    public string Estado { get; set; } = "completed";

    /// <summary>Destacado: aparece primero y más grande.</summary>
    public bool Destacado { get; set; } = false;

    /// <summary>Orden manual (menor = primero).</summary>
    public int Orden { get; set; } = 99;

    /// <summary>Fecha de inicio/fin (formato libre).</summary>
    public string Periodo { get; set; } = string.Empty;
}
