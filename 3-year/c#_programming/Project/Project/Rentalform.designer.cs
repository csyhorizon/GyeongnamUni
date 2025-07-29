namespace Project
{
    partial class Rentalform
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
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.book_rental = new ePOSOne.btnProduct.Button_WOC();
            this.book_cancel = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_userID
            // 
            this.tb_userID.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_userID.Location = new System.Drawing.Point(208, 307);
            this.tb_userID.Margin = new System.Windows.Forms.Padding(5);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(347, 45);
            this.tb_userID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(44, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 41);
            this.label5.TabIndex = 60;
            this.label5.Text = "회원 ID";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Enabled = false;
            this.tb_isbn.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_isbn.Location = new System.Drawing.Point(208, 72);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(5);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(347, 45);
            this.tb_isbn.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(44, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 41);
            this.label4.TabIndex = 61;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(44, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 41);
            this.label3.TabIndex = 62;
            this.label3.Text = "제목";
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_name.Location = new System.Drawing.Point(208, 190);
            this.tb_name.Margin = new System.Windows.Forms.Padding(5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(347, 45);
            this.tb_name.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 75);
            this.label1.TabIndex = 58;
            this.label1.Text = "도서 대여";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_userID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_isbn);
            this.panel1.Location = new System.Drawing.Point(47, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 440);
            this.panel1.TabIndex = 71;
            // 
            // book_rental
            // 
            this.book_rental.BackColor = System.Drawing.Color.White;
            this.book_rental.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.book_rental.ButtonColor = System.Drawing.Color.White;
            this.book_rental.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_rental.Location = new System.Drawing.Point(99, 659);
            this.book_rental.Margin = new System.Windows.Forms.Padding(5);
            this.book_rental.Name = "book_rental";
            this.book_rental.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.book_rental.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.book_rental.OnHoverTextColor = System.Drawing.Color.Gray;
            this.book_rental.Size = new System.Drawing.Size(193, 83);
            this.book_rental.TabIndex = 72;
            this.book_rental.Text = "대여";
            this.book_rental.TextColor = System.Drawing.Color.Blue;
            this.book_rental.UseVisualStyleBackColor = false;
            this.book_rental.Click += new System.EventHandler(this.book_rental_Click);
            // 
            // book_cancel
            // 
            this.book_cancel.BackColor = System.Drawing.Color.White;
            this.book_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.book_cancel.ButtonColor = System.Drawing.Color.White;
            this.book_cancel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_cancel.Location = new System.Drawing.Point(411, 659);
            this.book_cancel.Margin = new System.Windows.Forms.Padding(5);
            this.book_cancel.Name = "book_cancel";
            this.book_cancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.book_cancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.book_cancel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.book_cancel.Size = new System.Drawing.Size(193, 83);
            this.book_cancel.TabIndex = 72;
            this.book_cancel.Text = "취소";
            this.book_cancel.TextColor = System.Drawing.Color.Red;
            this.book_cancel.UseVisualStyleBackColor = false;
            // 
            // Rentalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 805);
            this.Controls.Add(this.book_cancel);
            this.Controls.Add(this.book_rental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Rentalform";
            this.Text = "도서 대여";
            this.Load += new System.EventHandler(this.Rentalform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC book_rental;
        private ePOSOne.btnProduct.Button_WOC book_cancel;
    }
}