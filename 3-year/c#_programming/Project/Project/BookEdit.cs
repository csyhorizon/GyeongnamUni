using System;
using System.Collections;
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
    public partial class BookEdit : Form
    {
        String name, artist, isbn, year, count;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;


        public BookEdit(string bk_name, string bk_artist, string bk_isbn, string bk_year, string bk_count)
        {
            InitializeComponent();
            name = bk_name;
            artist = bk_artist;
            isbn = bk_isbn;
            year = bk_year;
            count = bk_count;
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            tb_id.Text = name;
            tb_artist.Text = artist;
            tb_isbn.Text = isbn;
            tb_bookyear.Text = year;
            tb_book_count.Text = count;
        }


        private void book_add_Click(object sender, EventArgs e)
        {
            string data1, data2, data3, data4;
            int data5;

            if (tb_id.Text == "" || tb_artist.Text == "" || tb_isbn.Text == "" || tb_bookyear.Text == "" || tb_book_count.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
                return;
            }

            // ID, ARTIST, ISBN, YEAR, COUNT
            data1 = tb_id.Text;
            data2 = tb_artist.Text;
            data3 = tb_isbn.Text;
            data4 = tb_bookyear.Text;
            data5 = int.Parse(tb_book_count.Text);




            // 책 데이터 수정하는 코드 [SQL]  
            cmd.CommandText = "UPDATE " +
                                    "Book_Data " +
                              "SET " +
                                    "book_name = '" + data1 + "', " +
                                    "book_artist = '" + data2 + "', " +
                                    "book_isbn = '" + data3 + "', " +
                                    "book_year = '" + data4 + "', " +
                                    "book_count = '" + data5 + "' " +
                              "WHERE " +
                                    "book_isbn = '" + data3 + "';";

            cmd.ExecuteNonQuery();

            MessageBox.Show("'" + data1 + "' 도서의 데이터가 수정되었습니다.");
            this.Close();
        }

        private void book_del_Click(object sender, EventArgs e)
        {
            string data1 = tb_id.Text;


            // 책 데이터 삭제하는 코드 [SQL]
            cmd.CommandText = "DELETE " +
                              "FROM " +
                                  "Book_Data " +
                              "WHERE " +
                                  "book_isbn = '" + tb_isbn.Text + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("'" + data1 + "' 도서를 삭제하였습니다.");
            this.Close();
        }

    }
}
