using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            catch (Exception)
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
            string PlusMinus = "";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
                var list = new List<Lists.MoneyStorage>();
                while (reader.Read())
                {
                    if (reader.GetString(5).Replace(" ", "") == "Plus")
                        PlusMinus = "Recebimento";
                    else
                        PlusMinus = "Pagamento";
                    list.Add(new Lists.MoneyStorage
                    {
                        Quantia = reader.GetString(0),
                        Local = reader.GetString(1)
                    ,
                        DinCard = reader.GetString(2),
                        Data = reader.GetString(3)
                    ,
                        Hora = reader.GetString(4),
                        PagRec = PlusMinus
                    });
                }


                return list;
            }
        }
        public void CreateTable(string query)
        {
            if (query == null)
                query = "CREATE TABLE [dbo].[MoneyStorage]  ( [Quantia] integer, [Local] nchar(200), [DinCard] nchar(50), [Data] nchar(50), [Hora] nchar(50), [PlusMinus] nchar(50))";
            SqlCommand comando = new SqlCommand(query, conex);
        }
        public bool InsertInto(string quantia, string local, string DinCard, string data, string hora, string PlusMinus)
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "INSERT INTO [dbo].[MoneyStorage] ( [Quantia], [Local], [Data], [DinCard], [Hora], [PlusMinus]) VALUES ( '" + quantia + "', '" + local + "', '" + data + "', '" + DinCard + "', '" + hora + "', '" + PlusMinus + "')";
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

                catch (Exception)
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
            string query = "select * from [dbo].[" + qual + "]", PlusMinus = "";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
                var list = new List<Lists.MoneyStorageBackUp>();
                while (reader.Read())
                {
                    if (reader.GetString(5).Replace(" ", "") == "Plus")
                        PlusMinus = "Recebimento";
                    else
                        PlusMinus = "Pagamento";
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
                        Pag_Rec = PlusMinus
                    ,
                        DataBK = reader.GetString(6)
                    });
                }

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
        public void InsertLocalTable(string Nome, string Endereco)
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "INSERT INTO [dbo].[Locais] ( [Nome], [Endereco], [Quantia]) VALUES ('" + Nome + "', '" + Endereco + "', '0')";
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
        private void UpdateLocalTable(string Nome, string Quantia)
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "UPDATE [dbo].[Locais] SET Quantia = '" + Quantia + "' WHERE Nome = '" + Nome + "'";
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
        public List<Lists.LocalTable> ReadLocalTable()
        {
            string qt;
            string query = "select * from [dbo].[Locais]";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {
              
                var list = new List<Lists.LocalTable>();
                while (reader.Read())
                {
                    if (reader.GetString(2) == null)
                        qt = "0";
                    else
                        qt = reader.GetString(2);
                    list.Add(new Lists.LocalTable
                    {
                        Nome = reader.GetString(0),
                        Endereco = reader.GetString(1),
                        Quantia = qt
                    });
                }

                return list;
            }
        }
        public void AttQuantiaLocais()
        {
            List<Lists.LocalTable> localTable = new List<Lists.LocalTable>();
            List<Lists.MoneyStorage> Storage = new List<Lists.MoneyStorage>();
            double soma = 0;
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "SELECT * FROM [dbo].[MoneyStorage]";
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        Storage.Add(new Lists.MoneyStorage
                        {
                            Quantia = reader.GetString(0),
                            Local = reader.GetString(1)
                        ,
                            DinCard = reader.GetString(2),
                            Data = reader.GetString(3)
                        ,
                            Hora = reader.GetString(4),
                            PagRec = reader.GetString(5)
                        });
                }

                comando.CommandText = "SELECT * FROM [dbo].[Locais]";
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                        localTable.Add(new Lists.LocalTable
                        {
                            Nome = reader.GetString(0),
                            Endereco = reader.GetString(1),
                            Quantia = reader.GetString(2)
                        });
                }
            }

            for(int i = 0; i < localTable.Count; i++)
            {
                for(int j = 0; j < Storage.Count; j++)
                {
                    if (Storage[j].Local.ToString().Replace(" ", "") == localTable[i].Nome.ToString().Replace(" ", ""))
                    {
                        if (Storage[j].PagRec.ToString().Replace(" ", "") == "Plus")
                            soma += Convert.ToDouble(Storage[j].Quantia);
                        else
                            soma -= Convert.ToDouble(Storage[j].Quantia);
                    }
                }
                UpdateLocalTable(localTable[i].Nome, soma.ToString());
                soma = 0;
            }
        }
        public void AttInsertPayTable(string Quantia, string Local, string DiaPagamento)
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "INSERT INTO [dbo].[PayTable] ( [Quantia], [Local], [DiaPagamento]) VALUES ('" + Quantia + "', '" + Local + "', '" + DiaPagamento + "')";
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
        public List<Lists.PagFixoTable> ReadPagFixo()
        {
            string qt;
            string query = "select * from [dbo].[PayTable]";
            SqlCommand command = new SqlCommand(query, conex);
            using (var reader = command.ExecuteReader())
            {

                var list = new List<Lists.PagFixoTable>();
                while (reader.Read())
                {
                    list.Add(new Lists.PagFixoTable
                    {
                        Quantia = reader.GetString(0),
                        Local = reader.GetString(1),
                        DiaPagamento = reader.GetString(2)
                    });
                }

                return list;
            }
        }
        public void CreatePayTable()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "CREATE TABLE [dbo].[PayTable]  ([Quantia] nchar(50), [Local] nchar(100), [DiaPagamento] nChar(20))";
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
        public void CreateLocalTable()
        {
            using (SqlCommand comando = new SqlCommand())
            {
                comando.Connection = conex;
                comando.CommandText = "CREATE TABLE [dbo].[Locais]  ([Nome] nchar(50), [Endereco] nchar(100))";
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
