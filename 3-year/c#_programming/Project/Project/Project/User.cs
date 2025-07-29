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
    public partial class User : Form
    {
        string id;

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public User(string user_id)
        {
            InitializeComponent();
            id = user_id;
        }

        private void User_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            userID.Text = id;


            booklist.View = View.Details;
            booklist.GridLines = true;
            int listWidth = booklist.Width;

            booklist.Columns.Add("도서 이름", (int)(listWidth * 0.2));
            booklist.Columns.Add("저자", (int)(listWidth * 0.2));
            booklist.Columns.Add("고유번호", (int)(listWidth * 0.2));
            booklist.Columns.Add("발행일", (int)(listWidth * 0.2));
            booklist.Columns.Add("개수", (int)(listWidth * 0.2));

            string data1, data2, data3, data4, data5;

            cmd.CommandText = "SELECT * FROM Book_Data";
            SqlDataReader reader = cmd.ExecuteReader();

            booklist.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetString(0);
                data2 = reader.GetString(1);
                data3 = reader.GetString(2);
                data4 = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                data5 = reader.GetInt32(4).ToString();

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);
                item.SubItems.Add(data5);

                booklist.Items.Add(item);
            }

            reader.Close();
        }

        private void btn_book_search_Click(object sender, EventArgs e)
        {
            book_search();
        }
        private void tb_book_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                book_search();
            }
        }

        private void book_search()
        {
            string input = tb_book_search.Text;

            cmd.CommandText = "SELECT * FROM Book_Data WHERE book_name Like '%" + input + "%' or book_artist like '%" + input + "%';";

            SqlDataReader reader = cmd.ExecuteReader();

            string data1, data2, data3, data4, data5;

            booklist.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetString(0);
                data2 = reader.GetString(1);
                data3 = reader.GetString(2);
                data4 = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                data5 = reader.GetInt32(4).ToString();

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);
                item.SubItems.Add(data5);

                booklist.Items.Add(item);
            }
            reader.Close();
        }





        private void btn_book_rental_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRow = booklist.SelectedItems[0].Index;
                string bookName = booklist.Items[selectRow].SubItems[0].Text;
                string isbn = booklist.Items[selectRow].SubItems[2].Text;
                ReturnForm subForm = new ReturnForm(bookName, isbn);
                subForm.ShowDialog();
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("목록을 선택해주세요.");
                return;
            }


            // 대여 코드 [SQL]
            //cmd.CommandText = "INSERT INTO Rent_Data VALUES( '" + id + "', '" + selectId"
        }

        private void btn_book_return_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRow = booklist.SelectedItems[0].Index;
                string bookName = booklist.Items[selectRow].SubItems[0].Text;
                string isbn = booklist.Items[selectRow].SubItems[2].Text;
                ReturnForm subForm = new ReturnForm(bookName, isbn);
                subForm.ShowDialog();
                



            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("목록을 선택해주세요.");
                return;
            }

            // 반납 코드 [SQL]
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
