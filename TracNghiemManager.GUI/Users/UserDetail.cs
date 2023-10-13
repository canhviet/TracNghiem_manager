using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TracNghiemManager.DAO;
using TracNghiemManager.DTO;

namespace TracNghiem_manager
{
    public partial class UserDetail : Form
    {
        private List<ChucNangDTO> chucNangOfUser;
        public UserDetail(int user_id)
        {
            InitializeComponent();
            renderListBoxUserAction(user_id);
        }

        private void renderListBoxUserAction(int user_id)
        {
            chucNangOfUser = ChucNangDAO.Instance.GetTenChucNangBangUserId(user_id);
            for (int i = 0; i < chucNangOfUser.Count; i++)
            {
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
