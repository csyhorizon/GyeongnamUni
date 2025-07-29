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

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public ReturnForm(string book_isbn, string book_name)
        {
            InitializeComponent();
            isbn = book_isbn;
            name = book_name;
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {

            tb_isbn.Text = isbn;
            tb_name.Text = name;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string userId = tb_userID.Text;

            if(userId == null)
            {
                MessageBox.Show("회원 ID를 입력해주세요.");
                return;
            }

            cmd.CommandText = "update rent_data set return_date = getDate() where book_isbn = '" + isbn + "' and user_name = '" + name + "'";
            cmd.ExecuteNonQuery();
        }
    }
}
