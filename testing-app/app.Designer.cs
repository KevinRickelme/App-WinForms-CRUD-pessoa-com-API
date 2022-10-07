
namespace testing_app
{
    partial class app
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxInformacaoPessoal = new System.Windows.Forms.GroupBox();
            this.dateDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtDDDTel = new System.Windows.Forms.TextBox();
            this.txtDDDCel = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.cboxUF = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxFoto = new System.Windows.Forms.GroupBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxConsulta = new System.Windows.Forms.GroupBox();
            this.dataGridPessoa = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxRelatorio = new System.Windows.Forms.GroupBox();
            this.btnRelatorioTXT = new System.Windows.Forms.Button();
            this.btnRelatorioPDF = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxInformacaoPessoal.SuspendLayout();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBoxFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBoxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBoxRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teste CRUD com API";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 222);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(710, 56);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnExcluir);
            this.groupBox7.Controls.Add(this.btnAtualizar);
            this.groupBox7.Controls.Add(this.btnAdicionar);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(319, 53);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operação";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(207, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 30);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(109, 17);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(92, 30);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(6, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 30);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPesquisa);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.btnPesquisa);
            this.groupBox6.Location = new System.Drawing.Point(328, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(379, 53);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(96, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(134, 23);
            this.txtPesquisa.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nome ou CPF";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(237, 17);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(136, 30);
            this.btnPesquisa.TabIndex = 18;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBoxInformacaoPessoal);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxEndereco);
            this.flowLayoutPanel2.Controls.Add(this.groupBoxFoto);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(710, 167);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // groupBoxInformacaoPessoal
            // 
            this.groupBoxInformacaoPessoal.Controls.Add(this.dateDataNasc);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtDDDTel);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtDDDCel);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtCel);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label8);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtTel);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label6);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label7);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label5);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtCPF);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label4);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtRG);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label3);
            this.groupBoxInformacaoPessoal.Controls.Add(this.txtNome);
            this.groupBoxInformacaoPessoal.Controls.Add(this.label2);
            this.groupBoxInformacaoPessoal.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInformacaoPessoal.Name = "groupBoxInformacaoPessoal";
            this.groupBoxInformacaoPessoal.Size = new System.Drawing.Size(325, 164);
            this.groupBoxInformacaoPessoal.TabIndex = 0;
            this.groupBoxInformacaoPessoal.TabStop = false;
            this.groupBoxInformacaoPessoal.Text = "Informação pessoal";
            // 
            // dateDataNasc
            // 
            this.dateDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataNasc.Location = new System.Drawing.Point(199, 87);
            this.dateDataNasc.Name = "dateDataNasc";
            this.dateDataNasc.Size = new System.Drawing.Size(112, 23);
            this.dateDataNasc.TabIndex = 4;
            this.dateDataNasc.Value = new System.DateTime(2022, 10, 18, 0, 0, 0, 0);
            // 
            // txtDDDTel
            // 
            this.txtDDDTel.Location = new System.Drawing.Point(6, 134);
            this.txtDDDTel.Name = "txtDDDTel";
            this.txtDDDTel.Size = new System.Drawing.Size(42, 23);
            this.txtDDDTel.TabIndex = 5;
            // 
            // txtDDDCel
            // 
            this.txtDDDCel.Location = new System.Drawing.Point(169, 134);
            this.txtDDDCel.Name = "txtDDDCel";
            this.txtDDDCel.Size = new System.Drawing.Size(42, 23);
            this.txtDDDCel.TabIndex = 7;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(217, 134);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(94, 23);
            this.txtCel.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(54, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(82, 23);
            this.txtTel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data de nascimento";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(101, 87);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(89, 23);
            this.txtCPF.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(6, 87);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(89, 23);
            this.txtRG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.cboxUF);
            this.groupBoxEndereco.Controls.Add(this.label13);
            this.groupBoxEndereco.Controls.Add(this.txtCidade);
            this.groupBoxEndereco.Controls.Add(this.label12);
            this.groupBoxEndereco.Controls.Add(this.label11);
            this.groupBoxEndereco.Controls.Add(this.txtBairro);
            this.groupBoxEndereco.Controls.Add(this.txtNumero);
            this.groupBoxEndereco.Controls.Add(this.label10);
            this.groupBoxEndereco.Controls.Add(this.txtLogradouro);
            this.groupBoxEndereco.Controls.Add(this.label9);
            this.groupBoxEndereco.Location = new System.Drawing.Point(334, 3);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(242, 164);
            this.groupBoxEndereco.TabIndex = 17;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // cboxUF
            // 
            this.cboxUF.FormattingEnabled = true;
            this.cboxUF.Location = new System.Drawing.Point(163, 133);
            this.cboxUF.Name = "cboxUF";
            this.cboxUF.Size = new System.Drawing.Size(61, 23);
            this.cboxUF.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 134);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(151, 23);
            this.txtCidade.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(81, 87);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(143, 23);
            this.txtBairro.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 85);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 23);
            this.txtNumero.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(6, 41);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(218, 23);
            this.txtLogradouro.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logradouro";
            // 
            // groupBoxFoto
            // 
            this.groupBoxFoto.Controls.Add(this.picFoto);
            this.groupBoxFoto.Location = new System.Drawing.Point(582, 3);
            this.groupBoxFoto.Name = "groupBoxFoto";
            this.groupBoxFoto.Size = new System.Drawing.Size(125, 164);
            this.groupBoxFoto.TabIndex = 0;
            this.groupBoxFoto.TabStop = false;
            this.groupBoxFoto.Text = "Foto";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(6, 22);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(113, 135);
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBoxConsulta);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 281);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(710, 151);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // groupBoxConsulta
            // 
            this.groupBoxConsulta.Controls.Add(this.dataGridPessoa);
            this.groupBoxConsulta.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConsulta.Name = "groupBoxConsulta";
            this.groupBoxConsulta.Size = new System.Drawing.Size(707, 148);
            this.groupBoxConsulta.TabIndex = 0;
            this.groupBoxConsulta.TabStop = false;
            this.groupBoxConsulta.Text = "Consulta";
            // 
            // dataGridPessoa
            // 
            this.dataGridPessoa.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPessoa.Location = new System.Drawing.Point(6, 23);
            this.dataGridPessoa.Name = "dataGridPessoa";
            this.dataGridPessoa.RowTemplate.Height = 25;
            this.dataGridPessoa.Size = new System.Drawing.Size(698, 117);
            this.dataGridPessoa.TabIndex = 19;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.groupBoxRelatorio);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 438);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(710, 46);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // groupBoxRelatorio
            // 
            this.groupBoxRelatorio.Controls.Add(this.btnRelatorioTXT);
            this.groupBoxRelatorio.Controls.Add(this.btnRelatorioPDF);
            this.groupBoxRelatorio.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRelatorio.Name = "groupBoxRelatorio";
            this.groupBoxRelatorio.Size = new System.Drawing.Size(707, 43);
            this.groupBoxRelatorio.TabIndex = 0;
            this.groupBoxRelatorio.TabStop = false;
            this.groupBoxRelatorio.Text = "Relatório";
            // 
            // btnRelatorioTXT
            // 
            this.btnRelatorioTXT.Location = new System.Drawing.Point(412, 8);
            this.btnRelatorioTXT.Name = "btnRelatorioTXT";
            this.btnRelatorioTXT.Size = new System.Drawing.Size(142, 35);
            this.btnRelatorioTXT.TabIndex = 20;
            this.btnRelatorioTXT.Text = "Gerar Relatório TXT";
            this.btnRelatorioTXT.UseVisualStyleBackColor = true;
            // 
            // btnRelatorioPDF
            // 
            this.btnRelatorioPDF.Location = new System.Drawing.Point(562, 8);
            this.btnRelatorioPDF.Name = "btnRelatorioPDF";
            this.btnRelatorioPDF.Size = new System.Drawing.Size(142, 35);
            this.btnRelatorioPDF.TabIndex = 20;
            this.btnRelatorioPDF.Text = "Gerar Relatório PDF";
            this.btnRelatorioPDF.UseVisualStyleBackColor = true;
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(739, 493);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "app";
            this.Text = "CRUD de pessoa";
            this.Load += new System.EventHandler(this.app_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBoxInformacaoPessoal.ResumeLayout(false);
            this.groupBoxInformacaoPessoal.PerformLayout();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBoxFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBoxConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBoxRelatorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBoxInformacaoPessoal;
        private System.Windows.Forms.TextBox txtDDDTel;
        private System.Windows.Forms.TextBox txtDDDCel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.ComboBox cboxUF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.DataGridView dataGridPessoa;
        private System.Windows.Forms.GroupBox groupBoxRelatorio;
        private System.Windows.Forms.Button btnRelatorioTXT;
        private System.Windows.Forms.Button btnRelatorioPDF;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dateDataNasc;
    }
}

