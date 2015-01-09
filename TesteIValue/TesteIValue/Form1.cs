using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteIValue
{
    public partial class formVerbosPreposicoes : Form
    {
        private static string[] foo { get { return new string[] { "t", "s", "w", "l", "h" }; } }

        private static string urlA { get { return "https://raw.githubusercontent.com/I-Value/ExameIValue/master/textoA.txt"; } }
        private static string urlB { get { return "https://raw.githubusercontent.com/I-Value/ExameIValue/master/textoB.txt"; } }

        string textoA = string.Empty;
        string textoB = string.Empty;

        public formVerbosPreposicoes()
        {
            InitializeComponent();
        }

        private void formVerbosPreposicoes_Load(object sender, EventArgs e)
        {
            this.lblLetrasFoo.Text = string.Join(", ", formVerbosPreposicoes.foo);
        }

        private void btnBaixarTextoATextoB_Click(object sender, EventArgs e)
        {
            this.btnContarPreposicoesTextoA.Enabled = this.btnContarPreposicoesTextoB.Enabled = this.btnContarVerbosTextoB.Enabled = this.btnContarVerbosTextoA.Enabled = false;

            try
            {
                using (WebClient client = new WebClient())
                {
                    textoA = client.DownloadString(urlA);
                    textoB = client.DownloadString(urlB);
                }

                this.txtTextoA.Text = textoA;
                this.txtTextoB.Text = textoB;

                this.btnContarPreposicoesTextoA.Enabled = this.btnContarPreposicoesTextoB.Enabled = this.btnContarVerbosTextoB.Enabled = this.btnContarVerbosTextoA.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar baixar o TextoA e o TextoB: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContarPreposicoesTextoA_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateTextoATextoB();

                List<string> strPalavras = this.textoA.Split(' ').ToList();

                this.lblPreposicoesTextoA.Text = strPalavras.Count(ff => ff.Length == 3 && formVerbosPreposicoes.foo.Contains(ff.Substring(ff.Length - 1, 1)) && !ff.Contains("m")).ToString().PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar contar as preposições do Texto A: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContarPreposicoesTextoB_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateTextoATextoB(true);

                List<string> strPalavras = this.textoB.Split(' ').ToList();

                this.lblPreposicoesTextoB.Text = strPalavras.Count(ff => ff.Length == 3 && formVerbosPreposicoes.foo.Contains(ff.Substring(ff.Length - 1, 1)) && !ff.Contains("m")).ToString().PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar contar as preposições do Texto B: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContarVerbosTextoA_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateTextoATextoB();

                List<string> strPalavras = this.textoA.Split(' ').Where(ff => ff.Length >= 8 && formVerbosPreposicoes.foo.Contains(ff.Substring(ff.Length - 1, 1))).ToList();

                this.lblVerbosTextoA.Text = strPalavras.Count().ToString().PadLeft(2, '0');
                this.lblEmPrimeiraPessoaTextoA.Text = strPalavras.Count(ff => formVerbosPreposicoes.foo.Contains(ff.Substring(0, 1))).ToString().PadLeft(2, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar contar os verbos do Texto A: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContarVerbosTextoB_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateTextoATextoB(true);

                List<string> strPalavras = this.textoB.Split(' ').Where(ff => ff.Length >= 8 && formVerbosPreposicoes.foo.Contains(ff.Substring(ff.Length - 1, 1))).ToList();

                this.lblVerbosTextoB.Text = strPalavras.Count().ToString().PadLeft(2, '0');
                this.lblEmPrimeiraPessoaTextoB.Text = strPalavras.Count(ff => formVerbosPreposicoes.foo.Contains(ff.Substring(0, 1))).ToString().PadLeft(2, '0');

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar contar os verbos do Texto B: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateTextoATextoB(bool isTextoB = false)
        {
            if (!isTextoB)
            {
                if (this.textoA.Trim().Length == 0)
                    throw new Exception("Texto A não adquirido! Favor baixá-lo antes de tentar executar alguma operação com ele!");
            }
            else
            {
                if (this.textoB.Trim().Length == 0)
                    throw new Exception("Texto B não adquirido! Favor baixá-lo antes de tentar executar alguma operação com ele!");
            }
        }
    }
}
