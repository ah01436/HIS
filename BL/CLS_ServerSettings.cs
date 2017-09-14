using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIS
{
    class CLS_ServerSettings
    {
        public bool TestConnection(string ServerName , string database,string UserName , string Password , bool ISWinAuth)
        {
            Connection conn = new Connection(ServerName ,database ,UserName , Password , ISWinAuth);
            bool temp = conn.OpenConnection();
            conn.CloseConnection();
            return temp;
        }
    }
}
