# ✨ MyFirtsProyAPIServer: API REST de Gestión de Empleados en C# (.NET)

MyFirtsProyAPIServer es una API REST creada con C# y ASP.NET Core para la gestión de empleados.
Incluye operaciones CRUD, conexión a base de datos, validaciones, buenas prácticas, documentación con Swagger y una arquitectura limpia ideal para aprendizaje o proyectos reales.

---

## 📁 Estructura del Proyecto

Este proyecto sirve como ejemplo para quienes desean aprender a construir APIs en .NET desde cero.

```
MyFirtsProyAPIServer/
├── Dependencias            
│   └── Paquetes/             
│
├── Properties       
│   └── launchSetting.json                     
│
├── Controller   
│   ├── EmployeeController.cs           
│   └── WaetherForecastController.cs                           
│
├── Data   
│   └── MyAppContext.cs                                        
│
├── Migrations/   
│   ├── 20251127225243_Creation Model Employee.cs         
│   └── MyAppContextModelSnapshot.cs
|
├── Models/   
│   ├──  Employee.cs           
│   └──  EmployeeDTO.cs
|
├── appsettings.json
|
├── Program.cs
|
└── WeatherForecast.cs

```

---

## ⚙️ Tecnologías Utilizadas

- ASP.NET Core API
- SQL Server (o SQLite)
- .NET 7.0 / .NET 8.0
- Microsoft.AspNetCore.OpenApi (9.0.0)
- Microsoft.EntityFrameworkCore (9.0.0)
-	Microsoft.EntityFrameworkCore.SqlServer (9.0.0)
-	Microsoft.EntityFramework Core.Tools (9.0.0)
-	Swashbuckle.AspNetCore.SwaggerGen (9.0.0)
-	Swashbuckle.AspNetCore.SwaggerUI (9.0.0)

---


## 🚀 Instalación y Ejecución

### 1. Clona el proyecto

```bash
https://github.com/BannerAlfredo/MyFirtsProyAPIServer.git
cd MyFirtsProyAPIServer
```
### 2. Configura la cadena de conexión

Edita el archivo `appsettings.json` en `MyFirtsProyAPIServer`:

```json
"ConnectionStrings": {
  "DefaulConnection": "Data Source=BANNER;Initial Catalog=My_Firts_Api;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False"
},
```

### 3. Aplica las migraciones

```bash
cd MyFirtsProyAPIServer
dotnet ef database update
```

### 4. Ejecuta la aplicación

```bash
dotnet run HTPP --MyFirtsProyAPIServer
```

---

## 📚 Principios Aplicados

### ✅ METODOS APLICADOS

- public IActionResult GetAllEmpleados: `[HttpGet]`, Leer Empleados.
- public IActionResult AddEmployee: `[HttpPost]`, Agregar Empleados.
- public IActionResult DeleteEmployee:  `[HttpDelete]`, Eliminar Empleados.

---

## 🧑‍💻 Autor

Desarrollado por Banner Rodriguez

---

## 📄 Licencia

Este proyecto está bajo la licencia MIT.
