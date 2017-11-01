namespace Shop_analyzer
{
    partial class AddOrder
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
            this.inDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inLogin = new System.Windows.Forms.TextBox();
            this.inLid = new System.Windows.Forms.CheckBox();
            this.inInfo = new System.Windows.Forms.CheckBox();
            this.inCost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inNumMerch = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inNumMerch)).BeginInit();
            this.SuspendLayout();
            // 
            // inDate
            // 
            this.inDate.Location = new System.Drawing.Point(93, 12);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(152, 20);
            this.inDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поисковая система";
            // 
            // inSearch
            // 
            this.inSearch.Location = new System.Drawing.Point(131, 38);
            this.inSearch.Name = "inSearch";
            this.inSearch.Size = new System.Drawing.Size(114, 20);
            this.inSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // inLogin
            // 
            this.inLogin.Location = new System.Drawing.Point(131, 64);
            this.inLogin.Name = "inLogin";
            this.inLogin.Size = new System.Drawing.Size(114, 20);
            this.inLogin.TabIndex = 5;
            // 
            // inLid
            // 
            this.inLid.AutoSize = true;
            this.inLid.Location = new System.Drawing.Point(15, 165);
            this.inLid.Name = "inLid";
            this.inLid.Size = new System.Drawing.Size(110, 17);
            this.inLid.TabIndex = 10;
            this.inLid.Text = "Заказ завершён";
            this.inLid.UseVisualStyleBackColor = true;
            // 
            // inInfo
            // 
            this.inInfo.AutoSize = true;
            this.inInfo.Location = new System.Drawing.Point(15, 142);
            this.inInfo.Name = "inInfo";
            this.inInfo.Size = new System.Drawing.Size(176, 17);
            this.inInfo.TabIndex = 8;
            this.inInfo.Text = "Доп. информация запрошена";
            this.inInfo.UseVisualStyleBackColor = true;
            // 
            // inCost
            // 
            this.inCost.DecimalPlaces = 2;
            this.inCost.Location = new System.Drawing.Point(131, 90);
            this.inCost.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inCost.Name = "inCost";
            this.inCost.Size = new System.Drawing.Size(114, 20);
            this.inCost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стоимость заказа";
            // 
            // inNumMerch
            // 
            this.inNumMerch.Location = new System.Drawing.Point(151, 116);
            this.inNumMerch.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.inNumMerch.Name = "inNumMerch";
            this.inNumMerch.Size = new System.Drawing.Size(94, 20);
            this.inNumMerch.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кол-во товаров в заказе";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(170, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 195);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inNumMerch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inCost);
            this.Controls.Add(this.inInfo);
            this.Controls.Add(this.inLid);
            this.Controls.Add(this.inLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inDate);
            this.Name = "AddOrder";
            this.Text = "Добавление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.inCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inNumMerch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker inDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inLogin;
        private System.Windows.Forms.CheckBox inLid;
        private System.Windows.Forms.CheckBox inInfo;
        private System.Windows.Forms.NumericUpDown inCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inNumMerch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}