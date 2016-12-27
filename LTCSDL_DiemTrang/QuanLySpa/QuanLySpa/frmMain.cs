using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLySpa;
//using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLySpa
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        string username = "", password = "";
    
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
            lbName.Text = " Spa pé đẹp nơi nhan sắc mãi trường tồn";
            Functions.Connect();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        private void rdHT_Click(object sender, EventArgs e)
        {
           
        }

       
        private void btThemNV_Click(object sender, EventArgs e)
        {
           
        }

        

        private void btThemLDV_Click(object sender, EventArgs e)
        {
           
        }

        private void btT_Click(object sender, EventArgs e)
        {
            Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frKH = new frmKhachhang();
            frKH.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            Application.Exit();
        }

       

    }
}
