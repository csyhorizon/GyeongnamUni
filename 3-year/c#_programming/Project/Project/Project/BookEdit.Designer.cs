
namespace Project
{
    partial class BookEdit
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
            this.book_del = new System.Windows.Forms.Button();
            this.book_add = new System.Windows.Forms.Button();
            this.tb_bookyear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_book_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_artist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // book_del
            // 
            this.book_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.book_del.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_del.Location = new System.Drawing.Point(208, 368);
            this.book_del.Name = "book_del";
            this.book_del.Size = new System.Drawing.Size(87, 40);
            this.book_del.TabIndex = 56;
            this.book_del.Text = "삭제";
            this.book_del.UseVisualStyleBackColor = false;
            this.book_del.Click += new System.EventHandler(this.book_del_Click);
            // 
            // book_add
            // 
            this.book_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.book_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_add.Location = new System.Drawing.Point(71, 368);
            this.book_add.Name = "book_add";
            this.book_add.Size = new System.Drawing.Size(87, 40);
            this.book_add.TabIndex = 57;
            this.book_add.Text = "수정";
            this.book_add.UseVisualStyleBackColor = false;
            this.book_add.Click += new System.EventHandler(this.book_add_Click);
            // 
            // tb_bookyear
            // 
            this.tb_bookyear.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_bookyear.Location = new System.Drawing.Point(150, 262);
            this.tb_bookyear.Name = "tb_bookyear";
            this.tb_bookyear.Size = new System.Drawing.Size(146, 29);
            this.tb_bookyear.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(70, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "발행일";
            // 
            // tb_book_count
            // 
            this.tb_book_count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_book_count.Location = new System.Drawing.Point(150, 311);
            this.tb_book_count.Name = "tb_book_count";
            this.tb_book_count.Size = new System.Drawing.Size(146, 29);
            this.tb_book_count.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(70, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "책 개수";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_isbn.Location = new System.Drawing.Point(150, 214);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(146, 29);
            this.tb_isbn.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(70, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "ISBN";
            // 
            // tb_artist
            // 
            this.tb_artist.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_artist.Location = new System.Drawing.Point(150, 167);
            this.tb_artist.Name = "tb_artist";
            this.tb_artist.Size = new System.Drawing.Size(146, 29);
            this.tb_artist.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(70, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "이름";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_id.Location = new System.Drawing.Point(149, 120);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(146, 29);
            this.tb_id.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(70, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 45;
            this.label1.Text = "도서 수정";
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.book_del);
            this.Controls.Add(this.book_add);
            this.Controls.Add(this.tb_bookyear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_book_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_artist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookEdit";
            this.Text = "BookEdit";
            this.Load += new System.EventHandler(this.BookEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button book_del;
        private System.Windows.Forms.Button book_add;
        private System.Windows.Forms.TextBox tb_bookyear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_book_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_artist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}