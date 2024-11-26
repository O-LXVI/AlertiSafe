- Cambios para que la db funcione
1. Abrir proyecto en el IDE de preferencia
   1. Buscar carpeta **Modelo**
   2. En la carpeta modelo buscar **IdentifierContext.cs**
2. En **IdentifierContext.cs** hacer lo siguiente
   1. Buscar en la linea 22 `=> optionsBuilder.UseSqlite("Data Source=C:\\Users\\manub\\Desktop\\db\\identifier.sqlite");`
   2. Cambiar la zona de `("Data Source=C:\\Users\\manub\\Desktop\\db\\identifier.sqlite");` Por la ruta que tengas en tu pc
3. Una vez cambiado debe ejecutar el siguiente codigo en la terminal de el IDE de preferencia
   1. y lanzar el siguiente comando  `dotnet ef dbcontext scaffold "Data Source=C:\Users\manub\Desktop\db\identifier.sqlite" Microsoft.EntityFrameworkCore.Sqlite -o Modelo `
   2. Donde tienes que remplazar lo mismo que remplazaste en el codigo `"Data Source=C:\Users\manub\Desktop\db\identifier.sqlite"` echo eso deberia funcionar perfectamente 
