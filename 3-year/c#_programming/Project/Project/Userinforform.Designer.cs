namespace Project
{
    partial class Userinforform
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
            this.remove = new System.Windows.Forms.Button();
            this.tb_id_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remove.Location = new System.Drawing.Point(552, 864);
            this.remove.Margin = new System.Windows.Forms.Padding(4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(249, 70);
            this.remove.TabIndex = 52;
            this.remove.Text = "탈퇴";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // tb_id_number
            // 
            this.tb_id_number.Location = new System.Drawing.Point(293, 480);
            this.tb_id_number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id_number.Name = "tb_id_number";
            this.tb_id_number.Size = new System.Drawing.Size(574, 35);
            this.tb_id_number.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(52, 480);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 51);
            this.label5.TabIndex = 50;
            this.label5.Text = "주민등록번호";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(297, 352);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(574, 35);
            this.tb_phone.TabIndex = 49;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(297, 622);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(574, 35);
            this.tb_email.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(52, 608);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 51);
            this.label3.TabIndex = 47;
            this.label3.Text = "이메일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(52, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 51);
            this.label4.TabIndex = 46;
            this.label4.Text = "전화번호";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(605, 206);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(266, 35);
            this.tb_id.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(470, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 51);
            this.label2.TabIndex = 44;
            this.label2.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(52, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 51);
            this.label1.TabIndex = 43;
            this.label1.Text = "이름";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(152, 206);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(281, 35);
            this.tb_name.TabIndex = 42;
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.edit.Location = new System.Drawing.Point(152, 864);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(251, 70);
            this.edit.TabIndex = 41;
            this.edit.Text = "수정";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_user.Location = new System.Drawing.Point(323, 52);
            this.label_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(293, 86);
            this.label_user.TabIndex = 40;
            this.label_user.Text = "회원정보";
            // 
            // Userinforform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 986);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.tb_id_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label_user);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Userinforform";
            this.Text = "회원정보 관리";
            this.Load += new System.EventHandler(this.Userform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox tb_id_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label_user;
    }
}