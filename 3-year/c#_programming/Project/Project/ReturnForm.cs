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
    public partial class ReturnForm : Form
    {
        string isbn;
        string name;
        int userCode;
        string user_id;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public ReturnForm(string book_isbn, string book_name, int user_code, string id)
        {
            InitializeComponent();
            isbn = book_isbn;
            name = book_name;
            userCode = user_code;
            user_id = id;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

            tb_isbn.Text = isbn;
            tb_name.Text = name;
            tb_userID.Text = user_id;

            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {

            if (tb_userID.Text == "")
            {
                MessageBox.Show("회원 ID를 입력해주세요.");
                return;
            }

            cmd.CommandText = "SELECT " +
                                    "user_id " +
                              "FROM " +
                                    "User_Data " +
                              "WHERE " +
                                    "user_code = '" + userCode + "'";
            if (cmd.ExecuteScalar().ToString().Trim() != tb_userID.Text)
            {
                MessageBox.Show("아이디가 일치하지 않습니다.");
                return;
            }

            cmd.CommandText = "SELECT " +
                                    "COUNT(*) " +
                              "FROM " +
                                    "Rent_Data " +
                              "WHERE " +
                                    "user_code = '" + userCode + "' and " +
                                    "book_isbn = '" + isbn + "' and " +
                                    "return_date IS NULL";

            if ((int)cmd.ExecuteScalar() == 0)
            {
                MessageBox.Show("대여중인 책이 아닙니다.");
                return;
            }


            cmd.CommandText = "UPDATE " +
                                    "Rent_Data " +
                              "SET " +
                                    "return_date = GETDATE() " +
                              "WHERE " +
                                    "book_isbn = '" + isbn + "' and " +
                                    "user_code = '" + userCode + "'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE " +
                                    "Book_Data " +
                              "SET " +
                                    "book_count = book_count + 1 " +
                              "WHERE " +
                                    "book_isbn = '" + isbn + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("반납 완료");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
