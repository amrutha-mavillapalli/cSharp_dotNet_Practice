namespace MVCApplicationPrac.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    // "ConnectionStrings": {
      //   "DefaultConnection": "Server=tcp:localhost.database.windows.net,1433;Initial Catalog=Books;Persist Security Info=False;User ID=sa;Password=<SQLConnect1!>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
      // }
}
