using System.Windows.Forms;

namespace AlarmaArduino
{
    partial class ComunicacionArduino
    {
        public NumericUpDown numericUpDown1;

        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;

        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Button btn_fechas;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button BuscaPuertos;
        private System.Windows.Forms.Button Conectar;
        private System.Windows.Forms.Button Desconectar;
        private System.Windows.Forms.Button EEPROM_Read;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
        private System.Windows.Forms.DateTimePicker dateTimePicker10;
        private System.Windows.Forms.DateTimePicker dateTimePicker11;
        private System.Windows.Forms.DateTimePicker dateTimePicker12;
        private System.Windows.Forms.DateTimePicker dateTimePicker13;
        private System.Windows.Forms.DateTimePicker dateTimePicker14;
        private System.Windows.Forms.DateTimePicker dateTimePicker15;
        private System.Windows.Forms.DateTimePicker dateTimePicker16;
        private System.Windows.Forms.DateTimePicker dateTimePicker17;
        private System.Windows.Forms.DateTimePicker dateTimePicker18;
        private System.Windows.Forms.DateTimePicker dateTimePicker19;
        private System.Windows.Forms.DateTimePicker dateTimePicker20;
        private System.Windows.Forms.DateTimePicker dateTimePicker21;

        private FolderBrowserDialog folderBrowserDialog1;

        private System.Windows.Forms.ToolStripMenuItem dddToolStripMenuItem;

        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_fechas;
        private System.Windows.Forms.Label reloj;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private ListBox listBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Panel panel_master;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.IO.Ports.SerialPort serialPort1;

        private TabControl tabControl1;

        private TabPage tabPage1;
        private TabPage tabPage2;

