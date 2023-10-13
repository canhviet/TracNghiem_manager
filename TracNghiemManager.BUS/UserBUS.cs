﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TracNghiemManager.DAO;
using TracNghiemManager.DTO;

namespace TracNghiemManager.BUS
{
    public class UserBUS
    {
        public UserDAO UserDAO;
        public UserBUS()
        {
            UserDAO = UserDAO.instance;
        }
        public List<UserDTO> GetAll()
        {
            return UserDAO.GetAll();
        }
        public void Delete (int id)
        {
            UserDAO.Delete(id);
        }
        public string Add(UserDTO t)
        {
            if (UserDAO.Add(t))
            {
                return "Thêm thành công!";
            }
            return "Thêm thất bại!";
        }

        public int getNewId()
        {
            return UserDAO.newIdOfUser;
        }

        public bool isExistUsername(string s)
        {
            return UserDAO.isExistUsername(s);
        }

        public List<UserDTO> SearchEvenUsername(string s)
        {
            return UserDAO.SearchEvenUsername(s);
        }

        public List<UserDTO> SearchEvenPermisson(string s)
        {
            List<UserDTO> list = UserDAO.SearchUserIdInPermisson(s);
            List<UserDTO> users = new List<UserDTO> ();
            for(int i = 0; i < list.Count; i++) 
            {
                users.Add(UserDAO.GetById(list[i].Id));
            }
            return users;
        }

        public List<UserDTO> Search(string s)
        {
            List<UserDTO> list = UserDAO.Search(s);
            List<UserDTO> users = new List<UserDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                users.Add(UserDAO.GetById(list[i].Id));
            }
            return users;
        }

        public List<UserDTO> SearchEvenDate(string s1, string s2)
        {
            return UserDAO.SearchEvenDate(s1, s2);
        }
    }
}
