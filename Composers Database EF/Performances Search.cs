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
    
    public partial class Performances_Search : Form
    {
        ComposersLibrary_EF.DBLibraryEntities1 obj;

        public Performances_Search()
        {
            InitializeComponent();
        }

        private void FindPerformances()
        {
            obj = new ComposersLibrary_EF.DBLibraryEntities1();

            var query = (from c in obj.PERFORMANCEs
                         select c);
            
            query = query.Where(c => c.PRF_DATE.Value>(DateTimePickerFrom.Value));
            query = query.Where(c => c.PRF_DATE.Value < DateTimePickerTo.Value);


            pERFORMANCEBindingSource.DataSource = query.ToList();

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            FindPerformances();
        }
    }
}
