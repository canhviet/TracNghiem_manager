using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TracNghiemManager.DAO;
using TracNghiemManager.DTO;

namespace TracNghiemManager.BUS
{
    public class UserBUS
    {
        public List<UserDTO> userlist = UserDAO.instance.GetAll();
        public static UserBUS instance = new UserBUS();
        public List<UserDTO> GetAll()
        {
            return userlist;
        }
        public void Delete (int id)
        {
            UserDAO.instance.Delete(id);
        }
    }
}
