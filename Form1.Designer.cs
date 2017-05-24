namespace KlientTCP
{
    partial class Form1
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
            this.przycisk = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(240, 170);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(75, 23);
            this.przycisk.TabIndex = 0;
            this.przycisk.Text = "Zamknij";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(-1, 199);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(316, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "połącz";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(12, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(168, 20);
            this.Adres.TabIndex = 2;
            this.Adres.Text = "Adres";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(195, 12);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(120, 20);
            this.Port.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 121);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.ListBox listBox1;
    }
}

