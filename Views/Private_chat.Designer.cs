namespace Views
{
    partial class Private_chat
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
            this.groupBox_private = new System.Windows.Forms.GroupBox();
            this.button_senden = new System.Windows.Forms.Button();
            this.textBox_private = new System.Windows.Forms.TextBox();
            this.listBox_private = new System.Windows.Forms.ListBox();
            this.groupBox_private.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_private
            // 
            this.groupBox_private.Controls.Add(this.button_senden);
            this.groupBox_private.Controls.Add(this.textBox_private);
            this.groupBox_private.Controls.Add(this.listBox_private);
            this.groupBox_private.Location = new System.Drawing.Point(46, 81);
            this.groupBox_private.Name = "groupBox_private";
            this.groupBox_private.Size = new System.Drawing.Size(554, 344);
            this.groupBox_private.TabIndex = 7;
            this.groupBox_private.TabStop = false;
            this.groupBox_private.Text = "Private Chat";
            // 
            // button_senden
            // 
            this.button_senden.Location = new System.Drawing.Point(446, 284);
            this.button_senden.Name = "button_senden";
            this.button_senden.Size = new System.Drawing.Size(75, 23);
            this.button_senden.TabIndex = 4;
            this.button_senden.Text = "senden";
            this.button_senden.UseVisualStyleBackColor = true;
            // 
            // textBox_private
            // 
            this.textBox_private.Location = new System.Drawing.Point(32, 287);
            this.textBox_private.Name = "textBox_private";
            this.textBox_private.Size = new System.Drawing.Size(411, 20);
            this.textBox_private.TabIndex = 5;
            // 
            // listBox_private
            // 
            this.listBox_private.FormattingEnabled = true;
            this.listBox_private.Location = new System.Drawing.Point(32, 56);
            this.listBox_private.Name = "listBox_private";
            this.listBox_private.Size = new System.Drawing.Size(485, 225);
            this.listBox_private.TabIndex = 3;
            // 
            // Private_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 477);
            this.Controls.Add(this.groupBox_private);
            this.Name = "Private_chat";
            this.Text = "Private_chatcs";
            this.groupBox_private.ResumeLayout(false);
            this.groupBox_private.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_private;
        private System.Windows.Forms.Button button_senden;
        private System.Windows.Forms.TextBox textBox_private;
        private System.Windows.Forms.ListBox listBox_private;
    }
}