namespace Shop_analyzer
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.inRegister = new System.Windows.Forms.DateTimePicker();
            this.inLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // inRegister
            // 
            this.inRegister.Location = new System.Drawing.Point(128, 36);
            this.inRegister.Name = "inRegister";
            this.inRegister.Size = new System.Drawing.Size(156, 20);
            this.inRegister.TabIndex = 1;
            // 
            // inLogin
            // 
            this.inLogin.Location = new System.Drawing.Point(57, 10);
            this.inLogin.Name = "inLogin";
            this.inLogin.Size = new System.Drawing.Size(227, 20);
            this.inLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поисковая система";
            // 
            // inSearch
            // 
            this.inSearch.Location = new System.Drawing.Point(128, 62);
            this.inSearch.Name = "inSearch";
            this.inSearch.Size = new System.Drawing.Size(155, 20);
            this.inSearch.TabIndex = 5;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 93);
            this.Controls.Add(this.inSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inLogin);
            this.Controls.Add(this.inRegister);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(311, 131);
            this.MinimumSize = new System.Drawing.Size(311, 131);
            this.Name = "AddUser";
            this.Text = "Добавление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inRegister;
        private System.Windows.Forms.TextBox inLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inSearch;
    }
}