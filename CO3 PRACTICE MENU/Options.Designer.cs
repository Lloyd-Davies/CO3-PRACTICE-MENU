namespace CO3_PRACTICE_MENU
{
    partial class Options
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
            this.Boarderless = new System.Windows.Forms.Button();
            this.Boardered = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boarderless
            // 
            this.Boarderless.Location = new System.Drawing.Point(13, 227);
            this.Boarderless.Name = "Boarderless";
            this.Boarderless.Size = new System.Drawing.Size(75, 23);
            this.Boarderless.TabIndex = 0;
            this.Boarderless.Text = "Boarderless";
            this.Boarderless.UseVisualStyleBackColor = true;
            this.Boarderless.Click += new System.EventHandler(this.Boarderless_Click);
            // 
            // Boardered
            // 
            this.Boardered.Location = new System.Drawing.Point(13, 198);
            this.Boardered.Name = "Boardered";
            this.Boardered.Size = new System.Drawing.Size(75, 23);
            this.Boardered.TabIndex = 1;
            this.Boardered.Text = "Boardered";
            this.Boardered.UseVisualStyleBackColor = true;
            this.Boardered.Click += new System.EventHandler(this.Boardered_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(197, 227);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Boardered);
            this.Controls.Add(this.Boarderless);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boarderless;
        private System.Windows.Forms.Button Boardered;
        private System.Windows.Forms.Button Close;
    }
}