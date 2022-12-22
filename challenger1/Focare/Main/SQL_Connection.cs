using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    static class SQL_Connection
    {
        private const string serverNme = "localhost";
        private const string databaseName = "Crud_focare";
        private const string userName = "darkstar";
        private const string userPass = "LeonardiSRT2033";
        private const int serverPort = 3306;

        static public string connectionStr = $"server={serverNme};database={databaseName};uid={userName};pwd={userPass};port={serverPort}";
    }
}
