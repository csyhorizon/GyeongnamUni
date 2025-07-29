using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Mainform : Form
    {

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public Mainform()
        {
            InitializeComponent();
        }


        private void Mainform_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            user_login();
        }
        private void user_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                user_login();
            }
        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
            id_text.Enabled = true;
            user_id.Enabled = true;
        }

        private void developer_CheckedChanged(object sender, EventArgs e)
        {
            id_text.Enabled = false;
            user_id.Enabled = false;
        }


        private void user_login()
        {
            if (user.Checked)
            {
                if (user_id.Text == "")
                {
                    MessageBox.Show("아이디를 입력하세요.");
                    return;
                }

                bool idChecker = Regex.IsMatch(user_id.Text, @"[0-9a-zA-Z]{3,15}$");
                if (idChecker == false) { 
                    MessageBox.Show("잘못된 아이디 형식 입니다.");
                    return;
                }
                // ID 검증 SQL
                cmd.CommandText = "SELECT " +
                                        "CASE WHEN user_id = '" + user_id.Text + "' " +
                                        "THEN 1 " +
                                        "ELSE 0 " +
                                        "END AS checkID " +
                                  "FROM " +
                                        "user_data " +
                                  "WHERE " +
                                        "user_id = '" + user_id.Text + "'";
                cmd.ExecuteNonQuery();
                int result, userCode;


                try
                {
                    result = (int)cmd.ExecuteScalar(); // 받는 값이 있으면 1 반환 , 없으면 에러 

                    // 1일 때만 정상 작동 에러라면 catch로 이동
                    cmd.CommandText = "SELECT " +
                                            "user_code " +
                                      "FROM " +
                                            "User_Data " +
                                      "WHERE " +
                                            "user_id ='" + user_id.Text + "'";
                    userCode = (int)cmd.ExecuteScalar();

                    User subForm = new User(user_id.Text, userCode);
                    subForm.ShowDialog();

                }
                catch (NullReferenceException er)
                {
                    result = 0;
                    MessageBox.Show("아이디가 없습니다.");
                }
            }
            else
            {
                Manager subForm = new Manager();
                subForm.ShowDialog();
            }
        }
    }
}
