﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemManager.BUS;
using TracNghiemManager.DAO;
using TracNghiemManager.DTO;
using TracNghiemManager.GUI.Users;

namespace TracNghiem_manager
{
    public partial class ManageUser : UserControl
    {
        private Panel[] panelUser;
        private PictureBox[] avatarImg;
        private Button[] buttonCT;
        private Button[] buttonDELETE;
        private TextBox[] textBoxDate;
        private TextBox[] textBoxRole;
        private TextBox[] textBoxName;
        private List<UserDTO> users;
        UserBUS userBUS = new UserBUS();
        public ManageUser()
        {
            InitializeComponent();
            reLoad(userBUS.GetAll());
        }

        private void renderUsers()
        {
            panelUser = new Panel[users.Count];
            buttonCT = new Button[users.Count];
            buttonDELETE = new Button[users.Count];
            textBoxDate = new TextBox[users.Count];
            textBoxRole = new TextBox[users.Count];
            textBoxName = new TextBox[users.Count];
            avatarImg = new PictureBox[users.Count];
            for (int i = 0; i < users.Count; i++)
            {
                panelUser[i] = new Panel();
                panelUser[i].Name = "panelUser" + i;
                panelUser[i].Size = new Size(385, 150);
                panelUser[i].BorderStyle = BorderStyle.FixedSingle;
                // 
                // buttonCT
                // 
                buttonCT[i] = new Button();
                buttonCT[i].Location = new Point(202, 105);
                buttonCT[i].Name = "buttonCT" + i;
                buttonCT[i].Size = new Size(75, 23);
                buttonCT[i].Tag = "" + users[i].Id;
                buttonCT[i].Text = "Chi Tiet";
                buttonCT[i].UseVisualStyleBackColor = true;
                buttonCT[i].MouseClick += Detail_MouseClick;
                // 
                // buttonDELETE
                // 
                buttonDELETE[i] = new Button();
                buttonDELETE[i].Location = new Point(283, 105);
                buttonDELETE[i].Name = "buttonDELETE" + i;
                buttonDELETE[i].Size = new Size(75, 23);
                buttonDELETE[i].Text = "DELETE";
                buttonDELETE[i].Tag = "" + users[i].Id;
                buttonDELETE[i].TextImageRelation = TextImageRelation.ImageBeforeText;
                buttonDELETE[i].UseVisualStyleBackColor = true;
                buttonDELETE[i].MouseClick += Delete_MouseClick;
                // 
                // textBoxDate
                // 
                textBoxDate[i] = new TextBox();
                textBoxDate[i].BackColor = SystemColors.Control;
                textBoxDate[i].Location = new Point(149, 76);
                textBoxDate[i].Name = "textBoxDate" + i;
                textBoxDate[i].Size = new Size(209, 23);
                textBoxDate[i].Text = "" + users[i].ngaySinh;
                // 
                // textBoxRole
                // 
                textBoxRole[i] = new TextBox();
                textBoxRole[i].BackColor = SystemColors.Control;
                textBoxRole[i].Location = new Point(149, 47);
                textBoxRole[i].Name = "textBoxRole" + i;
                textBoxRole[i].Size = new Size(209, 23);

                List<ChiTietQuyenDTO> user_roles = ChiTietQuyenDAO.Instance.GetRoleByUserId(users[i].Id);

                for(int j = 0; j <  user_roles.Count; j++)
                {
                    textBoxRole[i].Text += user_roles[j].ten_quyen + "|";
                }    

                // 
                // textBoxName
                // 
                textBoxName[i] = new TextBox();
                textBoxName[i].BackColor = SystemColors.Control;
                textBoxName[i].Location = new Point(149, 18);
                textBoxName[i].Name = "textBoxName" + i;
                textBoxName[i].Size = new Size(209, 23);
                textBoxName[i].Text = users[i].UserName;
                // 
                // avatarImg
                // 
                avatarImg[i] = new PictureBox();
                avatarImg[i].ImageLocation = @"" + users[i].avatar;
                avatarImg[i].Location = new Point(22, 18);
                avatarImg[i].Name = "avatarImg" + i;
                avatarImg[i].Size = new Size(100, 113);
                avatarImg[i].TabStop = false;


                panelUser[i].Controls.Add(buttonCT[i]);
                panelUser[i].Controls.Add(buttonDELETE[i]);
                panelUser[i].Controls.Add(textBoxDate[i]);
                panelUser[i].Controls.Add(textBoxRole[i]);
                panelUser[i].Controls.Add(textBoxName[i]);
                panelUser[i].Controls.Add(avatarImg[i]);
                flowLayoutContainer.Controls.Add(panelUser[i]);

            }


        }

        private void Delete_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "Do you want to delete this user?";
            string title = "Delete User";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Button bt = sender as Button;
                if (bt != null)
                {
                    int user_id = Convert.ToInt32(bt.Tag);
                    DeleteUser(user_id);

                    flowLayoutContainer.Controls.Clear();
                    renderUsers();
                }

            }
        }

        private void Detail_MouseClick(object sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null)
            {
                int user_id = Convert.ToInt32(bt.Tag);
                UserDetail detail = new UserDetail(user_id);
                detail.ShowDialog();
            }
        }

        private void DeleteUser(int id)
        {
            userBUS = new UserBUS();
            userBUS.Delete(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser add_user = new AddUser();
            add_user.ShowDialog();
        }

        private void reLoad(List<UserDTO> list)
        {
            flowLayoutContainer.Controls.Clear();
            users = list;
            renderUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if(index == -1)
            {
                reLoad(userBUS.Search(textBox1.Text.Trim()));
            }
            else
            {
                switch (index)
                {
                    case 0: reLoad(userBUS.SearchEvenUsername(textBox1.Text.Trim())); break;
                    case 1: reLoad(userBUS.SearchEvenPermisson(textBox1.Text.Trim())) ; break;
                    case 2: reLoad(userBUS.SearchEvenDate(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString())); break;
                }
            } 
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 2)
            {
                tableLayoutPanel4.Visible = true;
            }
            else
            {
                tableLayoutPanel4.Visible = false;
            }
        }
    }
}
