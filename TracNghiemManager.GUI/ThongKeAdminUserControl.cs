﻿using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts.WinForms;
using System.Windows.Forms;
using LiveCharts.Defaults;
using System.Windows.Media;
using TracNghiemManager.BUS;
using TracNghiemManager.DTO;
using System.IO;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities.Collections;

namespace TracNghiemManager.GUI
{
	public partial class ThongKeAdminUserControl : UserControl
	{
		private ThongKeBUS tkBus;
		public DataTable dt;
		private int flag = 1; // check data
		public ThongKeAdminUserControl()
		{
			InitializeComponent();
			tkBus = new ThongKeBUS();
			dt = new DataTable();
			dt.Columns.Add("ID", typeof(string));
			dt.Columns.Add("Họ tên", typeof(string));
			dt.Columns.Add("Quyền", typeof(string));
			dt.Columns.Add("Thời gian đăng nhập", typeof(string));
			dt.Columns.Add("Thời gian thoát", typeof(string));
			load();
		}
		public void load()
		{
			loadDataGridView();
			if (flag == 1)
			{
				StyleDataGridView();
			}
			lblCountCauHoi.Text = tkBus.getCountCauHoi().ToString();
			lblCountGV.Text = tkBus.getCountGv().ToString();
			lblCountHS.Text = tkBus.GetCountHs().ToString();
		}
		public void loadDataGridView()
		{
			List<UserDTO> loginHistories = new List<UserDTO>();

			if (File.Exists("loginHistory.json"))
			{
				string json = File.ReadAllText("loginHistory.json");
				loginHistories = JsonConvert.DeserializeObject<List<UserDTO>>(json);
			}

			dt.Clear();
			if (loginHistories != null)
			{
				//foreach (var history in loginHistories)
				//{
				//	DataRow row = dt.NewRow();
				//	row["ID"] = history.IdLogin.ToString();
				//	row["Họ tên"] = history.HoVaTen;
				//	row["Quyền"] = history.TenQuyen;
				//	if (history.TimeOut.ToString() == "01/01/0001 00:00:00")
				//	{
				//		row["Thời gian thoát"] = "";
				//	}
				//	else
				//	{

				//		row["Thời gian thoát"] = history.TimeOut.ToString();
				//	}
				//	row["Thời gian đăng nhập"] = history.TimeIn.ToString();
				//	dt.Rows.Add(row);
				//}
				for (int i = loginHistories.Count - 1; i >= 0; i--)
				{
					DataRow row = dt.NewRow();
					row["ID"] = loginHistories[i].IdLogin.ToString();
					row["Họ tên"] = loginHistories[i].HoVaTen;
					row["Quyền"] = loginHistories[i].TenQuyen;
					if (loginHistories[i].TimeOut.ToString() == "01/01/0001 00:00:00")
					{
						row["Thời gian thoát"] = "";
					}
					else
					{

						row["Thời gian thoát"] = loginHistories[i].TimeOut.ToString();
					}
					row["Thời gian đăng nhập"] = loginHistories[i].TimeIn.ToString();
					dt.Rows.Add(row);
				}
				dataGridView1.DataSource = dt;
				dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(242, 242, 242);
				dataGridView1.EnableHeadersVisualStyles = false;
				// setChieuCaoCuaTatCaCacDong
				for (int i = 0; i < loginHistories.Count; i++)
				{
					dataGridView1.Rows[i].Height = 40;
				}

			}
			if (dataGridView1.DataSource == null)
			{
				flag = -1;
			}
		}
		public void StyleDataGridView()
		{
			dataGridView1.Columns["Thời gian thoát"].Width = 250;
			dataGridView1.Columns["Thời gian đăng nhập"].Width = 250;
			dataGridView1.Columns["Quyền"].Width = 200;
			dataGridView1.Columns["ID"].Width = 200;
			dataGridView1.Columns["Họ tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


		}
	}
}
