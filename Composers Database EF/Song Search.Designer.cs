namespace Composers_Database_EF
{
    partial class Song_Search
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.SongSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.sNGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGCMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGGENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGPPSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFORMANCEsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGCOLLECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сSONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPOSERsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XMLButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SongSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(568, 113);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 35);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(31, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(31, 131);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 17);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(31, 174);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(75, 34);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "Duration\r\n(less than)";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 87);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(194, 22);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(115, 131);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(194, 22);
            this.GenreTextBox.TabIndex = 7;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(115, 174);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(194, 22);
            this.DurationTextBox.TabIndex = 8;
            // 
            // SongSearchDataGridView
            // 
            this.SongSearchDataGridView.AutoGenerateColumns = false;
            this.SongSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SongSearchDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.SongSearchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SongSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNGIDDataGridViewTextBoxColumn,
            this.sNGCMPIDDataGridViewTextBoxColumn,
            this.sNGNAMEDataGridViewTextBoxColumn,
            this.sNGGENREDataGridViewTextBoxColumn,
            this.sNGDURATIONDataGridViewTextBoxColumn,
            this.sNGPPSIDDataGridViewTextBoxColumn,
            this.pERFORMANCEsDataGridViewTextBoxColumn,
            this.sONGCOLLECTIONDataGridViewTextBoxColumn,
            this.сSONGDataGridViewTextBoxColumn,
            this.cOMPOSERsDataGridViewTextBoxColumn});
            this.SongSearchDataGridView.DataSource = this.sONGBindingSource;
            this.SongSearchDataGridView.Location = new System.Drawing.Point(-1, 233);
            this.SongSearchDataGridView.Name = "SongSearchDataGridView";
            this.SongSearchDataGridView.RowTemplate.Height = 24;
            this.SongSearchDataGridView.Size = new System.Drawing.Size(801, 320);
            this.SongSearchDataGridView.TabIndex = 9;
            // 
            // sNGIDDataGridViewTextBoxColumn
            // 
            this.sNGIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.HeaderText = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.Name = "sNGIDDataGridViewTextBoxColumn";
            this.sNGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGCMPIDDataGridViewTextBoxColumn
            // 
            this.sNGCMPIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_CMP_ID";
            this.sNGCMPIDDataGridViewTextBoxColumn.HeaderText = "SNG_CMP_ID";
            this.sNGCMPIDDataGridViewTextBoxColumn.Name = "sNGCMPIDDataGridViewTextBoxColumn";
            this.sNGCMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGNAMEDataGridViewTextBoxColumn
            // 
            this.sNGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNG_NAME";
            this.sNGNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.sNGNAMEDataGridViewTextBoxColumn.Name = "sNGNAMEDataGridViewTextBoxColumn";
            // 
            // sNGGENREDataGridViewTextBoxColumn
            // 
            this.sNGGENREDataGridViewTextBoxColumn.DataPropertyName = "SNG_GENRE";
            this.sNGGENREDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.sNGGENREDataGridViewTextBoxColumn.Name = "sNGGENREDataGridViewTextBoxColumn";
            // 
            // sNGDURATIONDataGridViewTextBoxColumn
            // 
            this.sNGDURATIONDataGridViewTextBoxColumn.DataPropertyName = "SNG_DURATION";
            this.sNGDURATIONDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.sNGDURATIONDataGridViewTextBoxColumn.Name = "sNGDURATIONDataGridViewTextBoxColumn";
            // 
            // sNGPPSIDDataGridViewTextBoxColumn
            // 
            this.sNGPPSIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_PPS_ID";
            this.sNGPPSIDDataGridViewTextBoxColumn.HeaderText = "SNG_PPS_ID";
            this.sNGPPSIDDataGridViewTextBoxColumn.Name = "sNGPPSIDDataGridViewTextBoxColumn";
            this.sNGPPSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pERFORMANCEsDataGridViewTextBoxColumn
            // 
            this.pERFORMANCEsDataGridViewTextBoxColumn.DataPropertyName = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn.HeaderText = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn.Name = "pERFORMANCEsDataGridViewTextBoxColumn";
            this.pERFORMANCEsDataGridViewTextBoxColumn.Visible = false;
            // 
            // sONGCOLLECTIONDataGridViewTextBoxColumn
            // 
            this.sONGCOLLECTIONDataGridViewTextBoxColumn.DataPropertyName = "SONG_COLLECTION";
            this.sONGCOLLECTIONDataGridViewTextBoxColumn.HeaderText = "SONG_COLLECTION";
            this.sONGCOLLECTIONDataGridViewTextBoxColumn.Name = "sONGCOLLECTIONDataGridViewTextBoxColumn";
            this.sONGCOLLECTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // сSONGDataGridViewTextBoxColumn
            // 
            this.сSONGDataGridViewTextBoxColumn.DataPropertyName = "СSONG";
            this.сSONGDataGridViewTextBoxColumn.HeaderText = "СSONG";
            this.сSONGDataGridViewTextBoxColumn.Name = "сSONGDataGridViewTextBoxColumn";
            this.сSONGDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMPOSERsDataGridViewTextBoxColumn
            // 
            this.cOMPOSERsDataGridViewTextBoxColumn.DataPropertyName = "COMPOSERs";
            this.cOMPOSERsDataGridViewTextBoxColumn.HeaderText = "COMPOSERs";
            this.cOMPOSERsDataGridViewTextBoxColumn.Name = "cOMPOSERsDataGridViewTextBoxColumn";
            this.cOMPOSERsDataGridViewTextBoxColumn.Visible = false;
            // 
            // sONGBindingSource
            // 
            this.sONGBindingSource.DataSource = typeof(ComposersLibrary_EF.SONG);
            // 
            // XMLButton
            // 
            this.XMLButton.Location = new System.Drawing.Point(34, 13);
            this.XMLButton.Name = "XMLButton";
            this.XMLButton.Size = new System.Drawing.Size(177, 40);
            this.XMLButton.TabIndex = 10;
            this.XMLButton.Text = "Transform to XML";
            this.XMLButton.UseVisualStyleBackColor = true;
            // 
            // Song_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.XMLButton);
            this.Controls.Add(this.SongSearchDataGridView);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SearchButton);
            this.Name = "Song_Search";
            this.ShowIcon = false;
            this.Text = "Song Search";
            ((System.ComponentModel.ISupportInitialize)(this.SongSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.DataGridView SongSearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGCMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGGENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGPPSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFORMANCEsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGCOLLECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сSONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPOSERsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sONGBindingSource;
        private System.Windows.Forms.Button XMLButton;
    }
}