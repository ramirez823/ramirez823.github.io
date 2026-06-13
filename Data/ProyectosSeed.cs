using Portafolio.Models;

namespace Portafolio.Data;

/// <summary>
/// Lista de proyectos del portafolio.
/// Para agregar un proyecto nuevo: agregar una entrada acá con los links
/// al repo de GitHub y (opcional) deploy. El resto se renderiza automático.
/// </summary>
public static class ProyectosSeed
{
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
            Imagen = "/images/Proyecto-optica.svg",
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
            Imagen = "/images/Proyecto-scraper.svg",
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
            Imagen = "/images/Proyecto-api.svg",
            Stack = new() { "C#", ".NET 8", "ASP.NET Core", "Clean Architecture", "EF Core", "SQL Server", "SQLite", "JWT", "FluentValidation", "Bogus", "Swagger", "RFC 7807" },
            Rol = "Backend, arquitectura, modelado de dominio",
            Estado = "completed",
            Destacado = true,
            Orden = 3,
            Periodo = "2026"
        }
    };
}
