using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace new_db
{
    public partial class Connect_pwd : Form
    {
        public Connect_pwd()
        {
            InitializeComponent();
        }
        private readonly Form _parent;
        public Connect_pwd(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            //Form1 frm = new Form1();
            int pwd = 12345;
            int con_pwd = Convert.ToInt32(textBox1.Text);
            if (con_pwd == pwd)
            {
                _parent.Show();

                this.Close();
            }
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
