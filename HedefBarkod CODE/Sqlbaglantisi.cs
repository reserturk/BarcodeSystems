using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace HedefBarkod
{
    class Sqlbaglantisi
    {
       public OleDbConnection baglanti()
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
            baglan.Open();
            return baglan;
        }
    }
}
