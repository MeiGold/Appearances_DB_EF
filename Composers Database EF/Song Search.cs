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
using System.Data.Entity;
using ComposersLibrary_EF;

namespace Composers_Database_EF
{
    public partial class Song_Search : Form
    {
        public IQueryable<SONG> query;
        private ComposersLibrary_EF.DBLibraryEntities1 obj;
        public Song_Search()
        {
            InitializeComponent();
        }
        private void FindSong()
        {
            obj = new ComposersLibrary_EF.DBLibraryEntities1();

            query = (from c in obj.SONGs
                         select c);
            if (!String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                query = query.Where(c => c.SNG_NAME.Contains(NameTextBox.Text));
            }

            if (!String.IsNullOrWhiteSpace(GenreTextBox.Text))
            {
                query = query.Where(c => c.SNG_GENRE.Contains(GenreTextBox.Text));
            }

            if (!String.IsNullOrWhiteSpace(DurationTextBox.Text))
            {
                TimeSpan time;
                if(TimeSpan.TryParse(DurationTextBox.Text, out time))
                query = query.Where(c => c.SNG_DURATION.Value <= time);
                else
                {
                    MessageBox.Show("You have entered the wrong format of duration time of song, it must be HH:MM:SS.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    DurationTextBox.Text = "";
                    return;
                }
            }

            sONGBindingSource.DataSource = query.ToList();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FindSong();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FindSong();
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            FindSong();
        }

        private void XMLButton_Click(object sender, EventArgs e)
        {
            if (query == null)
            {
                MessageBox.Show("There is nothing to transform!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            OpenFile();

            //string path = CreateXml.Create(query);
        }
        public void OpenFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All files(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
                //return "";
            }
            string path = save.FileName;
            CreateXml.Create(query, path);
            MessageBox.Show("File was successfully created!", "Notification", MessageBoxButtons.OK);
            //return FileName;
        }

    }
}
