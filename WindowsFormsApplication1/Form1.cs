using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment\";
            string regValue = (string)Registry.LocalMachine.OpenSubKey(regKey).GetValue("PATH", "", RegistryValueOptions.DoNotExpandEnvironmentNames);

            var items = regValue.Split(';');

            foreach(string i in items)
            {
                listView1.Items.Add(i);
            }
            //dataGridView1.DataSource = items; 
        }
    }
}
