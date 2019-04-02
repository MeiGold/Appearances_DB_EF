namespace Composers_Database_EF
{
    partial class Performances_Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.LabelTo = new System.Windows.Forms.Label();
            this.PerformanceSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.pERFORMANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.pERFORMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPERFORMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFSONGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFORMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Location = new System.Drawing.Point(98, 29);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.DateTimePickerFrom.TabIndex = 0;
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Location = new System.Drawing.Point(496, 29);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.DateTimePickerTo.TabIndex = 1;
            // 
            // LabelFrom
            // 
            this.LabelFrom.AutoSize = true;
            this.LabelFrom.Location = new System.Drawing.Point(25, 29);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(44, 17);
            this.LabelFrom.TabIndex = 2;
            this.LabelFrom.Text = "From:";
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Location = new System.Drawing.Point(444, 29);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(29, 17);
            this.LabelTo.TabIndex = 3;
            this.LabelTo.Text = "To:";
            // 
            // PerformanceSearchDataGridView
            // 
            this.PerformanceSearchDataGridView.AutoGenerateColumns = false;
            this.PerformanceSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformanceSearchDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.PerformanceSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformanceSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRFIDDataGridViewTextBoxColumn,
            this.pRFPERFORMERIDDataGridViewTextBoxColumn,
            this.pRFSONGIDDataGridViewTextBoxColumn,
            this.pRFNAMEDataGridViewTextBoxColumn,
            this.pRFDATEDataGridViewTextBoxColumn,
            this.pRFPLACEDataGridViewTextBoxColumn,
            this.pERFORMERDataGridViewTextBoxColumn,
            this.sONGDataGridViewTextBoxColumn});
            this.PerformanceSearchDataGridView.DataSource = this.pERFORMANCEBindingSource;
            this.PerformanceSearchDataGridView.Location = new System.Drawing.Point(1, 127);
            this.PerformanceSearchDataGridView.Name = "PerformanceSearchDataGridView";
            this.PerformanceSearchDataGridView.RowTemplate.Height = 24;
            this.PerformanceSearchDataGridView.Size = new System.Drawing.Size(799, 323);
            this.PerformanceSearchDataGridView.TabIndex = 4;
            // 
            // pERFORMANCEBindingSource
            // 
            this.pERFORMANCEBindingSource.DataSource = typeof(ComposersLibrary_EF.PERFORMANCE);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(323, 78);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 33);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pERFORMERBindingSource
            // 
            this.pERFORMERBindingSource.DataSource = typeof(ComposersLibrary_EF.PERFORMER);
            // 
            // pRFIDDataGridViewTextBoxColumn
            // 
            this.pRFIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.HeaderText = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.Name = "pRFIDDataGridViewTextBoxColumn";
            this.pRFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFPERFORMERIDDataGridViewTextBoxColumn
            // 
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.HeaderText = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Name = "pRFPERFORMERIDDataGridViewTextBoxColumn";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFSONGIDDataGridViewTextBoxColumn
            // 
            this.pRFSONGIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.HeaderText = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.Name = "pRFSONGIDDataGridViewTextBoxColumn";
            this.pRFSONGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFNAMEDataGridViewTextBoxColumn
            // 
            this.pRFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRF_NAME";
            this.pRFNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pRFNAMEDataGridViewTextBoxColumn.Name = "pRFNAMEDataGridViewTextBoxColumn";
            // 
            // pRFDATEDataGridViewTextBoxColumn
            // 
            this.pRFDATEDataGridViewTextBoxColumn.DataPropertyName = "PRF_DATE";
            this.pRFDATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.pRFDATEDataGridViewTextBoxColumn.Name = "pRFDATEDataGridViewTextBoxColumn";
            // 
            // pRFPLACEDataGridViewTextBoxColumn
            // 
            this.pRFPLACEDataGridViewTextBoxColumn.DataPropertyName = "PRF_PLACE";
            this.pRFPLACEDataGridViewTextBoxColumn.HeaderText = "Place";
            this.pRFPLACEDataGridViewTextBoxColumn.Name = "pRFPLACEDataGridViewTextBoxColumn";
            // 
            // pERFORMERDataGridViewTextBoxColumn
            // 
            this.pERFORMERDataGridViewTextBoxColumn.DataPropertyName = "PERFORMER";
            this.pERFORMERDataGridViewTextBoxColumn.HeaderText = "PERFORMER";
            this.pERFORMERDataGridViewTextBoxColumn.Name = "pERFORMERDataGridViewTextBoxColumn";
            this.pERFORMERDataGridViewTextBoxColumn.Visible = false;
            // 
            // sONGDataGridViewTextBoxColumn
            // 
            this.sONGDataGridViewTextBoxColumn.DataPropertyName = "SONG";
            this.sONGDataGridViewTextBoxColumn.HeaderText = "SONG";
            this.sONGDataGridViewTextBoxColumn.Name = "sONGDataGridViewTextBoxColumn";
            this.sONGDataGridViewTextBoxColumn.Visible = false;
            // 
            // Performances_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PerformanceSearchDataGridView);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Name = "Performances_Search";
            this.ShowIcon = false;
            this.Text = "Performances Search";
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker DateTimePickerTo;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.DataGridView PerformanceSearchDataGridView;
        private System.Windows.Forms.BindingSource pERFORMANCEBindingSource;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.BindingSource pERFORMERBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPERFORMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFSONGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFORMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGDataGridViewTextBoxColumn;
    }
}