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
    public partial class Composers_Search : Form
    {
        ComposersLibrary_EF.DBLibraryEntities1 obj;

        public Composers_Search()
        {
            InitializeComponent();
        }
        private void FindComposers()
        {
            obj = new ComposersLibrary_EF.DBLibraryEntities1();

            var query = (from c in obj.COMPOSERs
                         select c);

            if (!String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                query = query.Where(c => c.CMP_FULL_NAME.Contains(NameTextBox.Text));
            }
            if (!String.IsNullOrWhiteSpace(NationalityTextBox.Text))
            {
                query = query.Where(c => c.CMP_NATIONALITY.Contains(NationalityTextBox.Text));
            }


            cOMPOSERBindingSource.DataSource = query.ToList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FindComposers();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            FindComposers();
        }

        private void NationalityTextBox_TextChanged(object sender, EventArgs e)
        {
            FindComposers();
        }
    }
}
