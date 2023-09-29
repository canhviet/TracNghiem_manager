﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TracNghiemManager.DTO;

namespace TracNghiemManager.DAO
{
    public class ChucNangDAO : IDAO<ChucNangDTO>
    {
        public static ChucNangDAO Instance = new ChucNangDAO();
        public bool Add(ChucNangDTO t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChucNangDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ChucNangDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ChucNangDTO t)
        {
            throw new NotImplementedException();
        }

        public List<ChucNangDTO> GetChucNangTuMaQuyen(int maQuyen)
        {
            List<ChucNangDTO> list = new List<ChucNangDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT * FROM chuc_nang WHERE trang_thai = 1 and ma_quyen = " + maQuyen;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChucNangDTO chucNang = new ChucNangDTO();
                            {
                                chucNang.ma_quyen = Convert.ToInt32(reader["ma_quyen"]);
                                chucNang.ma_chuc_nang = Convert.ToInt32(reader["ma_chuc_nang"]);
                                chucNang.ten_chuc_nang = reader["ten_chuc_nang"].ToString();
                                chucNang.trang_thai = Convert.ToInt32(reader["trang_thai"]);
                            };
                            list.Add(chucNang);
                        }
                    }

                }
                connection.Close();
            }
            return list;
        }

        public List<ChucNangDTO> GetTenChucNangBangUserId(int userID)
        {
            List<ChucNangDTO> list = new List<ChucNangDTO>();
            using (SqlConnection connection = DbConnection.GetSqlConnection())
            {
                string query = "SELECT cn.ten_chuc_nang FROM quyen AS q " +
                    "JOIN chi_tiet_quyen AS ct ON q.ma_quyen = ct.ma_quyen " +
                    "JOIN users AS u ON ct.user_id = u.id " +
                    "JOIN chuc_nang AS cn ON cn.ma_quyen = q.ma_quyen " +
                    "WHERE ct.cho_phep = 1 AND u.trang_thai = 1 AND q.trang_thai = 1 AND u.id = " + userID;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChucNangDTO chucNang = new ChucNangDTO();
                            {
                                chucNang.ten_chuc_nang = reader["ten_chuc_nang"].ToString();
                            };
                            list.Add(chucNang);
                        }
                    }

                }
                connection.Close();
            }
            return list;
        }
    }
}
