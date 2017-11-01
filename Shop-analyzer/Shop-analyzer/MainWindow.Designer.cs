namespace Shop_analyzer
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataEcons = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDelEcon = new System.Windows.Forms.Button();
            this.btnAddEcon = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEcons)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataUsers);
            this.groupBox1.Location = new System.Drawing.Point(639, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователи";
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.Location = new System.Drawing.Point(3, 16);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.Size = new System.Drawing.Size(353, 262);
            this.dataUsers.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataOrders);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 281);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказы";
            // 
            // dataOrders
            // 
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOrders.Location = new System.Drawing.Point(3, 16);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.Size = new System.Drawing.Size(622, 262);
            this.dataOrders.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataEcons);
            this.groupBox3.Location = new System.Drawing.Point(9, 292);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 260);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основные показатели (по месяцам)";
            // 
            // dataEcons
            // 
            this.dataEcons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEcons.Location = new System.Drawing.Point(3, 16);
            this.dataEcons.Name = "dataEcons";
            this.dataEcons.Size = new System.Drawing.Size(619, 241);
            this.dataEcons.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelOrder);
            this.groupBox4.Controls.Add(this.btnAddOrder);
            this.groupBox4.Location = new System.Drawing.Point(642, 293);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 95);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление заказами";
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(7, 62);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDelOrder.TabIndex = 1;
            this.btnDelOrder.Text = "Удалить";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(7, 33);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Добавить";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelUser);
            this.groupBox5.Controls.Add(this.btnAddUser);
            this.groupBox5.Location = new System.Drawing.Point(752, 293);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(109, 95);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление пользователями";
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(7, 62);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(96, 23);
            this.btnDelUser.TabIndex = 1;
            this.btnDelUser.Text = "Удалить";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(7, 33);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(96, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Добавить";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDelEcon);
            this.groupBox6.Controls.Add(this.btnAddEcon);
            this.groupBox6.Location = new System.Drawing.Point(886, 293);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(109, 95);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Управление показателями";
            // 
            // btnDelEcon
            // 
            this.btnDelEcon.Location = new System.Drawing.Point(7, 62);
            this.btnDelEcon.Name = "btnDelEcon";
            this.btnDelEcon.Size = new System.Drawing.Size(96, 23);
            this.btnDelEcon.TabIndex = 1;
            this.btnDelEcon.Text = "Удалить";
            this.btnDelEcon.UseVisualStyleBackColor = true;
            this.btnDelEcon.Click += new System.EventHandler(this.btnDelEcon_Click);
            // 
            // btnAddEcon
            // 
            this.btnAddEcon.Location = new System.Drawing.Point(7, 33);
            this.btnAddEcon.Name = "btnAddEcon";
            this.btnAddEcon.Size = new System.Drawing.Size(96, 23);
            this.btnAddEcon.TabIndex = 0;
            this.btnAddEcon.Text = "Добавить";
            this.btnAddEcon.UseVisualStyleBackColor = true;
            this.btnAddEcon.Click += new System.EventHandler(this.btnAddEcon_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCalc);
            this.groupBox7.Controls.Add(this.btnGraphs);
            this.groupBox7.Location = new System.Drawing.Point(649, 390);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(346, 53);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Рассчёт показателей";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(6, 19);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(172, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Рассчитать показатели";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnGraphs
            // 
            this.btnGraphs.Location = new System.Drawing.Point(184, 19);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(156, 23);
            this.btnGraphs.TabIndex = 1;
            this.btnGraphs.Text = "Построить графики";
            this.btnGraphs.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEcons)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataEcons;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDelEcon;
        private System.Windows.Forms.Button btnAddEcon;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnGraphs;
    }
}

