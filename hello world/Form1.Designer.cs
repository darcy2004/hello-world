namespace hello_world
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 120);
            this.button1.TabIndex = 0;
            this.button1.Text = "hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(805, 85);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(100, 20);
            this.txtBxName.TabIndex = 1;
            this.txtBxName.Text = "whats your name?";
            // 
            // txtBxName2
            // 
            this.txtBxName2.Location = new System.Drawing.Point(606, 84);
            this.txtBxName2.Name = "txtBxName2";
            this.txtBxName2.Size = new System.Drawing.Size(100, 20);
            this.txtBxName2.TabIndex = 2;
            this.txtBxName2.Text = "im darcy!";
            this.txtBxName2.TextChanged += new System.EventHandler(this.TxtBxName2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 828);
            this.Controls.Add(this.txtBxName2);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxName2;
    }
}

