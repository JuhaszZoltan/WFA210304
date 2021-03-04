
namespace WFA210304
{
    partial class FrmVizsgazo
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSzul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(142, 41);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 1;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(329, 146);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(101, 61);
            this.btnUj.TabIndex = 3;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.BtnUjClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // tbTel
            // 
            this.tbMobil.Location = new System.Drawing.Point(142, 133);
            this.tbMobil.Name = "tbTel";
            this.tbMobil.Size = new System.Drawing.Size(161, 22);
            this.tbMobil.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefonszám:";
            // 
            // tbSzul
            // 
            this.tbSzul.Location = new System.Drawing.Point(142, 179);
            this.tbSzul.Name = "tbSzul";
            this.tbSzul.Size = new System.Drawing.Size(161, 22);
            this.tbSzul.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Születési év:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(142, 87);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(161, 22);
            this.tbNev.TabIndex = 1;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(329, 79);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(101, 61);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Módosítás";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BtnModClick);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(329, 12);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(101, 61);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.BtnTorlesClick);
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 232);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbSzul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMobil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "FrmVizsgazo";
            this.Text = "FrmVizsgazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSzul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnTorles;
    }
}