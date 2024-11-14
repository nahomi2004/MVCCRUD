# MVCCRUD
Taller Individual 04 de la materia Fundamentos de Ing. de SW

Este codigo fue gracias a:
https://www.youtube.com/watch?v=dhguXv3vRIk&list=TLPQMTMxMTIwMjTe_cvj6-xBiQ&index=7

Notas, codigo o comandos importantes:

Connection string:

Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

Ruta proyecto MVCCRUD:
C:\Users\nahom\source\repos

Ruta query:
C:\Users\nahom\OneDrive\Documentos\SQL Server Management Studio

Scaffold-DbContext "server=Nahomi\SQLEXPRESS; database=MVCCRUD; integrated security=true; TrustServerCertificate=Yes" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models

Scaffold-DbContext "server=Nahomi\SQLEXPRESS; database=MVCCRUD; integrated security=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

services.AddDbContext<conexion>(options => options.UseSqlServer(Configuration.GetConnectionString(“conexion”)));

builder.Services.AddDbContext<MvccrudContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

"AllowedHosts": "*",
"ConnectionStrings": {
  "conexion": "server=Nahomi\\SQLEXPRESS; database=MVCCRUD; integrated security=true; TrustServerCertificate=Yes"

<a asp-action="Edit" class="btn btn-warning" asp-route-id="@item.Id">Edit</a> |
<a asp-action="Details" class="btn btn-primary" asp-route-id="@item.Id">Details</a> |
    <a asp-action="Delete" class="btn btn-danger" asp-route-id="@item.Id">Delete</a>
