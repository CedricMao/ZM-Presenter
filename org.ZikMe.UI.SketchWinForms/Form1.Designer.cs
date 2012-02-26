namespace org.ZikMe.UI.SketchWinForms
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
            this.btAction1 = new System.Windows.Forms.Button();
            this.btAction2 = new System.Windows.Forms.Button();
            this.lbDebug = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAction1
            // 
            this.btAction1.Location = new System.Drawing.Point(12, 12);
            this.btAction1.Name = "btAction1";
            this.btAction1.Size = new System.Drawing.Size(75, 23);
            this.btAction1.TabIndex = 0;
            this.btAction1.Text = "Connect !";
            this.btAction1.UseVisualStyleBackColor = true;
            this.btAction1.Click += new System.EventHandler(this.btAction1_Click);
            // 
            // btAction2
            // 
            this.btAction2.Location = new System.Drawing.Point(93, 12);
            this.btAction2.Name = "btAction2";
            this.btAction2.Size = new System.Drawing.Size(75, 23);
            this.btAction2.TabIndex = 1;
            this.btAction2.Text = "Get Tracks";
            this.btAction2.UseVisualStyleBackColor = true;
            this.btAction2.Click += new System.EventHandler(this.btAction2_Click);
            // 
            // lbDebug
            // 
            this.lbDebug.FormattingEnabled = true;
            this.lbDebug.Location = new System.Drawing.Point(12, 41);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(556, 251);
            this.lbDebug.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 300);
            this.Controls.Add(this.lbDebug);
            this.Controls.Add(this.btAction2);
            this.Controls.Add(this.btAction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAction1;
        private System.Windows.Forms.Button btAction2;
        private System.Windows.Forms.ListBox lbDebug;
    }
}

