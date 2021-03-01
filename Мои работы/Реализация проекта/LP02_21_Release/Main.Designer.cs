namespace LP02_21_Release
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnEntryEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntry.Location = new System.Drawing.Point(25, 90);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(200, 28);
            this.btnEntry.TabIndex = 0;
            this.btnEntry.Text = "Вход";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(25, 122);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(200, 28);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnEntryEmployee
            // 
            this.btnEntryEmployee.BackColor = System.Drawing.Color.White;
            this.btnEntryEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntryEmployee.Location = new System.Drawing.Point(723, 11);
            this.btnEntryEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntryEmployee.Name = "btnEntryEmployee";
            this.btnEntryEmployee.Size = new System.Drawing.Size(150, 25);
            this.btnEntryEmployee.TabIndex = 2;
            this.btnEntryEmployee.Text = "Войти как сотрудник";
            this.btnEntryEmployee.UseVisualStyleBackColor = false;
            this.btnEntryEmployee.Click += new System.EventHandler(this.btnEntryEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnEntry);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Location = new System.Drawing.Point(325, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEntryEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnEntryEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

