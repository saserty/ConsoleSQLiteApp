using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestRSSever
{
    public partial class NewNews : UserControl
    {
        public NewNews(string title, string message, string publicdate, string source)
        {
            InitializeComponent();
            TitleLabel.Text = title;
            DescriptionRichTextBox.Text = message;
            PublicDateLabel.Text = publicdate;
            SourceLinkLabel.Text = source;
        }

        private void SourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SourceLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(SourceLinkLabel.Text);
        }
    }

        
}
