# ✨ MyFirtsProyAPIServer: API REST de Gestión de Empleados en C# (.NET)

MyFirtsProyAPIServer es una API REST creada con C# y ASP.NET Core para la gestión de empleados.
Incluye operaciones CRUD, conexión a base de datos, validaciones, buenas prácticas, documentación con Swagger y una arquitectura limpia ideal para aprendizaje o proyectos reales.

---

## 📁 Estructura del Proyecto
Este proyecto sirve como ejemplo para quienes desean aprender a construir APIs en .NET desde cero.

```
MyFirtsProyAPIServer/
├── Ecommerce.Domain            # Núcleo del negocio: entidades y contratos
│   └── Entities/              # Clases como Product, Category
│
├── Ecommerce.Application       # Lógica de aplicación (casos de uso)
│   ├── Interfaces/            # IProductService, ICategoryService
│   └── Services/             # Implementaciones de servicios
│
├── Ecommerce.Infrastructure    # Implementaciones técnicas
│   ├── Data/                  # AppDbContext y EF Core
│   ├── Interfaces/            # Contratos de repositorios (ICategoryRepository)
│   └── Repositories/          # Repositorios concretos usando EF Core
│
├── EcommerceApp.Web            # Capa de presentación (ASP.NET MVC)
│   └── Controllers/           # Controladores MVC (ProductController)
