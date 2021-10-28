using System;
using System.Windows.Forms;

namespace ListHTML
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.CSSText = "body {font-family: Arial;}";

            this.listView1.Items.Add("test1").Tag = "<p>test1</p>";
            this.listView1.Items.Add("test2").Tag = "<p>test12345</p>";
            this.listView1.Items.Add("test3").Tag = "<p>Another Test</p>";
            this.listView1.Items.Add("test4").Tag = "<h1>Heading 1 Test</h1>";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;

            this.htmlEditControl1.DocumentHTML = listView1.SelectedItems[0].Tag.ToString();
        }

        private void htmlEditControl1_HTMLChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;

            listView1.SelectedItems[0].Tag = this.htmlEditControl1.DocumentHTML;
        }
    }
}
