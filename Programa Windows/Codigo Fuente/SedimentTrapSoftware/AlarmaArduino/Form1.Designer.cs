using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using SedimentTrap.Properties;

namespace AlarmaArduino
{
    partial class ComunicacionArduino
    {

        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Button BuscaPuertos;
        private Button Conectar;
        private Button Desconectar;
        private Button EEPROM_Read;

        private ComboBox comboBox1;

        private IContainer components = null;

        private FolderBrowserDialog folderBrowserDialog1;

        private ToolStripMenuItem dddToolStripMenuItem;

        private Label fecha;
        private Label label_connect;
        private Label reloj;

        private LinkLabel linkLabel1;

        private MenuStrip menuStrip1;

        private Panel panel_config;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;

        private SerialPort serialPort1;
        private Timer timer1;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComunicacionArduino));
            this.Conectar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Desconectar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscaPuertos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.reloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_connect = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.EEPROM_Read = new System.Windows.Forms.Button();
            this.btnSyncDate = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_pos_act = new System.Windows.Forms.TextBox();
            this.cb_pos_ok = new System.Windows.Forms.CheckBox();
            this.PosDes = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.PosAct = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.inputSerial = new System.Windows.Forms.TextBox();
            this.panel_master = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.dateTimePicker21 = new System.Windows.Forms.DateTimePicker();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.dateTimePicker20 = new System.Windows.Forms.DateTimePicker();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel19 = new System.Windows.Forms.Panel();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.dateTimePicker19 = new System.Windows.Forms.DateTimePicker();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dateTimePicker18 = new System.Windows.Forms.DateTimePicker();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.dateTimePicker17 = new System.Windows.Forms.DateTimePicker();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.panel16 = new System.Windows.Forms.Panel();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.dateTimePicker16 = new System.Windows.Forms.DateTimePicker();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker15 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker14 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker13 = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dateTimePicker12 = new System.Windows.Forms.DateTimePicker();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechas = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1_1 = new System.Windows.Forms.Label();
            this.bt_print = new System.Windows.Forms.Button();
            this.btn_fechas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblTiempoMuestras = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosAct)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel_master.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Conectar
            // 
            this.Conectar.Enabled = false;
            this.Conectar.Location = new System.Drawing.Point(6, 45);
            this.Conectar.Name = "Conectar";
            this.Conectar.Size = new System.Drawing.Size(75, 23);
            this.Conectar.TabIndex = 0;
            this.Conectar.Text = "Conectar";
            this.Conectar.UseVisualStyleBackColor = true;
            this.Conectar.Click += new System.EventHandler(this.ON_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Desconectar
            // 
            this.Desconectar.Enabled = false;
            this.Desconectar.Location = new System.Drawing.Point(87, 45);
            this.Desconectar.Name = "Desconectar";
            this.Desconectar.Size = new System.Drawing.Size(75, 23);
            this.Desconectar.TabIndex = 1;
            this.Desconectar.Text = "Desconectar";
            this.Desconectar.UseVisualStyleBackColor = true;
            this.Desconectar.Click += new System.EventHandler(this.OFF_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SedimentTrap.Properties.Resources.icml;
            this.pictureBox2.Location = new System.Drawing.Point(4, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SedimentTrap.Properties.Resources.ic_error_red_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(6, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dddToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dddToolStripMenuItem
            // 
            this.dddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.dddToolStripMenuItem.Name = "dddToolStripMenuItem";
            this.dddToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dddToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // BuscaPuertos
            // 
            this.BuscaPuertos.Location = new System.Drawing.Point(3, 3);
            this.BuscaPuertos.Name = "BuscaPuertos";
            this.BuscaPuertos.Size = new System.Drawing.Size(118, 23);
            this.BuscaPuertos.TabIndex = 14;
            this.BuscaPuertos.Text = "Buscar puertos";
            this.BuscaPuertos.UseVisualStyleBackColor = true;
            this.BuscaPuertos.Click += new System.EventHandler(this.BuscaPuertos_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Qué puerto asigna Windows a la trampa?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel_config
            // 
            this.panel_config.Controls.Add(this.BuscaPuertos);
            this.panel_config.Controls.Add(this.linkLabel1);
            this.panel_config.Controls.Add(this.comboBox1);
            this.panel_config.Controls.Add(this.Conectar);
            this.panel_config.Controls.Add(this.Desconectar);
            this.panel_config.Location = new System.Drawing.Point(6, 19);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(227, 68);
            this.panel_config.TabIndex = 26;
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(143, 114);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(83, 31);
            this.reloj.TabIndex = 45;
            this.reloj.Text = "Reloj ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(143, 83);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(90, 31);
            this.fecha.TabIndex = 46;
            this.fecha.Text = "Fecha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SedimentTrap.Properties.Resources.config;
            this.pictureBox3.Location = new System.Drawing.Point(235, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // label_connect
            // 
            this.label_connect.AutoSize = true;
            this.label_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connect.ForeColor = System.Drawing.Color.Red;
            this.label_connect.Location = new System.Drawing.Point(61, 114);
            this.label_connect.Name = "label_connect";
            this.label_connect.Size = new System.Drawing.Size(245, 15);
            this.label_connect.TabIndex = 49;
            this.label_connect.Text = "No está conectado actualmente a la trampa";
            // 
            // EEPROM_Read
            // 
            this.EEPROM_Read.Enabled = false;
            this.EEPROM_Read.Location = new System.Drawing.Point(329, 54);
            this.EEPROM_Read.Name = "EEPROM_Read";
            this.EEPROM_Read.Size = new System.Drawing.Size(140, 23);
            this.EEPROM_Read.TabIndex = 54;
            this.EEPROM_Read.Text = "Verificar hora y fechas";
            this.EEPROM_Read.UseVisualStyleBackColor = true;
            this.EEPROM_Read.Click += new System.EventHandler(this.EEPROM_Read_Click);
            // 
            // btnSyncDate
            // 
            this.btnSyncDate.Enabled = false;
            this.btnSyncDate.Location = new System.Drawing.Point(329, 27);
            this.btnSyncDate.Name = "btnSyncDate";
            this.btnSyncDate.Size = new System.Drawing.Size(140, 23);
            this.btnSyncDate.TabIndex = 57;
            this.btnSyncDate.Text = "Sincronizar hora y fecha";
            this.btnSyncDate.UseVisualStyleBackColor = true;
            this.btnSyncDate.Click += new System.EventHandler(this.btnSyncDate_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(329, 90);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(163, 121);
            this.listBox2.TabIndex = 57;
            this.listBox2.MouseEnter += new System.EventHandler(this.listBox2_MouseEnter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(300, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 20);
            this.label25.TabIndex = 58;
            this.label25.Text = "1)";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(300, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 20);
            this.label26.TabIndex = 59;
            this.label26.Text = "2)";
            this.label26.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel_config);
            this.groupBox1.Controls.Add(this.label_connect);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(534, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 153);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.tb_pos_act);
            this.tabPage2.Controls.Add(this.cb_pos_ok);
            this.tabPage2.Controls.Add(this.PosDes);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.PosAct);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.btn_start);
            this.tabPage2.Controls.Add(this.btn_stop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Girar trampa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(218, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(199, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Por favor seleccione la posición correcta";
            this.label24.Visible = false;
            // 
            // tb_pos_act
            // 
            this.tb_pos_act.Enabled = false;
            this.tb_pos_act.Location = new System.Drawing.Point(125, 23);
            this.tb_pos_act.Name = "tb_pos_act";
            this.tb_pos_act.Size = new System.Drawing.Size(55, 20);
            this.tb_pos_act.TabIndex = 16;
            this.tb_pos_act.Text = "1";
            // 
            // cb_pos_ok
            // 
            this.cb_pos_ok.AutoSize = true;
            this.cb_pos_ok.Checked = true;
            this.cb_pos_ok.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_pos_ok.Location = new System.Drawing.Point(200, 23);
            this.cb_pos_ok.Name = "cb_pos_ok";
            this.cb_pos_ok.Size = new System.Drawing.Size(180, 17);
            this.cb_pos_ok.TabIndex = 15;
            this.cb_pos_ok.Text = "¿La posición actual es correcta?";
            this.cb_pos_ok.UseVisualStyleBackColor = true;
            this.cb_pos_ok.CheckedChanged += new System.EventHandler(this.cb_pos_ok_CheckedChanged);
            // 
            // PosDes
            // 
            this.PosDes.Location = new System.Drawing.Point(125, 50);
            this.PosDes.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.PosDes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PosDes.Name = "PosDes";
            this.PosDes.Size = new System.Drawing.Size(55, 20);
            this.PosDes.TabIndex = 13;
            this.PosDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PosDes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Posición deseada";
            // 
            // PosAct
            // 
            this.PosAct.Enabled = false;
            this.PosAct.Location = new System.Drawing.Point(434, 50);
            this.PosAct.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.PosAct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PosAct.Name = "PosAct";
            this.PosAct.Size = new System.Drawing.Size(55, 20);
            this.PosAct.TabIndex = 11;
            this.PosAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PosAct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PosAct.Visible = false;
            this.PosAct.ValueChanged += new System.EventHandler(this.PosAct_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Posición actual";
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Image = global::SedimentTrap.Properties.Resources.Arrow_48px;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_start.Location = new System.Drawing.Point(21, 104);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(67, 79);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Girar";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_clic);
            // 
            // btn_stop
            // 
            this.btn_stop.AutoEllipsis = true;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stop.Enabled = false;
            this.btn_stop.Image = global::SedimentTrap.Properties.Resources.Stop01;
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stop.Location = new System.Drawing.Point(94, 104);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(67, 79);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Detener";
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel22);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.btn_alarm);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.inputSerial);
            this.tabPage1.Controls.Add(this.panel_master);
            this.tabPage1.Controls.Add(this.lbl_fechas);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1_1);
            this.tabPage1.Controls.Add(this.bt_print);
            this.tabPage1.Controls.Add(this.btn_fechas);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Almacenar fechas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.linkLabel2);
            this.panel22.Controls.Add(this.label31);
            this.panel22.Location = new System.Drawing.Point(222, 8);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(339, 36);
            this.panel22.TabIndex = 61;
            this.panel22.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(5, 17);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(88, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ruta de guardado";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(122, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "Archivo almacenado en:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(734, 92);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 20);
            this.label30.TabIndex = 65;
            this.label30.Text = "6)";
            this.label30.Visible = false;
            // 
            // btn_alarm
            // 
            this.btn_alarm.Location = new System.Drawing.Point(763, 92);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(140, 23);
            this.btn_alarm.TabIndex = 64;
            this.btn_alarm.Text = "btn_alarm";
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Visible = false;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(587, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 23);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(558, 57);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 20);
            this.label29.TabIndex = 62;
            this.label29.Text = "5)";
            this.label29.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(558, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 20);
            this.label28.TabIndex = 61;
            this.label28.Text = "4)";
            this.label28.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 20);
            this.label27.TabIndex = 60;
            this.label27.Text = "3)";
            this.label27.Visible = false;
            // 
            // inputSerial
            // 
            this.inputSerial.Location = new System.Drawing.Point(587, 280);
            this.inputSerial.Multiline = true;
            this.inputSerial.Name = "inputSerial";
            this.inputSerial.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputSerial.Size = new System.Drawing.Size(140, 44);
            this.inputSerial.TabIndex = 56;
            this.inputSerial.Text = "visible en debug";
            this.inputSerial.Visible = false;
            // 
            // panel_master
            // 
            this.panel_master.AutoScroll = true;
            this.panel_master.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_master.Controls.Add(this.panel21);
            this.panel_master.Controls.Add(this.panel1);
            this.panel_master.Controls.Add(this.panel20);
            this.panel_master.Controls.Add(this.panel3);
            this.panel_master.Controls.Add(this.panel19);
            this.panel_master.Controls.Add(this.panel2);
            this.panel_master.Controls.Add(this.panel18);
            this.panel_master.Controls.Add(this.panel4);
            this.panel_master.Controls.Add(this.panel17);
            this.panel_master.Controls.Add(this.panel10);
            this.panel_master.Controls.Add(this.panel16);
            this.panel_master.Controls.Add(this.panel5);
            this.panel_master.Controls.Add(this.panel15);
            this.panel_master.Controls.Add(this.panel7);
            this.panel_master.Controls.Add(this.panel14);
            this.panel_master.Controls.Add(this.panel6);
            this.panel_master.Controls.Add(this.panel13);
            this.panel_master.Controls.Add(this.panel8);
            this.panel_master.Controls.Add(this.panel12);
            this.panel_master.Controls.Add(this.panel9);
            this.panel_master.Controls.Add(this.panel11);
            this.panel_master.Location = new System.Drawing.Point(6, 45);
            this.panel_master.Name = "panel_master";
            this.panel_master.Size = new System.Drawing.Size(555, 268);
            this.panel_master.TabIndex = 41;
            this.panel_master.MouseEnter += new System.EventHandler(this.panel_master_MouseEnter);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.textBox21);
            this.panel21.Controls.Add(this.dateTimePicker21);
            this.panel21.Controls.Add(this.checkBox21);
            this.panel21.Controls.Add(this.label21);
            this.panel21.Location = new System.Drawing.Point(3, 543);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(530, 26);
            this.panel21.TabIndex = 180;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(178, 3);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(207, 20);
            this.textBox21.TabIndex = 153;
            this.textBox21.Text = "Primero elija una fecha";
            // 
            // dateTimePicker21
            // 
            this.dateTimePicker21.Enabled = false;
            this.dateTimePicker21.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker21.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker21.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker21.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker21.Name = "dateTimePicker21";
            this.dateTimePicker21.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker21.TabIndex = 151;
            this.dateTimePicker21.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Enabled = false;
            this.checkBox21.Location = new System.Drawing.Point(391, 6);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(136, 17);
            this.checkBox21.TabIndex = 152;
            this.checkBox21.Text = "¿La fecha es correcta?";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 176;
            this.label21.Text = "label21";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 26);
            this.panel1.TabIndex = 154;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(391, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 72;
            this.checkBox1.Text = "¿La fecha es correcta?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(178, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 77;
            this.textBox1.Text = "Elija el puerto COM";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.textBox20);
            this.panel20.Controls.Add(this.dateTimePicker20);
            this.panel20.Controls.Add(this.checkBox20);
            this.panel20.Controls.Add(this.label20);
            this.panel20.Location = new System.Drawing.Point(3, 516);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(530, 26);
            this.panel20.TabIndex = 182;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(178, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(207, 20);
            this.textBox20.TabIndex = 149;
            this.textBox20.Text = "Primero elija una fecha";
            // 
            // dateTimePicker20
            // 
            this.dateTimePicker20.Enabled = false;
            this.dateTimePicker20.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker20.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker20.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker20.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker20.Name = "dateTimePicker20";
            this.dateTimePicker20.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker20.TabIndex = 147;
            this.dateTimePicker20.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Enabled = false;
            this.checkBox20.Location = new System.Drawing.Point(391, 6);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(136, 17);
            this.checkBox20.TabIndex = 148;
            this.checkBox20.Text = "¿La fecha es correcta?";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 175;
            this.label20.Text = "label20";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.dateTimePicker3);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 26);
            this.panel3.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(207, 20);
            this.textBox3.TabIndex = 85;
            this.textBox3.Text = "Primero elija una fecha";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(391, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 17);
            this.checkBox3.TabIndex = 84;
            this.checkBox3.Text = "¿La fecha es correcta?";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker3.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker3.TabIndex = 83;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.textBox19);
            this.panel19.Controls.Add(this.dateTimePicker19);
            this.panel19.Controls.Add(this.checkBox19);
            this.panel19.Controls.Add(this.label19);
            this.panel19.Location = new System.Drawing.Point(3, 489);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(530, 26);
            this.panel19.TabIndex = 181;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(178, 3);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(207, 20);
            this.textBox19.TabIndex = 145;
            this.textBox19.Text = "Primero elija una fecha";
            // 
            // dateTimePicker19
            // 
            this.dateTimePicker19.Enabled = false;
            this.dateTimePicker19.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker19.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker19.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker19.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker19.Name = "dateTimePicker19";
            this.dateTimePicker19.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker19.TabIndex = 143;
            this.dateTimePicker19.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Enabled = false;
            this.checkBox19.Location = new System.Drawing.Point(391, 6);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(136, 17);
            this.checkBox19.TabIndex = 144;
            this.checkBox19.Text = "¿La fecha es correcta?";
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 174;
            this.label19.Text = "label19";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(3, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 26);
            this.panel2.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "label2";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker2.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker2.TabIndex = 75;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 20);
            this.textBox2.TabIndex = 73;
            this.textBox2.Text = "Primero elija una fecha";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(391, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 17);
            this.checkBox2.TabIndex = 76;
            this.checkBox2.Text = "¿La fecha es correcta?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.textBox18);
            this.panel18.Controls.Add(this.dateTimePicker18);
            this.panel18.Controls.Add(this.checkBox18);
            this.panel18.Controls.Add(this.label18);
            this.panel18.Location = new System.Drawing.Point(3, 462);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(530, 26);
            this.panel18.TabIndex = 180;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(178, 3);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(207, 20);
            this.textBox18.TabIndex = 141;
            this.textBox18.Text = "Primero elija una fecha";
            // 
            // dateTimePicker18
            // 
            this.dateTimePicker18.Enabled = false;
            this.dateTimePicker18.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker18.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker18.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker18.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker18.Name = "dateTimePicker18";
            this.dateTimePicker18.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker18.TabIndex = 139;
            this.dateTimePicker18.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Enabled = false;
            this.checkBox18.Location = new System.Drawing.Point(391, 6);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(136, 17);
            this.checkBox18.TabIndex = 140;
            this.checkBox18.Text = "¿La fecha es correcta?";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 173;
            this.label18.Text = "label18";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.dateTimePicker4);
            this.panel4.Location = new System.Drawing.Point(3, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 26);
            this.panel4.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 167;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 89;
            this.textBox4.Text = "Primero elija una fecha";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(391, 6);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(136, 17);
            this.checkBox4.TabIndex = 88;
            this.checkBox4.Text = "¿La fecha es correcta?";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker4.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker4.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker4.TabIndex = 87;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.textBox17);
            this.panel17.Controls.Add(this.dateTimePicker17);
            this.panel17.Controls.Add(this.checkBox17);
            this.panel17.Controls.Add(this.label17);
            this.panel17.Location = new System.Drawing.Point(3, 435);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(530, 26);
            this.panel17.TabIndex = 179;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(178, 3);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(207, 20);
            this.textBox17.TabIndex = 137;
            this.textBox17.Text = "Primero elija una fecha";
            // 
            // dateTimePicker17
            // 
            this.dateTimePicker17.Enabled = false;
            this.dateTimePicker17.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker17.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker17.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker17.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker17.Name = "dateTimePicker17";
            this.dateTimePicker17.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker17.TabIndex = 135;
            this.dateTimePicker17.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Enabled = false;
            this.checkBox17.Location = new System.Drawing.Point(391, 6);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(136, 17);
            this.checkBox17.TabIndex = 136;
            this.checkBox17.Text = "¿La fecha es correcta?";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 172;
            this.label17.Text = "label17";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.textBox10);
            this.panel10.Controls.Add(this.checkBox10);
            this.panel10.Controls.Add(this.dateTimePicker10);
            this.panel10.Location = new System.Drawing.Point(3, 246);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(530, 26);
            this.panel10.TabIndex = 162;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 167;
            this.label10.Text = "label10";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(178, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(207, 20);
            this.textBox10.TabIndex = 113;
            this.textBox10.Text = "Primero elija una fecha";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Enabled = false;
            this.checkBox10.Location = new System.Drawing.Point(391, 6);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(136, 17);
            this.checkBox10.TabIndex = 112;
            this.checkBox10.Text = "¿La fecha es correcta?";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.Enabled = false;
            this.dateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker10.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker10.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker10.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker10.TabIndex = 111;
            this.dateTimePicker10.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.textBox16);
            this.panel16.Controls.Add(this.dateTimePicker16);
            this.panel16.Controls.Add(this.checkBox16);
            this.panel16.Controls.Add(this.label16);
            this.panel16.Location = new System.Drawing.Point(3, 408);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(530, 26);
            this.panel16.TabIndex = 178;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(178, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(207, 20);
            this.textBox16.TabIndex = 133;
            this.textBox16.Text = "Primero elija una fecha";
            // 
            // dateTimePicker16
            // 
            this.dateTimePicker16.Enabled = false;
            this.dateTimePicker16.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker16.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker16.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker16.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker16.Name = "dateTimePicker16";
            this.dateTimePicker16.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker16.TabIndex = 131;
            this.dateTimePicker16.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Enabled = false;
            this.checkBox16.Location = new System.Drawing.Point(391, 6);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(136, 17);
            this.checkBox16.TabIndex = 132;
            this.checkBox16.Text = "¿La fecha es correcta?";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 171;
            this.label16.Text = "label16";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.dateTimePicker5);
            this.panel5.Location = new System.Drawing.Point(3, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(530, 26);
            this.panel5.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 167;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(207, 20);
            this.textBox5.TabIndex = 93;
            this.textBox5.Text = "Primero elija una fecha";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(391, 6);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(136, 17);
            this.checkBox5.TabIndex = 92;
            this.checkBox5.Text = "¿La fecha es correcta?";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Enabled = false;
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker5.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker5.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker5.TabIndex = 91;
            this.dateTimePicker5.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox15);
            this.panel15.Controls.Add(this.checkBox15);
            this.panel15.Controls.Add(this.dateTimePicker15);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(3, 381);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(530, 26);
            this.panel15.TabIndex = 177;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(178, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(207, 20);
            this.textBox15.TabIndex = 129;
            this.textBox15.Text = "Primero elija una fecha";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Enabled = false;
            this.checkBox15.Location = new System.Drawing.Point(391, 6);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(136, 17);
            this.checkBox15.TabIndex = 128;
            this.checkBox15.Text = "¿La fecha es correcta?";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // dateTimePicker15
            // 
            this.dateTimePicker15.Enabled = false;
            this.dateTimePicker15.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker15.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker15.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker15.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker15.Name = "dateTimePicker15";
            this.dateTimePicker15.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker15.TabIndex = 127;
            this.dateTimePicker15.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 170;
            this.label15.Text = "label15";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.textBox7);
            this.panel7.Controls.Add(this.checkBox7);
            this.panel7.Controls.Add(this.dateTimePicker7);
            this.panel7.Location = new System.Drawing.Point(3, 165);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(530, 26);
            this.panel7.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "label7";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(178, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(207, 20);
            this.textBox7.TabIndex = 101;
            this.textBox7.Text = "Primero elija una fecha";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(391, 6);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 17);
            this.checkBox7.TabIndex = 100;
            this.checkBox7.Text = "¿La fecha es correcta?";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.Enabled = false;
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker7.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker7.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker7.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker7.TabIndex = 99;
            this.dateTimePicker7.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.textBox14);
            this.panel14.Controls.Add(this.checkBox14);
            this.panel14.Controls.Add(this.dateTimePicker14);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Location = new System.Drawing.Point(3, 354);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(530, 26);
            this.panel14.TabIndex = 166;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(178, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(207, 20);
            this.textBox14.TabIndex = 125;
            this.textBox14.Text = "Primero elija una fecha";
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Enabled = false;
            this.checkBox14.Location = new System.Drawing.Point(391, 6);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(136, 17);
            this.checkBox14.TabIndex = 124;
            this.checkBox14.Text = "¿La fecha es correcta?";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // dateTimePicker14
            // 
            this.dateTimePicker14.Enabled = false;
            this.dateTimePicker14.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker14.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker14.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker14.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker14.Name = "dateTimePicker14";
            this.dateTimePicker14.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker14.TabIndex = 123;
            this.dateTimePicker14.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 169;
            this.label14.Text = "label14";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Controls.Add(this.checkBox6);
            this.panel6.Controls.Add(this.dateTimePicker6);
            this.panel6.Location = new System.Drawing.Point(3, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 26);
            this.panel6.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 167;
            this.label6.Text = "label6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(178, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(207, 20);
            this.textBox6.TabIndex = 97;
            this.textBox6.Text = "Primero elija una fecha";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(391, 6);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(136, 17);
            this.checkBox6.TabIndex = 96;
            this.checkBox6.Text = "¿La fecha es correcta?";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Enabled = false;
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker6.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker6.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker6.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker6.TabIndex = 95;
            this.dateTimePicker6.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label13);
            this.panel13.Controls.Add(this.textBox13);
            this.panel13.Controls.Add(this.checkBox13);
            this.panel13.Controls.Add(this.dateTimePicker13);
            this.panel13.Location = new System.Drawing.Point(3, 327);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(530, 26);
            this.panel13.TabIndex = 165;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 169;
            this.label13.Text = "label13";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(178, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(207, 20);
            this.textBox13.TabIndex = 124;
            this.textBox13.Text = "Primero elija una fecha";
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Enabled = false;
            this.checkBox13.Location = new System.Drawing.Point(391, 6);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(136, 17);
            this.checkBox13.TabIndex = 123;
            this.checkBox13.Text = "¿La fecha es correcta?";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // dateTimePicker13
            // 
            this.dateTimePicker13.Enabled = false;
            this.dateTimePicker13.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker13.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker13.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker13.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker13.Name = "dateTimePicker13";
            this.dateTimePicker13.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker13.TabIndex = 122;
            this.dateTimePicker13.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.textBox8);
            this.panel8.Controls.Add(this.checkBox8);
            this.panel8.Controls.Add(this.dateTimePicker8);
            this.panel8.Location = new System.Drawing.Point(3, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(530, 26);
            this.panel8.TabIndex = 160;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 167;
            this.label8.Text = "label8";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(178, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(207, 20);
            this.textBox8.TabIndex = 105;
            this.textBox8.Text = "Primero elija una fecha";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(391, 6);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(136, 17);
            this.checkBox8.TabIndex = 104;
            this.checkBox8.Text = "¿La fecha es correcta?";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.Enabled = false;
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker8.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker8.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker8.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker8.TabIndex = 103;
            this.dateTimePicker8.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.textBox12);
            this.panel12.Controls.Add(this.dateTimePicker12);
            this.panel12.Controls.Add(this.checkBox12);
            this.panel12.Location = new System.Drawing.Point(3, 300);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(530, 26);
            this.panel12.TabIndex = 164;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 168;
            this.label12.Text = "label12";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(178, 1);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(207, 20);
            this.textBox12.TabIndex = 120;
            this.textBox12.Text = "Primero elija una fecha";
            // 
            // dateTimePicker12
            // 
            this.dateTimePicker12.Enabled = false;
            this.dateTimePicker12.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker12.Location = new System.Drawing.Point(84, 1);
            this.dateTimePicker12.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker12.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker12.Name = "dateTimePicker12";
            this.dateTimePicker12.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker12.TabIndex = 118;
            this.dateTimePicker12.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Enabled = false;
            this.checkBox12.Location = new System.Drawing.Point(391, 4);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(136, 17);
            this.checkBox12.TabIndex = 119;
            this.checkBox12.Text = "¿La fecha es correcta?";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.textBox9);
            this.panel9.Controls.Add(this.checkBox9);
            this.panel9.Controls.Add(this.dateTimePicker9);
            this.panel9.Location = new System.Drawing.Point(3, 219);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(530, 26);
            this.panel9.TabIndex = 159;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 167;
            this.label9.Text = "label9";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(178, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(207, 20);
            this.textBox9.TabIndex = 109;
            this.textBox9.Text = "Primero elija una fecha";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Enabled = false;
            this.checkBox9.Location = new System.Drawing.Point(391, 6);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(136, 17);
            this.checkBox9.TabIndex = 108;
            this.checkBox9.Text = "¿La fecha es correcta?";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.Enabled = false;
            this.dateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker9.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker9.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker9.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker9.TabIndex = 107;
            this.dateTimePicker9.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.textBox11);
            this.panel11.Controls.Add(this.checkBox11);
            this.panel11.Controls.Add(this.dateTimePicker11);
            this.panel11.Location = new System.Drawing.Point(3, 273);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(530, 26);
            this.panel11.TabIndex = 163;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 167;
            this.label11.Text = "label11";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(178, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(207, 20);
            this.textBox11.TabIndex = 117;
            this.textBox11.Text = "Primero elija una fecha";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Enabled = false;
            this.checkBox11.Location = new System.Drawing.Point(391, 6);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(136, 17);
            this.checkBox11.TabIndex = 116;
            this.checkBox11.Text = "¿La fecha es correcta?";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.Enabled = false;
            this.dateTimePicker11.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker11.Location = new System.Drawing.Point(84, 3);
            this.dateTimePicker11.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker11.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker11.TabIndex = 115;
            this.dateTimePicker11.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_fechas
            // 
            this.lbl_fechas.AutoSize = true;
            this.lbl_fechas.Location = new System.Drawing.Point(584, 264);
            this.lbl_fechas.Name = "lbl_fechas";
            this.lbl_fechas.Size = new System.Drawing.Size(84, 13);
            this.lbl_fechas.TabIndex = 55;
            this.lbl_fechas.Text = "Fechas elegidas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.Location = new System.Drawing.Point(30, 18);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(109, 13);
            this.label1_1.TabIndex = 10;
            this.label1_1.Text = "Cantidad de muestras";
            // 
            // bt_print
            // 
            this.bt_print.Enabled = false;
            this.bt_print.Location = new System.Drawing.Point(587, 56);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(140, 23);
            this.bt_print.TabIndex = 52;
            this.bt_print.Text = "Guardar fechas";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // btn_fechas
            // 
            this.btn_fechas.Enabled = false;
            this.btn_fechas.Location = new System.Drawing.Point(587, 8);
            this.btn_fechas.Name = "btn_fechas";
            this.btn_fechas.Size = new System.Drawing.Size(140, 23);
            this.btn_fechas.TabIndex = 50;
            this.btn_fechas.Text = "Enviar a trampa";
            this.btn_fechas.UseVisualStyleBackColor = true;
            this.btn_fechas.Click += new System.EventHandler(this.btn_fechas_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(587, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 173);
            this.listBox1.TabIndex = 51;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 213);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 353);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.lblTiempoMuestras);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(844, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuración";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Restablecer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(575, 295);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(131, 13);
            this.label33.TabIndex = 6;
            this.label33.Text = "Restablecer configuración";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(329, 3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 20);
            this.label35.TabIndex = 5;
            this.label35.Text = "días.";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 36);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(293, 20);
            this.label34.TabIndex = 4;
            this.label34.Text = "Cambiar tiempo entre muestras máximo.";
            // 
            // lblTiempoMuestras
            // 
            this.lblTiempoMuestras.AutoSize = true;
            this.lblTiempoMuestras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoMuestras.Location = new System.Drawing.Point(303, 3);
            this.lblTiempoMuestras.Name = "lblTiempoMuestras";
            this.lblTiempoMuestras.Size = new System.Drawing.Size(27, 20);
            this.lblTiempoMuestras.TabIndex = 3;
            this.lblTiempoMuestras.Text = "30";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(281, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "Tiempo máximo entre muestras actual:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cambiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(307, 36);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ComunicacionArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(852, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnSyncDate);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.EEPROM_Read);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ComunicacionArduino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trampa de sedimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComunicacionArduino_FormClosing);
            this.Load += new System.EventHandler(this.ComunicacionArduino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosAct)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel_master.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBox2;
        private Button btnSyncDate;
        private Label label25;
        private Label label26;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private Label label24;
        private TextBox tb_pos_act;
        private CheckBox cb_pos_ok;
        public NumericUpDown PosDes;
        private Label label23;
        public NumericUpDown PosAct;
        private Label label22;
        private Button btn_start;
        private Button btn_stop;
        private TabPage tabPage1;
        private Panel panel22;
        private LinkLabel linkLabel2;
        private Label label31;
        private Label label30;
        private Button btn_alarm;
        private ProgressBar progressBar1;
        private Label label29;
        private Label label28;
        private Label label27;
        public TextBox inputSerial;
        private Panel panel_master;
        private Panel panel21;
        private TextBox textBox21;
        private DateTimePicker dateTimePicker21;
        private CheckBox checkBox21;
        private Label label21;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Panel panel20;
        private TextBox textBox20;
        private DateTimePicker dateTimePicker20;
        private CheckBox checkBox20;
        private Label label20;
        private Panel panel3;
        private Label label3;
        private TextBox textBox3;
        private CheckBox checkBox3;
        private DateTimePicker dateTimePicker3;
        private Panel panel19;
        private TextBox textBox19;
        private DateTimePicker dateTimePicker19;
        private CheckBox checkBox19;
        private Label label19;
        private Panel panel2;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private CheckBox checkBox2;
        private Panel panel18;
        private TextBox textBox18;
        private DateTimePicker dateTimePicker18;
        private CheckBox checkBox18;
        private Label label18;
        private Panel panel4;
        private Label label4;
        private TextBox textBox4;
        private CheckBox checkBox4;
        private DateTimePicker dateTimePicker4;
        private Panel panel17;
        private TextBox textBox17;
        private DateTimePicker dateTimePicker17;
        private CheckBox checkBox17;
        private Label label17;
        private Panel panel10;
        private Label label10;
        private TextBox textBox10;
        private CheckBox checkBox10;
        private DateTimePicker dateTimePicker10;
        private Panel panel16;
        private TextBox textBox16;
        private DateTimePicker dateTimePicker16;
        private CheckBox checkBox16;
        private Label label16;
        private Panel panel5;
        private Label label5;
        private TextBox textBox5;
        private CheckBox checkBox5;
        private DateTimePicker dateTimePicker5;
        private Panel panel15;
        private TextBox textBox15;
        private CheckBox checkBox15;
        private DateTimePicker dateTimePicker15;
        private Label label15;
        private Panel panel7;
        private Label label7;
        private TextBox textBox7;
        private CheckBox checkBox7;
        private DateTimePicker dateTimePicker7;
        private Panel panel14;
        private TextBox textBox14;
        private CheckBox checkBox14;
        private DateTimePicker dateTimePicker14;
        private Label label14;
        private Panel panel6;
        private Label label6;
        private TextBox textBox6;
        private CheckBox checkBox6;
        private DateTimePicker dateTimePicker6;
        private Panel panel13;
        private Label label13;
        private TextBox textBox13;
        private CheckBox checkBox13;
        private DateTimePicker dateTimePicker13;
        private Panel panel8;
        private Label label8;
        private TextBox textBox8;
        private CheckBox checkBox8;
        private DateTimePicker dateTimePicker8;
        private Panel panel12;
        private Label label12;
        private TextBox textBox12;
        private DateTimePicker dateTimePicker12;
        private CheckBox checkBox12;
        private Panel panel9;
        private Label label9;
        private TextBox textBox9;
        private CheckBox checkBox9;
        private DateTimePicker dateTimePicker9;
        private Panel panel11;
        private Label label11;
        private TextBox textBox11;
        private CheckBox checkBox11;
        private DateTimePicker dateTimePicker11;
        private Label lbl_fechas;
        public NumericUpDown numericUpDown1;
        private Label label1_1;
        private Button bt_print;
        private Button btn_fechas;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private Label label35;
        private Label label34;
        private Label lblTiempoMuestras;
        private Label label32;
        private Button button2;
        private Label label33;
    }
}

