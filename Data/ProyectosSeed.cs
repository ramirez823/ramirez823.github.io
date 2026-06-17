using Portafolio.Models;

namespace Portafolio.Data;

/// <summary>
/// Lista de proyectos del portafolio.
/// Para agregar un proyecto nuevo: agregar una entrada acá con los links
/// al repo de GitHub y (opcional) deploy. El resto se renderiza automático.
/// </summary>
public static class ProyectosSeed
{
    // Project thumbnails are inlined as base64 data URIs. They are tiny
    // (~1 KB SVG → ~1.4 KB base64) and would otherwise cost 4 separate
    // HTTP requests below the fold. Swap back to file paths (e.g. "/images/foo.png")
    // when you have real screenshots to ship.
    private const string ImgDefault = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCA4MDAgNDAwIiBwcmVzZXJ2ZUFzcGVjdFJhdGlvPSJ4TWlkWU1pZCBzbGljZSI+CiAgPGRlZnM+CiAgICA8bGluZWFyR3JhZGllbnQgaWQ9ImciIHgxPSIwJSIgeTE9IjAlIiB4Mj0iMTAwJSIgeTI9IjEwMCUiPgogICAgICA8c3RvcCBvZmZzZXQ9IjAlIiBzdG9wLWNvbG9yPSIjMWExYzI4Ii8+CiAgICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iIzI1MjgzNyIvPgogICAgPC9saW5lYXJHcmFkaWVudD4KICAgIDxyYWRpYWxHcmFkaWVudCBpZD0iZ2xvdyIgY3g9IjIwJSIgY3k9IjIwJSIgcj0iNjAlIj4KICAgICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0icmdiYSg5OSwxMDIsMjQxLDAuNCkiLz4KICAgICAgPHN0b3Agb2Zmc2V0PSIxMDAlIiBzdG9wLWNvbG9yPSJyZ2JhKDk5LDEwMiwyNDEsMCkiLz4KICAgIDwvcmFkaWFsR3JhZGllbnQ+CiAgPC9kZWZzPgogIDxyZWN0IHdpZHRoPSI4MDAiIGhlaWdodD0iNDAwIiBmaWxsPSJ1cmwoI2cpIi8+CiAgPHJlY3Qgd2lkdGg9IjgwMCIgaGVpZ2h0PSI0MDAiIGZpbGw9InVybCgjZ2xvdykiLz4KICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0MDAsMjAwKSIgdGV4dC1hbmNob3I9Im1pZGRsZSIgZm9udC1mYW1pbHk9IkludGVyLCBzYW5zLXNlcmlmIj4KICAgIDx0ZXh0IHk9Ii0xMCIgZm9udC1zaXplPSI0MiIgZm9udC13ZWlnaHQ9IjcwMCIgZmlsbD0iI2Y1ZjZmYSI+UHJveWVjdG88L3RleHQ+CiAgICA8dGV4dCB5PSIzNSIgZm9udC1zaXplPSIxNiIgZmlsbD0iIzhhOGU5ZSIgZm9udC1mYW1pbHk9IkpldEJyYWlucyBNb25vLCBtb25vc3BhY2UiPlR1IHByw7N4aW1vIHByb3llY3RvPC90ZXh0PgogIDwvZz4KICA8ZyBzdHJva2U9IiMyYTJkM2UiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSI+CiAgICA8Y2lyY2xlIGN4PSI3MDAiIGN5PSI4MCIgcj0iNDAiLz4KICAgIDxjaXJjbGUgY3g9IjEwMCIgY3k9IjMyMCIgcj0iNjAiLz4KICA8L2c+Cjwvc3ZnPg==";
    private const string ImgApi = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCA4MDAgNDAwIiBwcmVzZXJ2ZUFzcGVjdFJhdGlvPSJ4TWlkWU1pZCBzbGljZSI+CiAgPGRlZnM+CiAgICA8bGluZWFyR3JhZGllbnQgaWQ9ImciIHgxPSIwJSIgeTE9IjAlIiB4Mj0iMTAwJSIgeTI9IjEwMCUiPgogICAgICA8c3RvcCBvZmZzZXQ9IjAlIiBzdG9wLWNvbG9yPSIjMWExYzI4Ii8+CiAgICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iIzI1MjgzNyIvPgogICAgPC9saW5lYXJHcmFkaWVudD4KICAgIDxyYWRpYWxHcmFkaWVudCBpZD0iZ2xvdyIgY3g9IjIwJSIgY3k9IjIwJSIgcj0iNjAlIj4KICAgICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0icmdiYSg5OSwxMDIsMjQxLDAuNCkiLz4KICAgICAgPHN0b3Agb2Zmc2V0PSIxMDAlIiBzdG9wLWNvbG9yPSJyZ2JhKDk5LDEwMiwyNDEsMCkiLz4KICAgIDwvcmFkaWFsR3JhZGllbnQ+CiAgPC9kZWZzPgogIDxyZWN0IHdpZHRoPSI4MDAiIGhlaWdodD0iNDAwIiBmaWxsPSJ1cmwoI2cpIi8+CiAgPHJlY3Qgd2lkdGg9IjgwMCIgaGVpZ2h0PSI0MDAiIGZpbGw9InVybCgjZ2xvdykiLz4KICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0MDAsMjAwKSIgdGV4dC1hbmNob3I9Im1pZGRsZSIgZm9udC1mYW1pbHk9IkludGVyLCBzYW5zLXNlcmlmIj4KICAgIDx0ZXh0IHk9Ii0xMCIgZm9udC1zaXplPSI0MiIgZm9udC13ZWlnaHQ9IjcwMCIgZmlsbD0iI2Y1ZjZmYSI+QVBJIFJFU1Q8L3RleHQ+CiAgICA8dGV4dCB5PSIzNSIgZm9udC1zaXplPSIxNiIgZmlsbD0iIzhhOGU5ZSIgZm9udC1mYW1pbHk9IkpldEJyYWlucyBNb25vLCBtb25vc3BhY2UiPi5ORVQgOCDCtyBFRiBDb3JlIMK3IEpXVDwvdGV4dD4KICA8L2c+CiAgPGcgc3Ryb2tlPSIjMmEyZDNlIiBzdHJva2Utd2lkdGg9IjEiIGZpbGw9Im5vbmUiPgogICAgPGNpcmNsZSBjeD0iNzAwIiBjeT0iODAiIHI9IjQwIi8+CiAgICA8Y2lyY2xlIGN4PSIxMDAiIGN5PSIzMjAiIHI9IjYwIi8+CiAgPC9nPgo8L3N2Zz4=";
    private const string ImgOptica = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCA4MDAgNDAwIiBwcmVzZXJ2ZUFzcGVjdFJhdGlvPSJ4TWlkWU1pZCBzbGljZSI+CiAgPGRlZnM+CiAgICA8bGluZWFyR3JhZGllbnQgaWQ9ImciIHgxPSIwJSIgeTE9IjAlIiB4Mj0iMTAwJSIgeTI9IjEwMCUiPgogICAgICA8c3RvcCBvZmZzZXQ9IjAlIiBzdG9wLWNvbG9yPSIjMWExYzI4Ii8+CiAgICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iIzI1MjgzNyIvPgogICAgPC9saW5lYXJHcmFkaWVudD4KICAgIDxyYWRpYWxHcmFkaWVudCBpZD0iZ2xvdyIgY3g9IjIwJSIgY3k9IjIwJSIgcj0iNjAlIj4KICAgICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0icmdiYSg5OSwxMDIsMjQxLDAuNCkiLz4KICAgICAgPHN0b3Agb2Zmc2V0PSIxMDAlIiBzdG9wLWNvbG9yPSJyZ2JhKDk5LDEwMiwyNDEsMCkiLz4KICAgIDwvcmFkaWFsR3JhZGllbnQ+CiAgPC9kZWZzPgogIDxyZWN0IHdpZHRoPSI4MDAiIGhlaWdodD0iNDAwIiBmaWxsPSJ1cmwoI2cpIi8+CiAgPHJlY3Qgd2lkdGg9IjgwMCIgaGVpZ2h0PSI0MDAiIGZpbGw9InVybCgjZ2xvdykiLz4KICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0MDAsMjAwKSIgdGV4dC1hbmNob3I9Im1pZGRsZSIgZm9udC1mYW1pbHk9IkludGVyLCBzYW5zLXNlcmlmIj4KICAgIDx0ZXh0IHk9Ii0xMCIgZm9udC1zaXplPSI0MiIgZm9udC13ZWlnaHQ9IjcwMCIgZmlsbD0iI2Y1ZjZmYSI+U2lzdGVtYU9wdGljYUNvbXVuYWw8L3RleHQ+CiAgICA8dGV4dCB5PSIzNSIgZm9udC1zaXplPSIxNiIgZmlsbD0iIzhhOGU5ZSIgZm9udC1mYW1pbHk9IkpldEJyYWlucyBNb25vLCBtb25vc3BhY2UiPkMjIMK3IC5ORVQgOCDCtyBTUUwgU2VydmVyPC90ZXh0PgogIDwvZz4KICA8ZyBzdHJva2U9IiMyYTJkM2UiIHN0cm9rZS13aWR0aD0iMSIgZmlsbD0ibm9uZSI+CiAgICA8Y2lyY2xlIGN4PSI3MDAiIGN5PSI4MCIgcj0iNDAiLz4KICAgIDxjaXJjbGUgY3g9IjEwMCIgY3k9IjMyMCIgcj0iNjAiLz4KICA8L2c+Cjwvc3ZnPg==";
    private const string ImgScraper = "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCA4MDAgNDAwIiBwcmVzZXJ2ZUFzcGVjdFJhdGlvPSJ4TWlkWU1pZCBzbGljZSI+CiAgPGRlZnM+CiAgICA8bGluZWFyR3JhZGllbnQgaWQ9ImciIHgxPSIwJSIgeTE9IjAlIiB4Mj0iMTAwJSIgeTI9IjEwMCUiPgogICAgICA8c3RvcCBvZmZzZXQ9IjAlIiBzdG9wLWNvbG9yPSIjMWExYzI4Ii8+CiAgICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iIzI1MjgzNyIvPgogICAgPC9saW5lYXJHcmFkaWVudD4KICAgIDxyYWRpYWxHcmFkaWVudCBpZD0iZ2xvdyIgY3g9IjIwJSIgY3k9IjIwJSIgcj0iNjAlIj4KICAgICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0icmdiYSg5OSwxMDIsMjQxLDAuNCkiLz4KICAgICAgPHN0b3Agb2Zmc2V0PSIxMDAlIiBzdG9wLWNvbG9yPSJyZ2JhKDk5LDEwMiwyNDEsMCkiLz4KICAgIDwvcmFkaWFsR3JhZGllbnQ+CiAgPC9kZWZzPgogIDxyZWN0IHdpZHRoPSI4MDAiIGhlaWdodD0iNDAwIiBmaWxsPSJ1cmwoI2cpIi8+CiAgPHJlY3Qgd2lkdGg9IjgwMCIgaGVpZ2h0PSI0MDAiIGZpbGw9InVybCgjZ2xvdykiLz4KICA8ZyB0cmFuc2Zvcm09InRyYW5zbGF0ZSg0MDAsMjAwKSIgdGV4dC1hbmNob3I9Im1pZGRsZSIgZm9udC1mYW1pbHk9IkludGVyLCBzYW5zLXNlcmlmIj4KICAgIDx0ZXh0IHk9Ii0xMCIgZm9udC1zaXplPSI0MiIgZm9udC13ZWlnaHQ9IjcwMCIgZmlsbD0iI2Y1ZjZmYSI+UlBBIOKAlCBTY3JhcGVyPC90ZXh0PgogICAgPHRleHQgeT0iMzUiIGZvbnQtc2l6ZT0iMTYiIGZpbGw9IiM4YThlOWUiIGZvbnQtZmFtaWx5PSJKZXRCcmFpbnMgTW9ubywgbW9ub3NwYWNlIj5DIyDCtyBTZWxlbml1bSDCtyBFeGNlbDwvdGV4dD4KICA8L2c+CiAgPGcgc3Ryb2tlPSIjMmEyZDNlIiBzdHJva2Utd2lkdGg9IjEiIGZpbGw9Im5vbmUiPgogICAgPGNpcmNsZSBjeD0iNzAwIiBjeT0iODAiIHI9IjQwIi8+CiAgICA8Y2lyY2xlIGN4PSIxMDAiIGN5PSIzMjAiIHI9IjYwIi8+CiAgPC9nPgo8L3N2Zz4=";

