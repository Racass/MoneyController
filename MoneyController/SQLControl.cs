using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace MoneyController
{
    class SQLControl
    {
        SqlConnection conex;
        string cam = Directory.GetCurrentDirectory() + @"\config";
        string[] configReady;
        

        public SQLControl()
        {
            if (Directory.Exists(cam) && File.Exists(cam + @"\conex.ecfg"))
            {
                using (StreamReader littleFile = new StreamReader(cam + @"\conex.ecfg"))
                {
                   configReady = littleFile.ReadToEnd().Split('|');
                   littleFile.Close();
                }
                CriarConexao();
            }
            else
            {
                RefazerInfo();
                CriarConexao();
            }
        }



        void CriarConexao()
        {
                conex = new SqlConnection(@"Data Source=" + configReady[0] + ";" +
                                                 "Initial Catalog=" + configReady[1] + ";" +
                                                 "User id=" + configReady[2] + ";" +
                                                 "Password=" + configReady[3] + ";");
                try
                {
                    conex.Open();
                }
                catch(Exception)
                {
                    RefazerInfo();
                    CriarConexao();
                }
        }
        void RefazerInfo()
        {
            MessageBox.Show("Erro na conexão. Verifique seus dados", "Erro");
            InfoConexao info = new InfoConexao();
            info.ShowDialog();
            using (StreamReader littleFile = new StreamReader(cam + @"\conex.ecfg"))
            {
                configReady = littleFile.ReadToEnd().Split('|');
                littleFile.Close();
            }
        }
        public List<Lists.MoneyStorage> LerTabela(string qual)
        {
            string query = "select * from [dbo].[" + qual + "]";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
                var list = new List<Lists.MoneyStorage>();
                while (reader.Read())
                    list.Add(new Lists.MoneyStorage { Quantia = reader.GetString(0), Local = reader.GetString(1)
                                                    ,DinCard = reader.GetString(2), Data = reader.GetString(3)
                                                    ,Hora = reader.GetString(4), PlusMinus = reader.GetString(5)});


                return list;
            }
        }
        public void CreateTable(string query)
        {
            if(query == null)
                query = "CREATE TABLE [dbo].[MoneyStorage]  ( [Quantia] integer, [Local] nchar(200), [DinCard] nchar(50), [Data] nchar(50), [Hora] nchar(50), [PlusMinus] nchar(50))";
            SqlCommand comando = new SqlCommand(query,conex);
        }
        public bool InsertInto(string quantia, string local, string DinCard, string data, string hora, string PlusMinus)
        {
            using(SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "INSERT INTO [dbo].[MoneyStorage] ( [Quantia], [Local], [Data], [DinCard], [Hora], [PlusMinus]) VALUES ( '" + quantia +"', '" + local + "', '" + data + "', '" + DinCard + "', '" + hora + "', '" + PlusMinus + "')";
                try
                {
                    comando.ExecuteNonQuery();
                    return true;
                }

                catch (Exception)
                {
                    return false;
                }
            }
        }
        public void Truncate()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "TRUNCATE TABLE [dbo].[MoneyStorage]";
                comando.ExecuteNonQuery();
            }
        }
        public bool NextMonth()
        {
            if (DevoCopiar())
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conex;
                    comando.CommandText = "INSERT INTO [dbo].[MoneyLegacy] SELECT * FROM [dbo].[MoneyStorage]";
                    try
                    {
                        comando.ExecuteNonQuery();
                        Truncate();
                        return true;
                    }

                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public bool DevoCopiar()
        {
            string query = "select * from [dbo].[MoneyStorage]";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
                try
                {
                    if (Convert.ToDateTime(reader.GetString(3).ToString()).Month == DateTime.Now.Month)
                        return false;

                    else
                        return true;
                }

                catch(Exception)
                {
                    return false;
                }
                    
            }
        }
        public void DeleteRow(string Quantia, string Local, string DinCard, string Data, string Hora, string PlusMinus)
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "DELETE FROM [dbo].[MoneyStorage] WHERE Quantia = '" + Quantia + "'" +
                                      " AND Local = '" + Local + "'" + " AND DinCard = '" + DinCard + "'" +
                                      " AND Data = '" + Data + "'" + " AND Hora = '" + Hora + "'";
                try
                {
                    comando.ExecuteNonQuery();
                    return;
                }

                catch (Exception)
                {
                    return;
                }
            }
        }
        public List<Lists.MoneyStorageBackUp> LerTabelaBackUp(string qual)
        {
            string query = "select * from [dbo].[" + qual + "]";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
                var list = new List<Lists.MoneyStorageBackUp>();
                while (reader.Read())
                    list.Add(new Lists.MoneyStorageBackUp
                    {
                        Quantia = reader.GetString(0)
                    ,
                        Local = reader.GetString(1)
                    ,
                        DinCard = reader.GetString(2)
                    ,
                        Data = reader.GetString(3)
                    ,
                        Hora = reader.GetString(4)
                    ,
                        PlusMinus = reader.GetString(5)
                    ,
                        DataBK = reader.GetString(6)
                    });


                return list;
            }
        }
        public void MakeBackUp()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                ApagarBackUp();
                try
                {
                    comando.CommandText = "INSERT INTO [dbo].[MoneyStorageBackUp] ( [Quantia], [Local] , [DinCard], [Data] , [Hora], [PlusMinus]) select * from [dbo].[MoneyStorage]";
                    comando.ExecuteNonQuery();
                    comando.CommandText = "UPDATE [dbo].[MoneyStorageBackUp] SET [DataBK] = '" + DateTime.Now.ToShortDateString() + "'";
                    comando.ExecuteNonQuery();
                }

                catch (Exception)
                {
                    return;
                }
            }
        }
        public void ApagarBackUp()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "DELETE FROM [dbo].[MoneyStorageBackUp]";
                try
                {
                    comando.ExecuteNonQuery();
                    return;
                }

                catch (Exception)
                {
                    return;
                }
            }
        }
    }
}
