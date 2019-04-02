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
    public partial class Performers_Search : Form
    {
        ComposersLibrary_EF.DBLibraryEntities1 obj;

        public Performers_Search()
        {
            InitializeComponent();
        }

        private void FindPerformer()
        {
            obj = new ComposersLibrary_EF.DBLibraryEntities1();

            var query = (from c in obj.PERFORMERs
                         
                         where c.PERFORMANCEs.Any()
                         select c);
            if (!String.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                query = query.Where(c => c.PF_NAME.Contains(NameTextBox.Text));
            }
            if (!String.IsNullOrWhiteSpace(NationalityTextBox.Text))
            {
                query = query.Where(c => c.PF_NATIONALITY.Contains(NationalityTextBox.Text));
            }


            pERFORMERBindingSource.DataSource = query.ToList();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            FindPerformer();
        }
    }
}
