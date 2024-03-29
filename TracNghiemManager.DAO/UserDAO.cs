﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TracNghiemManager.DTO;

namespace TracNghiemManager.DAO
{
    public class UserDAO : IDAO<UserDTO>
    {
		public static UserDAO instance = new UserDAO();
		public int newIdOfUser = -1;
		public bool Add(UserDTO t)
		{
			try
			{
				using (SqlConnection connection = DbConnection.GetSqlConnection())
				{
					string query = "INSERT INTO users (username, mat_khau, ngay_tao, trang_thai, ngay_sinh, gioi_tinh) VALUES (@username, @password, @ngayTao, 1, @ngayTao, 1) SELECT @@IDENTITY AS id";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@username", t.UserName);
						command.Parameters.AddWithValue("@password", t.Password);
						command.Parameters.AddWithValue("@ngayTao", t.ngayTao);

						int id = Convert.ToInt32(command.ExecuteScalar());
						newIdOfUser = id;
						return id > 0;
					}
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}

		public bool Delete(int id)
		{
			try
			{
				using (SqlConnection connection = DbConnection.GetSqlConnection())
				{
					string query = "Update users Set trang_thai = 0 Where id = " + id;
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						int rowsChanged = command.ExecuteNonQuery();
						return rowsChanged > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}
		}

		public List<UserDTO> GetAll()
		{
			List<UserDTO> List = new List<UserDTO>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM users WHERE trang_thai = 1 ";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							UserDTO user = new UserDTO();
							user.Id = Convert.ToInt32(reader["id"]);
							user.HoVaTen = reader["ho_va_ten"].ToString();
							user.Email = reader["email"].ToString();
							user.Password = reader["mat_khau"].ToString();
							user.UserName = reader["username"].ToString();
							user.avatar = reader["avatar"].ToString();
							user.gioiTinh = Convert.ToInt32(reader["gioi_tinh"]);
							user.ngaySinh = Convert.ToDateTime(reader["ngay_sinh"]);
							if (reader["ngay_tao"].ToString() != "")
							{
								user.ngayTao = Convert.ToDateTime(reader["ngay_tao"]);
							}

							List.Add(user);
						}
					}

				}
				connection.Close();
			}
			return List;
		}

		public List<UserDTO> SearchEvenUsername(string s)
		{
			List<UserDTO> List = new List<UserDTO>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM users WHERE trang_thai = 1 and username LIKE '" + s + "%'";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							UserDTO user = new UserDTO();
							user.Id = Convert.ToInt32(reader["id"]);
							user.UserName = reader["username"].ToString();
							user.avatar = reader["avatar"].ToString();
							user.Password = reader["mat_khau"].ToString();
							List.Add(user);
						}
					}

				}
				connection.Close();
			}
			return List;
		}

		public List<UserDTO> Search(string s)
		{
			List<UserDTO> List = new List<UserDTO>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT DISTINCT u.id FROM users AS u " +
					"JOIN chi_tiet_quyen AS ct ON u.id = ct.user_id " +
					"JOIN quyen AS q ON q.ma_quyen = ct.ma_quyen " +
					"WHERE ct.cho_phep = 1 and u.trang_thai = 1 and (u.username LIKE '" + s + "%' or q.ten_quyen LIKE '" + s + "%')";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							UserDTO user = new UserDTO();
							user.Id = Convert.ToInt32(reader["id"]);
							List.Add(user);
						}
					}

				}
				connection.Close();
			}
			return List;
		}

		public List<UserDTO> SearchUserIdInPermisson(string s)
		{
			List<UserDTO> List = new List<UserDTO>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT DISTINCT ct.user_id FROM  chi_tiet_quyen AS ct JOIN quyen AS q ON q.ma_quyen = ct.ma_quyen join users AS u on u.id = ct.user_id " +
					"WHERE ct.cho_phep = 1 and u.trang_thai = 1 and q.ten_quyen LIKE '" + s + "%'";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							UserDTO user = new UserDTO();
							user.Id = Convert.ToInt32(reader["user_id"]);
							List.Add(user);
						}
					}

				}
				connection.Close();
			}
			return List;
		}

		public List<UserDTO> SearchEvenDate(string s1, string s2)
		{
			List<UserDTO> List = new List<UserDTO>();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM users WHERE trang_thai = 1 AND ngay_tao >= '" + s1 + "' AND ngay_tao <= '" + s2 + "'";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							UserDTO user = new UserDTO();
							user.Id = Convert.ToInt32(reader["id"]);
							user.UserName = reader["username"].ToString();
							user.avatar = reader["avatar"].ToString();
							user.Password = reader["mat_khau"].ToString();
							List.Add(user);
						}
					}

				}
				connection.Close();
			}
			return List;
		}

		public int GetIdByUsername(string username)
		{
			int Id = -1;
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT id FROM users WHERE trang_thai = 1 AND username = '" + username + "'";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Id = Convert.ToInt32(reader["id"]);
						}
					}

				}
				connection.Close();
			}
			return Id;
		}

		public UserDTO GetById(int id)
		{
			UserDTO user = new UserDTO();
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM users WHERE trang_thai = 1 AND id = " + id;
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							user.Id = Convert.ToInt32(reader["id"]);
							user.avatar = reader["avatar"].ToString();
							user.Email = reader["email"].ToString();
							user.HoVaTen = reader["ho_va_ten"].ToString();
							if (reader["ngay_sinh"].ToString() != "")
							{
								user.ngaySinh = Convert.ToDateTime(reader["ngay_sinh"]);
							}
							if (reader["gioi_tinh"].ToString() != "")
							{
								user.gioiTinh = Convert.ToInt32(reader["gioi_tinh"]);
							}
							if (reader["ngay_tao"].ToString() != "")
							{
								user.ngayTao = Convert.ToDateTime(reader["ngay_tao"]);
							}
							user.UserName = reader["username"].ToString();
							user.Password = reader["mat_khau"].ToString();
							user.trangThai = Convert.ToInt32(reader["trang_thai"]);
						}
					}

				}
				connection.Close();
			}
			return user;
		}

		public bool Update(UserDTO t)
		{
			try
			{
				using (SqlConnection connection = DbConnection.GetSqlConnection())
				{
					string query = "update users set mat_khau = @mat_khau, ho_va_ten = @ho_va_ten, ngay_sinh = @ngay_sinh, avatar = @avatar, gioi_tinh = @gioi_tinh, email = @email where id = @id; ";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@id", t.Id);
						command.Parameters.AddWithValue("@ho_va_ten", t.HoVaTen);
						command.Parameters.AddWithValue("@ngay_sinh", t.ngaySinh);
						command.Parameters.AddWithValue("@avatar", t.avatar);
						command.Parameters.AddWithValue("@gioi_tinh", t.gioiTinh);
						command.Parameters.AddWithValue("@email", t.Email);
						command.Parameters.AddWithValue("@mat_khau", t.Password);
						int rowsChanged = command.ExecuteNonQuery();
						return rowsChanged > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}

		public bool isExistUsername(string s)
		{
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "SELECT * FROM users WHERE username = @username";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@username", s);
					SqlDataReader dr = command.ExecuteReader();

					if (dr.HasRows)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
			}
		}
		public List<UserDTO> GetMailandAvatar(string s)
		{
			List<UserDTO> users = new List<UserDTO>();

			try
			{
				using (SqlConnection connection = DbConnection.GetSqlConnection())
				{
					string query = "SELECT email, avatar, username,ho_va_ten FROM users WHERE trang_thai = 1 AND (username = @input OR email = @input)";

					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@input", s);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								UserDTO user = new UserDTO();
								user.Email = reader["email"].ToString();
								user.avatar = reader["avatar"].ToString();
								user.UserName = reader["username"].ToString();
								user.HoVaTen = reader["ho_va_ten"].ToString();
								users.Add(user);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}

			return users;
		}
		public void UpdatePassword(string email, string newPassword)
		{
			using (SqlConnection connection = DbConnection.GetSqlConnection())
			{
				string query = "UPDATE users SET mat_khau = @newPassword WHERE email = @email";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@email", email);
					command.Parameters.AddWithValue("@newPassword", newPassword);
					command.ExecuteNonQuery();
				}
			}
		}

		 public int GetAutoIncrement()
        {
            int result = -1;
            try
            {
                using (SqlConnection connection = DbConnection.GetSqlConnection())
                {
                    string query = "SELECT id from users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No data");
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    result = reader.GetInt32(0); // Lấy giá trị cột AUTO_INCREMENT
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result + 1;
        }
	}
}