    public static List<Proyecto> Todos => new()
    {
        new Proyecto
        {
            Id = "sistema-optica-comunal",
            Titulo = "SistemaOpticaComunal",
            DescripcionCorta = "Sistema de gestión para óptica: pacientes, exámenes visuales, inventario y recetas.",
            DescripcionLarga = "Aplicación web ASP.NET Core 8 + SQL Server para una óptica comunitaria. " +
                              "Incluye gestión de pacientes, historial de exámenes visuales, control de inventario " +
                              "de lentes y armazones, emisión de recetas, y reportes. " +
                              "Proyecto de tesis de la carrera.",
            UrlRepositorio = "https://github.com/ramirez823/Sistema-Optica-Comunal",
            UrlDemo = null,
            Imagen = ImgOptica,
            Stack = new() { "C#", ".NET 8", "ASP.NET Core", "SQL Server", "Entity Framework Core", "Razor Pages" },
            Rol = "Backend, modelado de DB, auth",
            Estado = "completed",
            Destacado = true,
            Orden = 1,
            Periodo = "2025"
        },
        new Proyecto
        {
            Id = "scraper-empleos",
            Titulo = "RPA — Scraper de Empleos",
            DescripcionCorta = "Bot en C# que scrapea ofertas de empleo y las exporta a Excel.",
            DescripcionLarga = "Servicio de scraping que extrae ofertas de Computrabajo, las deduplica, " +
                              "filtra por palabras clave y exporta reportes a Excel con formato. " +
                              "Arquitectura en capas con repositorio en memoria y servicios intercambiables.",
            UrlRepositorio = "https://github.com/ramirez823/RPA-con-CSharp",
            UrlDemo = null,
            Imagen = ImgScraper,
            Stack = new() { "C#", ".NET 8", "Selenium", "ClosedXML", "Patrón Repository" },
            Rol = "Full project",
            Estado = "completed",
            Destacado = true,
            Orden = 2,
            Periodo = "2025"
        },
        new Proyecto
        {
            Id = "hotel-reservation-api",
            Titulo = "Hotel Reservation API",
            DescripcionCorta = "API REST en .NET 8 con Clean Architecture, JWT, EF Core, FluentValidation y seed con Bogus.",
            DescripcionLarga = "API REST para gestión de reservas de hotel: autenticación JWT con roles, " +
                              "validación con FluentValidation, repositorios por entidad, " +
                              "reglas de negocio en el Domain (overlap de fechas, cálculo de TotalPrice, " +
                              "cancelación que libera la habitación) y errores RFC 7807. " +
                              "Soporta SQL Server con fallback automático a SQLite. " +
                              "Swagger con esquema Bearer preconfigurado, seed automático en Development " +
                              "(1 admin, 10 guests, 20 habitaciones, 30 reservas).",
            UrlRepositorio = "https://github.com/ramirez823/Hotel-Reservation-API",
            UrlDemo = null,
            Imagen = ImgApi,
            Stack = new() { "C#", ".NET 8", "ASP.NET Core", "Clean Architecture", "EF Core", "SQL Server", "SQLite", "JWT", "FluentValidation", "Bogus", "Swagger", "RFC 7807" },
            Rol = "Backend, arquitectura, modelado de dominio",
            Estado = "completed",
            Destacado = true,
            Orden = 3,
            Periodo = "2026"
        }
    };
}
