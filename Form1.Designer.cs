
namespace CodingText
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BinCodeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 31);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(214, 291);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.HideSelection = false;
            this.richTextBox2.Location = new System.Drawing.Point(309, 31);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(214, 291);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // BinCodeButton
            // 
            this.BinCodeButton.Location = new System.Drawing.Point(97, 352);
            this.BinCodeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BinCodeButton.Name = "BinCodeButton";
            this.BinCodeButton.Size = new System.Drawing.Size(114, 65);
            this.BinCodeButton.TabIndex = 2;
            this.BinCodeButton.Text = "BinFormat";
            this.BinCodeButton.UseVisualStyleBackColor = true;
            this.BinCodeButton.Click += new System.EventHandler(this.BinCodeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Decoding BitFormat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BinCodeButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Decoding BitFormat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BinCodeButton;
        private System.Windows.Forms.Button button1;
    }
}

