namespace LP02_21_Release
{
    partial class Tikets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tikets));
            this.dataGridTikets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTikets)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTikets
            // 
            this.dataGridTikets.AllowUserToAddRows = false;
            this.dataGridTikets.AllowUserToDeleteRows = false;
            this.dataGridTikets.AllowUserToResizeColumns = false;
            this.dataGridTikets.AllowUserToResizeRows = false;
            this.dataGridTikets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTikets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTikets.Location = new System.Drawing.Point(11, 42);
            this.dataGridTikets.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridTikets.MultiSelect = false;
            this.dataGridTikets.Name = "dataGridTikets";
            this.dataGridTikets.ReadOnly = true;
            this.dataGridTikets.RowHeadersVisible = false;
            this.dataGridTikets.RowHeadersWidth = 51;
            this.dataGridTikets.RowTemplate.Height = 24;
            this.dataGridTikets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTikets.Size = new System.Drawing.Size(862, 408);
            this.dataGridTikets.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(382, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список билетов";
            // 
            // Tikets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTikets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tikets";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список билетов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tikets_FormClosed);
            this.Load += new System.EventHandler(this.Tikets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTikets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTikets;
        private System.Windows.Forms.Label label1;
    }
}