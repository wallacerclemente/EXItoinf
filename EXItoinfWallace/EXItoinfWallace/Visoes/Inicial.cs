using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXItoinfWallace.Modelos;
using EXItoinfWallace.Controllers;
using Refit;

namespace EXItoinfWallace.Visoes
{
    public partial class Inicial : Form
    {
        EtiquetasBD etiquetasBD = new EtiquetasBD();
        Etiqueta etiquetaReg = new Etiqueta();
        static string gCodigoEtiqueta = " ";
        static string gChaveIntegracao = " ";
        static string gStatus = " ";

        public Inicial()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (tbCodigoEtiqueta.Text.Equals(""))
            {
                MessageBox.Show("Informe o código da etiqueta.");
                tbCodigoEtiqueta.Focus();
            }
            else if(tbChaveIntegracao.Text.Equals(""))
            {
                MessageBox.Show("Informe o código da etiqueta.");
                tbChaveIntegracao.Focus();
            }
            else
            {
                try
                {
                    etiquetaReg.Etiquetas(tbCodigoEtiqueta.Text, tbNome.Text, tbEndereco.Text, tbBairro.Text, tbCidade.Text, tbCEP.Text, tbChaveIntegracao.Text, tbStatus.Text);
                    etiquetasBD.IncluirEtiqueta(etiquetaReg);
                    MessageBox.Show("Registro salvo com sucesso.");
                    PopulaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void Inicial_Enter(object sender, EventArgs e)
        {
           
        }

        private void PopulaGrid()
        {
            dgvEtiquetas.DataSource = etiquetasBD.getEtiquetas();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void alterar()
        {
            if (tbCodigoEtiqueta.Text.Equals(""))
            {
                MessageBox.Show("Informe o código da etiqueta.");
                tbCodigoEtiqueta.Focus();
            }
            else if (tbChaveIntegracao.Text.Equals(""))
            {
                MessageBox.Show("Informe o código da etiqueta.");
                tbChaveIntegracao.Focus();
            }
            else
            {
                try
                {
                    etiquetaReg.Etiquetas(tbCodigoEtiqueta.Text, tbNome.Text, tbEndereco.Text, tbBairro.Text, tbCidade.Text, tbCEP.Text, tbChaveIntegracao.Text, tbStatus.Text);
                    etiquetasBD.AlteraEtiqueta(etiquetaReg);
                    MessageBox.Show("Registro salvo com sucesso.");
                    PopulaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (tbCodigoEtiqueta.Text.Equals(""))
            {
                MessageBox.Show("Informe o código da etiqueta.");
                tbCodigoEtiqueta.Focus();
            }
            else
            {
                try
                {
                    etiquetasBD.ApagaEtiqueta(tbCodigoEtiqueta.Text);
                    MessageBox.Show("Registro excluido com sucesso.");
                    PopulaGrid();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            this.Close();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            gChaveIntegracao = tbChaveIntegracao.Text;
            gCodigoEtiqueta = tbCodigoEtiqueta.Text;
            Validacao();
            if (gStatus.Length != 0)
            {
                tbStatus.Text = gStatus;
                alterar();
            }
        }
        
        public async Task Validacao()
        {
            try
            {
                var etiquetaClient = RestService.For<IEtiquetaApiService>("https://apiserver.sgpmaisvendas.com.br:80");
                var address = await etiquetaClient.GetAddressAsync(gChaveIntegracao, gCodigoEtiqueta);

                //string[] status = address.GetEnumerator();
                //gStatus = address.Status;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possivel encontrar a etiqueta : " + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
