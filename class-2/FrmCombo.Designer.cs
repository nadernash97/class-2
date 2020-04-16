namespace class_2
{
    partial class FrmCombo
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
            this.btnssm1 = new System.Windows.Forms.Button();
            this.btnssm2 = new System.Windows.Forms.Button();
            this.btnrbn = new System.Windows.Forms.Button();
            this.btnrbi = new System.Windows.Forms.Button();
            this.btnrli = new System.Windows.Forms.Button();
            this.btnr2li = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnssm1
            // 
            this.btnssm1.Location = new System.Drawing.Point(94, 40);
            this.btnssm1.Name = "btnssm1";
            this.btnssm1.Size = new System.Drawing.Size(122, 68);
            this.btnssm1.TabIndex = 0;
            this.btnssm1.Text = "Show Selcted Method 1";
            this.btnssm1.UseVisualStyleBackColor = true;
            this.btnssm1.Click += new System.EventHandler(this.btnssm1_Click);
            // 
            // btnssm2
            // 
            this.btnssm2.Location = new System.Drawing.Point(353, 40);
            this.btnssm2.Name = "btnssm2";
            this.btnssm2.Size = new System.Drawing.Size(122, 68);
            this.btnssm2.TabIndex = 1;
            this.btnssm2.Text = "Show Selected Method 2";
            this.btnssm2.UseVisualStyleBackColor = true;
            this.btnssm2.Click += new System.EventHandler(this.btnssm2_Click);
            // 
            // btnrbn
            // 
            this.btnrbn.Location = new System.Drawing.Point(353, 302);
            this.btnrbn.Name = "btnrbn";
            this.btnrbn.Size = new System.Drawing.Size(128, 64);
            this.btnrbn.TabIndex = 2;
            this.btnrbn.Text = "Remove by Name";
            this.btnrbn.UseVisualStyleBackColor = true;
            this.btnrbn.Click += new System.EventHandler(this.btnrbn_Click);
            // 
            // btnrbi
            // 
            this.btnrbi.Location = new System.Drawing.Point(94, 302);
            this.btnrbi.Name = "btnrbi";
            this.btnrbi.Size = new System.Drawing.Size(128, 64);
            this.btnrbi.TabIndex = 3;
            this.btnrbi.Text = "Remove By index";
            this.btnrbi.UseVisualStyleBackColor = true;
            this.btnrbi.Click += new System.EventHandler(this.btnrbi_Click);
            // 
            // btnrli
            // 
            this.btnrli.Location = new System.Drawing.Point(589, 88);
            this.btnrli.Name = "btnrli";
            this.btnrli.Size = new System.Drawing.Size(130, 44);
            this.btnrli.TabIndex = 4;
            this.btnrli.Text = "Remove last item";
            this.btnrli.UseVisualStyleBackColor = true;
            // 
            // btnr2li
            // 
            this.btnr2li.Location = new System.Drawing.Point(589, 183);
            this.btnr2li.Name = "btnr2li";
            this.btnr2li.Size = new System.Drawing.Size(130, 44);
            this.btnr2li.TabIndex = 5;
            this.btnr2li.Text = "Remove 2nd last item";
            this.btnr2li.UseVisualStyleBackColor = true;
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(121, 183);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(329, 24);
            this.CmbDays.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(589, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 44);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.btnr2li);
            this.Controls.Add(this.btnrli);
            this.Controls.Add(this.btnrbi);
            this.Controls.Add(this.btnrbn);
            this.Controls.Add(this.btnssm2);
            this.Controls.Add(this.btnssm1);
            this.Name = "FrmCombo";
            this.Text = "Form Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnssm1;
        private System.Windows.Forms.Button btnssm2;
        private System.Windows.Forms.Button btnrbn;
        private System.Windows.Forms.Button btnrbi;
        private System.Windows.Forms.Button btnrli;
        private System.Windows.Forms.Button btnr2li;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button btnBack;
    }
}