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
    public partial class BookAdd : Form
    {
        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public BookAdd()
        {
            InitializeComponent();
        }
        private void BookAdd_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
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



            // 책 데이터 추가하는 코드 [SQL]
            cmd.CommandText = "INSERT INTO " +
                                    "Book_Data " +
                                    "VALUES( " +
                                    "'" + data1 + "', " +
                                    "'" + data2 + "', " +
                                    "'" + data3 + "', " +
                                    "'" + data4 + "', " +
                                    "'" + data5 + "');";
            cmd.ExecuteNonQuery();

            MessageBox.Show("'" + data1 + "' 도서가 추가되었습니다.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
