
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
            this.book_del.Location = new System.Drawing.Point(282, 467);
            this.book_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_del.Name = "book_del";
            this.book_del.Size = new System.Drawing.Size(99, 50);
            this.book_del.TabIndex = 6;
            this.book_del.Text = "삭제";
            this.book_del.UseVisualStyleBackColor = false;
            this.book_del.Click += new System.EventHandler(this.book_del_Click);
            // 
            // book_add
            // 
            this.book_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.book_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_add.Location = new System.Drawing.Point(125, 467);
            this.book_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_add.Name = "book_add";
            this.book_add.Size = new System.Drawing.Size(99, 50);
            this.book_add.TabIndex = 5;
            this.book_add.Text = "수정";
            this.book_add.UseVisualStyleBackColor = false;
            this.book_add.Click += new System.EventHandler(this.book_add_Click);
            // 
            // tb_bookyear
            // 
            this.tb_bookyear.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_bookyear.Location = new System.Drawing.Point(139, 314);
            this.tb_bookyear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bookyear.Name = "tb_bookyear";
            this.tb_bookyear.Size = new System.Drawing.Size(313, 34);
            this.tb_bookyear.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(52, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "발행일";
            // 
            // tb_book_count
            // 
            this.tb_book_count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_book_count.Location = new System.Drawing.Point(139, 375);
            this.tb_book_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_book_count.Name = "tb_book_count";
            this.tb_book_count.Size = new System.Drawing.Size(313, 34);
            this.tb_book_count.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(52, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "책 개수";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Enabled = false;
            this.tb_isbn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_isbn.Location = new System.Drawing.Point(139, 254);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(313, 34);
            this.tb_isbn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(52, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "ISBN";
            // 
            // tb_artist
            // 
            this.tb_artist.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_artist.Location = new System.Drawing.Point(139, 195);
            this.tb_artist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_artist.Name = "tb_artist";
            this.tb_artist.Size = new System.Drawing.Size(313, 34);
            this.tb_artist.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(52, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "도서명";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_id.Location = new System.Drawing.Point(138, 136);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(313, 34);
            this.tb_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(52, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(160, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 57);
            this.label1.TabIndex = 45;
            this.label1.Text = "도서 수정";
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 553);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookEdit";
            this.Text = "도서 수정";
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