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
    public partial class Rentalform : Form
    {
        string isbn;
        string name;
        string user_id;
        int userCode;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public Rentalform(string book_isbn, string book_name, int user_code, string id)
        {
            InitializeComponent();
            isbn = book_isbn;
            name = book_name;
            userCode = user_code;
            user_id = id;
        }

        private void Rentalform_Load(object sender, EventArgs e)
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

        private void book_rental_Click(object sender, EventArgs e)
        {

            if (tb_userID.Text == "")
            {
                MessageBox.Show("유저 아이디를 입력해주세요.");
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
                MessageBox.Show("아이디가 일치하지 않습니다." + cmd.ExecuteScalar() + tb_userID.Text);
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

            if ((int)cmd.ExecuteScalar() >= 1)
            {
                MessageBox.Show("같은 책을 2권 이상 대여하실 수 없습니다.");
                return;
            }

            cmd.CommandText = "SELECT " +
                                    "COUNT(*) " +
                              "FROM " +
                                    "Rent_Data " +
                              "WHERE " +
                                    "user_code = '" + userCode + "' and " +
                                    "return_date IS NULL";

            if ((int)cmd.ExecuteScalar() == 5)
            {
                // 현재 대여중인 책이 5권입니다. 반납 후 진행해주세요. 둘중 선택하세요.ㅋㅋ
                MessageBox.Show("5권까지만 대여 가능합니다.");
                return;
            }

            cmd.CommandText = "SELECT " +
                                    "book_count " +
                              "FROM " +
                                    "Book_Data " +
                              "WHERE " +
                                    "book_isbn = '" + isbn + "'";

            if ((int)cmd.ExecuteScalar() == 0)
            {
                MessageBox.Show("이 도서는 현재 수량이 없습니다.");
                this.Close();
                return;
            }


            cmd.CommandText = "INSERT INTO " +
                                    "Rent_Data " +
                                    "VALUES( " +
                                    "'" + userCode + "', " +
                                    "'" + isbn + "', " +
                                    "getDate(), " +
                                    "null)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE " +
                                    "Book_Data " +
                              "SET " +
                                    "book_count = book_count - 1 " +
                              "WHERE " +
                                    "book_isbn = '" + isbn + "'";

            cmd.ExecuteNonQuery();

            MessageBox.Show("대여 완료");
            this.Close();
        }
    }
}
