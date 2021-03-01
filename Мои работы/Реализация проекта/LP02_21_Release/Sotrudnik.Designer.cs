namespace LP02_21_Release
{
    partial class Sotrudnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotrudnik));
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTikets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.White;
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFlights.Location = new System.Drawing.Point(350, 182);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(200, 30);
            this.btnFlights.TabIndex = 0;
            this.btnFlights.Text = "Список рейсов";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEmployees.Location = new System.Drawing.Point(350, 216);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 30);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Список сотрудников";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTikets
            // 
            this.btnTikets.BackColor = System.Drawing.Color.White;
            this.btnTikets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTikets.Location = new System.Drawing.Point(350, 251);
            this.btnTikets.Name = "btnTikets";
            this.btnTikets.Size = new System.Drawing.Size(200, 30);
            this.btnTikets.TabIndex = 2;
            this.btnTikets.Text = "Список билетов";
            this.btnTikets.UseVisualStyleBackColor = false;
            this.btnTikets.Click += new System.EventHandler(this.btnTikets_Click);
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnTikets);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sotrudnik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню сотрудников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sotrudnik_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnTikets;
    }
}