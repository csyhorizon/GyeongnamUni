namespace Project
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tp_book = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_book_search = new System.Windows.Forms.Button();
            this.tb_book_search = new System.Windows.Forms.TextBox();
            this.label_book = new System.Windows.Forms.Label();
            this.btn_book_upd = new System.Windows.Forms.Button();
            this.btn_book_add = new System.Windows.Forms.Button();
            this.booklist = new System.Windows.Forms.ListView();
            this.tp_user = new System.Windows.Forms.TabPage();
            this.btn_user_search = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.tb_user_search = new System.Windows.Forms.TextBox();
            this.btn_user_upd = new System.Windows.Forms.Button();
            this.btn_user_insert = new System.Windows.Forms.Button();
            this.list_user = new System.Windows.Forms.ListView();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_book.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tp_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_book
            // 
            this.tp_book.Controls.Add(this.tabPage1);
            this.tp_book.Controls.Add(this.tp_user);
            this.tp_book.Location = new System.Drawing.Point(9, 48);
            this.tp_book.Margin = new System.Windows.Forms.Padding(1);
            this.tp_book.Name = "tp_book";
            this.tp_book.SelectedIndex = 0;
            this.tp_book.Size = new System.Drawing.Size(831, 566);
            this.tp_book.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_book_search);
            this.tabPage1.Controls.Add(this.tb_book_search);
            this.tabPage1.Controls.Add(this.label_book);
            this.tabPage1.Controls.Add(this.btn_book_upd);
            this.tabPage1.Controls.Add(this.btn_book_add);
            this.tabPage1.Controls.Add(this.booklist);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(823, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "도서 관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_book_search
            // 
            this.btn_book_search.BackColor = System.Drawing.Color.Wheat;
            this.btn_book_search.Enabled = false;
            this.btn_book_search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_book_search.Location = new System.Drawing.Point(534, 96);
            this.btn_book_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_book_search.Name = "btn_book_search";
            this.btn_book_search.Size = new System.Drawing.Size(87, 40);
            this.btn_book_search.TabIndex = 2;
            this.btn_book_search.Text = "검색";
            this.btn_book_search.UseVisualStyleBackColor = false;
            this.btn_book_search.Click += new System.EventHandler(this.btn_book_search_Click);
            // 
            // tb_book_search
            // 
            this.tb_book_search.Enabled = false;
            this.tb_book_search.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_book_search.Location = new System.Drawing.Point(31, 96);
            this.tb_book_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_book_search.Name = "tb_book_search";
            this.tb_book_search.Size = new System.Drawing.Size(499, 38);
            this.tb_book_search.TabIndex = 1;
            this.tb_book_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_book_search_KeyPress);
            // 
            // label_book
            // 
            this.label_book.AutoSize = true;
            this.label_book.Font = new System.Drawing.Font("맑은 고딕", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_book.Location = new System.Drawing.Point(23, 14);
            this.label_book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_book.Name = "label_book";
            this.label_book.Size = new System.Drawing.Size(270, 50);
            this.label_book.TabIndex = 68;
            this.label_book.Text = "도서 정보 관리";
            // 
            // btn_book_upd
            // 
            this.btn_book_upd.Enabled = false;
            this.btn_book_upd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_book_upd.Location = new System.Drawing.Point(655, 452);
            this.btn_book_upd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_book_upd.Name = "btn_book_upd";
            this.btn_book_upd.Size = new System.Drawing.Size(112, 36);
            this.btn_book_upd.TabIndex = 63;
            this.btn_book_upd.Text = "도서 수정";
            this.btn_book_upd.UseVisualStyleBackColor = true;
            this.btn_book_upd.Click += new System.EventHandler(this.btn_book_upd_Click);
            // 
            // btn_book_add
            // 
            this.btn_book_add.Enabled = false;
            this.btn_book_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_book_add.Location = new System.Drawing.Point(655, 411);
            this.btn_book_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_book_add.Name = "btn_book_add";
            this.btn_book_add.Size = new System.Drawing.Size(112, 36);
            this.btn_book_add.TabIndex = 61;
            this.btn_book_add.Text = "도서 추가";
            this.btn_book_add.UseVisualStyleBackColor = true;
            this.btn_book_add.Click += new System.EventHandler(this.btn_book_add_Click);
            // 
            // booklist
            // 
            this.booklist.HideSelection = false;
            this.booklist.Location = new System.Drawing.Point(31, 149);
            this.booklist.Margin = new System.Windows.Forms.Padding(2);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(590, 362);
            this.booklist.TabIndex = 59;
            this.booklist.UseCompatibleStateImageBehavior = false;
            // 
            // tp_user
            // 
            this.tp_user.Controls.Add(this.btn_user_search);
            this.tp_user.Controls.Add(this.label_user);
            this.tp_user.Controls.Add(this.tb_user_search);
            this.tp_user.Controls.Add(this.btn_user_upd);
            this.tp_user.Controls.Add(this.btn_user_insert);
            this.tp_user.Controls.Add(this.list_user);
            this.tp_user.Location = new System.Drawing.Point(4, 25);
            this.tp_user.Margin = new System.Windows.Forms.Padding(1);
            this.tp_user.Name = "tp_user";
            this.tp_user.Padding = new System.Windows.Forms.Padding(1);
            this.tp_user.Size = new System.Drawing.Size(823, 537);
            this.tp_user.TabIndex = 1;
            this.tp_user.Text = "회원 관리";
            this.tp_user.UseVisualStyleBackColor = true;
            // 
            // btn_user_search
            // 
            this.btn_user_search.BackColor = System.Drawing.Color.Wheat;
            this.btn_user_search.Enabled = false;
            this.btn_user_search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_user_search.Location = new System.Drawing.Point(534, 96);
            this.btn_user_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user_search.Name = "btn_user_search";
            this.btn_user_search.Size = new System.Drawing.Size(87, 35);
            this.btn_user_search.TabIndex = 79;
            this.btn_user_search.Text = "검색";
            this.btn_user_search.UseVisualStyleBackColor = false;
            this.btn_user_search.Click += new System.EventHandler(this.btn_user_search_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("맑은 고딕", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_user.Location = new System.Drawing.Point(23, 14);
            this.label_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(270, 50);
            this.label_user.TabIndex = 81;
            this.label_user.Text = "회원 정보 관리";
            // 
            // tb_user_search
            // 
            this.tb_user_search.Enabled = false;
            this.tb_user_search.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_user_search.Location = new System.Drawing.Point(31, 96);
            this.tb_user_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user_search.Name = "tb_user_search";
            this.tb_user_search.Size = new System.Drawing.Size(499, 38);
            this.tb_user_search.TabIndex = 73;
            this.tb_user_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_user_search_KeyPress);
            // 
            // btn_user_upd
            // 
            this.btn_user_upd.Enabled = false;
            this.btn_user_upd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_user_upd.Location = new System.Drawing.Point(655, 414);
            this.btn_user_upd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user_upd.Name = "btn_user_upd";
            this.btn_user_upd.Size = new System.Drawing.Size(112, 35);
            this.btn_user_upd.TabIndex = 80;
            this.btn_user_upd.Text = "회원 수정";
            this.btn_user_upd.UseVisualStyleBackColor = true;
            this.btn_user_upd.Click += new System.EventHandler(this.btn_user_upd_Click);
            // 
            // btn_user_insert
            // 
            this.btn_user_insert.Enabled = false;
            this.btn_user_insert.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_user_insert.Location = new System.Drawing.Point(655, 360);
            this.btn_user_insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user_insert.Name = "btn_user_insert";
            this.btn_user_insert.Size = new System.Drawing.Size(112, 35);
            this.btn_user_insert.TabIndex = 79;
            this.btn_user_insert.Text = "회원 등록";
            this.btn_user_insert.UseVisualStyleBackColor = true;
            this.btn_user_insert.Click += new System.EventHandler(this.btn_user_insert_Click);
            // 
            // list_user
            // 
            this.list_user.HideSelection = false;
            this.list_user.Location = new System.Drawing.Point(31, 149);
            this.list_user.Margin = new System.Windows.Forms.Padding(2);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(590, 362);
            this.list_user.TabIndex = 72;
            this.list_user.UseCompatibleStateImageBehavior = false;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(640, 20);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(165, 25);
            this.tb_password.TabIndex = 0;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(526, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 57;
            this.label2.Text = "비밀번호";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 619);
            this.Controls.Add(this.tp_book);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Manager";
            this.Text = "관리자 창";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.tp_book.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tp_user.ResumeLayout(false);
            this.tp_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tp_book;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_book_upd;
        private System.Windows.Forms.Button btn_book_add;
        private System.Windows.Forms.ListView booklist;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_book;
        private System.Windows.Forms.TabPage tp_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox tb_user_search;
        private System.Windows.Forms.Button btn_user_upd;
        private System.Windows.Forms.Button btn_user_search;
        private System.Windows.Forms.ListView list_user;
        private System.Windows.Forms.TextBox tb_book_search;
        private System.Windows.Forms.Button btn_user_insert;
        private System.Windows.Forms.Button btn_book_search;
    }
}