using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace P1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            inputEmail.Enabled = false;
            inputFacebook.Enabled = false;
            inputTwitter.Enabled = false;
            sendEmail.Enabled = false;
            accessFacebook.Enabled = false;
            accessTwitter.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Dados Pessoais
            inputCode.Clear();
            inputName.Clear();
            inputRG.Clear();
            inputCPF.Clear();
            inputTel.Clear();
            inputCel.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            //Endereço
            inputCEP.Clear();
            inputAddress.Clear();
            inputNum.Clear();
            inputNei.Clear();
            inputCity.Clear();
            inputState.Clear();

            //Dados Extras
            inputEmail.Clear();
            inputEmail.Enabled = false;
            inputFacebook.Clear();
            inputFacebook.Enabled = false;
            inputTwitter.Clear();
            inputTwitter.Enabled = false;
            cbEmail.Checked = false;
            cbFacebook.Checked = false;
            cbTwitter.Checked = false;

            inputCode.Focus();
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked == true)
            {
                inputEmail.Enabled = true;
                sendEmail.Enabled = true;
            }
            else
            {
                inputEmail.Clear();
                inputEmail.Enabled = false;
                sendEmail.Enabled = false;
            }
        }

        private void cbFacebook_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFacebook.Checked == true)
            {
                inputFacebook.Enabled = true;
                accessFacebook.Enabled = true;
            }
            else
            {
                inputFacebook.Clear();
                inputFacebook.Enabled = false;
                accessFacebook.Enabled = false;
            }
        }

        private void cbTwitter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTwitter.Checked == true)
            {
                inputTwitter.Enabled = true;
                accessTwitter.Enabled = true;
            }
            else
            {
                inputTwitter.Clear();
                inputTwitter.Enabled = false;
                accessTwitter.Enabled = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Dados Pessoais
            inputCode.Text = "123";
            inputName.Text = "Arthur, Carolina e Matheus";
            inputRG.Text = "00.000.000/0";
            inputCPF.Text = "000.000.000-00";
            inputTel.Text = "(00) 0000-0000";
            inputCel.Text = "(00) 00000-0000";
            rdoMale.Checked = true;

            //Endereço
            inputCEP.Text = "00000-000";
            inputAddress.Text = "Rua da Silva";
            inputNum.Text = "00";
            inputNei.Text = "Bairro Souza";
            inputCity.Text = "Araraquara";
            inputState.Text = "São Paulo";

            //Dados Extras
            inputEmail.Text = "email@email.com";
            inputEmail.Enabled = true;
            inputFacebook.Text = "Amantes de Araraquara";
            inputFacebook.Enabled = true;
            inputTwitter.Text = "@amantesdeararaquara";
            inputTwitter.Enabled = true;
            cbEmail.Checked = true;
            cbFacebook.Checked = true;
            cbTwitter.Checked = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string msg = "";
            string caption = "Dados Cadastrais";
            msg += inputCode.Text + "\n";
            if (inputName.TextLength == 0)
            {
                msg += "Não existe um nome no formulário.\n";
            }
            else
            {
                msg += inputName.Text + "\n";
            }
            msg += inputRG.Text + "\n";
            msg += inputCPF.Text + "\n";
            msg += inputTel.Text + "\n";
            msg += inputCel.Text + "\n";
            msg += inputCEP.Text + "\n";
            msg += inputAddress.Text + "\n";
            msg += inputNum.Text + "\n";
            msg += inputNei.Text + "\n";
            msg += inputCity.Text + "\n";
            msg += inputState.Text + "\n";
            msg += inputEmail.Text + "\n";
            msg += inputFacebook.Text + "\n";
            msg += inputTwitter.Text + "\n";
            MessageBox.Show(msg, caption);
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            openFile.FileName = "";
            openFile.Title = "Selecione uma imagem";
            openFile.Filter = "JPEG|*.jpeg|JPG|*.jpg|PNG|*.png";
            openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            img.Image = Image.FromFile(openFile.FileName);
        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            img.Image = null;
        }

        private void sendEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "mailto:" + inputEmail.Text;
            System.Diagnostics.Process.Start(url);
        }

        private void accessFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/" + inputFacebook.Text;
            System.Diagnostics.Process.Start(url);
        }

        private void accessTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.twitter.com/" + inputTwitter.Text;
            System.Diagnostics.Process.Start(url);
        }
    }
}
