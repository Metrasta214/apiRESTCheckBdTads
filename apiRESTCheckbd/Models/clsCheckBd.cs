using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//-------------------------------------------------
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;   
using System.Data;
using System.Configuration;
using apiRESTCheckbd.Models;
//-------------------------------------------------
namespace apiRESTCheckBdTads.Models
{
    public class clsCheckBd
    {
        public int ban { get; set; }

        public string statusMsg { get; set; }

        public void checkBd()
        {
            try
            {
                string cadConn =
                    ConfigurationManager
                    .ConnectionStrings["conexionMySQL"]
                    .ConnectionString;

                MySqlConnection cnn =
                    new MySqlConnection(cadConn);

                cnn.Open();
                cnn.Close();

                ban = 1;

                statusMsg =
                    "Conexion exitosa (MySql) control_acceso";
            }
            catch (Exception ex)
            {
                ban = 0;
                statusMsg = ex.Message;
            }
        }
    }
}