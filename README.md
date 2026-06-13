# Portafolio — Daniel Ramirez Varela

Sitio de portafolio personal construido con **Blazor WebAssembly** y **.NET 8**.

Es la **vitrina** de mis proyectos. Cada proyecto vive en su propio repositorio; este sitio los presenta con descripción, stack, links al código y demo en vivo.

## Stack

- **.NET 8** (LTS)
- **Blazor WebAssembly** (standalone, sin backend)
- **CSS puro** con variables, tema dark, responsive
- **GitHub Pages / Cloudflare Pages** ready (sitio 100% estático al publicar)

## Estructura del proyecto

```
Portafolio/
├── Models/              Clases de datos (Proyecto, Skill, Experiencia, Perfil)
├── Data/                Seeds: lista de proyectos, skills, experiencia, perfil
│                        ← único lugar para editar el contenido del sitio
├── Components/          Componentes Blazor reutilizables
│   ├── ProjectCard.razor
│   ├── Section.razor
│   └── SkillBadge.razor
├── Layout/              MainLayout + NavMenu
├── Pages/               Páginas (rutas)
│   ├── Home.razor              → /
│   ├── Proyectos.razor         → /proyectos
│   ├── SobreMi.razor           → /sobre-mi
│   └── Contacto.razor          → /contacto
├── wwwroot/
│   ├── css/app.css     ← todo el CSS del sitio
│   ├── images/         ← imágenes de proyectos (SVG placeholders)
│   └── index.html
└── Program.cs
```

## Cómo correrlo localmente

```bash
dotnet restore
dotnet run
# Abre http://localhost:5160
```

## Cómo agregar un proyecto nuevo

1. Abre `Data/ProyectosSeed.cs`
2. Agrega una entrada nueva en la lista:

```csharp
new Proyecto
{
    Id = "mi-proyecto",
    Titulo = "Mi Proyecto Increíble",
    DescripcionCorta = "Una línea de qué hace.",
    DescripcionLarga = "Descripción más detallada...",
    UrlRepositorio = "https://github.com/tu-usuario/mi-proyecto",
    UrlDemo = null,  // o URL si hay deploy
    Imagen = "/images/mi-proyecto.svg",  // pon la imagen en wwwroot/images/
    Stack = new() { "C#", ".NET 8", "SQL Server" },
    Rol = "Backend, auth, DB",
    Estado = "completed",  // o "wip" o "archived"
    Destacado = true,      // aparece en la home
    Orden = 4,
    Periodo = "2026"
}
```

3. Listo. Aparece automáticamente en `/` y `/proyectos`.

## Cómo personalizar el sitio

| Quiero cambiar... | Editar archivo |
|---|---|
| Mi nombre, email, links | `Data/PerfilSeed.cs` |
| Mis skills y niveles | `Data/SkillsSeed.cs` |
| Mi experiencia / educación | `Data/ExperienciaSeed.cs` |
| Mis proyectos | `Data/ProyectosSeed.cs` |
| Colores del tema | `wwwroot/css/app.css` (`:root`) |
| Secciones de la home | `Pages/Home.razor` |

## Publicar (gratis)

Opción 1 — **Cloudflare Pages** (recomendado):
```bash
dotnet publish -c Release
# Sube el contenido de bin/Release/net8.0/wwwroot/ a Cloudflare Pages
```

Opción 2 — **GitHub Pages**:
```bash
dotnet publish -c Release -p:PublishBaseUrl=https://tu-usuario.github.io/Portafolio/
```

## Licencia

MIT — Usá la estructura como quieras.
