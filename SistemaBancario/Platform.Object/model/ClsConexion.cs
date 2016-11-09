using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Imports adicionales
using System.Data;//SQLSERVER
using System.Data.SqlClient;//SQLSERVER
using System.Configuration;

namespace Platform.Object.model
{
    public class ClsConexion
    {

        String cadena;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataAdapter adaptador;
        protected DataSet dataset;

        public bool ejecutar(String sql)
        {
            cadena = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
            conexion = new SqlConnection(cadena);            
            comando = new SqlCommand(sql, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            desconectar();
            return true;
        }


        public bool ejecutarRetorno(String sql)
        {
            try
            {
                cadena = ConfigurationManager.ConnectionStrings["conexionBD"].ToString();
                conexion = new SqlConnection(cadena);
                conexion.Open();
                //Diferencias con el anterior
                adaptador = new SqlDataAdapter(sql, conexion); //no es sql command, es adapter
                dataset = new DataSet();
                adaptador.Fill(dataset);
                desconectar();
                
            }catch(Exception e){
                return false;
            }
            return true; 
        }


        public void desconectar()
        {
            conexion.Close();
        }      
    }
}
