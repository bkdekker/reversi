namespace Reversi
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
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_rood = new System.Windows.Forms.Panel();
            this.panel_blauw = new System.Windows.Forms.Panel();
            this.label_rood = new System.Windows.Forms.Label();
            this.label_blauw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(14, 107);
            this.Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(562, 625);
            this.Panel.TabIndex = 0;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(14, 60);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(138, 29);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Nieuw Spel";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rood begint";
            // 
            // panel_rood
            // 
            this.panel_rood.Location = new System.Drawing.Point(318, 12);
            this.panel_rood.Name = "panel_rood";
            this.panel_rood.Size = new System.Drawing.Size(65, 65);
            this.panel_rood.TabIndex = 3;
            this.panel_rood.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rood_Paint);
            // 
            // panel_blauw
            // 
            this.panel_blauw.Location = new System.Drawing.Point(434, 13);
            this.panel_blauw.Name = "panel_blauw";
            this.panel_blauw.Size = new System.Drawing.Size(65, 65);
            this.panel_blauw.TabIndex = 4;
            this.panel_blauw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_blauw_Paint);
            // 
            // label_rood
            // 
            this.label_rood.AutoSize = true;
            this.label_rood.Location = new System.Drawing.Point(314, 81);
            this.label_rood.Name = "label_rood";
            this.label_rood.Size = new System.Drawing.Size(51, 20);
            this.label_rood.TabIndex = 5;
            this.label_rood.Text = "label2";
            // 
            // label_blauw
            // 
            this.label_blauw.AutoSize = true;
            this.label_blauw.Location = new System.Drawing.Point(430, 81);
            this.label_blauw.Name = "label_blauw";
            this.label_blauw.Size = new System.Drawing.Size(51, 20);
            this.label_blauw.TabIndex = 6;
            this.label_blauw.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 747);
            this.Controls.Add(this.label_blauw);
            this.Controls.Add(this.label_rood);
            this.Controls.Add(this.panel_blauw);
            this.Controls.Add(this.panel_rood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_rood;
        private System.Windows.Forms.Panel panel_blauw;
        private System.Windows.Forms.Label label_rood;
        private System.Windows.Forms.Label label_blauw;
    }
}
