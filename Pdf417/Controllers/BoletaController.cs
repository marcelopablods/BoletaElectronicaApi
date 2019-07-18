using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pdf417.Models;
using System.Data;
using Pdf417.ConexionBD;

namespace Pdf417.Controllers
{
    public class BoletaController : ApiController
    {
        [HttpGet]
        public IEnumerable<BoletaElectronica> obtenerBoleta(string rut, string tipo, int folio, string fecha, int monto)
        {
            IList<BoletaElectronica> listaBoleta = new List<BoletaElectronica>();
            DataSet ds = Conexion.ejecutar_select("CONSULTA_DTES_PARA_IMAGEN '" + rut + "','" + tipo + "','" + folio + "','" + fecha + "','"+monto+"'");
            BoletaElectronica boleta = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    boleta = new BoletaElectronica();
                    boleta.numDoc = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    boleta.estado = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                    boleta.logoEmpresa = ds.Tables[0].Rows[i][2].ToString();
                    boleta.rutEmisor = ds.Tables[0].Rows[i][3].ToString();
                    boleta.tipoDocu = ds.Tables[0].Rows[i][4].ToString();
                    boleta.folioDte = Convert.ToInt32(ds.Tables[0].Rows[i][5].ToString());
                    boleta.fechaFact = ds.Tables[0].Rows[i][6].ToString();
                    boleta.fechaVenc = ds.Tables[0].Rows[i][7].ToString();
                    boleta.rutCliente = ds.Tables[0].Rows[i][8].ToString();
                    boleta.nombreCliente = ds.Tables[0].Rows[i][9].ToString();
                    boleta.direccion = ds.Tables[0].Rows[i][10].ToString();
                    boleta.comuna = ds.Tables[0].Rows[i][11].ToString();
                    boleta.ciudad = ds.Tables[0].Rows[i][12].ToString();
                    boleta.giro = ds.Tables[0].Rows[i][13].ToString();
                    boleta.observacion = ds.Tables[0].Rows[i][14].ToString();
                    boleta.formaPago = ds.Tables[0].Rows[i][15].ToString();
                    boleta.vendedor = ds.Tables[0].Rows[i][16].ToString();
                    boleta.noOperacion = ds.Tables[0].Rows[i][17].ToString();
                    boleta.montoNeto = Convert.ToInt32( ds.Tables[0].Rows[i][18].ToString());
                    boleta.montoexento = Convert.ToInt32(ds.Tables[0].Rows[i][19].ToString());
                    boleta.montoIva = Convert.ToInt32(ds.Tables[0].Rows[i][20].ToString());
                    boleta.montoTotal = Convert.ToInt32(ds.Tables[0].Rows[i][21].ToString());
                    boleta.timbreDte = ds.Tables[0].Rows[i][22].ToString();
                    boleta.dteCompleto = ds.Tables[0].Rows[i][23].ToString();
                    boleta.archivoPdf = ds.Tables[0].Rows[i][24].ToString();
                    boleta.linea = Convert.ToInt32(ds.Tables[0].Rows[i][25].ToString());
                    boleta.glosa = ds.Tables[0].Rows[i][26].ToString();
                    //boleta.cantidad = Convert.ToInt32(Convert.ToDouble(ds.Tables[0].Rows[i][27].ToString()));
                    //boleta.unidad = ds.Tables[0].Rows[i][28].ToString();
                    //boleta.precioUnitario = Convert.ToInt32(ds.Tables[0].Rows[i][29].ToString());
                    boleta.monto = Convert.ToInt32(ds.Tables[0].Rows[i][30].ToString());
                    boleta.exento = Convert.ToInt32(ds.Tables[0].Rows[i][31].ToString());
                    boleta.montoTxt = ds.Tables[0].Rows[i][32].ToString();
                    listaBoleta.Add(boleta);
                }
            }
            else
            {
                boleta = new BoletaElectronica();
                boleta.numDoc = 0;
                boleta.estado = 0;
                boleta.rutEmisor = "";
                boleta.tipoDocu = "";
                boleta.folioDte = 0;
                boleta.fechaFact = "";
                boleta.nombreCliente = "";
                boleta.montoNeto = 0;
                boleta.montoexento = 0;
                boleta.montoIva = 0;
                boleta.montoTotal = 0;
                boleta.timbreDte = "";
                boleta.dteCompleto = "";
                boleta.archivoPdf = "";
                boleta.linea = 0;
                boleta.glosa = "";
                boleta.cantidad = 0;
                boleta.unidad = "";
                boleta.precioUnitario = 0;
                boleta.monto = 0;
                boleta.exento = 0;
                boleta.rutCliente = "";
                boleta.direccion = "";
                boleta.comuna = "";
                boleta.ciudad = "";
                boleta.giro = "";
                boleta.observacion = "";
                boleta.fechaVenc = "";
                boleta.formaPago = "";
                boleta.vendedor = "";
                boleta.noOperacion = "";


            }
            return listaBoleta;

        }
    }
}
