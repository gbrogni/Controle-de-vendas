using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoDeCustos.Connection
{
  class Conn
  {
    private static string server = @"DESKTOP-MVV8N06\SQLEXPRESS";
    private static string dataBase = "Movtech";
    private static string user = "sa";
    private static string password = "123";

    public static string StrCon
    {
      get { return "Data Source=" + server + "; Integrated Security=False;Initial Catalog=" + dataBase + "; User ID=" + user + "; Password=" + password; }
    }
  }
}
