
namespace Project
{
    partial class BookAdd
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
            this.cancel = new System.Windows.Forms.Button();
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
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel.Location = new System.Drawing.Point(284, 467);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 50);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "취소";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // book_add
            // 
            this.book_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.book_add.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_add.Location = new System.Drawing.Point(128, 467);
            this.book_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_add.Name = "book_add";
            this.book_add.Size = new System.Drawing.Size(99, 50);
            this.book_add.TabIndex = 5;
            this.book_add.Text = "추가";
            this.book_add.UseVisualStyleBackColor = false;
            this.book_add.Click += new System.EventHandler(this.book_add_Click);
            // 
            // tb_bookyear
            // 
            this.tb_bookyear.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_bookyear.Location = new System.Drawing.Point(151, 326);
            this.tb_bookyear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bookyear.Name = "tb_bookyear";
            this.tb_bookyear.Size = new System.Drawing.Size(292, 34);
            this.tb_bookyear.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "발행일";
            // 
            // tb_book_count
            // 
            this.tb_book_count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_book_count.Location = new System.Drawing.Point(151, 388);
            this.tb_book_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_book_count.Name = "tb_book_count";
            this.tb_book_count.Size = new System.Drawing.Size(292, 34);
            this.tb_book_count.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(59, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "책 개수";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_isbn.Location = new System.Drawing.Point(151, 266);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(292, 34);
            this.tb_isbn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(59, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "ISBN";
            // 
            // tb_artist
            // 
            this.tb_artist.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_artist.Location = new System.Drawing.Point(151, 208);
            this.tb_artist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_artist.Name = "tb_artist";
            this.tb_artist.Size = new System.Drawing.Size(292, 34);
            this.tb_artist.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(59, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "도서명";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_id.Location = new System.Drawing.Point(150, 149);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(292, 34);
            this.tb_id.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(59, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "저자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 57);
            this.label1.TabIndex = 32;
            this.label1.Text = "도서 추가";
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 553);
            this.Controls.Add(this.cancel);
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
            this.Name = "BookAdd";
            this.Text = "도서 추가";
            this.Load += new System.EventHandler(this.BookAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
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