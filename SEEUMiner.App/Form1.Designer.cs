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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItems
            // 
            this.txtItems.Location = new System.Drawing.Point(28, 22);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(241, 20);
            this.txtItems.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 56);
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
            this.lstNotNormalized.Location = new System.Drawing.Point(313, 22);
            this.lstNotNormalized.Name = "lstNotNormalized";
            this.lstNotNormalized.Size = new System.Drawing.Size(89, 147);
            this.lstNotNormalized.TabIndex = 2;
            // 
            // lstNormalized
            // 
            this.lstNormalized.FormattingEnabled = true;
            this.lstNormalized.Location = new System.Drawing.Point(501, 22);
            this.lstNormalized.Name = "lstNormalized";
            this.lstNormalized.Size = new System.Drawing.Size(89, 147);
            this.lstNormalized.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstNormalized);
            this.Controls.Add(this.lstNotNormalized);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNotNormalized;
        private System.Windows.Forms.ListBox lstNormalized;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button3;

    }
}

