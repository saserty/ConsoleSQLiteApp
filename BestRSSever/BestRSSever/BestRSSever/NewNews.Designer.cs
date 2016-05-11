namespace BestRSSever
{
    partial class NewNews
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PublicDateLabel = new System.Windows.Forms.Label();
            this.SourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(26, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // PublicDateLabel
            // 
            this.PublicDateLabel.AutoSize = true;
            this.PublicDateLabel.Location = new System.Drawing.Point(26, 171);
            this.PublicDateLabel.Name = "PublicDateLabel";
            this.PublicDateLabel.Size = new System.Drawing.Size(85, 13);
            this.PublicDateLabel.TabIndex = 1;
            this.PublicDateLabel.Text = "Publication Date";
            // 
            // SourceLinkLabel
            // 
            this.SourceLinkLabel.AutoEllipsis = true;
            this.SourceLinkLabel.Location = new System.Drawing.Point(214, 171);
            this.SourceLinkLabel.Name = "SourceLinkLabel";
            this.SourceLinkLabel.Size = new System.Drawing.Size(183, 13);
            this.SourceLinkLabel.TabIndex = 2;
            this.SourceLinkLabel.TabStop = true;
            this.SourceLinkLabel.Text = "Source Link";
            this.SourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLinkLabel_LinkClicked);
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(29, 40);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.ReadOnly = true;
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(368, 117);
            this.DescriptionRichTextBox.TabIndex = 5;
            this.DescriptionRichTextBox.Text = "";
            // 
            // NewNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.SourceLinkLabel);
            this.Controls.Add(this.PublicDateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "NewNews";
            this.Size = new System.Drawing.Size(415, 195);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PublicDateLabel;
        private System.Windows.Forms.LinkLabel SourceLinkLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
    }
}