        private System.Windows.Forms.TextBox textBox1_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Timer timer1;

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
            this.textBox1_2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1_1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscaPuertos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker14 = new System.Windows.Forms.DateTimePicker();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dateTimePicker15 = new System.Windows.Forms.DateTimePicker();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.dateTimePicker16 = new System.Windows.Forms.DateTimePicker();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.dateTimePicker17 = new System.Windows.Forms.DateTimePicker();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.dateTimePicker18 = new System.Windows.Forms.DateTimePicker();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dateTimePicker19 = new System.Windows.Forms.DateTimePicker();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.dateTimePicker20 = new System.Windows.Forms.DateTimePicker();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.dateTimePicker21 = new System.Windows.Forms.DateTimePicker();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.panel_master = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.panel14 = new System.Windows.Forms.Panel();
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
            this.reloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_connect = new System.Windows.Forms.Label();
            this.btn_fechas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_print = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.EEPROM_Read = new System.Windows.Forms.Button();
            this.lbl_fechas = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputSerial = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_master.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel20.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // textBox1_2
            // 
            this.textBox1_2.Location = new System.Drawing.Point(701, 151);
            this.textBox1_2.Name = "textBox1_2";
            this.textBox1_2.Size = new System.Drawing.Size(156, 20);
            this.textBox1_2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 4);
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
            this.label1_1.Location = new System.Drawing.Point(31, 6);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(109, 13);
            this.label1_1.TabIndex = 10;
            this.label1_1.Text = "Cantidad de muestras";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AlarmaArduino.Properties.Resources.icml;
            this.pictureBox2.Location = new System.Drawing.Point(518, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlarmaArduino.Properties.Resources.ic_error_red_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(9, 23);
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
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
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
            this.comboBox1.Location = new System.Drawing.Point(127, 3);
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
            this.linkLabel1.Size = new System.Drawing.Size(201, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Qué puerto asigna Windows a Arduino?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel_config
            // 
            this.panel_config.Controls.Add(this.BuscaPuertos);
            this.panel_config.Controls.Add(this.linkLabel1);
            this.panel_config.Controls.Add(this.comboBox1);
            this.panel_config.Controls.Add(this.Conectar);
            this.panel_config.Controls.Add(this.Desconectar);
            this.panel_config.Location = new System.Drawing.Point(117, 70);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(208, 101);
            this.panel_config.TabIndex = 26;
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
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(178, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(207, 20);
            this.textBox14.TabIndex = 125;
            this.textBox14.Text = "Primero elija una fecha";
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
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(178, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(207, 20);
            this.textBox15.TabIndex = 129;
            this.textBox15.Text = "Primero elija una fecha";
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
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(178, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(207, 20);
            this.textBox16.TabIndex = 133;
            this.textBox16.Text = "Primero elija una fecha";
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
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(178, 3);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(207, 20);
            this.textBox17.TabIndex = 137;
            this.textBox17.Text = "Primero elija una fecha";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 77;
            this.textBox1.Text = "Elija el puerto COM";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(178, 3);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(207, 20);
            this.textBox18.TabIndex = 141;
            this.textBox18.Text = "Primero elija una fecha";
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
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(178, 3);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(207, 20);
            this.textBox19.TabIndex = 145;
            this.textBox19.Text = "Primero elija una fecha";
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
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(178, 3);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(207, 20);
            this.textBox20.TabIndex = 149;
            this.textBox20.Text = "Primero elija una fecha";
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
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(178, 3);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(207, 20);
            this.textBox21.TabIndex = 153;
            this.textBox21.Text = "Primero elija una fecha";
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
            this.panel_master.Location = new System.Drawing.Point(6, 33);
            this.panel_master.Name = "panel_master";
            this.panel_master.Size = new System.Drawing.Size(555, 187);
            this.panel_master.TabIndex = 41;
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 175;
            this.label20.Text = "label20";
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
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.Location = new System.Drawing.Point(338, 54);
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
            this.fecha.Location = new System.Drawing.Point(338, 23);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(90, 31);
            this.fecha.TabIndex = 46;
            this.fecha.Text = "Fecha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AlarmaArduino.Properties.Resources.config;
            this.pictureBox3.Location = new System.Drawing.Point(9, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // label_connect
            // 
            this.label_connect.AutoSize = true;
            this.label_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connect.ForeColor = System.Drawing.Color.Red;
            this.label_connect.Location = new System.Drawing.Point(76, 23);
            this.label_connect.Name = "label_connect";
            this.label_connect.Size = new System.Drawing.Size(245, 15);
            this.label_connect.TabIndex = 49;
            this.label_connect.Text = "No está conectado actualmente a la trampa";
            // 
            // btn_fechas
            // 
            this.btn_fechas.Enabled = false;
            this.btn_fechas.Location = new System.Drawing.Point(11, 223);
            this.btn_fechas.Name = "btn_fechas";
            this.btn_fechas.Size = new System.Drawing.Size(129, 23);
            this.btn_fechas.TabIndex = 50;
            this.btn_fechas.Text = "Almacenar en la trampa";
            this.btn_fechas.UseVisualStyleBackColor = true;
            this.btn_fechas.Click += new System.EventHandler(this.btn_fechas_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(567, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 173);
            this.listBox1.TabIndex = 51;
            // 
            // bt_print
            // 
            this.bt_print.Location = new System.Drawing.Point(11, 250);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(129, 23);
            this.bt_print.TabIndex = 52;
            this.bt_print.Text = "Guardar fechas";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // EEPROM_Read
            // 
            this.EEPROM_Read.Enabled = false;
            this.EEPROM_Read.Location = new System.Drawing.Point(240, 234);
            this.EEPROM_Read.Name = "EEPROM_Read";
            this.EEPROM_Read.Size = new System.Drawing.Size(126, 23);
            this.EEPROM_Read.TabIndex = 54;
            this.EEPROM_Read.Text = "Verificar fechas";
            this.EEPROM_Read.UseVisualStyleBackColor = true;
            this.EEPROM_Read.Click += new System.EventHandler(this.EEPROM_Read_Click);
            // 
            // lbl_fechas
            // 
            this.lbl_fechas.AutoSize = true;
            this.lbl_fechas.Location = new System.Drawing.Point(607, 44);
            this.lbl_fechas.Name = "lbl_fechas";
            this.lbl_fechas.Size = new System.Drawing.Size(79, 13);
            this.lbl_fechas.TabIndex = 55;
            this.lbl_fechas.Text = "Lista de fechas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 183);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(964, 314);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputSerial);
            this.tabPage1.Controls.Add(this.panel_master);
            this.tabPage1.Controls.Add(this.lbl_fechas);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.EEPROM_Read);
            this.tabPage1.Controls.Add(this.label1_1);
            this.tabPage1.Controls.Add(this.bt_print);
            this.tabPage1.Controls.Add(this.btn_fechas);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(956, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Almacenar fechas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputSerial
            // 
            this.inputSerial.Location = new System.Drawing.Point(780, 42);
            this.inputSerial.Multiline = true;
            this.inputSerial.Name = "inputSerial";
            this.inputSerial.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inputSerial.Size = new System.Drawing.Size(100, 200);
            this.inputSerial.TabIndex = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_start);
            this.tabPage2.Controls.Add(this.btn_stop);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(956, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Girar trampa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Image = global::AlarmaArduino.Properties.Resources.ic_adjust_black_48dp;
            this.btn_start.Location = new System.Drawing.Point(87, 53);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(57, 68);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Girar";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_der_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.AutoEllipsis = true;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stop.Enabled = false;
            this.btn_stop.Image = global::AlarmaArduino.Properties.Resources.ic_warning_amber_48dp;
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_stop.Location = new System.Drawing.Point(24, 53);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(57, 68);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Detener";
            this.btn_stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_izq_Click);
            // 
            // ComunicacionArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(981, 493);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_connect);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.textBox1_2);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ComunicacionArduino";
            this.Text = "Trampa de sedimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComunicacionArduino_FormClosing);
            this.Load += new System.EventHandler(this.ComunicacionArduino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_master.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox inputSerial;

    }
}

