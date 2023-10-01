﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracNghiemManager.DTO
{
    public class MonHocDTO
    {
        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public int TrangThai { get; set; }
        public MonHocDTO()
        {

        }
        public MonHocDTO(int maMonHoc, string tenMonHoc, int trangThai)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
            TrangThai = trangThai;
        }
    }
}
