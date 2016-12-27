using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLySpa
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string username = "", password = "";
        DataTable tblCTHDB;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain (string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {


        }
      
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Application.Exit();
        }

        

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

       

        

      

        


        

    }
}
