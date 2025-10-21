using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ValidadorCpf
{
    public partial class Form1 : Form
    {
        // Atributos
        private enum Documentos { CNPJ, CPF, PIS };
        private Documentos ValorDocumentos;
        
        // Ferramentas Para Mexer a Janela
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        // Mexer a Janela
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Botões (✖, 🗖, 🗕)
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Cor (✖, 🗖, 🗕)
        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Red;
        }
        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = pnlBarraTitulo.BackColor;
        }
        private void btnMaximizar_MouseEnter(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(74, 96, 116);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = pnlBarraTitulo.BackColor;
        }
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(74, 96, 116);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = pnlBarraTitulo.BackColor;
        }

        // Permitir somente números
        private void txtNumeroDigitado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Botões (CNPJ, CPF e PIS)
        private void btnCnpj_Click(object sender, EventArgs e)
        {
            ValorDocumentos = Documentos.CNPJ;
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            ValorDocumentos = Documentos.CPF;
        }

        private void btnPis_Click(object sender, EventArgs e)
        {
            ValorDocumentos = Documentos.PIS;
        }

        // Validar
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string numero = txtNumeroDigitado.Text;
            int totalDeCaracteres = numero.Length;

            lblResultado.Visible = true;

            switch (ValorDocumentos)
            {
                case Documentos.CNPJ:
                    if (totalDeCaracteres == 14)
                    {
                        if (IsCnpjValido(numero))
                        {
                            lblResultado.Text = "CNPJ VÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#27AE60");
                        }
                        else
                        {
                            lblResultado.Text = "CNPJ INVÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                        }
                    }
                    else if (totalDeCaracteres == 0)
                    {
                        lblResultado.Text = "ERRO!\n  Digite o número!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    else
                    {
                        lblResultado.Text = "ERRO!\n  O CNPJ deve ter 14 dígitos!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    break;

                case Documentos.CPF:
                    if (totalDeCaracteres == 11)
                    {
                        if (IsCpfValido(numero))
                        {
                            lblResultado.Text = "CPF VÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#27AE60");
                        }
                        else
                        {
                            lblResultado.Text = "CPF INVÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                        }
                    }
                    else if (totalDeCaracteres == 0)
                    {
                        lblResultado.Text = "ERRO!\n  Digite o número!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    else
                    {
                        lblResultado.Text = "ERRO!\n  O CPF deve ter 11 dígitos!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    break;

                case Documentos.PIS:
                    if (totalDeCaracteres == 11)
                    {
                        if (IsPisValido(numero))
                        {
                            lblResultado.Text = "PIS VÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#27AE60");
                        }
                        else
                        {
                            lblResultado.Text = "PIS INVÁLIDO";
                            lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                        }
                    }
                    else if (totalDeCaracteres == 0)
                    {
                        lblResultado.Text = "ERRO!\n  Digite o número!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    else
                    {
                        lblResultado.Text = "ERRO!\n O PIS deve ter 11 dígitos!";
                        lblResultado.ForeColor = ColorTranslator.FromHtml("#E74C3C");
                    }
                    break;
            }
        }

        private bool IsCnpjValido(string cnpj)
        {

            int[] pesosDV1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesosDV2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            int digitoVerificador;

            // Verificar se os numeros do CNPJ são iguais.    Ex: 55.555.555/5555-55
            if (cnpj.Distinct().Count() == 1)
            {
                return false;
            }

            // Calculo do primeiro digito
            soma = 0;
            for (int i = 0; i < 12; i++)
            {
                soma = soma + (cnpj[i] - '0') * pesosDV1[i];
            }

            resto = soma % 11;
            digitoVerificador = (resto < 2) ? 0 : 11 - resto;

            // Ver se o penultimo digito está certo
            if ((cnpj[12] - '0') != digitoVerificador)
            {
                return false;
            }

            // Calculo do segundo digito
            soma = 0;
            for (int i = 0; i < 13; i++)
            {
                soma += (cnpj[i] - '0') * pesosDV2[i];
            }

            resto = soma % 11;
            digitoVerificador = (resto < 2) ? 0 : 11 - resto;

            // Ver se o ultimo digito está certo
            if ((cnpj[13] - '0') != digitoVerificador)
            {
                return false;
            }

            return true;
        }

        private bool IsCpfValido(string cpf)
        {
            int[] pesosDV1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesosDV2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            int digitoVerificador;

            // Verificar se os numeros do CPF são iguais.    Ex: 555.555.555-55
            if (cpf.Distinct().Count() == 1)
            {
                return false;
            }

            // Calculo do primeiro digito
            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma = soma + (cpf[i] - '0') * pesosDV1[i];
            }

            resto = soma % 11;
            digitoVerificador = (resto < 2) ? 0 : 11 - resto;

            // Ver se o penultimo digito está certo
            if ((cpf[9] - '0') != digitoVerificador)
            {
                return false;
            }

            // Calculo do segundo digito
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (cpf[i] - '0') * pesosDV2[i];
            }

            resto = soma % 11;
            digitoVerificador = (resto < 2) ? 0 : 11 - resto;

            // Ver se o ultimo digito está certo
            if ((cpf[10] - '0') != digitoVerificador)
            {
                return false;
            }

            return true;
        }
        
        private bool IsPisValido(string pis)
        {
            int[] pesosDV1 = { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            int digitoVerificador;

            // Verificar se os numeros do PIS são iguais.    Ex: 555.55555.55-5
            if (pis.Distinct().Count() == 1)
            {
                return false;
            }

            // Calculo do digito
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma = soma + (pis[i] - '0') * pesosDV1[i];
            }

            resto = soma % 11;
            digitoVerificador = (resto < 2) ? 0 : 11 - resto;

            // Ver se o ultimo digito está certo
            if ((pis[10] - '0') != digitoVerificador)
            {
                return false;
            }

            return true;
        }
    }
}
