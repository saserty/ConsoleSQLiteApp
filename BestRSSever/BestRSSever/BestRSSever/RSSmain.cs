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
            //MainRSSflowLayoutPanel.Controls.Add(new NewNews(title, message, publicdate, RSSURL));//"test title", "test descr", "test date", "test link"

            //List<Post> listOfPosts = new List<Post>();


            ////int y = 0;

            //for (int i = 0; i < 134; i++)
            //{
            //    var t = new NewNews(i + " 1", i + " 2", i + " 3", i + " 4");//var t = new NewNews("TT " + i, "TD" + 1, "Tdate", "Tlink");
            //    //t.Location = new Point(100, y);
            //    //y += 836;
            //    MainRSSflowLayoutPanel.Controls.Add(t);
            //}
        }

        private void CheckUpdatesButton_Click(object sender, EventArgs e)
        {
            var reader = new RssReader();
            m_posts = reader.ReadFeed(RSSURL).ToList();
            m_posts.AddRange(reader.ReadFeed(RSSURL2).ToList());

            RedrewPosts();
            //read xml from rss();
            //ToXML.ReadRSS(RSSURL);
            //write to xml();
            //ToXML.WriteToXML();
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
            int max = (m_posts.Count / pageSize) + 1;
            currPage = Math.Min(max, ++currPage);
            RedrewPosts();
            //CheckUpdatesButton_Click(null, null);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            currPage = Math.Max(0, --currPage);
            RedrewPosts();            
        }
    }
}
