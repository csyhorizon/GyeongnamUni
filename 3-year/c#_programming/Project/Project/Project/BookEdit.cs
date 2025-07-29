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
    public partial class BookEdit : Form
    {

        String book_name;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public BookEdit(string bookName)
        {
            InitializeComponent();
            book_name = bookName;
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            tb_id.Text = book_name;
            string input = book_name;

            // 책 이름 검색해서 정보 받아오기 [SQL]
            cmd.CommandText = "SELECT * FROM Book_Data WHERE book_name LIKE '%" + input + "%' or book_artist LIKE '%" + input + "%';";
            cmd.ExecuteNonQuery();
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
            //cmd.CommandText = "UPDATE Book_Data SET data1"





            MessageBox.Show(data1 + "도서의 데이터가 수정되었습니다.");
            this.Close();
        }

        private void book_del_Click(object sender, EventArgs e)
        {
            string data1 = tb_id.Text;


            // 책 데이터 삭제하는 코드 [SQL]





            MessageBox.Show(data1 + "도서를 삭제하였습니다.");
            this.Close();
        }

    }
}
