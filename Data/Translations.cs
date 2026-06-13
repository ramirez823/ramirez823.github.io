namespace Portafolio.Data;

/// <summary>
/// Diccionario de traducciones del sitio.
/// Idioma por defecto: inglés. El sitio arranca en EN.
/// </summary>
public static class Translations
{
    /// <summary>
    /// Devuelve el texto en el idioma actual.
    /// </summary>
    public static string T(Lang lang, string key) =>
        Dictionary.TryGetValue(key, out var entry) ? entry.Get(lang) : key;

    public static Dictionary<string, Bilingual> Dictionary { get; } = new()
    {
        // ============== NAVBAR ==============
        ["nav.inicio"]   = new("Home",      "Inicio"),
        ["nav.proyectos"]= new("Projects",  "Proyectos"),
        ["nav.sobreMi"]  = new("About",     "Sobre mí"),
        ["nav.contacto"] = new("Contact",   "Contacto"),
        ["nav.cv"]       = new("Resume",    "CV"),

        // ============== HERO ==============
        ["hero.greeting"]    = new("Hi, I'm",         "Hola, soy"),
        ["hero.tagline"]     = new("I build solid backends with .NET, C# and SQL Server. About to graduate, already working with real enterprise patterns.",
                                   "Construyo backends robustos con .NET, C# y SQL Server. Próximo a graduarme, ya trabajo con patrones enterprise reales."),
        ["hero.verProyectos"]= new("View projects",   "Ver proyectos"),
        ["hero.hablemos"]    = new("Let's talk",      "Hablemos"),

        // ============== SERVICIOS ==============
        ["sec.servicios.eyebrow"] = new("Services",        "Servicios"),
        ["sec.servicios.titulo"]  = new("What I do",       "Lo que hago"),
        ["sec.servicios.sub"]     = new("Focused on backend, not scattered.",
                                        "Foco en backend, no dispersión"),

        ["srv.1.tag"]   = new("Backend",       "Backend"),
        ["srv.1.title"] = new(".NET & APIs",   ".NET & APIs"),
        ["srv.1.desc"]  = new("Design and build REST APIs with ASP.NET Core, Entity Framework and JWT auth. Clean Architecture and code that scales.",
                              "Diseño y construyo APIs REST con ASP.NET Core, Entity Framework y autenticación JWT. Clean Architecture y código que escala."),

        ["srv.2.tag"]   = new("Database",      "Database"),
        ["srv.2.title"] = new("SQL Server",    "SQL Server"),
        ["srv.2.desc"]  = new("Relational modeling, optimized queries, EF Core migrations. PostgreSQL and MySQL when the stack demands it.",
                              "Modelado relacional, consultas optimizadas, migraciones con EF Core. PostgreSQL y MySQL cuando el stack lo pide."),

        ["srv.3.tag"]   = new("Architecture",  "Arquitectura"),
        ["srv.3.title"] = new("Clean & Vertical", "Clean & Vertical"),
        ["srv.3.desc"]  = new("Enterprise patterns: Clean Architecture, Vertical Slices, Repository, Unit of Work. Structure that holds up 6 months later.",
                              "Patrones enterprise: Clean Architecture, Vertical Slices, Repository, Unit of Work. Estructura que se mantiene a 6 meses."),

        ["srv.4.tag"]   = new("DevOps",        "DevOps"),
        ["srv.4.title"] = new("Docker & CI/CD","Docker & CI/CD"),
        ["srv.4.desc"]  = new("Docker Compose, GitHub Actions, deploy to Azure or Railway. Pipelines that fail fast and show the error clearly.",
                              "Docker Compose, GitHub Actions, deploy en Azure o Railway. Pipelines que fallan rápido y muestran el error claro."),

        // ============== PROYECTOS ==============
        ["sec.proyectos.eyebrow"] = new("Portfolio",  "Portfolio"),
        ["sec.proyectos.titulo"]  = new("Featured projects", "Proyectos destacados"),
        ["sec.proyectos.sub"]     = new("The best of what I've built",
                                        "Lo mejor de lo que he construido"),
        ["sec.proyectos.verTodos"]= new("See all projects →", "Ver todos los proyectos →"),

        // Estados
        ["estado.completado"]  = new("Completed",     "Completado"),
        ["estado.wip"]         = new("In progress",   "En desarrollo"),
        ["estado.archived"]    = new("Archived",      "Archivado"),

        // Botones cards
        ["card.verCodigo"] = new("View code",   "Ver código"),
        ["card.demo"]      = new("Live demo",   "Demo en vivo"),

        // ============== STACK ==============
        ["sec.stack.eyebrow"] = new("Stack",         "Stack"),
        ["sec.stack.titulo"]  = new("Tech stack",    "Stack técnico"),
        ["sec.stack.sub"]     = new("What I use every day",
                                    "Lo que uso día a día"),

        // Categorías
        ["cat.lenguajes"]  = new("Languages",  "Lenguajes"),
        ["cat.backend"]    = new("Backend",    "Backend"),
        ["cat.database"]   = new("Database",   "Database"),
        ["cat.devops"]     = new("DevOps",     "DevOps"),
        ["cat.tools"]      = new("Tools",      "Tools"),

        // Niveles
        ["nivel.avanzado"]  = new("Advanced",  "Avanzado"),
        ["nivel.intermedio"]= new("Intermediate", "Intermedio"),
        ["nivel.basico"]    = new("Basic",     "Básico"),

        // ============== SOBRE MI ==============
        ["sec.sobre.eyebrow"] = new("About me",     "Sobre mí"),
        ["sec.sobre.titulo"]  = new("About me",     "Sobre mí"),
        ["sec.sobre.sub"]     = new("Who's behind the code", "Quién está detrás del código"),

        ["sobre.bio"] = new(
            "I'm a last-year Systems Engineering student focused on backend .NET development. I specialize in C#, ASP.NET Core, SQL Server and Entity Framework Core, and I've been applying Clean Architecture and Vertical Slices patterns in academic and personal projects. I'm into serious enterprise software: well-designed REST APIs, properly modeled databases, automated tests, and code that stays maintainable 6 months later.",
            "Soy estudiante de último año de Ingeniería en Sistemas con foco en desarrollo backend .NET. Me especializo en C#, ASP.NET Core, SQL Server y Entity Framework Core, y vengo aplicando patrones de Clean Architecture y Vertical Slices en proyectos académicos y personales. Me interesa el software empresarial serio: APIs REST bien diseñadas, bases de datos bien modeladas, tests automatizados, y código que se pueda mantener a 6 meses vista."),

        ["sobre.ubicacion"] = new("Costa Rica", "Costa Rica"),

        ["sec.skills.eyebrow"] = new("Skills",      "Skills"),
        ["sec.skills.titulo"]  = new("Tech stack",  "Stack técnico"),
        ["sec.skills.sub"]     = new("With honest levels", "Con niveles honestos"),

        ["sec.exp.eyebrow"] = new("Path",          "Trayectoria"),
        ["sec.exp.titulo"]  = new("Education & experience", "Formación y experiencia"),

        // ============== CONTACTO ==============
        ["sec.contacto.eyebrow"] = new("Connect",     "Conectemos"),
        ["sec.contacto.titulo"]  = new("Let's talk",  "Hablemos"),
        ["sec.contacto.sub"]     = new("I'm open to junior/mid backend .NET opportunities",
                                       "Estoy abierto a oportunidades junior/mid en backend .NET"),

        ["contacto.email"]   = new("Email",          "Email"),
        ["contacto.linkedin"]= new("LinkedIn",       "LinkedIn"),
        ["contacto.github"]  = new("GitHub",         "GitHub"),
        ["contacto.linkedinDesc"] = new("Let's connect professionally",
                                        "Conectemos en profesional"),
        ["contacto.githubDesc"]   = new("Check out my open code",
                                        "Revisa mi código abierto"),

        // ============== FILTROS PROYECTOS ==============
        ["filtro.todos"]       = new("All",          "Todos"),
        ["filtro.destacados"]  = new("Featured",     "Destacados"),
        ["filtro.completados"] = new("Completed",    "Completados"),
        ["filtro.wip"]         = new("In progress",  "En desarrollo"),
        ["filtro.empty"]       = new("No projects in this filter yet.",
                                    "No hay proyectos en este filtro todavía."),

        // ============== FOOTER ==============
        ["footer.copy"] = new("© {0} — Built with Blazor WASM + .NET 8",
                              "© {0} — Construido con Blazor WASM + .NET 8"),

        // ============== BOOT LOADER ==============
        ["boot.loading"] = new("loading portfolio…", "cargando portafolio…"),

        // ============== PAGE TITLES ==============
        ["title.home"]     = new("{0} — Portfolio",          "{0} — Portafolio"),
        ["title.proyectos"]= new("Projects — {0}",          "Proyectos — {0}"),
        ["title.sobreMi"]  = new("About — {0}",             "Sobre mí — {0}"),
        ["title.contacto"] = new("Contact — {0}",           "Contacto — {0}"),

        // ============== PERFIL ==============
        ["perfil.tagline"] = new("I build solid backends with .NET, C# and SQL Server. About to graduate, already working with real enterprise patterns.",
                                 "Construyo backends robustos con .NET, C# y SQL Server. Próximo a graduarme, ya trabajo con patrones enterprise reales."),
        ["perfil.titulo"]  = new("Systems Engineer | Backend .NET",
                                 "Ingeniero en Sistemas | Backend .NET"),
        ["perfil.sobreMi"] = new(
            "I'm a last-year Systems Engineering student focused on backend .NET development. I specialize in C#, ASP.NET Core, SQL Server and Entity Framework Core, and I've been applying Clean Architecture and Vertical Slices patterns in academic and personal projects. I'm into serious enterprise software: well-designed REST APIs, properly modeled databases, automated tests, and code that stays maintainable 6 months later.",
            "Soy estudiante de último año de Ingeniería en Sistemas con foco en desarrollo backend .NET. Me especializo en C#, ASP.NET Core, SQL Server y Entity Framework Core, y vengo aplicando patrones de Clean Architecture y Vertical Slices en proyectos académicos y personales. Me interesa el software empresarial serio: APIs REST bien diseñadas, bases de datos bien modeladas, tests automatizados, y código que se pueda mantener a 6 meses vista."),

        // Hero code preview
        ["hero.code.rol"]     = new("Backend .NET",          "Backend .NET"),
        ["hero.code.stack"]   = new("[\"C#\", \".NET 8\", \"SQL Server\", \"EF Core\"]",
                                    "[\"C#\", \".NET 8\", \"SQL Server\", \"EF Core\"]"),
        ["hero.code.buscando"]= new("Junior/mid opportunity", "Oportunidad junior/mid"),
        ["hero.code.status"]  = new("🟢 available",         "🟢 disponible"),
    };

    public static string Format(Lang lang, string key, params object[] args)
    {
        var template = T(lang, key);
        return args.Length > 0 ? string.Format(template, args) : template;
    }
}

/// <summary>
/// Par de strings bilingüe. Inglés primero (idioma por defecto), español segundo.
/// </summary>
public record Bilingual(string En, string Es)
{
    public string Get(Lang lang) => lang switch
    {
        Lang.Es => Es,
        _ => En
    };
}

public enum Lang { En, Es }
