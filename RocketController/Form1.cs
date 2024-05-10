using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RocketController
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        private string comPort = "";

        private Int32 baudRate = 9600;
        private Int32 prevBaudRate = 0;

        private bool portOpened = false;
        private bool commsCheck = false;
        private bool telemetryCheck = false;
        private bool fuelComputerCheck = false;
        private bool payloadCheck = false;
        private bool confirmedAllSystems = false;
        public Form1()
        {
            InitializeComponent();

            ReadTimer.Interval = 500;
            ReadTimer.Start();

            LoopTimer.Interval = 100;
            LoopTimer.Start();

            
            string[] ports = SerialPort.GetPortNames();

            comPort = ports[ports.Length - 1];

            foreach (var x in ports)
            {
                PortNumberComboBox.Items.Add(x);
             
            }


            StartSerial();
            
        }

        private void StartSerial()
        {
            serialPort = new SerialPort(comPort, baudRate);
            try
            {
                if (serialPort.IsOpen == false)
                {
                    serialPort.Open();
                    portOpened = true;
                }
            }
            catch
            {
                LogTextBox.AppendText("Unable to open COM port, check it's not in use.\r\n");
                portOpened = false;
                return;
            }
            BaudRateComboBox.Text = Convert.ToString(baudRate);
            PortNumberComboBox.Text = Convert.ToString(comPort);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {            
            if (portOpened == true)
            {            
                RawOutputTextBox.Text += serialPort.ReadLine() + "\r\n";
                ProcessCommsData();
                RawOutputTextBox.SelectionStart = RawOutputTextBox.TextLength;
                RawOutputTextBox.ScrollToCaret();
            }

        }

        private void ProcessCommsData()
        {

        }

        private void ManualOverrideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void LoopTimer_Tick(object sender, EventArgs e)
        {

            if ((ManualOverrideCheckBox.Checked == true || confirmedAllSystems == true) && ConfirmCheckBox.Checked == true)
            {
                LaunchButton.Enabled = true;
                LaunchButton.BackColor = Color.Green;
            }
            else
            {
                LaunchButton.Enabled = false;
                LaunchButton.BackColor = Color.Red;
            }

            StatusTextBox.Text = "";
            Int16 counter = 0;

            if (commsCheck == true)
            {
                StatusTextBox.AppendText("Comms status: GO\r\n");
            }
            else
            {
                StatusTextBox.AppendText("Comms status: NO GO\r\n");
                counter++;
            }
            
            if (telemetryCheck == true)
            {
                StatusTextBox.AppendText("Telemetry status: GO\r\n");
            }
            else
            {
                StatusTextBox.AppendText("Telemetry status: NO GO\r\n");
                counter++;
            }
            
            if (fuelComputerCheck == true)
            {
                StatusTextBox.AppendText("Fuel computer status: GO\r\n");
            }
            else
            {
                StatusTextBox.AppendText("Fuel computer status: NO GO\r\n");
                counter++;
            }

            if (payloadCheck == true)
            {
                StatusTextBox.AppendText("Payload status: GO\r\n");
            }
            else
            {
                StatusTextBox.AppendText("Payload status: NO GO\r\n");
                counter++;
            }

            confirmedAllSystems = false;
            
            if (counter == 0)
            {
                confirmedAllSystems = true;
            }
            if (confirmedAllSystems == true)
            {
                StatusTextBox.AppendText("Final system check: GO\r\n");
               
            }
            else
            {
                StatusTextBox.AppendText("counter" + " sytems remain\r\n");
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                LogTextBox.Text += "Sent launch command\r\n";
                serialPort.Write("LAUNCH");
            }
            else
            {
                LogTextBox.Text += "Unable to send launch command\r\n";
            }
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                LogTextBox.Text += "Sent abort command\r\n";
                serialPort.Write("ABORT");
            }
            else
            {
                LogTextBox.Text += "Unable to send abort command\r\n";
            }
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
        }


        private void PortNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comPort = PortNumberComboBox.Text;
            LogTextBox.AppendText("com port set to: " + comPort + "\r\n");
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
            serialPort.Dispose();
            StartSerial();
        }

        private void BaudRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            baudRate = Convert.ToInt32(BaudRateComboBox.Text);
            LogTextBox.AppendText("Baud rate set to: " + baudRate + "\r\n");
            LogTextBox.SelectionStart = LogTextBox.TextLength;
            LogTextBox.ScrollToCaret();
            serialPort.Dispose();
            StartSerial();
        }
    }
}
