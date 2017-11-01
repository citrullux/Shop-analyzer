namespace Shop_analyzer
{
    partial class AddEcon
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
            this.inSave = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.inMonth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inEn = new System.Windows.Forms.NumericUpDown();
            this.inHost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inProg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inCliManager = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.inPromotion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCliManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // inSave
            // 
            this.inSave.DecimalPlaces = 2;
            this.inSave.Location = new System.Drawing.Point(173, 11);
            this.inSave.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.inSave.Name = "inSave";
            this.inSave.Size = new System.Drawing.Size(110, 20);
            this.inSave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Экономия (прибыль) в месяц";
            // 
            // inMonth
            // 
            this.inMonth.Location = new System.Drawing.Point(58, 167);
            this.inMonth.Name = "inMonth";
            this.inMonth.Size = new System.Drawing.Size(137, 20);
            this.inMonth.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Эффективность вложений";
            // 
            // inEn
            // 
            this.inEn.DecimalPlaces = 2;
            this.inEn.Location = new System.Drawing.Point(173, 37);
            this.inEn.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inEn.Name = "inEn";
            this.inEn.Size = new System.Drawing.Size(110, 20);
            this.inEn.TabIndex = 5;
            // 
            // inHost
            // 
            this.inHost.DecimalPlaces = 2;
            this.inHost.Location = new System.Drawing.Point(173, 63);
            this.inHost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inHost.Name = "inHost";
            this.inHost.Size = new System.Drawing.Size(110, 20);
            this.inHost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Затраты на хостинг";
            // 
            // inProg
            // 
            this.inProg.DecimalPlaces = 2;
            this.inProg.Location = new System.Drawing.Point(173, 89);
            this.inProg.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inProg.Name = "inProg";
            this.inProg.Size = new System.Drawing.Size(110, 20);
            this.inProg.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Зарплата програмиста";
            // 
            // inCliManager
            // 
            this.inCliManager.DecimalPlaces = 2;
            this.inCliManager.Location = new System.Drawing.Point(173, 115);
            this.inCliManager.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inCliManager.Name = "inCliManager";
            this.inCliManager.Size = new System.Drawing.Size(110, 20);
            this.inCliManager.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Зарплата клиент-мэнеджера";
            // 
            // inPromotion
            // 
            this.inPromotion.DecimalPlaces = 2;
            this.inPromotion.Location = new System.Drawing.Point(173, 141);
            this.inPromotion.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.inPromotion.Name = "inPromotion";
            this.inPromotion.Size = new System.Drawing.Size(110, 20);
            this.inPromotion.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Реклама и продвижение";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddEcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 197);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inPromotion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inCliManager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inProg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inEn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inSave);
            this.MaximumSize = new System.Drawing.Size(312, 236);
            this.MinimumSize = new System.Drawing.Size(312, 236);
            this.Name = "AddEcon";
            this.Text = "AddEcon";
            ((System.ComponentModel.ISupportInitialize)(this.inSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCliManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPromotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown inSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inEn;
        private System.Windows.Forms.NumericUpDown inHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inProg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inCliManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inPromotion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
    }
}