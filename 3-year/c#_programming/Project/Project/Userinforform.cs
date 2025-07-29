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
        string id;
        string name;
        string phone;
        string email;
        string idNumber;


        String connStr;
        SqlConnection conn;
        SqlCommand cmd;
        public Userinforform(string user_id, string user_name, string user_phone, string user_email, string id_number)
        {
            InitializeComponent();
            id = user_id.Trim();
            name = user_name.Trim();
            phone = user_phone.Trim();
            email = user_email.Trim();
            idNumber = id_number.Trim();
        }
        private void Userform_Load(object sender, EventArgs e)
        {
            tb_id.Text = id;
            tb_name.Text = name;
            tb_phone.Text = phone;
            tb_email.Text = email;
            tb_id_number.Text = idNumber;

            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();

            cmd.Connection = conn;

            // SQL 유저 정보 불러오기

        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_id.Text == "" || tb_phone.Text == "" || tb_id_number.Text == "" || tb_email.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
                return;
            }


            // 유저 수정 SQL [아이디는 값이 변하지 않음]
            cmd.CommandText = "UPDATE " +
                                  "user_data " +
                              "SET " +
                                  "user_name ='" + tb_name.Text + "', " +
                                  "user_phone='" + tb_phone.Text + "', " +
                                  "id_number = '" + tb_id_number + "', " +
                                  "user_email=" + tb_email.Text + "' " +
                              "WHERE " +
                                  "user_id = '" + tb_id.Text + "'";

            cmd.ExecuteReader();


            MessageBox.Show(name + "유저를 수정하였습니다.");
            this.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT " +
                                    "COUNT(rd.user_code) " +
                              "FROM " +
                                    "User_Data ud " +
                                    "LEFT OUTER JOIN Rent_Data rd on(ud.user_code = rd.user_code) " +
                              "WHERE " +
                                    "ud.user_id = '" + id + "' and " +
                                    "rd.return_date IS NULL";

            if((int)cmd.ExecuteScalar() > 0)
            {
                MessageBox.Show("반납하지 않은 도서가 있습니다. 반납 후 탈퇴를 진행해주세요.");
                return;
            }



            // 유저 삭제 SQL [아이디는 값이 변하지 않음]
            cmd.CommandText = "DELETE " +
                              "FROM " +
                                  "user_data " +
                              "WHERE " +
                                  "user_id = '" + id + "'";
            cmd.ExecuteReader();



            MessageBox.Show(id + "가 탈퇴되었습니다.");
            this.Close();
        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }
    }
}
