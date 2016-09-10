using AlarmaArduino.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AlarmaArduino
{
    public partial class ComunicacionArduino : Form
    {
        //Se carga el form
        public ComunicacionArduino()
        {
            InitializeComponent();
            NumeraMuestras();
            OcultaPaneles();
        }

        #region Mensajes de error

        private static void MensajeErrorCom()
        {
            MessageBox.Show(Resources.ComunicacionArduino_MensajeErrorCom_Elija_antes_un_puerto_COM,
                Resources.ComunicacionArduino_MensajeErrorCom_Error_al_elegir_un_puerto, MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private static void MensajeErrorFechaMenor()
        {
            MessageBox.Show(
                @"Elija otra fecha, se tomará una semana después de la muestra anterior",
                Resources.ComunicacionArduino_MensajeErrorFechaMenor_Elija_una_fecha_adecuada, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        #endregion Mensajes de error

        #region Puerto COM

        //Crear lista de puertos
        public void BuscaPuertos_Click(object sender, EventArgs e)
        {
            // Lista de todos los puertos disponibles
            string[] ports = SerialPort.GetPortNames();
            // Se muestran los puertos en un combo box
            comboBox1.Items.Clear();
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

        //Al salir, cerrar el puerto COM
        public void ComunicacionArduino_FormClosing(object sender, FormClosingEventArgs e)
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

        private void OFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    Conectar.Enabled = true;
                    Desconectar.Enabled = false;
                    label_connect.Text = @"Desconectado";
                    label_connect.ForeColor = Color.Red;
                    pictureBox1.Image = Resources.ic_error_red_48dp;
                    EEPROM_Read.Enabled = false;
                }
                else if (!serialPort1.IsOpen)
                {
                    MensajeErrorCom();
                    //MessageBox.Show("Eliga el puerto serie antes");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MensajeErrorCom();
                //MessageBox.Show("Eliga el puerto serie antes");
            }
        }

        private void ON_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    Desconectar.Enabled = true;
                    Conectar.Enabled = false;
                    textBox1.Text = @"Elija la primer fecha";
                    Thread.Sleep(1000);
                    label_connect.Text = @"Conectado";
                    label_connect.ForeColor = Color.SeaGreen;
                    pictureBox1.Image = Resources.ic_ok_48dp;
                    btn_fechas.Enabled = true;
                    btn_start.Enabled = true;
                    EEPROM_Read.Enabled = true;
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

        #endregion Puerto COM

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

        private void ComunicacionArduino_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dateTimePicker1.MinDate=DateTime.Today;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker3.MinDate = dateTimePicker2.Value.AddDays(1);
            dateTimePicker4.MinDate = dateTimePicker3.Value.AddDays(1);
            dateTimePicker5.MinDate = dateTimePicker4.Value.AddDays(1);
            dateTimePicker6.MinDate = dateTimePicker5.Value.AddDays(1);
            dateTimePicker7.MinDate = dateTimePicker6.Value.AddDays(1);
            dateTimePicker8.MinDate = dateTimePicker7.Value.AddDays(1);
            dateTimePicker9.MinDate = dateTimePicker8.Value.AddDays(1);
            dateTimePicker10.MinDate = dateTimePicker9.Value.AddDays(1);
            dateTimePicker11.MinDate = dateTimePicker10.Value.AddDays(1);
            dateTimePicker12.MinDate = dateTimePicker11.Value.AddDays(1);
            dateTimePicker13.MinDate = dateTimePicker12.Value.AddDays(1);
            dateTimePicker14.MinDate = dateTimePicker13.Value.AddDays(1);
            dateTimePicker15.MinDate = dateTimePicker14.Value.AddDays(1);
            dateTimePicker16.MinDate = dateTimePicker15.Value.AddDays(1);
            dateTimePicker17.MinDate = dateTimePicker16.Value.AddDays(1);
            dateTimePicker18.MinDate = dateTimePicker17.Value.AddDays(1);
            dateTimePicker19.MinDate = dateTimePicker18.Value.AddDays(1);
            dateTimePicker20.MinDate = dateTimePicker19.Value.AddDays(1);
            dateTimePicker21.MinDate = dateTimePicker20.Value.AddDays(1);
        }

        //Se elige el número de páneles a mostrar
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var numRenglones = (int)numericUpDown1.Value;
            MostarRenglones(numRenglones);
        }
        private void MostarRenglones(int x)
        {
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = @"Hoy es " + DateTime.Now.ToShortDateString();
            reloj.Text = DateTime.Now.ToLongTimeString();
        }
        public void btn_fechas_Click(object sender, EventArgs e)
        {
            //Cada que se presiona el botón se debe borrar el contenido
            listBox1.Items.Clear();
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
                serialPort1.Write("b\n");//Se manda el comando de borrar EEPROM
                serialPort1.Write("x\n");//Se manda el comando de reinicar contador
                for (int i = 0; i < ((int)numericUpDown1.Value); i++)
                {
                
                    listBox1.Items.Add(listaFechas[i]);
                    serialPort1.Write("s" + listaFechas[i] + "\n");
                    /*Se escribe en el puerto serie cada una de las fechas con el
                    formato sdd/mm/aaaa\n ejemplo s09/06/2015\n es el 9 de Junio de 2015
                     */

                }
                
            }
            catch (InvalidOperationException)
            {
                MensajeErrorCom();
            }
        }

        public delegate void ImprimeTexto();

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
    //CheckForIllegalCrossThreadCalls = false; 
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();

            inputSerial.Text = "Hola";
            
            //string serialp = serialPort1.ReadExisting();
            //MessageBox.Show(serialp, @"Las fechas elegidas son", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show(@"Debe escoger las fechas a almacenar", @"Error en la selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        var fWriter = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);
                        fWriter.WriteLine("Fechas de control de la trampa de sedimentos\n");
                        fWriter.WriteLine("Instituto de ciencias del mar, UNAM\n");
                        fWriter.WriteLine(DateTime.Now);
                        foreach (object lista in listBox1.Items)
                        {
                            fWriter.WriteLine(lista.ToString());
                        }
                        fWriter.Flush();
                        fWriter.Close();
                        MessageBox.Show(@"Fichero de texto guardado correctamente.", @"Fichero guardado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            DateTime fecha3 = dateTimePicker3.Value;
            DateTime fecha4 = dateTimePicker4.Value;
            DateTime fecha5 = dateTimePicker5.Value;
            DateTime fecha6 = dateTimePicker6.Value;
            DateTime fecha7 = dateTimePicker7.Value;
            DateTime fecha8 = dateTimePicker8.Value;
            DateTime fecha9 = dateTimePicker9.Value;
            DateTime fecha10 = dateTimePicker10.Value;
            DateTime fecha11 = dateTimePicker11.Value;
            DateTime fecha12 = dateTimePicker12.Value;
            DateTime fecha13 = dateTimePicker13.Value;
            DateTime fecha14 = dateTimePicker14.Value;
            DateTime fecha15 = dateTimePicker15.Value;
            DateTime fecha16 = dateTimePicker16.Value;
            DateTime fecha17 = dateTimePicker17.Value;
            DateTime fecha18 = dateTimePicker18.Value;
            DateTime fecha19 = dateTimePicker19.Value;
            DateTime fecha20 = dateTimePicker20.Value;
            DateTime fecha21 = dateTimePicker21.Value;

            //textBox1.Text = fecha1.ToLongDateString() + @" " + fecha1.ToLongTimeString();
            checkBox1.Enabled = true;

            if (checkBox1.Checked)
            {
                if (fecha2 <= fecha1)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
                    fecha2 = fecha1.AddDays(7);
                }
                if (fecha2 > fecha3)
                {
                    MessageBox.Show("La fecha elegida es mayor que la fecha siguiente, verifique su selección");
                   
                }
                textBox2.Text = fecha2.ToLongDateString();
                checkBox2.Enabled = true;
            }

            if (checkBox2.Checked)
            {
                if (fecha3 <= fecha2)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker3.Value = dateTimePicker2.Value.AddDays(7);
                    fecha3 = fecha2.AddDays(7);
                }
                textBox3.Text = fecha3.ToLongDateString();
                checkBox3.Enabled = true;
            }
            if (checkBox3.Checked)
            {
                if (fecha4 <= fecha3)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker4.Value = dateTimePicker3.Value.AddDays(7);
                    fecha4 = fecha3.AddDays(7);
                }
                textBox4.Text = fecha4.ToLongDateString();
                checkBox4.Enabled = true;
            }

            if (checkBox4.Checked)
            {
                if (fecha5 <= fecha4)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker5.Value = dateTimePicker4.Value.AddDays(7);
                    fecha5 = fecha4.AddDays(7);
                }
                textBox5.Text = fecha5.ToLongDateString();
                checkBox5.Enabled = true;
            }

            if (checkBox5.Checked)
            {
                if (fecha6 <= fecha5)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker6.Value = dateTimePicker5.Value.AddDays(7);
                    fecha6 = fecha5.AddDays(7);
                }
                textBox6.Text = fecha6.ToLongDateString();
                checkBox6.Enabled = true;
            }

            if (checkBox6.Checked)
            {
                if (fecha7 <= fecha6 )
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker7.Value = dateTimePicker6.Value.AddDays(7);
                    fecha7 = fecha6.AddDays(7);
                }
                textBox7.Text = fecha7.ToLongDateString();
                checkBox7.Enabled = true;
            }

            if (checkBox7.Checked)
            {
                if (fecha8 < fecha7 )
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker8.Value = dateTimePicker7.Value.AddDays(7);
                    fecha8 = fecha7.AddDays(7);
                }
                textBox8.Text = fecha8.ToLongDateString();
                checkBox8.Enabled = true;
            }

            if (checkBox8.Checked)
            {
                if (fecha9 < fecha8)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker9.Value = dateTimePicker8.Value.AddDays(7);
                    fecha9 = fecha8.AddDays(7);
                }
                textBox9.Text = fecha9.ToLongDateString();
                checkBox9.Enabled = true;
            }

            if (checkBox9.Checked)
            {
                if (fecha10 < fecha9)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker10.Value = dateTimePicker9.Value.AddDays(7);
                    fecha10 = fecha9.AddDays(7);
                }
                textBox10.Text = fecha10.ToLongDateString();
                checkBox10.Enabled = true;
            }

            if (checkBox10.Checked)
            {
                if (fecha11 < fecha10)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker11.Value = dateTimePicker10.Value.AddDays(7);
                    fecha11 = fecha10.AddDays(7);
                }
                textBox11.Text = fecha11.ToLongDateString();
                checkBox11.Enabled = true;
            }

            if (checkBox11.Checked)
            {
                if (fecha12 < fecha11)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker12.Value = dateTimePicker11.Value.AddDays(7);
                    fecha12 = fecha11.AddDays(7);
                }
                textBox12.Text = fecha12.ToLongDateString();
                checkBox12.Enabled = true;
            }

            if (checkBox12.Checked)
            {
                if (fecha13 < fecha12)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker13.Value = dateTimePicker12.Value.AddDays(7);
                    fecha13 = fecha12.AddDays(7);
                }
                textBox13.Text = fecha13.ToLongDateString();
                checkBox13.Enabled = true;
            }

            if (checkBox13.Checked)
            {
                if (fecha14 < fecha13)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker14.Value = dateTimePicker13.Value.AddDays(7);
                    fecha14 = fecha13.AddDays(7);
                }
                textBox14.Text = fecha14.ToLongDateString();
                checkBox14.Enabled = true;
            }

            if (checkBox14.Checked)
            {
                if (fecha15 < fecha14)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker15.Value = dateTimePicker14.Value.AddDays(7);
                    fecha15 = fecha14.AddDays(7);
                }
                textBox15.Text = fecha15.ToLongDateString();
                checkBox15.Enabled = true;
            }

            if (checkBox15.Checked)
            {
                if (fecha16 < fecha15)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker16.Value = dateTimePicker15.Value.AddDays(7);
                    fecha16 = fecha15.AddDays(7);
                }
                textBox16.Text = fecha16.ToLongDateString();
                checkBox16.Enabled = true;
            }

            if (checkBox16.Checked)
            {
                if (fecha17 < fecha16)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker17.Value = dateTimePicker16.Value.AddDays(7);
                    fecha17 = fecha16.AddDays(7);
                }
                textBox17.Text = fecha17.ToLongDateString();
                checkBox17.Enabled = true;
            }

            if (checkBox17.Checked)
            {
                if (fecha18 < fecha17)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker18.Value = dateTimePicker17.Value.AddDays(7);
                    fecha18 = fecha17.AddDays(7);
                }
                textBox18.Text = fecha18.ToLongDateString();
                checkBox18.Enabled = true;
            }

            if (checkBox18.Checked)
            {
                if (fecha19 < fecha18)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker19.Value = dateTimePicker18.Value.AddDays(7);
                    fecha19 = fecha18.AddDays(7);
                }
                textBox19.Text = fecha19.ToLongDateString();
                checkBox19.Enabled = true;
            }

            if (checkBox19.Checked)
            {
                if (fecha20 < fecha19)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker20.Value = dateTimePicker19.Value.AddDays(7);
                    fecha20 = fecha19.AddDays(7);
                }
                textBox20.Text = fecha20.ToLongDateString();
                checkBox20.Enabled = true;
            }

            if (checkBox20.Checked)
            {
                if (fecha21 < fecha20)
                {
                    MensajeErrorFechaMenor();
                    dateTimePicker21.Value = dateTimePicker20.Value.AddDays(7);
                    fecha21 = fecha20.AddDays(7);
                }
                textBox21.Text = fecha21.ToLongDateString();
                checkBox21.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*
            if (!serialPort1.IsOpen)
                {
                    MensajeErrorCom();
                    //MessageBox.Show("El puerto no ha sido elegido");
                    checkBox1.Checked = false;
                }
             * *
            else
             * */
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

        private void EEPROM_Read_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("pr\n");
                Thread.Sleep(50);
                string serialp = serialPort1.ReadExisting();
                MessageBox.Show(serialp);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message, Resources.ComunicacionArduino_EEPROM_Read_Click_Error);
            }
            
        }

        private void btn_der_Click(object sender, EventArgs e)
        {
            try
            {
                btn_stop.Enabled = true;
                serialPort1.Write("l\n");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_izq_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("mof\n");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}

public class About : Form
{
}