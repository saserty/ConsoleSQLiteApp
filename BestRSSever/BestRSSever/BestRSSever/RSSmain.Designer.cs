namespace BestRSSever
{
    partial class RSSmain
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
            this.MainRSSflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckUpdatesButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageNumberLabel = new System.Windows.Forms.Label();
            this.RSSListListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MainRSSflowLayoutPanel
            // 
            this.MainRSSflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainRSSflowLayoutPanel.AutoScroll = true;
            this.MainRSSflowLayoutPanel.Location = new System.Drawing.Point(213, 13);
            this.MainRSSflowLayoutPanel.Name = "MainRSSflowLayoutPanel";
            this.MainRSSflowLayoutPanel.Size = new System.Drawing.Size(443, 413);
            this.MainRSSflowLayoutPanel.TabIndex = 0;
            // 
            // CheckUpdatesButton
            // 
            this.CheckUpdatesButton.Location = new System.Drawing.Point(26, 224);
            this.CheckUpdatesButton.Name = "CheckUpdatesButton";
            this.CheckUpdatesButton.Size = new System.Drawing.Size(157, 25);
            this.CheckUpdatesButton.TabIndex = 1;
            this.CheckUpdatesButton.Text = "Check for Updates";
            this.CheckUpdatesButton.UseVisualStyleBackColor = true;
            this.CheckUpdatesButton.Click += new System.EventHandler(this.CheckUpdatesButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PreviousButton.Location = new System.Drawing.Point(284, 433);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 3;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextButton.Location = new System.Drawing.Point(512, 433);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageNumberLabel
            // 
            this.PageNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PageNumberLabel.AutoSize = true;
            this.PageNumberLabel.Location = new System.Drawing.Point(406, 438);
            this.PageNumberLabel.Name = "PageNumberLabel";
            this.PageNumberLabel.Size = new System.Drawing.Size(32, 13);
            this.PageNumberLabel.TabIndex = 5;
            this.PageNumberLabel.Text = "Page";
            // 
            // RSSListListBox
            // 
            this.RSSListListBox.FormattingEnabled = true;
            this.RSSListListBox.Location = new System.Drawing.Point(26, 76);
            this.RSSListListBox.Name = "RSSListListBox";
            this.RSSListListBox.Size = new System.Drawing.Size(157, 95);
            this.RSSListListBox.TabIndex = 6;
            // 
            // RSSmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 467);
            this.Controls.Add(this.RSSListListBox);
            this.Controls.Add(this.PageNumberLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.CheckUpdatesButton);
            this.Controls.Add(this.MainRSSflowLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSSmain";
            this.Text = "RSS Aggregator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainRSSflowLayoutPanel;
        private System.Windows.Forms.Button CheckUpdatesButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageNumberLabel;
        private System.Windows.Forms.ListBox RSSListListBox;
    }
}

