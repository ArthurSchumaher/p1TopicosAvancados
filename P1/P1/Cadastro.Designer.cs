namespace P1
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.dadosPessoais = new System.Windows.Forms.GroupBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.inputCel = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cel = new System.Windows.Forms.Label();
            this.inputTel = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.btnClearImg = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.cpf = new System.Windows.Forms.Label();
            this.inputRG = new System.Windows.Forms.TextBox();
            this.rg = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.endereco = new System.Windows.Forms.GroupBox();
            this.inputState = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.inputCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.inputNei = new System.Windows.Forms.TextBox();
            this.nei = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.logradouro = new System.Windows.Forms.Label();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.Label();
            this.inputCEP = new System.Windows.Forms.TextBox();
            this.cep = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accessTwitter = new System.Windows.Forms.LinkLabel();
            this.accessFacebook = new System.Windows.Forms.LinkLabel();
            this.sendEmail = new System.Windows.Forms.LinkLabel();
            this.cbTwitter = new System.Windows.Forms.CheckBox();
            this.cbFacebook = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.twitter = new System.Windows.Forms.Label();
            this.inputTwitter = new System.Windows.Forms.TextBox();
            this.inputFacebook = new System.Windows.Forms.TextBox();
            this.facebook = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dadosPessoais.SuspendLayout();
            this.sexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.endereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Enabled = false;
            this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(248, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 45);
            this.title.TabIndex = 0;
            this.title.Text = "Cadastro de Cliente";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dadosPessoais
            // 
            this.dadosPessoais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dadosPessoais.Controls.Add(this.btnLoadImg);
            this.dadosPessoais.Controls.Add(this.inputCel);
            this.dadosPessoais.Controls.Add(this.sexo);
            this.dadosPessoais.Controls.Add(this.cel);
            this.dadosPessoais.Controls.Add(this.inputTel);
            this.dadosPessoais.Controls.Add(this.tel);
            this.dadosPessoais.Controls.Add(this.btnClearImg);
            this.dadosPessoais.Controls.Add(this.img);
            this.dadosPessoais.Controls.Add(this.inputCPF);
            this.dadosPessoais.Controls.Add(this.cpf);
            this.dadosPessoais.Controls.Add(this.inputRG);
            this.dadosPessoais.Controls.Add(this.rg);
            this.dadosPessoais.Controls.Add(this.inputName);
            this.dadosPessoais.Controls.Add(this.nome);
            this.dadosPessoais.Controls.Add(this.inputCode);
            this.dadosPessoais.Controls.Add(this.codigo);
            this.dadosPessoais.Location = new System.Drawing.Point(12, 57);
            this.dadosPessoais.Name = "dadosPessoais";
            this.dadosPessoais.Size = new System.Drawing.Size(780, 193);
            this.dadosPessoais.TabIndex = 1;
            this.dadosPessoais.TabStop = false;
            this.dadosPessoais.Text = "Dados Pessoais";
            this.dadosPessoais.UseWaitCursor = true;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadImg.Location = new System.Drawing.Point(636, 22);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(133, 74);
            this.btnLoadImg.TabIndex = 18;
            this.btnLoadImg.Text = "Carregar Imagem";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.UseWaitCursor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // inputCel
            // 
            this.inputCel.Location = new System.Drawing.Point(273, 114);
            this.inputCel.Name = "inputCel";
            this.inputCel.Size = new System.Drawing.Size(198, 23);
            this.inputCel.TabIndex = 15;
            this.inputCel.UseWaitCursor = true;
            // 
            // sexo
            // 
            this.sexo.Controls.Add(this.rdoFemale);
            this.sexo.Controls.Add(this.rdoMale);
            this.sexo.Location = new System.Drawing.Point(18, 145);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(204, 42);
            this.sexo.TabIndex = 17;
            this.sexo.TabStop = false;
            this.sexo.Text = "Sexo:";
            this.sexo.UseWaitCursor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(105, 17);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(75, 19);
            this.rdoFemale.TabIndex = 17;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Feminino";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.UseWaitCursor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(19, 17);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(80, 19);
            this.rdoMale.TabIndex = 16;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Masculino";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.UseWaitCursor = true;
            // 
            // cel
            // 
            this.cel.AutoSize = true;
            this.cel.Location = new System.Drawing.Point(236, 117);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(27, 15);
            this.cel.TabIndex = 14;
            this.cel.Text = "Cel:";
            this.cel.UseWaitCursor = true;
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(72, 114);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(150, 23);
            this.inputTel.TabIndex = 13;
            this.inputTel.UseWaitCursor = true;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(17, 117);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(54, 15);
            this.tel.TabIndex = 12;
            this.tel.Text = "Telefone:";
            this.tel.UseWaitCursor = true;
            // 
            // btnClearImg
            // 
            this.btnClearImg.Location = new System.Drawing.Point(635, 102);
            this.btnClearImg.Name = "btnClearImg";
            this.btnClearImg.Size = new System.Drawing.Size(134, 73);
            this.btnClearImg.TabIndex = 11;
            this.btnClearImg.Text = "Limpar Imagem";
            this.btnClearImg.UseVisualStyleBackColor = true;
            this.btnClearImg.UseWaitCursor = true;
            this.btnClearImg.Click += new System.EventHandler(this.btnClearImg_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img.Location = new System.Drawing.Point(483, 22);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(146, 153);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 9;
            this.img.TabStop = false;
            this.img.UseWaitCursor = true;
            // 
            // inputCPF
            // 
            this.inputCPF.Location = new System.Drawing.Point(273, 85);
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.Size = new System.Drawing.Size(198, 23);
            this.inputCPF.TabIndex = 8;
            this.inputCPF.UseWaitCursor = true;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(236, 88);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(31, 15);
            this.cpf.TabIndex = 7;
            this.cpf.Text = "CPF:";
            this.cpf.UseWaitCursor = true;
            // 
            // inputRG
            // 
            this.inputRG.Location = new System.Drawing.Point(72, 85);
            this.inputRG.Name = "inputRG";
            this.inputRG.Size = new System.Drawing.Size(150, 23);
            this.inputRG.TabIndex = 6;
            this.inputRG.UseWaitCursor = true;
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Location = new System.Drawing.Point(40, 88);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(31, 15);
            this.rg.TabIndex = 2;
            this.rg.Text = "R.G.:";
            this.rg.UseWaitCursor = true;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(72, 55);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(400, 23);
            this.inputName.TabIndex = 3;
            this.inputName.UseWaitCursor = true;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(28, 58);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(43, 15);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome:";
            this.nome.UseWaitCursor = true;
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(72, 25);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(100, 23);
            this.inputCode.TabIndex = 1;
            this.inputCode.UseWaitCursor = true;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(22, 28);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(49, 15);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Código:";
            this.codigo.UseWaitCursor = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // endereco
            // 
            this.endereco.Controls.Add(this.inputState);
            this.endereco.Controls.Add(this.state);
            this.endereco.Controls.Add(this.inputCity);
            this.endereco.Controls.Add(this.city);
            this.endereco.Controls.Add(this.inputNei);
            this.endereco.Controls.Add(this.nei);
            this.endereco.Controls.Add(this.inputAddress);
            this.endereco.Controls.Add(this.logradouro);
            this.endereco.Controls.Add(this.inputNum);
            this.endereco.Controls.Add(this.num);
            this.endereco.Controls.Add(this.inputCEP);
            this.endereco.Controls.Add(this.cep);
            this.endereco.Location = new System.Drawing.Point(12, 257);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(776, 82);
            this.endereco.TabIndex = 2;
            this.endereco.TabStop = false;
            this.endereco.Text = "Endereço";
            // 
            // inputState
            // 
            this.inputState.Location = new System.Drawing.Point(679, 49);
            this.inputState.Name = "inputState";
            this.inputState.Size = new System.Drawing.Size(90, 23);
            this.inputState.TabIndex = 11;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(627, 53);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(45, 15);
            this.state.TabIndex = 10;
            this.state.Text = "Estado:";
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(471, 50);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(150, 23);
            this.inputCity.TabIndex = 9;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(418, 53);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(47, 15);
            this.city.TabIndex = 8;
            this.city.Text = "Cidade:";
            // 
            // inputNei
            // 
            this.inputNei.Location = new System.Drawing.Point(262, 50);
            this.inputNei.Name = "inputNei";
            this.inputNei.Size = new System.Drawing.Size(150, 23);
            this.inputNei.TabIndex = 7;
            // 
            // nei
            // 
            this.nei.AutoSize = true;
            this.nei.Location = new System.Drawing.Point(215, 53);
            this.nei.Name = "nei";
            this.nei.Size = new System.Drawing.Size(41, 15);
            this.nei.TabIndex = 6;
            this.nei.Text = "Bairro:";
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(263, 19);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(506, 23);
            this.inputAddress.TabIndex = 5;
            // 
            // logradouro
            // 
            this.logradouro.AutoSize = true;
            this.logradouro.Location = new System.Drawing.Point(184, 23);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(72, 15);
            this.logradouro.TabIndex = 4;
            this.logradouro.Text = "Logradouro:";
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(72, 50);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(100, 23);
            this.inputNum.TabIndex = 3;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(17, 53);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(54, 15);
            this.num.TabIndex = 2;
            this.num.Text = "Número:";
            // 
            // inputCEP
            // 
            this.inputCEP.Location = new System.Drawing.Point(72, 20);
            this.inputCEP.Name = "inputCEP";
            this.inputCEP.Size = new System.Drawing.Size(100, 23);
            this.inputCEP.TabIndex = 1;
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Location = new System.Drawing.Point(40, 22);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(31, 15);
            this.cep.TabIndex = 0;
            this.cep.Text = "CEP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accessTwitter);
            this.groupBox1.Controls.Add(this.accessFacebook);
            this.groupBox1.Controls.Add(this.sendEmail);
            this.groupBox1.Controls.Add(this.cbTwitter);
            this.groupBox1.Controls.Add(this.cbFacebook);
            this.groupBox1.Controls.Add(this.cbEmail);
            this.groupBox1.Controls.Add(this.twitter);
            this.groupBox1.Controls.Add(this.inputTwitter);
            this.groupBox1.Controls.Add(this.inputFacebook);
            this.groupBox1.Controls.Add(this.facebook);
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Extras";
            // 
            // accessTwitter
            // 
            this.accessTwitter.AutoSize = true;
            this.accessTwitter.Location = new System.Drawing.Point(668, 81);
            this.accessTwitter.Name = "accessTwitter";
            this.accessTwitter.Size = new System.Drawing.Size(85, 15);
            this.accessTwitter.TabIndex = 11;
            this.accessTwitter.TabStop = true;
            this.accessTwitter.Text = "Acessar Twitter";
            this.accessTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessTwitter_LinkClicked);
            // 
            // accessFacebook
            // 
            this.accessFacebook.AutoSize = true;
            this.accessFacebook.Location = new System.Drawing.Point(668, 52);
            this.accessFacebook.Name = "accessFacebook";
            this.accessFacebook.Size = new System.Drawing.Size(101, 15);
            this.accessFacebook.TabIndex = 10;
            this.accessFacebook.TabStop = true;
            this.accessFacebook.Text = "Acessar Facebook";
            this.accessFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessFacebook_LinkClicked);
            // 
            // sendEmail
            // 
            this.sendEmail.AutoSize = true;
            this.sendEmail.Location = new System.Drawing.Point(668, 23);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(71, 15);
            this.sendEmail.TabIndex = 9;
            this.sendEmail.TabStop = true;
            this.sendEmail.Text = "Enviar Email";
            this.sendEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendEmail_LinkClicked);
            // 
            // cbTwitter
            // 
            this.cbTwitter.AutoSize = true;
            this.cbTwitter.Location = new System.Drawing.Point(578, 80);
            this.cbTwitter.Name = "cbTwitter";
            this.cbTwitter.Size = new System.Drawing.Size(61, 19);
            this.cbTwitter.TabIndex = 8;
            this.cbTwitter.Text = "Twitter";
            this.cbTwitter.UseVisualStyleBackColor = true;
            this.cbTwitter.CheckedChanged += new System.EventHandler(this.cbTwitter_CheckedChanged);
            // 
            // cbFacebook
            // 
            this.cbFacebook.AutoSize = true;
            this.cbFacebook.Location = new System.Drawing.Point(578, 51);
            this.cbFacebook.Name = "cbFacebook";
            this.cbFacebook.Size = new System.Drawing.Size(77, 19);
            this.cbFacebook.TabIndex = 7;
            this.cbFacebook.Text = "Facebook";
            this.cbFacebook.UseVisualStyleBackColor = true;
            this.cbFacebook.CheckedChanged += new System.EventHandler(this.cbFacebook_CheckedChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(579, 22);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(55, 19);
            this.cbEmail.TabIndex = 6;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // twitter
            // 
            this.twitter.AutoSize = true;
            this.twitter.Location = new System.Drawing.Point(21, 80);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(45, 15);
            this.twitter.TabIndex = 5;
            this.twitter.Text = "Twitter:";
            // 
            // inputTwitter
            // 
            this.inputTwitter.Location = new System.Drawing.Point(72, 77);
            this.inputTwitter.Name = "inputTwitter";
            this.inputTwitter.Size = new System.Drawing.Size(500, 23);
            this.inputTwitter.TabIndex = 4;
            // 
            // inputFacebook
            // 
            this.inputFacebook.Location = new System.Drawing.Point(72, 48);
            this.inputFacebook.Name = "inputFacebook";
            this.inputFacebook.Size = new System.Drawing.Size(500, 23);
            this.inputFacebook.TabIndex = 3;
            // 
            // facebook
            // 
            this.facebook.AutoSize = true;
            this.facebook.Location = new System.Drawing.Point(10, 51);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(61, 15);
            this.facebook.TabIndex = 2;
            this.facebook.Text = "Facebook:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(72, 19);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(500, 23);
            this.inputEmail.TabIndex = 1;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(32, 22);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(39, 15);
            this.email.TabIndex = 0;
            this.email.Text = "Email:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 462);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Incluir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(143, 462);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(274, 462);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Consultar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(405, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(536, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(667, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.dadosPessoais);
            this.Controls.Add(this.title);
            this.Name = "Cadastro";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.dadosPessoais.ResumeLayout(false);
            this.dadosPessoais.PerformLayout();
            this.sexo.ResumeLayout(false);
            this.sexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.endereco.ResumeLayout(false);
            this.endereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox dadosPessoais;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Button btnClearImg;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox inputRG;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.TextBox inputCel;
        private System.Windows.Forms.Label cel;
        private System.Windows.Forms.GroupBox sexo;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.GroupBox endereco;
        private System.Windows.Forms.TextBox inputCEP;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label logradouro;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.TextBox inputState;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox inputCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox inputNei;
        private System.Windows.Forms.Label nei;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTwitter;
        private System.Windows.Forms.CheckBox cbFacebook;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.Label twitter;
        private System.Windows.Forms.TextBox inputTwitter;
        private System.Windows.Forms.TextBox inputFacebook;
        private System.Windows.Forms.Label facebook;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel accessTwitter;
        private System.Windows.Forms.LinkLabel accessFacebook;
        private System.Windows.Forms.LinkLabel sendEmail;
    }
}

