namespace SEEUMiner.App
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
            this.txtItems = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstNotNormalized = new System.Windows.Forms.ListBox();
            this.lstNormalized = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(28, 101);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(226, 20);
            this.txtItems.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstNotNormalized
            // 
            this.lstNotNormalized.FormattingEnabled = true;
            this.lstNotNormalized.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "4",
            "3",
            "2",
            "3",
            "1"});
            this.lstNotNormalized.Location = new System.Drawing.Point(340, 47);
            this.lstNotNormalized.Name = "lstNotNormalized";
            this.lstNotNormalized.Size = new System.Drawing.Size(48, 147);
            this.lstNotNormalized.TabIndex = 2;
            // 
            // lstNormalized
            // 
            this.lstNormalized.FormattingEnabled = true;
            this.lstNormalized.Location = new System.Drawing.Point(445, 47);
            this.lstNormalized.Name = "lstNormalized";
            this.lstNormalized.Size = new System.Drawing.Size(48, 147);
            this.lstNormalized.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstNormalized);
            this.Controls.Add(this.lstNotNormalized);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNotNormalized;
        private System.Windows.Forms.ListBox lstNormalized;
        private System.Windows.Forms.Button button2;
    }
}

