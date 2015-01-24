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

namespace PathViewer
{
    public partial class FormPathViewer : Form
    {
        public FormPathViewer()
        {
            InitializeComponent();
            LoadPaths();
        }

        private void LoadPaths()
        {
            // Get the PATH from the registery
            string regKey = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment\";
            string regValue = (string)Registry.LocalMachine.OpenSubKey(regKey).GetValue("PATH", "", RegistryValueOptions.DoNotExpandEnvironmentNames);

            // Show length in title
            this.Text = "Path Viewer (" + regValue.Length + ")"; 

            // Split the string
            var paths = regValue.Split(';'); 

            // Display them 
            foreach(var i in paths)
            {
                lvPaths.Items.Add(i); 
            }

            // Alternate the background colors
            foreach (ListViewItem item in lvPaths.Items)
            {
                if (item.Index % 2 == 0)
                    item.BackColor = Color.White;
                else
                    item.BackColor = Color.FromArgb(200, 200, 200);

            }
        }

        // Have the column width match the listview width
        private void lvPaths_Resize(object sender, EventArgs e)
        {
            lvPaths.Columns[0].Width = lvPaths.Width;
        }
    }
}
