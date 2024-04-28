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
        private string comPort = "COM12";
        private Int32 baudRate = 9600;
        private bool portOpened = false;
        public Form1()
        {
            InitializeComponent();

            ReadTimer.Interval = 500;
            ReadTimer.Start();

            serialPort = new SerialPort(comPort, baudRate);

            try
            {
                serialPort.Open();
                portOpened = true;
            }
            catch
            {
                LogTextBox.Text += "Unable to open COM port, check it's not in use.";
                portOpened = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            if (portOpened == true)
            {
                RawOutputTextBox.Text += serialPort.ReadLine() + "\n";
                ProcessCommsData();
            }
            
        }

        private void ProcessCommsData()
        {

        }
    }
}
