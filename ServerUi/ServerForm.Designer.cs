namespace ServerUi
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
            this.TextBox_IpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RichTextBox_Logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBox_IpAddress
            // 
            this.TextBox_IpAddress.Location = new System.Drawing.Point(112, 6);
            this.TextBox_IpAddress.Name = "TextBox_IpAddress";
            this.TextBox_IpAddress.Size = new System.Drawing.Size(170, 20);
            this.TextBox_IpAddress.TabIndex = 0;
            this.TextBox_IpAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serevr Ip Address:";
            // 
            // TextBox_Port
            // 
            this.TextBox_Port.Location = new System.Drawing.Point(323, 6);
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.Size = new System.Drawing.Size(61, 20);
            this.TextBox_Port.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(390, 3);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 23);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RichTextBox_Logs
            // 
            this.RichTextBox_Logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_Logs.Location = new System.Drawing.Point(12, 32);
            this.RichTextBox_Logs.Name = "RichTextBox_Logs";
            this.RichTextBox_Logs.Size = new System.Drawing.Size(534, 157);
            this.RichTextBox_Logs.TabIndex = 3;
            this.RichTextBox_Logs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 201);
            this.Controls.Add(this.RichTextBox_Logs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.TextBox_IpAddress);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_IpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox RichTextBox_Logs;
    }
}

