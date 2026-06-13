using Portafolio.Models;

namespace Portafolio.Data;

/// <summary>
/// Experiencia laboral + educación. Ordenar de más reciente a más antiguo.
/// </summary>
public static class ExperienciaSeed
{
    public static List<Experiencia> Toda => new()
    {
        new()
        {
            Titulo = "Ingeniería en Sistemas",
            Organizacion = "Universidad [Tu Universidad]",
            Periodo = "2022 — 2026 (en curso)",
            Descripcion = "Cursando el último año. Foco en desarrollo de software, bases de datos y arquitectura de sistemas. " +
                         "Tesis: SistemaOpticaComunal — sistema de gestión empresarial en .NET 8 + SQL Server.",
            Tipo = "educacion",
            Ubicacion = "Costa Rica"
        },
        new()
        {
            Titulo = "Desarrollador Backend (prácticas / freelance)",
            Organizacion = "[Empresa o cliente]",
            Periodo = "2025",
            Descripcion = "Desarrollo de APIs y mantenimiento de bases de datos SQL Server. " +
                         "Trabajo con ASP.NET Core, Entity Framework y patrones Clean Architecture.",
            Tipo = "laboral",
            Ubicacion = "Costa Rica"
        }
    };
}
