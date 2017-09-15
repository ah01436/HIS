using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace HIS
{
    class Connection
    {
        public string connectionString;
        private SqlConnection connection;
        public Connection()
        {
           //connectionString = @"SERVER=DESKTOP-G7L2AEP\SQL2014;DATABASE=HIS_women;Integrated Security=true";
            connectionString = @"SERVER=172.31.44.100;DATABASE=HIS_women;uid=sa;password=sql@2013";
            var p = Properties.Settings.Default;

            //if (p.IsWinAuth)
            //    connectionString = @"SERVER=" + p.Server + ";DATABASE="+p.database+";Integrated Security=true;";
            //else
            //    connectionString = @"SERVER=" + p.Server + ";DATABASE=" + p.database + ";Integrated Security=false;User Id=" + p.uid + ";Password=" + p.password + ";";
            ////connection = new SqlConnection(connectionString);

           // MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
        }
        public Connection(string ServerName,  string UserName, string Password, bool WinAuth)
        {
            if (WinAuth)
                connectionString = @"SERVER=" + ServerName+ ";Integrated Security=true;";
            else
                connectionString = @"Data Source=" + ServerName + ";Integrated Security=false;User ID=" + UserName + ";Password=" + Password + ";";
            connection = new SqlConnection(connectionString);
        }
        public Connection(string ServerName,string Database,string UserName ,string Password, bool WinAuth)
        {
            if (WinAuth)
                connectionString = @"Persist Security Info=False;Data Source=" + ServerName + ";Initial Catalog=" + Database + ";Integrated Security=true;";
            else
                connectionString = @"Persist Security Info=False;Data Source=" + ServerName + ";Initial Catalog=" + Database + ";User ID=" + UserName + ";Password=" + Password + ";";
            connection = new SqlConnection(connectionString);
        }
        //open connection to database
        public bool OpenConnection()
        {

            //check connection is close or not 
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 53||ex.Number==1326)
                    {
                        MessageBox.Show("تم فقد الاتصال بقاعدة البيانات السرفر لا يعمل ");
                    }
                    else
                    {
                        MessageBox.Show(ex.Number.ToString());
                        MessageBox.Show(ex.ToString());
                    }
                    return false;
                }
            }

            return true;
        }
        //Close connection
        public void CloseConnection()
        {
            //check connection is open or not 
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 53 || ex.Number == 1326)
                    {
                        MessageBox.Show("تم فقد الاتصال بقاعدة البيانات السرفر لا يعمل ");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }
        //method to read data from database
        public DataTable ReadData(string stored_procdure, SqlParameter[] parameter)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.Add(parameter[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable ReadData(string stored_procdure)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;          
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        //method to insert or update or delete data from database 
        public int Exacute_procdure(string stored_procdure, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                if (parameter != null)
                {
                    cmd.Parameters.AddRange(parameter);
                }
                cmd.ExecuteNonQuery();
                CloseConnection();
                return 1;
            }
            catch (SqlException ex)
            {
               // MessageBox.Show(ex.Message);
                return ex.Number;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return 0;
            }
        }
        public void Exacute_procdure(string stored_procdure)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getid(string tabel)
        {
            string id = "";

            if (true)
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count('*') from " + tabel + " ;";
                cmd.Connection = connection;
                try
                {
                    id = cmd.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                //close connection
                finally
                {
                    this.CloseConnection();
                }

            }

            return id;
        }
        // convert image to byte - write image in database
        public static byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        // convert image to image - read image from database
        public static System.Drawing.Image ConvertBytesToImage(byte[] byt)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byt);
            return System.Drawing.Image.FromStream(ms);
        }
        SqlCommandBuilder CB;
        SqlDataAdapter adat;
        
        public bool update(DataTable dd)
        {
            try
            {
                CB = new SqlCommandBuilder(adat);
                adat.Update(dd);
                return true;
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool update(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.connection;
                cmd.CommandText = query;
                this.OpenConnection();
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public DataTable selectt(string query)
        {
            DataTable d = new DataTable();

            try
            {
                adat = new SqlDataAdapter(query,connection);
                adat.Fill(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return d;
        }
       public bool ExecuteInsertOrUpdateOrDeleteUsingStoredProc(string StoredProcName, string[] paramNames, string[] paramValues
    , SqlDbType[] paramType)
        {
            connection.Open();
            //int rowsAffected = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(StoredProcName, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paramNames.Length; i++)
                    cmd.Parameters.Add(paramNames[i], paramType[i]).Value = paramValues[i];
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);
            return false; 
            }
        }
       public bool ExecuteQueries(string Query)
       {
           try
           {
               Connection con = new Connection();
               con.OpenConnection();
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = con.connection;
               cmd.CommandText = Query;
               cmd.ExecuteNonQuery();
               con.CloseConnection();
               return true;
           }

           catch (SqlException ex)
           {
               MessageBox.Show(ex.Number.ToString());
               MessageBox.Show(ex.ToString());
               return false;

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
               return false;

           }
       }

    }
}

