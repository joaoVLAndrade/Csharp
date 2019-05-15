using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace interfaceVisualStudio2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void AtualizListaCOMs()
        {
            int i;
            bool quantDiferente;
            i = 0;
            quantDiferente = false;
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }
            if(quantDiferente == false)
            {
                return;
            }
            comboBox1.Items.Clear();
            foreach(string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
