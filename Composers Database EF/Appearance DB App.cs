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
    public partial class AppearenceForm : System.Windows.Forms.Form
    {
        private DateTimePicker date;
        private ComposersLibrary_EF.DBLibraryEntities1 ctx;

        public AppearenceForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new ComposersLibrary_EF.DBLibraryEntities1();
            ctx.SONGs.Load();
            this.sONGBindingSource.DataSource = ctx.SONGs.Local.ToBindingList();

            ctx.PERFORMERs.Load();
            this.pERFORMERBindingSource.DataSource = ctx.PERFORMERs.Local.ToBindingList();

            ctx.PERFORMANCEs.Load();
            this.pERFORMANCEBindingSource.DataSource = ctx.PERFORMANCEs.Local.ToBindingList();

            ctx.COMPOSERs.Load();
            this.cOMPOSERBindingSource.DataSource = ctx.COMPOSERs.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void DateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use
            date.Visible = false;
        }

        private void ButtonSaveSongs_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ButtonDeleteSongs_Click(object sender, EventArgs e)
        {
            try
            {
                SONG song = (SONG)SongsDataGridView.CurrentRow.DataBoundItem;
                if (song.PERFORMANCEs.Any())
                {
                    MessageBox.Show("You can not delete this song because it had been(or would be) performed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    sONGBindingSource.RemoveCurrent();
                    SetHeightdatagridview(SongsDataGridView);
                }
            }
            catch(Exception) {
                MessageBox.Show("Error occured after deleting song!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSavePerformers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ButtonDeletePerformers_Click(object sender, EventArgs e)
        {
            try
            {
                PERFORMER performer = (PERFORMER)PerformersDataGridView.CurrentRow.DataBoundItem;
                if (performer.PERFORMANCEs.Any())
                {
                    MessageBox.Show("You can not delete this performer because he performed a song(or would perform)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    pERFORMERBindingSource.RemoveCurrent();
                    SetHeightdatagridview(PerformersDataGridView);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured after deleting performer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSavePerformances_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ButtonDeletePerformances_Click(object sender, EventArgs e)
        {
            try
            {
                PERFORMANCE performance = (PERFORMANCE)PerformancesDataGridView.CurrentRow.DataBoundItem;
                pERFORMANCEBindingSource.RemoveCurrent();
                SetHeightdatagridview(PerformancesDataGridView);
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured after deleting performance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSaveComposers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void ButtonDeleteComposers_Click(object sender, EventArgs e)
        {
            try
            {
                COMPOSER composer = (COMPOSER)ComposersDataGridView.CurrentRow.DataBoundItem;
                if (composer.SONGs.Any())
                {
                    MessageBox.Show("You can not delete this composer because he has writed songs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    cOMPOSERBindingSource.RemoveCurrent();
                    SetHeightdatagridview(ComposersDataGridView);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured after deleting composer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetHeightdatagridview(DataGridView data)
        {
            data.Height = data.RowTemplate.Height * (data.Rows.Count + 1);
            return;
        }

        private void SongsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            int numRows = SongsDataGridView.Rows.Count;

            if (numRows == 1) return;
            if (SongsDataGridView.Rows.Count == 2)
            {
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[0].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[1].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[5].Value = 1;
            }
            if (Convert.ToString(SongsDataGridView.Rows[numRows - 2].Cells[0].Value) == "0")
            {
                SongsDataGridView.Rows[numRows - 2].Cells[0].Value = Convert.ToInt32(SongsDataGridView.Rows[numRows - 3].Cells[0].Value) + 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[1].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[5].Value = 1;
            }
            //SetHeightdatagridview(SongsDataGridView);
        }

        private void SongsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                TimeSpan tryparse;
                if (!TimeSpan.TryParse(SongsDataGridView.CurrentCell.EditedFormattedValue.ToString(), out tryparse))
                {
                    MessageBox.Show("You have entered a wrong format of song duration! Right format: HH:MM:SS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SongsDataGridView.CurrentCell.Value = "00:00:00";
                }
            }
        }

        private void PerformersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numRows = PerformersDataGridView.Rows.Count;
            if (numRows == 1) return;
            if (PerformersDataGridView.Rows.Count == 2)
            {
                PerformersDataGridView.Rows[PerformersDataGridView.Rows.Count - 2].Cells[1].Value = 1;

            }
            if (Convert.ToString(PerformersDataGridView.Rows[numRows - 2].Cells[1].Value) == "0")
            {
                PerformersDataGridView.Rows[numRows - 2].Cells[1].Value = Convert.ToInt32(PerformersDataGridView.Rows[numRows - 3].Cells[1].Value) + 1;
            }
            //SetHeightdatagridview(PerformersDataGridView);
        }

        private void PerformersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (date != null)
            {
                date.Visible = false;
            }

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {

                if (e.RowIndex == PerformersDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    PerformersDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (PerformersDataGridView.CurrentCell.Value != null)
                        date.Value = (DateTime)PerformersDataGridView.CurrentCell.Value;
                    else date.Value = DateTime.Now;
                    Rectangle rectangle = PerformersDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(DateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(PerformersDateTimePicker_OnTextChange);

                    date.Visible = true;
                }
            }

        }


        private void PerformersDateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell

            PerformersDataGridView.CurrentCell.Value = date.Text.ToString();
            if ((DateTime)PerformersDataGridView.CurrentCell.Value > DateTime.Now)
            {
                MessageBox.Show("You provided a wrong date, please enter a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PerformersDataGridView.CurrentCell.Value = DateTime.Now.ToShortDateString();

            }
        }

        private void PerformancesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (PerformancesDataGridView.Rows.Count == 1) return;
            if (PerformancesDataGridView.Rows.Count == 2) PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value = 1;
            if (Convert.ToString(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value) == "0")
            {
                PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value = Convert.ToInt32(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 3].Cells[1].Value) + 1;

                int i = PerformancesDataGridView.CurrentCell.RowIndex;
                if (PerformancesDataGridView[4, i].EditedFormattedValue.ToString() == "")
                    PerformancesDataGridView.Rows[i].Cells[4].Value = 1;
                if (PerformancesDataGridView[5, i].EditedFormattedValue.ToString() == "")
                    PerformancesDataGridView.Rows[i].Cells[5].Value = 1;

            }
            //SetHeightdatagridview(PerformancesDataGridView);
        }

        private void PerformancesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (PerformancesDataGridView.Rows.Count == 1) return;
            if (PerformancesDataGridView.Rows.Count == 2) PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value = 1;
            if (Convert.ToString(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value) == "0")
            {
                PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value = Convert.ToInt32(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 3].Cells[1].Value) + 1;

                int i = PerformancesDataGridView.CurrentCell.RowIndex;
                if (PerformancesDataGridView[4, i].EditedFormattedValue.ToString() == "")
                    PerformancesDataGridView.Rows[i].Cells[4].Value = 1;
                if (PerformancesDataGridView[5, i].EditedFormattedValue.ToString() == "")
                    PerformancesDataGridView.Rows[i].Cells[5].Value = 1;

            }
            SetHeightdatagridview(PerformancesDataGridView);
        }

        private void PerformancesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (date != null)
            {
                date.Visible = false;
            }

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {

                if (e.RowIndex == PerformancesDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    PerformancesDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (PerformancesDataGridView.CurrentCell.Value != null)
                        date.Value = (DateTime)PerformancesDataGridView.CurrentCell.Value;
                    else
                    {
                        date.Value = DateTime.Now;
                    }
                    Rectangle rectangle = PerformancesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(DateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(PerformancesDateTimePicker_OnTextChange);

                    date.Visible = true;
                }
            }
        }

        private void PerformancesDateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            PerformancesDataGridView.CurrentCell.Value = date.Text.ToString();
        }

        private void ComposersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numRows = ComposersDataGridView.Rows.Count;
            if (numRows == 1) return;
            if (ComposersDataGridView.Rows.Count == 2)
            {
                ComposersDataGridView.Rows[ComposersDataGridView.Rows.Count - 2].Cells[1].Value = 1;

            }
            if (Convert.ToString(ComposersDataGridView.Rows[numRows - 2].Cells[1].Value) == "0")
            {
                ComposersDataGridView.Rows[numRows - 2].Cells[1].Value = Convert.ToInt32(ComposersDataGridView.Rows[numRows - 3].Cells[1].Value) + 1;
            }
            //SetHeightdatagridview(ComposersDataGridView);
        }

        private void ComposersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (date != null)
            {
                date.Visible = false;
            }

            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {

                if (e.RowIndex == ComposersDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    ComposersDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (ComposersDataGridView.CurrentCell.Value != null)
                        date.Value = (DateTime)ComposersDataGridView.CurrentCell.Value;
                    else date.Value = DateTime.Now;
                    Rectangle rectangle = ComposersDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(DateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(ComposersDateTimePicker_OnTextChange);

                    date.Visible = true;
                }
            }
        }

        private void ComposersDateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            ComposersDataGridView.CurrentCell.Value = date.Text.ToString();
            if ((DateTime)ComposersDataGridView.CurrentCell.Value > DateTime.Now)
            {
                MessageBox.Show("You provided a wrong date, please enter a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ComposersDataGridView.CurrentCell.Value = DateTime.Now.ToShortDateString();

            }
        }

        private void SearchSongsButton_Click(object sender, EventArgs e)
        {
            Song_Search song = new Song_Search();
            song.Show();
        }

        private void SearchPerformersButton_Click(object sender, EventArgs e)
        {
            Performers_Search performers = new Performers_Search();
            performers.Show();
        }

        private void PerformancesSearchButton_Click(object sender, EventArgs e)
        {
            Performances_Search performances = new Performances_Search();
            performances.Show();
        }

        private void ComposerSearchButton_Click(object sender, EventArgs e)
        {
            Composers_Search composers = new Composers_Search();
            composers.Show();
        }
    }
}
