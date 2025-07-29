namespace Project
{
    partial class Mainform
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
            this.label_user = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.developer = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.RadioButton();
            this.id_text = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_user.Location = new System.Drawing.Point(351, 46);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(229, 86);
            this.label_user.TabIndex = 67;
            this.label_user.Text = "도서관";
            // 
            // user_id
            // 
            this.user_id.Font = new System.Drawing.Font("굴림", 12F);
            this.user_id.Location = new System.Drawing.Point(432, 237);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(305, 44);
            this.user_id.TabIndex = 68;
            // 
            // developer
            // 
            this.developer.AutoSize = true;
            this.developer.Font = new System.Drawing.Font("굴림", 15F);
            this.developer.Location = new System.Drawing.Point(112, 317);
            this.developer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(168, 44);
            this.developer.TabIndex = 70;
            this.developer.Text = "관리자";
            this.developer.UseVisualStyleBackColor = true;
            this.developer.CheckedChanged += new System.EventHandler(this.developer_CheckedChanged);
            // 
            // user
            // 
            this.user.AllowDrop = true;
            this.user.AutoSize = true;
            this.user.Checked = true;
            this.user.Font = new System.Drawing.Font("굴림", 15F);
            this.user.Location = new System.Drawing.Point(112, 242);
            this.user.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(168, 44);
            this.user.TabIndex = 71;
            this.user.TabStop = true;
            this.user.Text = "사용자";
            this.user.UseVisualStyleBackColor = true;
            this.user.CheckedChanged += new System.EventHandler(this.user_CheckedChanged);
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Font = new System.Drawing.Font("굴림", 12F);
            this.id_text.Location = new System.Drawing.Point(385, 242);
            this.id_text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(46, 32);
            this.id_text.TabIndex = 72;
            this.id_text.Text = "ID";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("굴림", 12F);
            this.btn_login.Location = new System.Drawing.Point(432, 317);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(275, 62);
            this.btn_login.TabIndex = 73;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 592);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.user);
            this.Controls.Add(this.developer);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label_user);
            this.Name = "Mainform";
            this.Text = "도서관리프로그램";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.RadioButton developer;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.Label id_text;
        private System.Windows.Forms.Button btn_login;
    }
}