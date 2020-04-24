namespace WikiForms
{
    partial class RandomizerForm
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
            this.RandomizerButton = new System.Windows.Forms.Button();
            this.LinkListBox = new System.Windows.Forms.ListBox();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.GoToLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomizerButton
            // 
            this.RandomizerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RandomizerButton.Location = new System.Drawing.Point(41, 71);
            this.RandomizerButton.Name = "RandomizerButton";
            this.RandomizerButton.Size = new System.Drawing.Size(186, 52);
            this.RandomizerButton.TabIndex = 0;
            this.RandomizerButton.Text = "Randomize!";
            this.RandomizerButton.UseVisualStyleBackColor = true;
            this.RandomizerButton.Click += new System.EventHandler(this.RandomizerButton_Click);
            // 
            // LinkListBox
            // 
            this.LinkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LinkListBox.FormattingEnabled = true;
            this.LinkListBox.ItemHeight = 31;
            this.LinkListBox.Location = new System.Drawing.Point(284, 51);
            this.LinkListBox.Name = "LinkListBox";
            this.LinkListBox.Size = new System.Drawing.Size(579, 531);
            this.LinkListBox.TabIndex = 1;
            this.LinkListBox.SelectedIndexChanged += new System.EventHandler(this.LinkListBox_SelectedIndexChanged);
            // 
            // TestBox
            // 
            this.TestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TestBox.Location = new System.Drawing.Point(934, 304);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(152, 38);
            this.TestBox.TabIndex = 2;
            // 
            // GoToLinkButton
            // 
            this.GoToLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GoToLinkButton.Location = new System.Drawing.Point(934, 387);
            this.GoToLinkButton.Name = "GoToLinkButton";
            this.GoToLinkButton.Size = new System.Drawing.Size(186, 52);
            this.GoToLinkButton.TabIndex = 3;
            this.GoToLinkButton.Text = "Go!";
            this.GoToLinkButton.UseVisualStyleBackColor = true;
            this.GoToLinkButton.Click += new System.EventHandler(this.GoToLinkButton_Click);
            // 
            // RandomizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.GoToLinkButton);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.LinkListBox);
            this.Controls.Add(this.RandomizerButton);
            this.Name = "RandomizerForm";
            this.Text = "RandomizerForm";
            this.Load += new System.EventHandler(this.RandomizerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomizerButton;
        private System.Windows.Forms.ListBox LinkListBox;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.Button GoToLinkButton;
    }
}