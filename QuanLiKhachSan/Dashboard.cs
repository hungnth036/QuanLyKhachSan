﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnManagerKH.Left + 60;
            uc_CustomerControl1.Visible = true;
            uc_CustomerControl1.BringToFront();
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left + 215;
            uC_CustomerReg1.Visible = true;
            uC_CustomerReg1.BringToFront();
        }

        private void btnCustomerRes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddRoom.Left + 50;
            
            uC_AddRoom1.Visible = true;
           
            uC_AddRoom1.BringToFront();
           
            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerReg1.Visible = false;
            uc_CheckOut1.Visible = false;
            uc_CustomerControl1.Visible = false;
            uc_Emloyee2.Visible = false;
            btnAddRoom.PerformClick();
      
            

        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnThanhToan.Left + 60;
            uc_CheckOut1.Visible = true;
            uc_CheckOut1.BringToFront();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnQuanLyNV.Left + 60;
            uc_Emloyee2.Visible = true;
            uc_Emloyee2.BringToFront();
        }
    }
}
