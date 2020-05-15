namespace WikiForms
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.LinkListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 55.75F);
            this.label1.Location = new System.Drawing.Point(158, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Website";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(173, 165);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(362, 20);
            this.InputBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(546, 157);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(98, 36);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // LinkListBox
            // 
            this.LinkListBox.FormattingEnabled = true;
            this.LinkListBox.Location = new System.Drawing.Point(173, 200);
            this.LinkListBox.Name = "LinkListBox";
            this.LinkListBox.Size = new System.Drawing.Size(362, 225);
            this.LinkListBox.TabIndex = 3;
            this.LinkListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LinkListBox_MouseDoubleClick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkListBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ListBox LinkListBox;
    }
}

