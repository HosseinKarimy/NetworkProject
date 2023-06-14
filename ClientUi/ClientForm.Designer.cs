namespace ClientUi
{
    partial class ClientForm
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
            this.Button_Process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_NewText = new System.Windows.Forms.TextBox();
            this.RichTextBox_AllContext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Button_Process
            // 
            this.Button_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Process.Location = new System.Drawing.Point(533, 184);
            this.Button_Process.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Button_Process.Name = "Button_Process";
            this.Button_Process.Size = new System.Drawing.Size(247, 42);
            this.Button_Process.TabIndex = 0;
            this.Button_Process.Text = "افزودن به دفتر یادداشت و مشاهده کامل دفتر یادداشت";
            this.Button_Process.UseVisualStyleBackColor = true;
            this.Button_Process.Click += new System.EventHandler(this.Button_Process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "متن جدید:";
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.Location = new System.Drawing.Point(567, 15);
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(147, 31);
            this.TextBox_UserName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام کاربری:";
            // 
            // TextBox_NewText
            // 
            this.TextBox_NewText.Location = new System.Drawing.Point(18, 87);
            this.TextBox_NewText.Multiline = true;
            this.TextBox_NewText.Name = "TextBox_NewText";
            this.TextBox_NewText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_NewText.Size = new System.Drawing.Size(762, 88);
            this.TextBox_NewText.TabIndex = 5;
            // 
            // RichTextBox_AllContext
            // 
            this.RichTextBox_AllContext.Location = new System.Drawing.Point(18, 235);
            this.RichTextBox_AllContext.Name = "RichTextBox_AllContext";
            this.RichTextBox_AllContext.ReadOnly = true;
            this.RichTextBox_AllContext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RichTextBox_AllContext.Size = new System.Drawing.Size(762, 355);
            this.RichTextBox_AllContext.TabIndex = 6;
            this.RichTextBox_AllContext.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 602);
            this.Controls.Add(this.RichTextBox_AllContext);
            this.Controls.Add(this.TextBox_NewText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Process);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClientForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_NewText;
        private System.Windows.Forms.RichTextBox RichTextBox_AllContext;
    }
}

