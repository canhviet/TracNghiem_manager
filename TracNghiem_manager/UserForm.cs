﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using TracNghiemManager.DTO;
using TracNghiemManager.DAO;

namespace TracNghiem_manager
{
    public partial class UserForm : Form
    {
        private Rectangle recLab1;

        public UserForm()
        {
            InitializeComponent();
            AddColorChange(btnHome, hoverColor, hoverColor);
            AddColorChange(btnCauHoi, hoverColor, hoverColor);
            AddColorChange(btnMonHoc, hoverColor, hoverColor);
            AddColorChange(btnLopHoc, hoverColor, hoverColor);
            AddColorChange(btnDeThi, hoverColor, hoverColor);
            AddColorChange(btnThongKe, hoverColor, hoverColor);
            AddColorChange(btnThoat, hoverColor, hoverColor);
            AddColorChange(btnNguoiDung, hoverColor, hoverColor);

            infoPanelBox.Paint += (sender, e) =>
            {
                Control control = (Control)sender;
                int borderWidth = 2; // Độ rộng của đường viền

                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    // Vẽ đường viền bên dưới của TableLayoutPanel
                    e.Graphics.DrawLine(borderPen, 0, control.Height - borderWidth, control.Width, control.Height - borderWidth);
                }
            };
            containerBtnPanel.Paint += (sender, e) =>
            {
                Control control = (Control)sender;
                int borderWidth = 2; // Độ rộng của đường viền

                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    // Vẽ đường viền bên phải của TableLayoutPanel
                    e.Graphics.DrawLine(borderPen, control.Width - borderWidth, 0, control.Width - borderWidth, control.Height);
                }
            };
            HideAllUserControls();
            homePanel.Visible = true;
        }

        private void HideAllUserControls()
        {
            homePanel.Visible = false;
            lopHocPanel.Visible = false;
            monHocPanel.Visible = false;
            cauHoiPanel.Visible = false;
            deThiPanel.Visible = false;
            thongKePanel.Visible = false;

        }


        private void ShowUserControl(UserControl controlToShow)
        {
            HideAllUserControls();
            controlToShow.Visible = true;
        }
        //private void ShowUserControl(UserControl selectedControl)
        //{
        //    // Duyệt qua tất cả các UserControl trong containerControl
        //    foreach (Control control in containerBtnPanel.Controls)
        //    {
        //        if (control is UserControl)
        //        {
        //            // Nếu UserControl là UserControl bạn muốn hiển thị, thì hiển thị nó
        //            if (control == selectedControl)
        //            {
        //                control.Visible = true;
        //            }
        //            else
        //            {
        //                // Nếu không phải UserControl bạn muốn hiển thị, thì tắt nó (ẩn đi)
        //                if (control != null)
        //                {

        //                    control.Visible = false;
        //                }
        //            }
        //        }
        //    }
        //}




        public T CreateAndConfigureControl<T>(string name) where T : Control, new()
        {
            T control = new T();
            control.Dock = DockStyle.Fill;
            control.Location = new Point(0, 0);
            control.Margin = new Padding(3, 4, 3, 4);
            control.Name = name;
            control.Size = new Size(1032, 570);
            control.TabIndex = 6;
            return control;
        }

        private void ConfigureButton(System.Windows.Forms.Button button)
        {
            button.BackColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button.Margin = new Padding(5);
            button.Padding = new Padding(5);
            button.TextAlign = ContentAlignment.MiddleRight;
            button.ForeColor = defaultTitleBtnColor;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = false;
        }

        private void SetBorderButton(System.Windows.Forms.Button button, int borderRadius)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90); // Góc trên bên trái
            buttonPath.AddArc(button.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90); // Góc trên bên phải
            buttonPath.AddArc(button.Width - borderRadius * 2, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Góc dưới bên phải
            buttonPath.AddArc(0, button.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Góc dưới bên trái
            buttonPath.CloseAllFigures();

            button.Region = new Region(buttonPath); // Đặt Region của nút bằng đường viền cong
        }
        private void AddColorChange(System.Windows.Forms.Button button, Color hoverColor, Color clickColor)
        {
            Color defaultBackColor = button.BackColor;
            Color defaultForeColor = button.ForeColor;

            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = hoverColor;
                button.ForeColor = Color.Black;
            };

            button.MouseHover += (sender, e) =>
            {
                button.BackColor = hoverColor;
                button.ForeColor = Color.Black;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = defaultBackColor;
                button.ForeColor = defaultForeColor;
            };

            button.Click += (sender, e) =>
            {
                button.BackColor = clickColor;
                button.ForeColor = Color.Black;
            };
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowUserControl(homePanel);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnCauHoi_Click(object sender, EventArgs e)
        {
            ShowUserControl(cauHoiPanel);
        }

        private void btnDeThi_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            ShowUserControl(userPanel);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            List<ChucNangDTO> listChucNang = ChucNangDAO.Instance.GetTenChucNangBangUserId(Form1.USER_ID);

            for (int i = 0; i < listChucNang.Count; i++)
            {
                if (listChucNang[i].ten_chuc_nang.Equals("sửa user") || listChucNang[i].ten_chuc_nang.Equals("xóa user") ||
                    listChucNang[i].ten_chuc_nang.Equals("thêm user"))
                {
                    containerBtnPanel.Controls.Add(btnNguoiDung);
                    containerBtnPanel.RowStyles.Add(new RowStyle());
                }

                if (listChucNang[i].ten_chuc_nang.Equals("tạo lớp") || listChucNang[i].ten_chuc_nang.Equals("xóa lớp") ||
                    listChucNang[i].ten_chuc_nang.Equals("sửa lớp"))
                {
                    containerBtnPanel.Controls.Add(btnLopHoc);
                    containerBtnPanel.RowStyles.Add(new RowStyle());
                }

                if (listChucNang[i].ten_chuc_nang.Equals("tạo câu hỏi") || listChucNang[i].ten_chuc_nang.Equals("sửa câu hỏi") ||
                    listChucNang[i].ten_chuc_nang.Equals("xóa câu hỏi"))
                {
                    containerBtnPanel.Controls.Add(btnCauHoi);
                    containerBtnPanel.RowStyles.Add(new RowStyle());
                }

                if (listChucNang[i].ten_chuc_nang.Equals("tạo đề thi") || listChucNang[i].ten_chuc_nang.Equals("xóa đề thi") ||
                    listChucNang[i].ten_chuc_nang.Equals("sửa đề thi"))
                {
                    containerBtnPanel.Controls.Add(btnDeThi);
                    containerBtnPanel.RowStyles.Add(new RowStyle());
                }

                if (listChucNang[i].ten_chuc_nang.Equals("tạo môn học") || listChucNang[i].ten_chuc_nang.Equals("sửa môn học") ||
                    listChucNang[i].ten_chuc_nang.Equals("xóa môn học"))
                {
                    containerBtnPanel.Controls.Add(btnMonHoc);
                    containerBtnPanel.RowStyles.Add(new RowStyle());
                }
            }
            containerBtnPanel.Controls.Add(btnThongKe);
            containerBtnPanel.RowStyles.Add(new RowStyle());
            containerBtnPanel.Controls.Add(btnThoat);
            containerBtnPanel.RowStyles.Add(new RowStyle());

        }


        // tmp
        //private void setHeightRow(TableLayoutPanel containerBtn)
        //{
        //    int desiredRowHeight = 30;

        //    // Đặt chiều cao cho các hàng trong các TableLayoutPanel
        //    foreach (TableLayoutPanel tableLayoutPanel in containerBtn)
        //    {
        //        tableLayoutPanel.SuspendLayout(); // Tạm ngừng việc vẽ để tăng hiệu suất

        //        foreach (RowStyle rowStyle in tableLayoutPanel.RowStyles)
        //        {
        //            rowStyle.SizeType = SizeType.Absolute; // Đặt loại kích thước thành Absolute
        //            rowStyle.Height = desiredRowHeight; // Đặt chiều cao cho hàng
        //        }

        //        tableLayoutPanel.ResumeLayout(); // Tiếp tục vẽ
        //    }
        //}


    }
}
