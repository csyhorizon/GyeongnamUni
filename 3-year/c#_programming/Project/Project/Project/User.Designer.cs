namespace Project
{
    partial class User
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
            this.tb_book_search = new System.Windows.Forms.TextBox();
            this.label_manager = new System.Windows.Forms.Label();
            this.booklist = new System.Windows.Forms.ListView();
            this.userID = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.logout = new ePOSOne.btnProduct.Button_WOC();
            this.btn_book_rental = new ePOSOne.btnProduct.Button_WOC();
            this.btn_book_return = new ePOSOne.btnProduct.Button_WOC();
            this.btn_book_search = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // tb_book_search
            // 
            this.tb_book_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_book_search.Font = new System.Drawing.Font("굴림", 21F);
            this.tb_book_search.Location = new System.Drawing.Point(11, 97);
            this.tb_book_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_book_search.Name = "tb_book_search";
            this.tb_book_search.Size = new System.Drawing.Size(589, 48);
            this.tb_book_search.TabIndex = 97;
            this.tb_book_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_book_search_KeyPress);
            // 
            // label_manager
            // 
            this.label_manager.AutoSize = true;
            this.label_manager.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manager.Location = new System.Drawing.Point(280, 18);
            this.label_manager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_manager.Name = "label_manager";
            this.label_manager.Size = new System.Drawing.Size(186, 51);
            this.label_manager.TabIndex = 96;
            this.label_manager.Text = "도서 대여";
            // 
            // booklist
            // 
            this.booklist.HideSelection = false;
            this.booklist.Location = new System.Drawing.Point(11, 164);
            this.booklist.Margin = new System.Windows.Forms.Padding(2);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(731, 453);
            this.booklist.TabIndex = 93;
            this.booklist.UseCompatibleStateImageBehavior = false;
            // 
            // userID
            // 
            this.userID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(466, 20);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(168, 20);
            this.userID.TabIndex = 99;
            this.userID.Text = "User ID";
            this.userID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logout
            // 
            this.logout.BorderColor = System.Drawing.Color.Silver;
            this.logout.ButtonColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Consolas", 9F);
            this.logout.Image = global::Project.Properties.Resources.logout;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.Location = new System.Drawing.Point(640, 18);
            this.logout.Name = "logout";
            this.logout.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.logout.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.logout.OnHoverTextColor = System.Drawing.Color.Gray;
            this.logout.Size = new System.Drawing.Size(102, 30);
            this.logout.TabIndex = 104;
            this.logout.Text = "로그아웃";
            this.logout.TextColor = System.Drawing.Color.Black;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // btn_book_rental
            // 
            this.btn_book_rental.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_book_rental.ButtonColor = System.Drawing.Color.White;
            this.btn_book_rental.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_rental.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_book_rental.Location = new System.Drawing.Point(148, 641);
            this.btn_book_rental.Name = "btn_book_rental";
            this.btn_book_rental.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_book_rental.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btn_book_rental.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_book_rental.Size = new System.Drawing.Size(174, 53);
            this.btn_book_rental.TabIndex = 103;
            this.btn_book_rental.Text = "도서 대여";
            this.btn_book_rental.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_book_rental.UseVisualStyleBackColor = true;
            this.btn_book_rental.Click += new System.EventHandler(this.btn_book_rental_Click);
            // 
            // btn_book_return
            // 
            this.btn_book_return.BackColor = System.Drawing.Color.White;
            this.btn_book_return.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_book_return.ButtonColor = System.Drawing.Color.White;
            this.btn_book_return.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_return.Location = new System.Drawing.Point(446, 641);
            this.btn_book_return.Name = "btn_book_return";
            this.btn_book_return.OnHoverBorderColor = System.Drawing.Color.DarkGray;
            this.btn_book_return.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btn_book_return.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_book_return.Size = new System.Drawing.Size(174, 53);
            this.btn_book_return.TabIndex = 102;
            this.btn_book_return.Text = "도서 반납";
            this.btn_book_return.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_book_return.UseVisualStyleBackColor = false;
            this.btn_book_return.Click += new System.EventHandler(this.btn_book_return_Click);
            // 
            // btn_book_search
            // 
            this.btn_book_search.BackColor = System.Drawing.Color.White;
            this.btn_book_search.BorderColor = System.Drawing.Color.Snow;
            this.btn_book_search.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_book_search.Font = new System.Drawing.Font("Consolas", 13F);
            this.btn_book_search.Location = new System.Drawing.Point(605, 95);
            this.btn_book_search.Name = "btn_book_search";
            this.btn_book_search.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_book_search.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btn_book_search.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_book_search.Size = new System.Drawing.Size(137, 52);
            this.btn_book_search.TabIndex = 101;
            this.btn_book_search.Text = "검색";
            this.btn_book_search.TextColor = System.Drawing.Color.White;
            this.btn_book_search.UseVisualStyleBackColor = false;
            this.btn_book_search.Click += new System.EventHandler(this.btn_book_search_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 724);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.btn_book_rental);
            this.Controls.Add(this.btn_book_return);
            this.Controls.Add(this.btn_book_search);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.tb_book_search);
            this.Controls.Add(this.label_manager);
            this.Controls.Add(this.booklist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "User";
            this.Text = "도서 관리 프로그램";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_book_search;
        private System.Windows.Forms.Label label_manager;
        private System.Windows.Forms.ListView booklist;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ePOSOne.btnProduct.Button_WOC btn_book_search;
        private ePOSOne.btnProduct.Button_WOC btn_book_return;
        private ePOSOne.btnProduct.Button_WOC btn_book_rental;
        private ePOSOne.btnProduct.Button_WOC logout;
    }
}