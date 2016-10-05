using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SedimentTrap.Properties;

namespace AlarmaArduino
{
    public partial class ComunicacionArduino : Form
    {
        //public static string ln = "\n";  //Esta línea habilita que el último comando sea un salto de línea
        // ReSharper disable once InconsistentNaming
        public static string ln = "$"; //El caracter final será $ debido a limitaciones de simulación en PROTEUS
        public static int MaxDias = Settings.Default.TiempoEntreFechas; //31 int
        public static string Fullname;
        public ComunicacionArduino()
        {
            InitializeComponent();  //Se inicia el programa
            NumeraMuestras();       //Se editan las etiquetas de las muestras
            OcultaPaneles();        //Sólo se muestran los paneles necesarios

        }

        private void ComunicacionArduino_Load(object sender, EventArgs e)//Inicia programa
        {
            
            //Este còdigo se ejecuta en cuanto se inicia el programa
            timer1.Start();//Se inicia el reloj en el programa
            dateTimePicker1.MinDate = DateTime.Today;//Se elige la fecha mínima desde la cuál se puede elegir
            lblTiempoMuestras.Text = Settings.Default.TiempoEntreFechas.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)//Despuès de que inicia el reloj se muestra la hora y la fecha en el program
        {
            fecha.Text = DateTime.Now.ToShortDateString();
            reloj.Text = DateTime.Now.ToLongTimeString();
        }
        private void MostarRenglones(int x)
        {
            //Se puede buscar una mejor forma de hacer esto posteriormente
            if (x <= 21)
            {
                switch (x)
                {
                    case 1:
                        panel1.Visible = true;
                        panel2.Visible = false;
                        panel3.Visible = false;
                        panel4.Visible = false;
                        panel5.Visible = false;
                        panel6.Visible = false;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 2:
                        panel2.Visible = true;
                        panel3.Visible = false;
                        panel4.Visible = false;
                        panel5.Visible = false;
                        panel6.Visible = false;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 3:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = false;
                        panel5.Visible = false;
                        panel6.Visible = false;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 4:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = false;
                        panel6.Visible = false;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 5:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = false;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 6:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = false;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 7:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = false;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 8:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = false;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 9:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 10:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = false;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 11:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = false;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 12:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = false;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 13:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = false;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 14:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = false;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 15:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = false;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 16:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = false;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 17:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = true;
                        panel18.Visible = false;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 18:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = true;
                        panel18.Visible = true;
                        panel19.Visible = false;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 19:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = true;
                        panel18.Visible = true;
                        panel19.Visible = true;
                        panel20.Visible = false;
                        panel21.Visible = false;
                        break;

                    case 20:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = true;
                        panel18.Visible = true;
                        panel19.Visible = true;
                        panel20.Visible = true;
                        panel21.Visible = false;
                        break;

                    case 21:
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;
                        panel16.Visible = true;
                        panel17.Visible = true;
                        panel18.Visible = true;
                        panel19.Visible = true;
                        panel20.Visible = true;
                        panel21.Visible = true;
                        break;

                    default:
                        panel1.Visible = true;
                        break;
                }
            }
        }

        //En esta región se crean los mensajes de error en el programa
        #region Mensajes de error

