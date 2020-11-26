using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DreamStorer
{
    public partial class CreateDream : Form
    {
        public CreateDream()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("../../DreamJournal/" + dreamTitle.Text + ".txt"))
            {
                // Add some text to file
                Byte[] title = new UTF8Encoding(true).GetBytes(dreamContent.Text);
                fs.Write(title, 0, title.Length);
            }
        }
    }
}
