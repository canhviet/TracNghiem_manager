﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemManager.BUS;
using TracNghiemManager.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TracNghiemManager.GUI.DeThi
{
    public partial class DeThiUserControl : UserControl
    {
        System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
        private int counter = 1;
        DeThiBUS dtBus;
        private List<DeThiDTO> listdt;
        MonHocBUS mhBus;
        public DeThiUserControl()
        {
            InitializeComponent();
            dtBus = new DeThiBUS();
            mhBus = new MonHocBUS();
            listdt = dtBus.GetAll(Form1.USER_ID);
            loadLop(listdt);
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadLop(List<DeThiDTO> list)
        {
            listdt = list;
            // Xóa tất cả các panel được tạo trước đó
            flowLayoutPanel1.Controls.Clear();
            foreach (var l in listdt)
            {
                CreatePanel(l);
            }
        }

        public void AddDeThi(DeThiDTO obj)
        {
            dtBus.Add(obj);
            listdt.Add(obj);
            CreatePanel(obj);
        }
        public void UpdateDeThi(DeThiDTO obj)
        {
            dtBus.Update(obj);
            DeThiBUS lnew = new DeThiBUS();
            List<DeThiDTO> newlist = lnew.GetAll(Form1.USER_ID);
            loadLop(newlist);
        }

        public void DeleteDeThi(int id)
        {
            dtBus.Delete(id);
        }

        private void CreatePanel(DeThiDTO obj)
        {
            Panel panelContain = new Panel
            {
                Location = new Point(3, 3),
                Name = "panelContain" + counter.ToString(),
                Size = new Size(360, 350),
                TabIndex = 0,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10, 10, 10, 10),
            };

            Panel panelHead = new Panel
            {
                Location = new Point(0, 0),
                Name = "panelHead",
                Size = new Size(360, 290),
                TabIndex = 1,
                BackColor = GetRandomColor(),
            };

            Label lblTenDeThi = new Label
            {
                AutoSize = false,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                Location = new Point(10, 9),
                Name = "lblTenDeThi" + counter.ToString(),
                Size = new Size(300, 200),
                TabIndex = 0,

                Text = obj.TenDeThi,
                AutoEllipsis = true
            };
            toolTip.SetToolTip(lblTenDeThi, lblTenDeThi.Text);
            lblTenDeThi.Click += (s, ev) => { lblTenDeThi_Click(s, ev, obj); };

            Label lblMonHoc = new Label
            {
                AutoSize = true,
                Location = new Point(20, 220),
                Name = "lblMonHoc1" + counter,
                Size = new Size(110, 13),
                TabIndex = 2,
                Text = "Môn học: " + mhBus.getById(obj.MaMonHoc).TenMonHoc,

            };

            Label lblThoiGianLamBai = new Label
            {
                AutoSize = true,
                Location = new Point(20, 250),
                Name = "lblThoiGianLamBai" + counter,
                Size = new Size(140, 13),
                TabIndex = 1,
                Text = "Thời gian làm bài: " + obj.ThoiGianLamBai + " phút"
            };

            System.Windows.Forms.Button btnThemCauHoiVaoDe = new System.Windows.Forms.Button
            {
                Location = new Point(10, 300),
                Name = "button2" + counter,
                Size = new Size(200, 40),
                TabIndex = 2,
                Text = "Thêm câu hỏi vào đề",
                UseVisualStyleBackColor = true,
                Cursor = System.Windows.Forms.Cursors.Hand,
            };

            System.Windows.Forms.Button buttonXoa = new System.Windows.Forms.Button
            {
                Location = new Point(250, 300),
                Name = "button3" + counter,
                Size = new Size(100, 40),
                TabIndex = 3,
                Text = "Xóa",
                UseVisualStyleBackColor = true,
                Cursor = System.Windows.Forms.Cursors.Hand,
            };
            buttonXoa.Click += (s, ev) =>
            {
                buttonXoa_Click(s, ev, obj);
            };
            btnThemCauHoiVaoDe.Click += (s, ev) =>
            {
                btnThemCauHoiVaoDe_Click(s, ev, obj);
            };
            panelHead.Controls.AddRange(new Control[] { lblMonHoc, lblThoiGianLamBai, lblTenDeThi });
            panelContain.Controls.AddRange(new Control[] { btnThemCauHoiVaoDe, buttonXoa, panelHead });

            panelContain.Location = new Point(20, flowLayoutPanel1.Controls.Count * 150);
            flowLayoutPanel1.Controls.Add(panelContain);

            flowLayoutPanel1.AutoScroll = true;

            counter++;
        }

        // Ramdom mau nhat
        private Color GetRandomColor()
        {
            Random random = new Random();
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);

            // Làm cho màu sắc nhạt hơn bằng cách thêm 128 vào mỗi thành phần màu
            r += 128;
            g += 128;
            b += 128;

            // Đảm bảo rằng các thành phần màu không vượt quá 255
            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;

            return Color.FromArgb(r, g, b);
        }

        private void lblTenDeThi_Click(object sender, EventArgs e, DeThiDTO obj)
        {
            fThemDeThi themDeThi = new fThemDeThi(this, "edit", obj);
            themDeThi.ShowDialog();
        }
        private void buttonXoa_Click(object sender, EventArgs e, DeThiDTO obj)
        {
            
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            Panel panelContain = (Panel)clickedButton.Parent;

            DialogResult result = MessageBox.Show("Xác nhận xóa lớp học?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Remove(panelContain);
				DeleteDeThi(obj.MaDeThi);
			}

        }
        private void btnThemCauHoiVaoDe_Click(object sender, EventArgs e, DeThiDTO obj)
        {
            fThemChiTietDeThi f = new fThemChiTietDeThi(obj);
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            fThemDeThi themLop = new fThemDeThi(this, "add");

            themLop.ShowDialog();

        }
    }
}
