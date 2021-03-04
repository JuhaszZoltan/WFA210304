
namespace WFA210304
{
    partial class FrmVizsgak
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
            this.dgvVizsgak = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNyelvek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVizsgak
            // 
            this.dgvVizsgak.AllowUserToAddRows = false;
            this.dgvVizsgak.AllowUserToDeleteRows = false;
            this.dgvVizsgak.AllowUserToResizeColumns = false;
            this.dgvVizsgak.AllowUserToResizeRows = false;
            this.dgvVizsgak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVizsgak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVizsgak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvVizsgak.Location = new System.Drawing.Point(12, 70);
            this.dgvVizsgak.Name = "dgvVizsgak";
            this.dgvVizsgak.RowHeadersVisible = false;
            this.dgvVizsgak.RowHeadersWidth = 51;
            this.dgvVizsgak.RowTemplate.Height = 24;
            this.dgvVizsgak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVizsgak.Size = new System.Drawing.Size(776, 358);
            this.dgvVizsgak.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IDŐPONT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NYELV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SZINT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // cbNyelvek
            // 
            this.cbNyelvek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNyelvek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNyelvek.FormattingEnabled = true;
            this.cbNyelvek.Location = new System.Drawing.Point(238, 11);
            this.cbNyelvek.Name = "cbNyelvek";
            this.cbNyelvek.Size = new System.Drawing.Size(550, 33);
            this.cbNyelvek.TabIndex = 4;
            this.cbNyelvek.SelectedValueChanged += new System.EventHandler(this.CbNyelvekSelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "szűrés nyelv alapján:";
            // 
            // FrmVizsgak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNyelvek);
            this.Controls.Add(this.dgvVizsgak);
            this.Name = "FrmVizsgak";
            this.Text = "FrmVizsgak";
            this.Load += new System.EventHandler(this.FrmVizsgakLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVizsgak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbNyelvek;
        private System.Windows.Forms.Label label1;
    }
}