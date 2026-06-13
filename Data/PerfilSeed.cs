using Portafolio.Models;

namespace Portafolio.Data;

/// <summary>
/// Datos del perfil. Editar acá para actualizar nombre, links, etc.
/// </summary>
public static class PerfilSeed
{
    public static Perfil Actual => new()
    {
        Nombre = "Daniel Ramirez",
        Titulo = "Ingeniero en Sistemas | Backend .NET",
        Tagline = "Construyo backends robustos con .NET, C# y SQL Server. Próximo a graduarme, ya trabajo con patrones enterprise reales.",
        SobreMi = "Soy estudiante de último año de Ingeniería en Sistemas con foco en desarrollo backend .NET. " +
                  "Me especializo en C#, ASP.NET Core, SQL Server y Entity Framework Core, y vengo aplicando patrones " +
                  "de Clean Architecture y Vertical Slices en proyectos académicos y personales. " +
                  "Me interesa el software empresarial serio: APIs REST bien diseñadas, bases de datos bien modeladas, " +
                  "tests automatizados, y código que se pueda mantener a 6 meses vista.",
        Ubicacion = "Costa Rica",
        Email = "cdanielrv.823@gmail.com",
        LinkedIn = "https://linkedin.com/in/daniramiv",
        GitHub = "https://github.com/ramirez823",
        CurriculumUrl = "/cv.pdf",
        FotoUrl = "/images/foto.jpg"
    };
}
