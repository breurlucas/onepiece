﻿namespace onepiece
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.txtVerificarVez = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtCorJogador = new System.Windows.Forms.TextBox();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSimbolo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.btnMoverTras = new System.Windows.Forms.Button();
            this.btnMoverFrente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblBottle = new System.Windows.Forms.Label();
            this.lblPistol = new System.Windows.Forms.Label();
            this.lblKnife = new System.Windows.Forms.Label();
            this.lblTricorn = new System.Windows.Forms.Label();
            this.lblSkull = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCadeia = new System.Windows.Forms.DataGridView();
            this.dgvBarco = new System.Windows.Forms.DataGridView();
            this.picMapBackground = new System.Windows.Forms.PictureBox();
            this.tmrVerificarVez = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVerificarVez
            // 
            this.txtVerificarVez.BackColor = System.Drawing.Color.Wheat;
            this.txtVerificarVez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerificarVez.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificarVez.Location = new System.Drawing.Point(0, 60);
            this.txtVerificarVez.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerificarVez.Multiline = true;
            this.txtVerificarVez.Name = "txtVerificarVez";
            this.txtVerificarVez.ReadOnly = true;
            this.txtVerificarVez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVerificarVez.Size = new System.Drawing.Size(215, 114);
            this.txtVerificarVez.TabIndex = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdJogador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSenhaJogador);
            this.groupBox1.Controls.Add(this.txtCorJogador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(12, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 248);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(6, 214);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(150, 28);
            this.btnIniciar.TabIndex = 97;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 100;
            this.label5.Text = "Id do Jogador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 102;
            this.label7.Text = "Cor do Jogador";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtIdJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdJogador.Location = new System.Drawing.Point(10, 60);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(104, 22);
            this.txtIdJogador.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 101;
            this.label6.Text = "Senha do Jogador";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtSenhaJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaJogador.Location = new System.Drawing.Point(10, 116);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(104, 22);
            this.txtSenhaJogador.TabIndex = 98;
            // 
            // txtCorJogador
            // 
            this.txtCorJogador.BackColor = System.Drawing.Color.Wheat;
            this.txtCorJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorJogador.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorJogador.Location = new System.Drawing.Point(10, 172);
            this.txtCorJogador.Name = "txtCorJogador";
            this.txtCorJogador.ReadOnly = true;
            this.txtCorJogador.Size = new System.Drawing.Size(104, 22);
            this.txtCorJogador.TabIndex = 99;
            // 
            // txtPosicao
            // 
            this.txtPosicao.BackColor = System.Drawing.Color.Wheat;
            this.txtPosicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosicao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicao.Location = new System.Drawing.Point(6, 60);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(108, 22);
            this.txtPosicao.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 104;
            this.label1.Text = "Posição ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 105;
            this.label2.Text = "Símbolo";
            // 
            // cboSimbolo
            // 
            this.cboSimbolo.BackColor = System.Drawing.Color.Wheat;
            this.cboSimbolo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSimbolo.FormattingEnabled = true;
            this.cboSimbolo.Location = new System.Drawing.Point(120, 58);
            this.cboSimbolo.Name = "cboSimbolo";
            this.cboSimbolo.Size = new System.Drawing.Size(109, 29);
            this.cboSimbolo.TabIndex = 106;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPosicao);
            this.groupBox2.Controls.Add(this.btnPularVez);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnMoverTras);
            this.groupBox2.Controls.Add(this.cboSimbolo);
            this.groupBox2.Controls.Add(this.btnMoverFrente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox2.Location = new System.Drawing.Point(198, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 214);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada";
            // 
            // btnPularVez
            // 
            this.btnPularVez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPularVez.BackgroundImage")));
            this.btnPularVez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPularVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPularVez.ForeColor = System.Drawing.Color.Black;
            this.btnPularVez.Location = new System.Drawing.Point(45, 166);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(150, 28);
            this.btnPularVez.TabIndex = 109;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnMoverTras
            // 
            this.btnMoverTras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoverTras.BackgroundImage")));
            this.btnMoverTras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoverTras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTras.ForeColor = System.Drawing.Color.Black;
            this.btnMoverTras.Location = new System.Drawing.Point(120, 110);
            this.btnMoverTras.Name = "btnMoverTras";
            this.btnMoverTras.Size = new System.Drawing.Size(108, 28);
            this.btnMoverTras.TabIndex = 108;
            this.btnMoverTras.Text = "Para trás";
            this.btnMoverTras.UseVisualStyleBackColor = true;
            this.btnMoverTras.Click += new System.EventHandler(this.btnMoverTras_Click);
            // 
            // btnMoverFrente
            // 
            this.btnMoverFrente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoverFrente.BackgroundImage")));
            this.btnMoverFrente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMoverFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverFrente.ForeColor = System.Drawing.Color.Black;
            this.btnMoverFrente.Location = new System.Drawing.Point(6, 110);
            this.btnMoverFrente.Name = "btnMoverFrente";
            this.btnMoverFrente.Size = new System.Drawing.Size(108, 28);
            this.btnMoverFrente.TabIndex = 107;
            this.btnMoverFrente.Text = "Para frente";
            this.btnMoverFrente.UseVisualStyleBackColor = true;
            this.btnMoverFrente.Click += new System.EventHandler(this.btnMoverFrente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKey);
            this.groupBox3.Controls.Add(this.lblBottle);
            this.groupBox3.Controls.Add(this.lblPistol);
            this.groupBox3.Controls.Add(this.lblKnife);
            this.groupBox3.Controls.Add(this.lblTricorn);
            this.groupBox3.Controls.Add(this.lblSkull);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnExibirMao);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox3.Location = new System.Drawing.Point(442, 441);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 214);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cartas";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(102, 113);
            this.lblKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(20, 24);
            this.lblKey.TabIndex = 129;
            this.lblKey.Text = "0";
            // 
            // lblBottle
            // 
            this.lblBottle.AutoSize = true;
            this.lblBottle.Location = new System.Drawing.Point(66, 113);
            this.lblBottle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottle.Name = "lblBottle";
            this.lblBottle.Size = new System.Drawing.Size(20, 24);
            this.lblBottle.TabIndex = 128;
            this.lblBottle.Text = "0";
            // 
            // lblPistol
            // 
            this.lblPistol.AutoSize = true;
            this.lblPistol.Location = new System.Drawing.Point(175, 113);
            this.lblPistol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPistol.Name = "lblPistol";
            this.lblPistol.Size = new System.Drawing.Size(20, 24);
            this.lblPistol.TabIndex = 127;
            this.lblPistol.Text = "0";
            // 
            // lblKnife
            // 
            this.lblKnife.AutoSize = true;
            this.lblKnife.Location = new System.Drawing.Point(139, 113);
            this.lblKnife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKnife.Name = "lblKnife";
            this.lblKnife.Size = new System.Drawing.Size(20, 24);
            this.lblKnife.TabIndex = 126;
            this.lblKnife.Text = "0";
            // 
            // lblTricorn
            // 
            this.lblTricorn.AutoSize = true;
            this.lblTricorn.Location = new System.Drawing.Point(245, 113);
            this.lblTricorn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTricorn.Name = "lblTricorn";
            this.lblTricorn.Size = new System.Drawing.Size(20, 24);
            this.lblTricorn.TabIndex = 125;
            this.lblTricorn.Text = "0";
            // 
            // lblSkull
            // 
            this.lblSkull.AutoSize = true;
            this.lblSkull.Location = new System.Drawing.Point(210, 113);
            this.lblSkull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkull.Name = "lblSkull";
            this.lblSkull.Size = new System.Drawing.Size(20, 24);
            this.lblSkull.TabIndex = 124;
            this.lblSkull.Text = "0";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::onepiece.Properties.Resources.cardHandKnife;
            this.pictureBox6.Location = new System.Drawing.Point(125, 58);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 53);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 118;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::onepiece.Properties.Resources.cardHandPistol;
            this.pictureBox5.Location = new System.Drawing.Point(160, 58);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 117;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::onepiece.Properties.Resources.cardHandSkull;
            this.pictureBox4.Location = new System.Drawing.Point(196, 58);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 116;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::onepiece.Properties.Resources.cardHandTricorn;
            this.pictureBox3.Location = new System.Drawing.Point(230, 58);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 115;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::onepiece.Properties.Resources.cardHandKey;
            this.pictureBox2.Location = new System.Drawing.Point(90, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::onepiece.Properties.Resources.cardHandBottle;
            this.pictureBox1.Location = new System.Drawing.Point(54, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibirMao.BackgroundImage")));
            this.btnExibirMao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExibirMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirMao.ForeColor = System.Drawing.Color.Black;
            this.btnExibirMao.Location = new System.Drawing.Point(54, 172);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(203, 28);
            this.btnExibirMao.TabIndex = 110;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = true;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCurrentPlayer);
            this.groupBox4.Controls.Add(this.btnVerificarVez);
            this.groupBox4.Controls.Add(this.txtVerificarVez);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox4.Location = new System.Drawing.Point(772, 441);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 214);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vez";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(72, 25);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(0, 24);
            this.lblCurrentPlayer.TabIndex = 114;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerificarVez.BackgroundImage")));
            this.btnVerificarVez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerificarVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVez.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarVez.Location = new System.Drawing.Point(6, 180);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(203, 28);
            this.btnVerificarVez.TabIndex = 113;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.Wheat;
            this.txtHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistorico.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(0, 25);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(240, 148);
            this.txtHistorico.TabIndex = 114;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHistorico);
            this.groupBox5.Controls.Add(this.txtHistorico);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox5.Location = new System.Drawing.Point(993, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 214);
            this.groupBox5.TabIndex = 115;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Histórico";
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistorico.BackgroundImage")));
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorico.Location = new System.Drawing.Point(6, 180);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(203, 28);
            this.btnHistorico.TabIndex = 114;
            this.btnHistorico.Text = "Exibir Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 116;
            this.label3.Text = "Cadeia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(1094, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 117;
            this.label4.Text = "Barco";
            // 
            // dgvCadeia
            // 
            this.dgvCadeia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadeia.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvCadeia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCadeia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadeia.ColumnHeadersVisible = false;
            this.dgvCadeia.Enabled = false;
            this.dgvCadeia.Location = new System.Drawing.Point(-1, 28);
            this.dgvCadeia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCadeia.MultiSelect = false;
            this.dgvCadeia.Name = "dgvCadeia";
            this.dgvCadeia.ReadOnly = true;
            this.dgvCadeia.RowHeadersVisible = false;
            this.dgvCadeia.RowTemplate.Height = 24;
            this.dgvCadeia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCadeia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadeia.Size = new System.Drawing.Size(148, 370);
            this.dgvCadeia.TabIndex = 118;
            // 
            // dgvBarco
            // 
            this.dgvBarco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarco.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvBarco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBarco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarco.ColumnHeadersVisible = false;
            this.dgvBarco.Enabled = false;
            this.dgvBarco.Location = new System.Drawing.Point(1094, 28);
            this.dgvBarco.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBarco.MultiSelect = false;
            this.dgvBarco.Name = "dgvBarco";
            this.dgvBarco.ReadOnly = true;
            this.dgvBarco.RowHeadersVisible = false;
            this.dgvBarco.RowTemplate.Height = 24;
            this.dgvBarco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBarco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarco.Size = new System.Drawing.Size(148, 370);
            this.dgvBarco.TabIndex = 120;
            // 
            // picMapBackground
            // 
            this.picMapBackground.BackColor = System.Drawing.Color.Transparent;
            this.picMapBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMapBackground.Image = global::onepiece.Properties.Resources.Map;
            this.picMapBackground.Location = new System.Drawing.Point(149, 0);
            this.picMapBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picMapBackground.Name = "picMapBackground";
            this.picMapBackground.Size = new System.Drawing.Size(943, 398);
            this.picMapBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMapBackground.TabIndex = 0;
            this.picMapBackground.TabStop = false;
            // 
            // tmrVerificarVez
            // 
            this.tmrVerificarVez.Tick += new System.EventHandler(this.tmrVerificarVez_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 693);
            this.Controls.Add(this.dgvBarco);
            this.Controls.Add(this.dgvCadeia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picMapBackground);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "One Piece – Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadeia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVerificarVez;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtCorJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSimbolo;
        private System.Windows.Forms.Button btnMoverFrente;
        private System.Windows.Forms.Button btnMoverTras;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.PictureBox picMapBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCadeia;
        private System.Windows.Forms.DataGridView dgvBarco;
        private System.Windows.Forms.Timer tmrVerificarVez;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblTricorn;
        private System.Windows.Forms.Label lblSkull;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblBottle;
        private System.Windows.Forms.Label lblPistol;
        private System.Windows.Forms.Label lblKnife;
    }
}