using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ComposersLibrary_EF;

namespace Composers_Database_EF
{
    public partial class Song_Search : Form
    {
        private ComposersLibrary_EF.DBLibraryEntities1 obj;
        public Song_Search()
        {
            InitializeComponent();
        }
        private void FindSong()
        {
            obj = new ComposersLibrary_EF.DBLibraryEntities1();

            var query = (from c in obj.SONGs
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
    }
}
