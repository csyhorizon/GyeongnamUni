using Project;
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
    public partial class Manager : Form
    {
        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void dataload()
        {
            // 버튼 활성화
            btn_book_search.Enabled = true;
            tb_book_search.Enabled = true;
            btn_book_add.Enabled = true;
            btn_book_upd.Enabled = true;

            btn_user_insert.Enabled = true;
            btn_user_upd.Enabled = true;
            tb_user_search.Enabled = true;
            btn_user_search.Enabled = true;




            // Book List Search
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


            // User List Search
            list_user.View = View.Details;
            list_user.GridLines = true;
            int userWidth = list_user.Width;

            list_user.Columns.Add("이름", (int)(userWidth * 0.2));
            list_user.Columns.Add("ID", (int)(userWidth * 0.2));
            list_user.Columns.Add("연락처", (int)(userWidth * 0.2));
            list_user.Columns.Add("주민번호", (int)(userWidth * 0.2));
            list_user.Columns.Add("이메일", (int)(userWidth * 0.2));

            cmd.CommandText = "SELECT * FROM UserData";

            list_user.Items.Clear();
            while (reader.Read())
            {
                data1 = reader.GetString(0);
                data2 = reader.GetString(1);
                data3 = reader.GetString(2);
                data4 = reader.GetString(3);
                data5 = reader.GetString(4);

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);
                item.SubItems.Add(data5);

                list_user.Items.Add(item);
            }
            reader.Close();
        }



        private void btn_book_add_Click(object sender, EventArgs e)
        {
            BookAdd subForm = new BookAdd();
            subForm.ShowDialog();
        }

        private void btn_book_upd_Click(object sender, EventArgs e)
        {
            try {
            int selectRow = booklist.SelectedItems[0].Index;
            string selectId = booklist.Items[selectRow].SubItems[0].Text;
            BookEdit subForm = new BookEdit(selectId);
            subForm.ShowDialog();
            } catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("목록을 선택해주세요.");
                return;
            }
}




        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (tb_password.Text == "")
                {
                    MessageBox.Show("비밀번호를 입력하세요");
                    return;
                }

                // 비밀번호 검증 후

                MessageBox.Show("관리자 로그인");
                dataload();
            }
        }






        private void tb_book_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                book_search();
            }
        }

        private void btn_book_search_Click(object sender, EventArgs e)
        {
            book_search();
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








        private void tb_user_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                user_search();
            }
        }

        private void btn_user_search_Click(object sender, EventArgs e)
        {
            user_search();
        }

        private void user_search()
        {
            string input = tb_user_search.Text;

            cmd.CommandText = "SELECT * FROM User_Data WHERE user_name Like '%" + input + "%' or user_id like '%" + input + "%';";
            
            SqlDataReader reader = cmd.ExecuteReader();

            string data1, data2, data3, data4, data5;

            list_user.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetString(0);
                data2 = reader.GetString(1);
                data3 = reader.GetString(2);
                data4 = reader.GetString(3);
                data5 = reader.GetString(4);

                Console.WriteLine(data1);

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);
                item.SubItems.Add(data5);

                list_user.Items.Add(item);
            }
            reader.Close();
        }



        private void btn_user_insert_Click(object sender, EventArgs e)
        {
            UserAdd subForm = new UserAdd();
            subForm.ShowDialog();
        }

        private void btn_user_upd_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRow = list_user.SelectedItems[0].Index;
                string selectId = list_user.Items[selectRow].SubItems[1].Text;
                Userinforform subForm = new Userinforform(selectId);
                subForm.ShowDialog();
            } catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show("목록을 선택해주세요.");
                return;
            }
        }
    }
}
