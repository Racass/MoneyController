using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace MoneyController.BD.MSSQL
{
    class MSSQLConnector
    {
        SqlConnection conex;
        public SqlConnection GetMSSQLConn
        {
            get
            {
                if (conex != null)
                    return conex;
                else
                    throw new Exception("Conexão não realizada.");
            }
        }

        public MSSQLConnector()
        {
            conecta();
        }
        void conecta()
        {
            conex = new SqlConnection(montaStringConex());
            conex.Open();
        }
        string montaStringConex()
        {
            if (Properties.Settings.Default.DataSource == "" || Properties.Settings.Default.InitialCatalog == "" || Properties.Settings.Default.User == "" || Properties.Settings.Default.Password == "")
                throw new Exception("Cheque seus dados de conexão.");
            string conn;
            conn =  "Data Source=" + Properties.Settings.Default.DataSource + ";";
            conn += "Initial Catalog=" + Properties.Settings.Default.InitialCatalog + ";" ;
            conn += "User id=" + Properties.Settings.Default.User + ";";
            conn += "Password=" + Properties.Settings.Default.Password + ";";

            return conn;
        }
    }
}
