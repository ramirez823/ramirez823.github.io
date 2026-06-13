using Portafolio.Models;

namespace Portafolio.Data;

/// <summary>
/// Habilidades técnicas. Editar niveles (avanzado/intermedio/basico) y categorías.
/// </summary>
public static class SkillsSeed
{
    public static List<Skill> Todas => new()
    {
        // Lenguajes
        new() { Nombre = "C#", Nivel = "avanzado", Categoria = "Lenguajes" },
        new() { Nombre = "SQL (T-SQL)", Nivel = "avanzado", Categoria = "Lenguajes" },
        new() { Nombre = "JavaScript", Nivel = "basico", Categoria = "Lenguajes" },
        new() { Nombre = "HTML/CSS", Nivel = "intermedio", Categoria = "Lenguajes" },

        // Backend
        new() { Nombre = "ASP.NET Core", Nivel = "avanzado", Categoria = "Backend" },
        new() { Nombre = "Entity Framework Core", Nivel = "intermedio", Categoria = "Backend" },
        new() { Nombre = "Web API REST", Nivel = "intermedio", Categoria = "Backend" },
        new() { Nombre = "Razor Pages", Nivel = "intermedio", Categoria = "Backend" },
        new() { Nombre = "Blazor WASM", Nivel = "intermedio", Categoria = "Backend" },

        // Database
        new() { Nombre = "SQL Server", Nivel = "avanzado", Categoria = "Database" },
        new() { Nombre = "MySQL", Nivel = "intermedio", Categoria = "Database" },
        new() { Nombre = "PostgreSQL", Nivel = "basico", Categoria = "Database" },

        // DevOps / Tools
        new() { Nombre = "Git + GitHub", Nivel = "avanzado", Categoria = "DevOps" },
        new() { Nombre = "Docker", Nivel = "intermedio", Categoria = "DevOps" },
        new() { Nombre = "GitHub Actions (CI/CD)", Nivel = "basico", Categoria = "DevOps" },
        new() { Nombre = "Linux (Ubuntu)", Nivel = "intermedio", Categoria = "DevOps" },

        // Tools
        new() { Nombre = "VSCode + C# DevKit", Nivel = "avanzado", Categoria = "Tools" },
        new() { Nombre = "Visual Studio", Nivel = "intermedio", Categoria = "Tools" },
        new() { Nombre = "Postman / Swagger", Nivel = "avanzado", Categoria = "Tools" }
    };
}
