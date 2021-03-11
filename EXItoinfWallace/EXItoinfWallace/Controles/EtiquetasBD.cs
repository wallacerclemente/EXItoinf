using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using EXItoinfWallace.Modelos;

namespace EXItoinfWallace.Controllers
{

    public class EtiquetasBD
    {
        string Con;

        public void etiquetasDB()

        {
            Con = ConfigurationManager.ConnectionStrings["ConexaoBD"].ToString(); // ConfigurationSettings.AppSettings["ConexaoBD"];
        }

        public void IncluirEtiqueta(Etiqueta etiqueta)
        {
            etiquetasDB();
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "INSERT INTO ex_itoinf.etiqueta(CodigoEtiqueta,Nome,Endereco,Bairro,Cidade,CEP,ChaveIntegracao,Status) VALUES('" + 
                              etiqueta.CodigoEtiqueta + "','" + etiqueta.NomeCliente + "','" + etiqueta.Endereco + "','" + etiqueta.Bairro + "','" + etiqueta.Cidade + 
                              "','" + etiqueta.Cep + "','" + etiqueta.ChaveIntegracao + "','" + etiqueta.Status + "');";
            try
            {
                CN.Open();
                int regitrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public void AlteraEtiqueta(Etiqueta etiqueta)
        {
            etiquetasDB();
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "UPDATE ex_itoinf.etiqueta SET Nome = '" +
                              etiqueta.NomeCliente + "', Endereco = '" + etiqueta.Endereco + "', Bairro = '" + etiqueta.Bairro + "', Cidade = '" +
                              etiqueta.Cidade + "', CEP = '" + etiqueta.Cep + "', ChaveIntegracao = '" + etiqueta.ChaveIntegracao + 
                              "',Status = '" + etiqueta.Status + "' WHERE CodigoEtiqueta = '" + etiqueta.CodigoEtiqueta + "';";
            try
            {
                CN.Open();
                int regitrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public void ApagaEtiqueta(string CodigoEtiqueta)
        {
            etiquetasDB();
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "DELETE FROM ex_itoinf.etiqueta WHERE CodigoEtiqueta = '" + CodigoEtiqueta + "';";
            try
            {
                CN.Open();
                int regitrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getEtiquetas()
        {
            etiquetasDB();
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT * from ex_itoinf.etiqueta";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                //
                DataTable dtEtiquetas = new DataTable();
                da.Fill(dtEtiquetas);
                return dtEtiquetas;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