        private static void MensajeErrorCom()
        {
            MessageBox.Show(Resources.ComunicacionArduino_MensajeErrorCom_Elija_antes_un_puerto_COM,
                Resources.ComunicacionArduino_MensajeErrorCom_Error_al_elegir_un_puerto, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
                private static void MensajeErrorMuestras()
                {
                    MessageBox.Show(Resources.ComunicacionArduino_MensajeErrorMuestras_El_número_máximo_de_muestras_es_21,
                        Resources.ComunicacionArduino_MensajeErrorMuestras_No_se_pueden_elegir_mas_muestras,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        */

        private static void MensajeErrorPuertoInvalido(Exception exception)
        {
            MessageBox.Show(exception.Message, Resources.ComunicacionArduino_MensajeErrorPuertoInvalido_Elija_un_puerto_adecuado,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion Mensajes de error

        /*La metodología es la siguiente:
        1)Al presionar el botón de buscar puertos se crea una lista de todos los puertos disponibles
        2)Al escoger de la lista el puerto, se habilita el botón de conectar
        3)Al presionar el botón de ON, se conecta al puerto serie
        4)Cuando no se requiera, se detiene la conexión con el botón OFF
        5)También si se cierra el programa, se detiene la conexión con el puerto serie.
        */
        #region Puerto COM


        public void BuscaPuertos_Click(object sender, EventArgs e)// Lista de todos los puertos disponibles
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.Clear();        // Se muestran los puertos en un combo box
            foreach (string port in ports)  //Se buscan todos los puertos disponibles y se enlistan
            {
                comboBox1.Items.Add(port);
                comboBox1.Enabled = true;
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conectar.Enabled = true;
            //Se habilita el botón de conectar al puerto serie
        }

        private void ON_Click(object sender, EventArgs e)//Configurar puerto
        {
            //Intenta establecer una conexiòn con el puerto seleccionado
            try
            {
                try
                {
                    /*Lo que hace este código es que toma el nombre del puerto de una lista y lo configura*/
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataReceived += serialPort1_DataReceived;
                    serialPort1.Open();
                    Desconectar.Enabled = true;
                    Conectar.Enabled = false;
                    textBox1.Text = @"Elija la primer fecha";
                    label_connect.Text = @"Conectado";
                    label_connect.ForeColor = Color.SeaGreen;
                    groupBox1.BackColor=Color.LightGreen;
                    textBox1.BackColor = Color.White;
                    pictureBox1.Image = Resources.ok_png;
                    btn_fechas.Enabled = true;
                    btn_start.Enabled = true;
                    EEPROM_Read.Enabled = true;
                    btnSyncDate.Enabled = true;
                    btn_fechas.Text = @"Almacenar en la trampa";
                }
                catch (IOException exception)
                {
                    /*MessageBox.Show(@"Error abriendo el puerto", exception.Message, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                     * */
                    MensajeErrorPuertoInvalido(exception);
                    label_connect.ForeColor = Color.Red;
                }
                catch (UnauthorizedAccessException exception)
                {
                    MensajeErrorPuertoInvalido(exception);
                    label_connect.ForeColor = Color.Red;
                }
                catch (Exception exception)
                {
                    MensajeErrorPuertoInvalido(exception);
                    label_connect.ForeColor = Color.Red;
                    return;
                }
                comboBox1.Enabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                MensajeErrorCom();
                //MessageBox.Show("Eliga el puerto serie antes");
            }
        }
        private void OFF_Click(object sender, EventArgs e)//Cerrar puerto
        {
            //Este método se ejecuta cuando se presione el botón de desconectar
            try
            {
                listBox2.Items.Clear();
                if (serialPort1.IsOpen)
                {
                    //Verifica que el puero serie este abierto, y si es asi, lo desconecta
                    //Ademas que habilita de nuevo el botón de conectar
                    serialPort1.Close();
                    Conectar.Enabled = true;
                    Desconectar.Enabled = false;
                    label_connect.Text = @"Desconectado";
                    label_connect.ForeColor = Color.Red;
                    groupBox1.BackColor = Color.FromArgb(255, 192, 192);
                    textBox1.BackColor = Color.FromArgb(255, 192, 192);
                    pictureBox1.Image = Resources.ic_error_red_48dp;
                    EEPROM_Read.Enabled = false;
                    btnSyncDate.Enabled = false;
                    progressBar1.Visible = false;
                }
                else if (!serialPort1.IsOpen)
                {
                    //Solo si no estuviera abierto el puerto se genera este error
                    MensajeErrorCom();
                    //MessageBox.Show("Eliga el puerto serie antes");
                }
            }
            catch (UnauthorizedAccessException)
            {
                //Solo si no estuviera abierto el puerto se genera este error
                MensajeErrorCom();
                //MessageBox.Show("Eliga el puerto serie antes");
            }
            catch (IOException)
            {
                MessageBox.Show(
                    @"Error al comunicarse con el puerto COM, verifique que la trampa no esté desconectada y por favor seleccione de nuevo el puerto COM correspondiente",
                    @"Reinicie el programa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void ComunicacionArduino_FormClosing(object sender, FormClosingEventArgs e)//Al salir, cerrar el puerto COM
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            catch (IOException)
            {
                serialPort1.Close();
            }
        }

        

        #endregion Puerto COM

        //región donde se crea el código para ventanas "Acerca de" y "Administrador de dispositivos"
        #region Ventanas extra

        //Abrir meno acerca de
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new About();
            frm.Show();
        }

        //Abrir admin. Dvos.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        #endregion Ventanas extra

        //Código donde se crean etiquetas numeradas
        #region Numerar y ocultar

        private void NumeraMuestras()
        {
            int i = 1;
            label1.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label2.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label3.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label4.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label5.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label6.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label7.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label8.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label9.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label10.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label11.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label12.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label13.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label14.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label15.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label16.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label17.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label18.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label19.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label20.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
            i++;
            label21.Text = Resources.ComunicacionArduino_NumeraMuestras_Muestra_ + i;
        }

        private void OcultaPaneles()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
            panel15.Visible = false;
            panel16.Visible = false;
            panel17.Visible = false;
            panel18.Visible = false;
            panel19.Visible = false;
            panel20.Visible = false;
            panel21.Visible = false;
        }

        #endregion Numerar y ocultar
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//Se elige el número de páneles a mostrar
        {
            var numRenglones = (int)numericUpDown1.Value;
            MostarRenglones(numRenglones);
        }

        public void btn_fechas_Click(object sender, EventArgs e)//Enviar a Arduino
        {
            progressBar1.Visible = true;
            //MessageBox.Show("Almacenando fechas, espera un momento", "Espera a que se almacenen las fechas",
                //MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Cada que se presiona el botón se debe borrar el contenido de las listas
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            inputSerial.Clear();
            //Utilizamos una variable como contador
            int j = 0;
            //Elegimos el número máximo de muestras y se les asigna su valor
            var listaFechas = new string[21];
            listaFechas[j] = dateTimePicker1.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker2.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker3.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker4.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker5.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker6.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker7.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker8.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker9.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker10.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker11.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker12.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker13.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker14.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker15.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker16.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker17.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker18.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker19.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker20.Value.ToShortDateString();
            j++;
            listaFechas[j] = dateTimePicker21.Value.ToShortDateString();
            //Se llena la lista sólo con el número de elementos seleccionados por el usuario
            try
            {
                
                bt_print.Enabled = true;
                serialPort1.Write("b"+ln);//Se manda el comando de borrar EEPROM
                serialPort1.Write("x"+ln);//Se manda el comando de reinicar contador
                progressBar1.Maximum = (int)numericUpDown1.Value;
                progressBar1.Value = 0;
                for (int i = 0; i < ((int)numericUpDown1.Value); i++)
                {
                    
                    inputSerial.AppendText((i + 1).ToString() + ") " + "s" + listaFechas[i] + ln);
                    listBox1.Items.Add(i + 1 + ") " + listaFechas[i]);
                    progressBar1.Value += 1;
                    if (progressBar1.Value==progressBar1.Maximum)
                    {
                        progressBar1.Enabled = false;
                    }
                    serialPort1.Write("s" + listaFechas[i] +ln);
                    Thread.Sleep(500);//Tiempo para que la fecha se mande sin problemas

                    /*Se escribe en el puerto serie cada una de las fechas con el
                    formato sdd/mm/aaaa\n ejemplo s09/06/2015$ es el 9 de Junio de 2015
                     */
                }
            }
            catch (InvalidOperationException)
            {
                bt_print.Enabled = false;
                MensajeErrorCom();
            }
            catch (IndexOutOfRangeException exception)
            {
                MessageBox.Show(exception.Message + Resources.txt_revise_fechas, Resources.txt_title_error_fechas, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //CheckForIllegalCrossThreadCalls = false;
                string line = serialPort1.ReadLine();
                BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
            catch (IOException)
            {
                
                serialPort1.Close();
            }
            catch(InvalidOperationException)
            {
                serialPort1.Close();
            }
            
        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string line)
        {
            //What to do with the received line here
            var received = line;
            listBox2.Items.Add(received);
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            //Mètodo para guardar las fechas en un archivo de texto
            if (listBox1.Items.Count == 0)
            {
                //Si no hay ninguna fecha en la lista, no se guardan
                MessageBox.Show(@"Aún no se han cargado las fechas en la trampa, debe seleccionar las fechas antes de guardar el archivo", @"Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var saveFileDialog1 = new SaveFileDialog
                {
                    Filter = @"Archivo de texto|*.txt",
                    DefaultExt = "txt",
                    Title = @"Guardar archivo como",
                    OverwritePrompt = true,
                    AddExtension = true,
                    AutoUpgradeEnabled = true,
                    CheckFileExists = false,
                    CheckPathExists = true
                };
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo f=new FileInfo(saveFileDialog1.FileName);
                        Fullname = f.FullName;
                        var fWriter = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                        fWriter.WriteLine("Fechas de control de la trampa de sedimentos");
                        fWriter.WriteLine("Trampa de Sedimentos S/MT 234");
                        fWriter.WriteLine("Instituto de Ciencias del Mar y Limnologia, UNAM\n");
                        fWriter.WriteLine("Fecha de creacion del archivo: ");
                        fWriter.WriteLine(DateTime.Now);
                        fWriter.WriteLine("Lista de fechas programadas en la trampa de sedimentos");
                        foreach (object lista in listBox1.Items)
                        {
                            fWriter.WriteLine(lista.ToString());
                        }
                        fWriter.Flush();
                        fWriter.Close();
                        MessageBox.Show(Resources.String_ruta_archivo + Fullname, @"Fichero guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel22.Visible = true;
                        linkLabel2.Text = Fullname;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            @"Error al guardar fichero de texto: " + Environment.NewLine + Environment.NewLine +
                            ex.GetType() + Environment.NewLine + ex.Message, Resources.ComunicacionArduino_EEPROM_Read_Click_Error, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region Eleccion_Horas_y_fechas

        public void Fechas()
        {

            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MaxDate = dateTimePicker1.Value.AddDays(MaxDias);
            dateTimePicker3.MaxDate = dateTimePicker2.Value.AddDays(MaxDias);
            dateTimePicker4.MaxDate = dateTimePicker3.Value.AddDays(MaxDias);
            dateTimePicker5.MaxDate = dateTimePicker4.Value.AddDays(MaxDias);
            dateTimePicker6.MaxDate = dateTimePicker5.Value.AddDays(MaxDias);
            dateTimePicker7.MaxDate = dateTimePicker6.Value.AddDays(MaxDias);
            dateTimePicker8.MaxDate = dateTimePicker7.Value.AddDays(MaxDias);
            dateTimePicker9.MaxDate = dateTimePicker8.Value.AddDays(MaxDias);
            dateTimePicker10.MaxDate = dateTimePicker9.Value.AddDays(MaxDias);
            dateTimePicker11.MaxDate = dateTimePicker10.Value.AddDays(MaxDias);
            dateTimePicker12.MaxDate = dateTimePicker11.Value.AddDays(MaxDias);
            dateTimePicker13.MaxDate = dateTimePicker12.Value.AddDays(MaxDias);
            dateTimePicker14.MaxDate = dateTimePicker13.Value.AddDays(MaxDias);
            dateTimePicker15.MaxDate = dateTimePicker14.Value.AddDays(MaxDias);
            dateTimePicker16.MaxDate = dateTimePicker15.Value.AddDays(MaxDias);
            dateTimePicker17.MaxDate = dateTimePicker16.Value.AddDays(MaxDias);
            dateTimePicker18.MaxDate = dateTimePicker17.Value.AddDays(MaxDias);
            dateTimePicker19.MaxDate = dateTimePicker18.Value.AddDays(MaxDias);
            dateTimePicker20.MaxDate = dateTimePicker19.Value.AddDays(MaxDias);
            dateTimePicker21.MaxDate = dateTimePicker20.Value.AddDays(MaxDias);
            
            
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddHours(1);
            dateTimePicker3.MinDate = dateTimePicker2.Value.AddHours(1);
            dateTimePicker4.MinDate = dateTimePicker3.Value.AddHours(1);
            dateTimePicker5.MinDate = dateTimePicker4.Value.AddHours(1);
            dateTimePicker6.MinDate = dateTimePicker5.Value.AddHours(1);
            dateTimePicker7.MinDate = dateTimePicker6.Value.AddHours(1);
            dateTimePicker8.MinDate = dateTimePicker7.Value.AddHours(1);
            dateTimePicker9.MinDate = dateTimePicker8.Value.AddHours(1);
            dateTimePicker10.MinDate = dateTimePicker9.Value.AddHours(1);
            dateTimePicker11.MinDate = dateTimePicker10.Value.AddHours(1);
            dateTimePicker12.MinDate = dateTimePicker11.Value.AddHours(1);
            dateTimePicker13.MinDate = dateTimePicker12.Value.AddHours(1);
            dateTimePicker14.MinDate = dateTimePicker13.Value.AddHours(1);
            dateTimePicker15.MinDate = dateTimePicker14.Value.AddHours(1);
            dateTimePicker16.MinDate = dateTimePicker15.Value.AddHours(1);
            dateTimePicker17.MinDate = dateTimePicker16.Value.AddHours(1);
            dateTimePicker18.MinDate = dateTimePicker17.Value.AddHours(1);
            dateTimePicker19.MinDate = dateTimePicker18.Value.AddHours(1);
            dateTimePicker20.MinDate = dateTimePicker19.Value.AddHours(1);
            dateTimePicker21.MinDate = dateTimePicker20.Value.AddHours(1);
            
            DateTime fecha1 = dateTimePicker1.Value;

            textBox1.Text = fecha1.ToLongDateString();
            checkBox1.Enabled = true;

            if (checkBox1.Checked)
            {
                DateTime fecha2 = dateTimePicker2.Value;
                textBox2.Text = fecha2.ToLongDateString();
                checkBox2.Enabled = true;
            }

            if (checkBox2.Checked)
            {
                DateTime fecha3 = dateTimePicker3.Value;
                textBox3.Text = fecha3.ToLongDateString();
                checkBox3.Enabled = true;
            }
            if (checkBox3.Checked)
            {
                DateTime fecha4 = dateTimePicker4.Value;
                textBox4.Text = fecha4.ToLongDateString();
                checkBox4.Enabled = true;
            }

            if (checkBox4.Checked)
            {
                DateTime fecha5 = dateTimePicker5.Value;
                textBox5.Text = fecha5.ToLongDateString();
                checkBox5.Enabled = true;
            }

            if (checkBox5.Checked)
            {
                DateTime fecha6 = dateTimePicker6.Value;
                textBox6.Text = fecha6.ToLongDateString();
                checkBox6.Enabled = true;
            }

            if (checkBox6.Checked)
            {
                //dateTimePicker7.Value = dateTimePicker6.Value.AddDays(1);
                DateTime fecha7 = dateTimePicker7.Value;
                textBox7.Text = fecha7.ToLongDateString();
                checkBox7.Enabled = true;
            }

            if (checkBox7.Checked)
            {
                //dateTimePicker8.Value = dateTimePicker7.Value.AddDays(1);
                DateTime fecha8 = dateTimePicker8.Value;
                textBox8.Text = fecha8.ToLongDateString();
                checkBox8.Enabled = true;
            }

            if (checkBox8.Checked)
            {
                //dateTimePicker9.Value = dateTimePicker8.Value.AddDays(1);
                DateTime fecha9 = dateTimePicker9.Value;
                textBox9.Text = fecha9.ToLongDateString();
                checkBox9.Enabled = true;
            }

            if (checkBox9.Checked)
            {
                //dateTimePicker10.Value = dateTimePicker9.Value.AddDays(1);
                DateTime fecha10 = dateTimePicker10.Value;
                textBox10.Text = fecha10.ToLongDateString();
                checkBox10.Enabled = true;
            }

            if (checkBox10.Checked)
            {
                //dateTimePicker11.Value = dateTimePicker10.Value.AddDays(1);
                DateTime fecha11 = dateTimePicker11.Value;
                textBox11.Text = fecha11.ToLongDateString();
                checkBox11.Enabled = true;
            }

            if (checkBox11.Checked)
            {
                //dateTimePicker12.Value = dateTimePicker11.Value.AddDays(1);
                DateTime fecha12 = dateTimePicker12.Value;
                textBox12.Text = fecha12.ToLongDateString();
                checkBox12.Enabled = true;
            }

            if (checkBox12.Checked)
            {
                //dateTimePicker13.Value = dateTimePicker12.Value.AddDays(1);
                DateTime fecha13 = dateTimePicker13.Value;
                textBox13.Text = fecha13.ToLongDateString();
                checkBox13.Enabled = true;
            }

            if (checkBox13.Checked)
            {
                // dateTimePicker14.Value = dateTimePicker13.Value.AddDays(1);
                DateTime fecha14 = dateTimePicker14.Value;
                textBox14.Text = fecha14.ToLongDateString();
                checkBox14.Enabled = true;
            }

            if (checkBox14.Checked)
            {
                //dateTimePicker15.Value = dateTimePicker14.Value.AddDays(1);
                DateTime fecha15 = dateTimePicker15.Value;
                textBox15.Text = fecha15.ToLongDateString();
                checkBox15.Enabled = true;
            }

            if (checkBox15.Checked)
            {
                //dateTimePicker16.Value = dateTimePicker15.Value.AddDays(1);
                DateTime fecha16 = dateTimePicker16.Value;
                textBox16.Text = fecha16.ToLongDateString();
                checkBox16.Enabled = true;
            }

            if (checkBox16.Checked)
            {
                //dateTimePicker17.Value = dateTimePicker16.Value.AddDays(1);
                DateTime fecha17 = dateTimePicker17.Value;
                textBox17.Text = fecha17.ToLongDateString();
                checkBox17.Enabled = true;
            }

            if (checkBox17.Checked)
            {
                //dateTimePicker18.Value = dateTimePicker17.Value.AddDays(1);
                DateTime fecha18 = dateTimePicker18.Value;
                textBox18.Text = fecha18.ToLongDateString();
                checkBox18.Enabled = true;
            }

            if (checkBox18.Checked)
            {
                //dateTimePicker19.Value = dateTimePicker18.Value.AddDays(1);
                DateTime fecha19 = dateTimePicker19.Value;
                textBox19.Text = fecha19.ToLongDateString();
                checkBox19.Enabled = true;
            }

            if (checkBox19.Checked)
            {
                //dateTimePicker20.Value = dateTimePicker19.Value.AddDays(1);
                DateTime fecha20 = dateTimePicker20.Value;
                textBox20.Text = fecha20.ToLongDateString();
                checkBox20.Enabled = true;
            }

            if (checkBox20.Checked)
            {
                //dateTimePicker21.Value = dateTimePicker20.Value.AddDays(1);
                DateTime fecha21 = dateTimePicker21.Value;
                textBox21.Text = fecha21.ToLongDateString();
                checkBox21.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Fechas();
        }

        #endregion Eleccion_Horas_y_fechas

        #region Verificar Fechas

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (checkBox1.Checked)
                    {
                        textBox1.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        dateTimePicker2.Enabled = true;
                    }
                    else if (!checkBox1.Checked)
                    {
                        textBox1.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        dateTimePicker2.Enabled = false;
                    }
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = false;
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = true;
            }
            else if (!checkBox2.Checked)
            {
                textBox2.Enabled = true;
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = true;
            }
            else if (!checkBox3.Checked)
            {
                textBox3.Enabled = true;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker5.Enabled = true;
            }
            else if (!checkBox4.Checked)
            {
                textBox4.Enabled = true;
                dateTimePicker4.Enabled = true;
                dateTimePicker5.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox5.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = true;
            }
            else if (!checkBox5.Checked)
            {
                textBox5.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox6.Enabled = false;
                dateTimePicker6.Enabled = false;
                dateTimePicker7.Enabled = true;
            }
            else if (!checkBox6.Checked)
            {
                textBox6.Enabled = true;
                dateTimePicker6.Enabled = true;
                dateTimePicker7.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox7.Enabled = false;
                dateTimePicker7.Enabled = false;
                dateTimePicker8.Enabled = true;
            }
            else if (!checkBox7.Checked)
            {
                textBox7.Enabled = true;
                dateTimePicker7.Enabled = true;
                dateTimePicker8.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                textBox8.Enabled = false;
                dateTimePicker8.Enabled = false;
                dateTimePicker9.Enabled = true;
            }
            else if (!checkBox8.Checked)
            {
                textBox8.Enabled = true;
                dateTimePicker8.Enabled = true;
                dateTimePicker9.Enabled = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                textBox9.Enabled = false;
                dateTimePicker9.Enabled = false;
                dateTimePicker10.Enabled = true;
            }
            else if (!checkBox9.Checked)
            {
                textBox9.Enabled = true;
                dateTimePicker9.Enabled = true;
                dateTimePicker10.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                textBox10.Enabled = false;
                dateTimePicker10.Enabled = false;
                dateTimePicker11.Enabled = true;
            }
            else if (!checkBox10.Checked)
            {
                textBox10.Enabled = true;
                dateTimePicker10.Enabled = true;
                dateTimePicker11.Enabled = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                textBox11.Enabled = false;
                dateTimePicker11.Enabled = false;
                dateTimePicker12.Enabled = true;
            }
            else if (!checkBox11.Checked)
            {
                textBox11.Enabled = true;
                dateTimePicker11.Enabled = true;
                dateTimePicker12.Enabled = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                textBox12.Enabled = false;
                dateTimePicker12.Enabled = false;
                dateTimePicker13.Enabled = true;
            }
            else if (!checkBox12.Checked)
            {
                textBox12.Enabled = true;
                dateTimePicker12.Enabled = true;
                dateTimePicker13.Enabled = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                textBox13.Enabled = false;
                dateTimePicker13.Enabled = false;
                dateTimePicker14.Enabled = true;
            }
            else if (!checkBox13.Checked)
            {
                textBox13.Enabled = true;
                dateTimePicker13.Enabled = true;
                dateTimePicker14.Enabled = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                textBox14.Enabled = false;
                dateTimePicker14.Enabled = false;
                dateTimePicker15.Enabled = true;
            }
            else if (!checkBox14.Checked)
            {
                textBox14.Enabled = true;
                dateTimePicker14.Enabled = true;
                dateTimePicker15.Enabled = false;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                textBox15.Enabled = false;
                dateTimePicker15.Enabled = false;
                dateTimePicker16.Enabled = true;
            }
            else if (!checkBox15.Checked)
            {
                textBox15.Enabled = true;
                dateTimePicker15.Enabled = true;
                dateTimePicker16.Enabled = false;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                textBox16.Enabled = false;
                dateTimePicker16.Enabled = false;
                dateTimePicker17.Enabled = true;
            }
            else if (!checkBox16.Checked)
            {
                textBox16.Enabled = true;
                dateTimePicker16.Enabled = true;
                dateTimePicker17.Enabled = false;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                textBox17.Enabled = false;
                dateTimePicker17.Enabled = false;
                dateTimePicker18.Enabled = true;
            }
            else if (!checkBox17.Checked)
            {
                textBox17.Enabled = true;
                dateTimePicker17.Enabled = true;
                dateTimePicker18.Enabled = false;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                textBox18.Enabled = false;
                dateTimePicker18.Enabled = false;
                dateTimePicker19.Enabled = true;
            }
            else if (!checkBox18.Checked)
            {
                textBox18.Enabled = true;
                dateTimePicker18.Enabled = true;
                dateTimePicker19.Enabled = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                textBox19.Enabled = false;
                dateTimePicker19.Enabled = false;
                dateTimePicker20.Enabled = true;
            }
            else if (!checkBox19.Checked)
            {
                textBox19.Enabled = true;
                dateTimePicker19.Enabled = true;
                dateTimePicker20.Enabled = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                textBox20.Enabled = false;
                dateTimePicker20.Enabled = false;
                dateTimePicker21.Enabled = true;
            }
            else if (!checkBox20.Checked)
            {
                textBox20.Enabled = true;
                dateTimePicker20.Enabled = true;
                dateTimePicker21.Enabled = true;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                textBox21.Enabled = false;
                dateTimePicker21.Enabled = false;
            }
            else if (!checkBox21.Checked)
            {
                textBox21.Enabled = true;
                dateTimePicker21.Enabled = true;
            }
        }

        #endregion Verificar Fechas

        /*private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort1.ReadLine();
                //Thread.Sleep(10);
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
            catch (IOException)
            {
                serialPort1.Close();
            }
        }*/

        private void EEPROM_Read_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            /*
            try
            {
                MessageBox.Show("")
                //Process.Start(@"C:\Users\Daniel\Dropbox\Tesis\Proyecto\AlarmaArduino\AlarmaArduino\AlarmaArduino\bin\Debug\logfile.txt");
                //Process.Start(@"..\logfile.txt");
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "No se encuentra el archivo de texto");

            }
            */
        
            try
            {
                serialPort1.Write("pt" + ln);   //Imprimir tiempo
                serialPort1.Write("pr"+ln);     //Imprimir fechas
                //string message = serialPort1.ReadLine();
                LineReceived("");
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message, Resources.ComunicacionArduino_EEPROM_Read_Click_Error);
            }
        }




        private void cb_pos_ok_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_pos_ok.Checked)
            {
                PosAct.Visible = true;
                PosAct.Enabled = true;
                label24.Visible = true;
            }
            if (cb_pos_ok.Checked)
            {
                PosAct.Visible = false;
                PosAct.Enabled = false;
                label24.Visible = false;
            }


        }

        private void PosAct_ValueChanged(object sender, EventArgs e)
        {
            var posActual = PosAct.Value;
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            tb_pos_act.Text = posActual.ToString();
        }

        private void btn_start_clic(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            string posActString;
            string posDesString;
            int posActVal = Convert.ToInt32(tb_pos_act.Text);   //Definimos una variable de tipo entero para la posición actual
            int posDesVal = Convert.ToInt32(PosDes.Value);      //De igual forma definimos una variable de tipo entero para la pos deseada
            //Debemos verificar la cadena si la posición es menor a dos dígitos.
            if (posActVal < 10)
            {
                posActString = "0" + Convert.ToString(posActVal);
            }
            else
            {
                posActString = Convert.ToString(posActVal);
            }

            if (posDesVal < 10)
            {
                posDesString = "0" + Convert.ToString(posDesVal);
            }
            else
            {
                posDesString = Convert.ToString(posDesVal);
            }


            /*Al presionar el botón se enviará al puerto serie el siguiente comando:
             * monpaXXpdYYLN
             * Donde:
             * mon: Encender motor
             * pa: Posición actual
             * XX: Posición actual, en dos dígitos (Verificar para posiciones menores a 10)
             * pd: Posición deseada
             * YY: Posición actual, en dos dígitos (Verificar para posiciones menores a 10)
             * 
             * 
             */
            try
            {
                /* Para verificar las variables
                MessageBox.Show("La posición actual es " + posActVal + " y la posición deseada es " + posDesVal +
                                " y para verificar la conversión, actual por deseada es " + posActVal*posDesVal);
                MessageBox.Show("Pos act es " + posActString + " y pos des es " + posDesString);
                */
                serialPort1.Write("monpa" + posActString + "pd" + posDesString + ln);
            }
            catch (InvalidOperationException ex)
            {
                btn_stop.Enabled = false;
                MessageBox.Show(ex.Message);
            }
            catch (IOException serial)
            {
                MessageBox.Show(serial.Message);
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            listBox2.Items.Clear();
            //btn_stop.Enabled = false;
            try
            {
                serialPort1.Write("mof" + ln);
                LineReceived("");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException exception)
            {
                //MessageBox.Show(exception.Message);
                MensajeErrorPuertoInvalido(exception);
                label_connect.ForeColor = Color.Red;
            }
            
        }

        private void btnSyncDate_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                var today = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //MessageBox.Show(today);
                serialPort1.Write("t" + today + ln);
                Thread.Sleep(100);//Tiempo para que la fecha se mande sin problemas

                /*Se escribe en el puerto serie cada una de las fechas con el
                formato sdd/mm/aaaa\n ejemplo t09/06/2015$ es el 9 de Junio de 2015
                 */
            }
            catch (InvalidOperationException)
            {
                bt_print.Enabled = false;
                MensajeErrorCom();
            }
        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {
            listBox2.Focus();
        }

        private void panel_master_MouseEnter(object sender, EventArgs e)
        {
            panel_master.Focus();
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                var today=dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss");
                
                //MessageBox.Show(today);
                serialPort1.Write("a" + today + ln);
                Thread.Sleep(100);//Tiempo para que la fecha se mande sin problemas

                /*Se escribe en el puerto serie cada una de las fechas con el
                formato sdd/mm/aaaa\n ejemplo t09/06/2015$ es el 9 de Junio de 2015
                 */
            }
            catch (InvalidOperationException)
            {
                MensajeErrorCom();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Fullname);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.TiempoEntreFechas = (int) numericUpDown2.Value;
            Settings.Default.Save();
            MessageBox.Show(Resources.ComunicacionArduino_button1_Click_Para_evitar_errores__reinicie_el_programa__su_configuración_se_encontrará_almacenada,
                Resources.ComunicacionArduino_button2_Click_Configuración_guardada__debe_de_reiniciar_el_programa, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.TiempoEntreFechas = Settings.Default.DefaultTiempoEntreFechas;
            Settings.Default.Save();
            MessageBox.Show(Resources.ComunicacionArduino_button2_Click_Configuración_original_reestablecida__para_evitar_errores__reinicie_el_programa__su_configuración_se_encontrará_almacenada,
                Resources.ComunicacionArduino_button2_Click_Configuración_guardada__debe_de_reiniciar_el_programa, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}

public class About : Form
{
}

public class TiempoFechas : Form
{
}