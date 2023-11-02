﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemManager.DTO.ViewModel
{
	public class DiemCuaHS
	{
		public int MaHocSinh { get; set; }
		public string HoTen { get; set; }
		public double Diem { get; set; }
		public DiemCuaHS()
		{

		}
		public DiemCuaHS(int maHocSinh, string hoTen, double diem)
		{
			MaHocSinh = maHocSinh;
			HoTen = hoTen;
			Diem = diem;
		}
	}
}