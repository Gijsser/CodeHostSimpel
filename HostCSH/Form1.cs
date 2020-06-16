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
using Newtonsoft.Json;

namespace HostCSH
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        JsonSerializer _serializer;
 
        bool isConnected = false;
        String[] ports;
        Timer timer_t = new Timer();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            timer_t.Interval = 100;
            timer_t.Enabled = false;
            timer_t.Tick += eventTimer;

            GetAvailableComPorts();

            string[] baudRate = { "9600", "19200", "38400", "57600", "115200" };
            foreach (string s in baudRate)
            {
                comboBox_Baudrate.Items.Add(s);
            }
            comboBox_Baudrate.SelectedIndex = 0;

            string message;

            Control.CheckForIllegalCrossThreadCalls = false;

            String json = "{\"type\":1,\"sensNr\":1,\"sensAdd\":104}";
            String json2 = "{\"type\":2,\"inType\":0,\"sensNr\":1,\"instNr\":1,\"reqB\":59,\"bNr\":0,\"bVal\":0,\"BRet\":14}";
            String json3 = "{\"type\":3,\"sensAdd\":104,\"reqB\":107,\"bNr\":2,\"bVal\":0}";
            String json4 = "{\"type\":3,\"sensAdd\":104,\"reqB\":107,\"bNr\":6,\"bVal\":0}";

            listBoxJsonFiles.Items.Add(json);
            listBoxJsonFiles.Items.Add(json2);
            listBoxJsonFiles.Items.Add(json3);
            listBoxJsonFiles.Items.Add(json4);

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.

            // Set the read/write timeouts
           
            _serialPort.WriteTimeout = 1000;

            _serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
         
            _serialPort.DtrEnable = true;
            _serialPort.RtsEnable = true;
            _serialPort.ReadTimeout = 1000;

            _serialPort.Close();

        }

        private void eventTimer(object sender, EventArgs e)
        {

            _serialPort.Open();
            string message = _serialPort.ReadExisting();
            textBoxOutput.AppendText(message);
            Console.WriteLine(message);
            _serialPort.Close();

        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //_serialPort.Open();
            string message = _serialPort.ReadExisting();
            textBoxOutput.AppendText(message);
            Console.WriteLine(message);
            //_serialPort.Close();
        }
        void GetAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();

            foreach (string port in ports) // miss niet hier neer zetten
            {
                comboBox_Comport.Items.Add(port);
                if (ports[0] != null)
                {
                    comboBox_Comport.SelectedItem = ports[0];
                }
            }

        }


        private void button_Connect_Click(object sender, EventArgs e)
        {

            _serialPort.PortName = comboBox_Comport.SelectedItem.ToString();
            _serialPort.BaudRate = Int32.Parse( comboBox_Baudrate.SelectedItem.ToString());
            _serialPort.DataBits = 8;

            comboBox_Baudrate.Enabled = false;
            comboBox_Comport.Enabled = false;

            _serialPort.Open();
            //timer_t.Enabled = true;
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            comboBox_Baudrate.Enabled = true;
            comboBox_Comport.Enabled = true;
            _serialPort.Close();
        }

        private void buttonSendJson_Click(object sender, EventArgs e)
        {
            String jsonmessage = textBoxJsonMessage.Text;

            //_serialPort.Open();
            _serialPort.Write(jsonmessage);
            //_serialPort.Close();

        }

        private void buttonWriteJsonFIle_Click(object sender, EventArgs e)
        {
            string message = listBoxJsonFiles.SelectedItem.ToString();
            _serialPort.Write(message);
        }

        private void listBoxJsonFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
