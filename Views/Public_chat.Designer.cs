namespace Views
{
    partial class Public_chat
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
            this.groupBox_public = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_senden_public = new System.Windows.Forms.Button();
            this.textBox_public = new System.Windows.Forms.TextBox();
            this.listBox_akt_online = new System.Windows.Forms.ListBox();
            this.listBox_chat_public = new System.Windows.Forms.ListBox();
            this.groupBox_public.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_public
            // 
            this.groupBox_public.Controls.Add(this.label2);
            this.groupBox_public.Controls.Add(this.button_senden_public);
            this.groupBox_public.Controls.Add(this.textBox_public);
            this.groupBox_public.Controls.Add(this.listBox_akt_online);
            this.groupBox_public.Controls.Add(this.listBox_chat_public);
            this.groupBox_public.Location = new System.Drawing.Point(33, 73);
            this.groupBox_public.Name = "groupBox_public";
            this.groupBox_public.Size = new System.Drawing.Size(681, 344);
            this.groupBox_public.TabIndex = 8;
            this.groupBox_public.TabStop = false;
            this.groupBox_public.Text = "Öffentlicher Chatraum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktuell Online:";
            // 
            // button_senden_public
            // 
            this.button_senden_public.Location = new System.Drawing.Point(546, 281);
            this.button_senden_public.Name = "button_senden_public";
            this.button_senden_public.Size = new System.Drawing.Size(75, 23);
            this.button_senden_public.TabIndex = 4;
            this.button_senden_public.Text = "senden";
            this.button_senden_public.UseVisualStyleBackColor = true;
            // 
            // textBox_public
            // 
            this.textBox_public.Location = new System.Drawing.Point(132, 284);
            this.textBox_public.Name = "textBox_public";
            this.textBox_public.Size = new System.Drawing.Size(411, 20);
            this.textBox_public.TabIndex = 5;
            // 
            // listBox_akt_online
            // 
            this.listBox_akt_online.FormattingEnabled = true;
            this.listBox_akt_online.Location = new System.Drawing.Point(6, 53);
            this.listBox_akt_online.Name = "listBox_akt_online";
            this.listBox_akt_online.Size = new System.Drawing.Size(120, 251);
            this.listBox_akt_online.TabIndex = 2;
            // 
            // listBox_chat_public
            // 
            this.listBox_chat_public.FormattingEnabled = true;
            this.listBox_chat_public.Location = new System.Drawing.Point(132, 53);
            this.listBox_chat_public.Name = "listBox_chat_public";
            this.listBox_chat_public.Size = new System.Drawing.Size(485, 225);
            this.listBox_chat_public.TabIndex = 3;
            // 
            // Public_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 491);
            this.Controls.Add(this.groupBox_public);
            this.Name = "Public_chat";
            this.Text = "Public_chat";
            this.groupBox_public.ResumeLayout(false);
            this.groupBox_public.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_public;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_senden_public;
        private System.Windows.Forms.TextBox textBox_public;
        private System.Windows.Forms.ListBox listBox_akt_online;
        private System.Windows.Forms.ListBox listBox_chat_public;
    }
}