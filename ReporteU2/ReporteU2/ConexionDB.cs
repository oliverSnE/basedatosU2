using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace ReporteU2
{
    class ConexionDB
    {
        private MySqlCommand cmd;
        private MySqlConnection cn;
        private MySqlDataReader dr;
        private const string CONNECTION_STRING = "Server=localhost;Database=ferreteria;Userid=root;password=;";
        private const string QUERY = "SELECT tem3.Cli AS No, tem3.Cliente, tem3.LimCredito, SUM(tem3.Total) AS Compras, SUM(tem4.Importe) AS Abonos,SUM(tem3.Total-tem4.Importe) AS Saldo FROM (SELECT tem1.Cli,tem1.Cliente,tem1.LimCredito,tem2.Total,tem2.Venta FROM (SELECT ferretera.clientes.Cli, ferretera.clientes.Cliente, ferretera.clientes.LimCredito FROM ferretera.clientes WHERE ferretera.clientes.Cli IN (SELECT ferretera.facturas.Cli FROM ferretera.facturas WHERE ferretera.facturas.Acredito = 1)) AS tem1 LEFT JOIN (SELECT cobranza.ventas.Venta, cobranza.ventas.Cli,cobranza.ventas.Total FROM cobranza.ventas WHERE cobranza.ventas.Folio IN (SELECT ferretera.facturas.Folio FROM ferretera.facturas WHERE ferretera.facturas.Acredito = 1)) AS tem2 ON tem1.Cli = tem2.Cli) AS tem3 LEFT JOIN (SELECT cobranza.pagos.Venta,cobranza.pagos.Importe FROM cobranza.pagos) AS tem4 ON tem3.Venta = tem4.Venta GROUP BY tem3.Cli;";
        public static bool res;
        public static string error;

        private bool openConnectionDB() {

            res = false;

            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    res = true;
                }
            }
            catch (MySqlException e)
            {
                error = "No fue posible abrir la conexiòn a Mysql: " + e.Message;

            }
            catch (Exception e)
            {
                error = "Error general: " + e.Message;
            }
            return res;
        }

        private bool closeConnectionDB() {

            res = false;
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    res = true;
                }
            }
            catch (MySqlException e)
            {
                error = "No fue posible abrir la conexiòn a Mysql: " + e.Message;

            }
            catch (Exception e)
            {
                error = "Error general: " + e.Message;
            }
            return res;
        }

        public void archivoHTML(WebBrowser wb) {

            string line = "";
            cn = new MySqlConnection(CONNECTION_STRING);
            Reporte reporte = null;


            if (openConnectionDB()) {

                try
                {
                    StreamWriter file = new StreamWriter("reporte.html");
                    file.WriteLine("<header><meta charset=\"UTF-8\"></header><body><table border='1' cellspacing='0' align='center'><tbody><tr><th colspan=\"6\">Burgara Estrella Oliver Sinue TIC8-2</th></tr><tr><th>Id</th><th>Cliente</th><th>LimCrèdito</th><th>Compras</th><th>Abonos</th><th>Saldo</th></tr>");
                    cmd = new MySqlCommand(QUERY, cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = dr.GetInt32(0);
                        string cliente = dr.GetString(1);
                        double lim = dr.GetDouble(2);
                        double compras = dr.GetDouble(3);
                        double abonos = dr.GetDouble(4);
                        double saldo = dr.GetDouble(5);
                        reporte = new Reporte(id, cliente, lim, compras, abonos, saldo);
                        line = "<tr><td>" + reporte.getId() + "</td><td>" + reporte.getCliente() + "</td><td>$ " + reporte.getLimite() + "</td><td>$ " + reporte.getCompras() + "</td><td>$ " + reporte.getAbonos() + "</td><td>$ " + reporte.getSaldo() + "</td></tr>";
                        file.WriteLine(line);
                    }
                    file.Close();
                    string folder = Directory.GetCurrentDirectory();
                    wb.Url = new Uri(string.Format("file:///{0}/reporte.html", folder));
                    res = true;
                }
                catch (Exception e)
                {

                    error = "Error general: " + e.Message;
                    res = false;
                }
                finally{
                    closeConnectionDB();
                }

            
            }
        }


    }
}
