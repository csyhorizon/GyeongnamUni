namespace Project
{
    partial class ReturnForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new ePOSOne.btnProduct.Button_WOC();
            this.btn_return = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(27, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 275);
            this.panel1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(27, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "제목";
            // 
            // tb_userID
            // 
            this.tb_userID.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_userID.Location = new System.Drawing.Point(128, 192);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(215, 31);
            this.tb_userID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "회원 ID";
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_name.Location = new System.Drawing.Point(128, 119);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(215, 31);
            this.tb_name.TabIndex = 68;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Font = new System.Drawing.Font("Consolas", 12F);
            this.tb_isbn.Location = new System.Drawing.Point(128, 45);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(215, 31);
            this.tb_isbn.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 47);
            this.label1.TabIndex = 69;
            this.label1.Text = "도서 반납";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancel.ButtonColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(251, 420);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_cancel.Size = new System.Drawing.Size(119, 52);
            this.btn_cancel.TabIndex = 73;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.TextColor = System.Drawing.Color.Red;
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_return.ButtonColor = System.Drawing.Color.White;
            this.btn_return.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(59, 420);
            this.btn_return.Name = "btn_return";
            this.btn_return.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_return.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_return.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_return.Size = new System.Drawing.Size(119, 52);
            this.btn_return.TabIndex = 74;
            this.btn_return.Text = "반납";
            this.btn_return.TextColor = System.Drawing.Color.Blue;
            this.btn_return.UseVisualStyleBackColor = false;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btn_cancel;
        private ePOSOne.btnProduct.Button_WOC btn_return;
    }
}