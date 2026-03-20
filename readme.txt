Scaffold DB
cd BaseballStatSearchMVC
dotnet ef dbcontext scaffold "Data Source=localhost\SQLEXPRESS;Initial Catalog=retro;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0" Microsoft.EntityFrameworkCore.SqlServer -o Models -f