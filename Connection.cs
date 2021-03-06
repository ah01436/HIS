﻿using System;
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

            //connectionString = @"SERVER=" + Properties.Settings.Default.Server + ";DATABASE=" + Properties.Settings.Default.database + ";UId=" + Properties.Settings.Default.uid + ";pwd=" + Properties.Settings.Default.pwd + ";";
            connection = new SqlConnection(connectionString);
        }
        //open connection to database
        public void OpenConnection()
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
                    MessageBox.Show(ex.ToString());
                }
            }
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
                    MessageBox.Show(ex.Message);

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
            }
            catch (SqlException ex)
            {
                return ex.Number;
                //MessageBox.Show(ex.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return 1;
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

    }
}

