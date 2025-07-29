using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Userinforform : Form
    {
        string user_id;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public Userinforform(string usr_id)
        {
            InitializeComponent();
            user_id = usr_id;
        }
        private void Userform_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            // SQL 유저 정보 불러오기

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_id.Text == "" || tb_num.Text == "" || tb_regnum.Text == "" || tb_email.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
                return;
            }

            String name, id, number, info_num, email;
            name = tb_name.Text;
            id = tb_id.Text;
            number = tb_num.Text;
            info_num = tb_regnum.Text;
            email = tb_email.Text;
            // 이름, 아이디, 전화번호, 주민번호, 이메일 [순서]



            // 유저 수정 SQL [아이디는 값이 변하지 않음]




            MessageBox.Show(name + "유저를 수정하였습니다.");
            this.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            String id;
            id = tb_id.Text;


            // 유저 삭제 SQL [아이디는 값이 변하지 않음]





            MessageBox.Show(id + "가 탈퇴되었습니다.");
            this.Close();
        }
    }
}
