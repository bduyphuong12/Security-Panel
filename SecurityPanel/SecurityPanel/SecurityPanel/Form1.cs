using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityPanel
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        
        private void txt1_Click(object sender, EventArgs e)
        {
            //string txt = txtSecurityCode.Text;
           
            Button bt = (Button)sender;
            txtSecurityPassword.Text += bt.Text;

        }

        private void BtBackspace_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
           
                txtSecurityPassword.Text = txtSecurityPassword.Text.Remove(txtSecurityPassword.Text.Length - 1, 1);
                
        }

        private void btenter_Click(object sender, EventArgs e)
        {
            if(txtSecurityPassword.TextLength != 4 && txtSecurityPassword.TextLength != 1)
            {
                MessageBox.Show("Vui long nhap code co 4 chu so hoac 1");
            }    
            else
            {
                if(txtSecurityPassword.Text=="1200" || txtSecurityPassword.Text == "1201" || txtSecurityPassword.Text == "1202" || txtSecurityPassword.Text == "1203")
                {
                    listboxacesslog.Items.Add(DateTime.Now.ToString() + "     Scientists");
                }
                else
                {
                    listboxacesslog.Items.Add(DateTime.Now.ToString() + "     Restricted Access");
                }
            }
            txtSecurityPassword.Clear();
            string spath = "102190331.txt";
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(spath); 
            foreach(var item in listboxacesslog.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.Close();
        }

        
    }
}
