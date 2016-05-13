using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BestRSSever
{
    public partial class RSSmain : Form
    {
        string RSSURL = "http://bash.im/rss/";
        string RSSURL2 = "http://feeds.bbci.co.uk/news/world/rss.xml";
        int pageSize = 30;
        int currPage = 1;
        private List<Post> m_posts = new List<Post>();

        public RSSmain()
        {
            InitializeComponent();
            NextButton.Enabled = false;
            PreviousButton.Enabled = false;
            int fixedRSS = RSSURL.Length;
            RSSListListBox.Items.Add(RSSURL.Substring(7));
            RSSListListBox.Items.Add(RSSURL2.Substring(7));
        }

        private void CheckUpdatesButton_Click(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            PreviousButton.Enabled = true;

            var reader = new RssReader();
            m_posts = reader.ReadFeed(RSSURL).ToList();
            m_posts.AddRange(reader.ReadFeed(RSSURL2).ToList());

            RedrewPosts();
        }

        private void RedrewPosts()
        {
            var postsToShow = m_posts.Skip((currPage - 1) * pageSize).Take(pageSize);
            MainRSSflowLayoutPanel.Controls.Clear();

            foreach (var post in postsToShow)
            {
                MainRSSflowLayoutPanel.Controls.Add(new NewNews(post.Title, post.Description, post.PublishedDate, post.Link));
            }

            var startIndex = (currPage - 1) * pageSize;
            this.PageNumberLabel.Text = string.Format("{0} to {1}", startIndex, Math.Min(startIndex + pageSize, m_posts.Count));
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PreviousButton.Enabled = true;
            int max = (m_posts.Count / pageSize) + 1;
            currPage = Math.Min(max, ++currPage);
            RedrewPosts();            
            //CheckUpdatesButton_Click(null, null);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currPage > 1)
            {
                currPage = Math.Max(0, --currPage);
            }
            else if (currPage == 1)
            {
                PreviousButton.Enabled = false;
            }
            else currPage = Math.Max(0, --currPage);
            RedrewPosts();            
        }
    }
}
