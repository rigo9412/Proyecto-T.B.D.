using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


    public static class Conexion
    {
        public static string usuario="", contraseña="",query="";

        public static string Login()
        {
            string connetionString = null;
            SqlConnection connection;
            //SqlCommand command;
            string sql = null;

            connetionString = "Data Source=vanessa-pc;Initial Catalog=CENTRO_COMERCIAL;User ID="+usuario+";Password="+contraseña;
            sql = "Your SQL Statemnt Here";

            connection = new SqlConnection(connetionString);
    
                connection.Open();
                //command = new SqlCommand(connection);
                //command.ExecuteNonQuery();
                //command.Dispose();
                connection.Close();
               
                return "Bienvenido " + usuario; 

        }
        public static void Actualizar(string query)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Data Source=vanessa-pc;Initial Catalog=CENTRO_COMERCIAL;User ID=" + usuario + ";Password=" + contraseña;
            sql = query;

            connection = new SqlConnection(connetionString);

            connection.Open();
            command = new SqlCommand(sql,connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
        public static void Cambiar(string query)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;

            connetionString = "Data Source=vanessa-pc;Initial Catalog=CENTRO_COMERCIAL;User ID=" + usuario + ";Password=" + contraseña;
            sql = query;

            connection = new SqlConnection(connetionString);

            connection.Open();
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
        public static DataTable Consultas(string query)
        {
            string connetionString = null;
            connetionString = "Data Source=vanessa-pc;Initial Catalog=CENTRO_COMERCIAL;User ID=" + usuario + ";Password=" + contraseña;
             DataTable dt = new DataTable();
            string sql = query;
            SqlConnection connection = new SqlConnection(connetionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            return dt;
        }
       
    }
