﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemManager.BUS;
using TracNghiemManager.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TracNghiemManager.GUI.LopHoc
{
    public partial class fThemLop : Form
    {
        private LopHocUserControl lopHocUserControl;
        private string hanhDong;
        LopDTO objUpdate;
        private string maMoi;
        LopBUS lBus;
        public fThemLop(LopHocUserControl lh, string hd, string mm = null, LopDTO lop = null)
        {
            InitializeComponent();
            lBus = new LopBUS();
            lopHocUserControl = lh;
            hanhDong = hd;
            maMoi = mm;
            if (hanhDong.Equals("edit"))
            {
                objUpdate = lop;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hanhDong.Equals("add"))
            {
                try
                {
                    if (checkValidInput())
                    {
                        LopDTO l = new LopDTO(lBus.GetAutoIncrement(), 1, txtTenlop.Text, maMoi, 1);
                        lopHocUserControl.AddLop(l);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (hanhDong.Equals("edit"))
            {
                if (checkValidInput())
                {
                    lopHocUserControl.Update();
                }
            }
        }
        private bool checkValidInput()
        {
            if (string.IsNullOrEmpty(txtTenlop.Text))
            {
                MessageBox.Show("Không được để trống tên lớp");
                return false;
            }
            return true;
        }
    }
}
