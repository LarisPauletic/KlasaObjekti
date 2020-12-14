namespace KlaseObjekti
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
            this.txtUnosS = new System.Windows.Forms.TextBox();
            this.txtUnosI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUnosS
            // 
            this.txtUnosS.Location = new System.Drawing.Point(65, 32);
            this.txtUnosS.Name = "txtUnosS";
            this.txtUnosS.Size = new System.Drawing.Size(100, 22);
            this.txtUnosS.TabIndex = 0;
            // 
            // txtUnosI
            // 
            this.txtUnosI.Location = new System.Drawing.Point(65, 101);
            this.txtUnosI.Name = "txtUnosI";
            this.txtUnosI.Size = new System.Drawing.Size(100, 22);
            this.txtUnosI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unos stringa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unos int";
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(316, 100);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 4;
            this.btnIspis.Text = "Ispisi";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(316, 32);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(65, 177);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(326, 181);
            this.txtIspis.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosI);
            this.Controls.Add(this.txtUnosS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosS;
        private System.Windows.Forms.TextBox txtUnosI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

