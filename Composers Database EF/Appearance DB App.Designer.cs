namespace Composers_Database_EF
{
    partial class AppearenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppearenceForm));
            this.DTab = new System.Windows.Forms.TabControl();
            this.SongsTab = new System.Windows.Forms.TabPage();
            this.SearchSongsButton = new System.Windows.Forms.Button();
            this.SongsDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteSongs = new System.Windows.Forms.Button();
            this.ButtonSaveSongs = new System.Windows.Forms.Button();
            this.PerformersTab = new System.Windows.Forms.TabPage();
            this.SearchPerformersButton = new System.Windows.Forms.Button();
            this.PerformersDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonDeletePerformers = new System.Windows.Forms.Button();
            this.ButtonSavePerformers = new System.Windows.Forms.Button();
            this.PerformancesTab = new System.Windows.Forms.TabPage();
            this.PerformancesSearchButton = new System.Windows.Forms.Button();
            this.PerformancesDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonDeletePerformances = new System.Windows.Forms.Button();
            this.ButtonSavePerformances = new System.Windows.Forms.Button();
            this.ComposersTab = new System.Windows.Forms.TabPage();
            this.ComposerSearchButton = new System.Windows.Forms.Button();
            this.ComposersDataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonDeleteComposers = new System.Windows.Forms.Button();
            this.ButtonSaveComposers = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
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
            this.pFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFORMANCEsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFORMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPERFORMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRFSONGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pERFORMANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMPFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPBIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPOSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTab.SuspendLayout();
            this.SongsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).BeginInit();
            this.PerformersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformersDataGridView)).BeginInit();
            this.PerformancesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformancesDataGridView)).BeginInit();
            this.ComposersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComposersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DTab
            // 
            this.DTab.Controls.Add(this.SongsTab);
            this.DTab.Controls.Add(this.PerformersTab);
            this.DTab.Controls.Add(this.PerformancesTab);
            this.DTab.Controls.Add(this.ComposersTab);
            this.DTab.Location = new System.Drawing.Point(0, 180);
            this.DTab.Name = "DTab";
            this.DTab.SelectedIndex = 0;
            this.DTab.Size = new System.Drawing.Size(912, 470);
            this.DTab.TabIndex = 0;
            // 
            // SongsTab
            // 
            this.SongsTab.BackColor = System.Drawing.Color.Bisque;
            this.SongsTab.Controls.Add(this.SearchSongsButton);
            this.SongsTab.Controls.Add(this.SongsDataGridView);
            this.SongsTab.Controls.Add(this.ButtonDeleteSongs);
            this.SongsTab.Controls.Add(this.ButtonSaveSongs);
            this.SongsTab.Location = new System.Drawing.Point(4, 25);
            this.SongsTab.Name = "SongsTab";
            this.SongsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SongsTab.Size = new System.Drawing.Size(904, 441);
            this.SongsTab.TabIndex = 0;
            this.SongsTab.Text = "Songs";
            // 
            // SearchSongsButton
            // 
            this.SearchSongsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchSongsButton.Location = new System.Drawing.Point(629, 18);
            this.SearchSongsButton.Name = "SearchSongsButton";
            this.SearchSongsButton.Size = new System.Drawing.Size(153, 32);
            this.SearchSongsButton.TabIndex = 3;
            this.SearchSongsButton.Text = "Search";
            this.SearchSongsButton.UseVisualStyleBackColor = true;
            this.SearchSongsButton.Click += new System.EventHandler(this.SearchSongsButton_Click);
            // 
            // SongsDataGridView
            // 
            this.SongsDataGridView.AllowUserToOrderColumns = true;
            this.SongsDataGridView.AutoGenerateColumns = false;
            this.SongsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SongsDataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            this.SongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.SongsDataGridView.DataSource = this.sONGBindingSource;
            this.SongsDataGridView.Location = new System.Drawing.Point(0, 68);
            this.SongsDataGridView.Name = "SongsDataGridView";
            this.SongsDataGridView.RowTemplate.Height = 24;
            this.SongsDataGridView.Size = new System.Drawing.Size(908, 373);
            this.SongsDataGridView.TabIndex = 2;
            this.SongsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SongsDataGridView_DataError);
            this.SongsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SongsDataGridView_RowsAdded);
            // 
            // ButtonDeleteSongs
            // 
            this.ButtonDeleteSongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteSongs.Location = new System.Drawing.Point(249, 18);
            this.ButtonDeleteSongs.Name = "ButtonDeleteSongs";
            this.ButtonDeleteSongs.Size = new System.Drawing.Size(105, 32);
            this.ButtonDeleteSongs.TabIndex = 1;
            this.ButtonDeleteSongs.Text = "Delete";
            this.ButtonDeleteSongs.UseVisualStyleBackColor = true;
            this.ButtonDeleteSongs.Click += new System.EventHandler(this.ButtonDeleteSongs_Click);
            // 
            // ButtonSaveSongs
            // 
            this.ButtonSaveSongs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSaveSongs.Location = new System.Drawing.Point(58, 18);
            this.ButtonSaveSongs.Name = "ButtonSaveSongs";
            this.ButtonSaveSongs.Size = new System.Drawing.Size(105, 32);
            this.ButtonSaveSongs.TabIndex = 0;
            this.ButtonSaveSongs.Text = "Save";
            this.ButtonSaveSongs.UseVisualStyleBackColor = true;
            this.ButtonSaveSongs.Click += new System.EventHandler(this.ButtonSaveSongs_Click);
            // 
            // PerformersTab
            // 
            this.PerformersTab.BackColor = System.Drawing.Color.Bisque;
            this.PerformersTab.Controls.Add(this.SearchPerformersButton);
            this.PerformersTab.Controls.Add(this.PerformersDataGridView);
            this.PerformersTab.Controls.Add(this.ButtonDeletePerformers);
            this.PerformersTab.Controls.Add(this.ButtonSavePerformers);
            this.PerformersTab.Location = new System.Drawing.Point(4, 25);
            this.PerformersTab.Name = "PerformersTab";
            this.PerformersTab.Padding = new System.Windows.Forms.Padding(3);
            this.PerformersTab.Size = new System.Drawing.Size(904, 441);
            this.PerformersTab.TabIndex = 1;
            this.PerformersTab.Text = "Performers";
            // 
            // SearchPerformersButton
            // 
            this.SearchPerformersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchPerformersButton.Location = new System.Drawing.Point(629, 18);
            this.SearchPerformersButton.Name = "SearchPerformersButton";
            this.SearchPerformersButton.Size = new System.Drawing.Size(153, 32);
            this.SearchPerformersButton.TabIndex = 3;
            this.SearchPerformersButton.Text = "Search";
            this.SearchPerformersButton.UseVisualStyleBackColor = true;
            this.SearchPerformersButton.Click += new System.EventHandler(this.SearchPerformersButton_Click);
            // 
            // PerformersDataGridView
            // 
            this.PerformersDataGridView.AutoGenerateColumns = false;
            this.PerformersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformersDataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            this.PerformersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pFNAMEDataGridViewTextBoxColumn,
            this.pFIDDataGridViewTextBoxColumn,
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn,
            this.pFNATIONALITYDataGridViewTextBoxColumn,
            this.pERFORMANCEsDataGridViewTextBoxColumn1});
            this.PerformersDataGridView.DataSource = this.pERFORMERBindingSource;
            this.PerformersDataGridView.Location = new System.Drawing.Point(0, 68);
            this.PerformersDataGridView.Name = "PerformersDataGridView";
            this.PerformersDataGridView.RowTemplate.Height = 24;
            this.PerformersDataGridView.Size = new System.Drawing.Size(908, 373);
            this.PerformersDataGridView.TabIndex = 2;
            this.PerformersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerformersDataGridView_CellClick);
            this.PerformersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PerformersDataGridView_RowsAdded);
            // 
            // ButtonDeletePerformers
            // 
            this.ButtonDeletePerformers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeletePerformers.Location = new System.Drawing.Point(249, 18);
            this.ButtonDeletePerformers.Name = "ButtonDeletePerformers";
            this.ButtonDeletePerformers.Size = new System.Drawing.Size(105, 32);
            this.ButtonDeletePerformers.TabIndex = 1;
            this.ButtonDeletePerformers.Text = "Delete";
            this.ButtonDeletePerformers.UseVisualStyleBackColor = true;
            this.ButtonDeletePerformers.Click += new System.EventHandler(this.ButtonDeletePerformers_Click);
            // 
            // ButtonSavePerformers
            // 
            this.ButtonSavePerformers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSavePerformers.Location = new System.Drawing.Point(58, 18);
            this.ButtonSavePerformers.Name = "ButtonSavePerformers";
            this.ButtonSavePerformers.Size = new System.Drawing.Size(105, 32);
            this.ButtonSavePerformers.TabIndex = 0;
            this.ButtonSavePerformers.Text = "Save";
            this.ButtonSavePerformers.UseVisualStyleBackColor = true;
            this.ButtonSavePerformers.Click += new System.EventHandler(this.ButtonSavePerformers_Click);
            // 
            // PerformancesTab
            // 
            this.PerformancesTab.BackColor = System.Drawing.Color.Bisque;
            this.PerformancesTab.Controls.Add(this.PerformancesSearchButton);
            this.PerformancesTab.Controls.Add(this.PerformancesDataGridView);
            this.PerformancesTab.Controls.Add(this.ButtonDeletePerformances);
            this.PerformancesTab.Controls.Add(this.ButtonSavePerformances);
            this.PerformancesTab.Location = new System.Drawing.Point(4, 25);
            this.PerformancesTab.Name = "PerformancesTab";
            this.PerformancesTab.Size = new System.Drawing.Size(904, 441);
            this.PerformancesTab.TabIndex = 2;
            this.PerformancesTab.Text = "Performances";
            // 
            // PerformancesSearchButton
            // 
            this.PerformancesSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PerformancesSearchButton.Location = new System.Drawing.Point(629, 18);
            this.PerformancesSearchButton.Name = "PerformancesSearchButton";
            this.PerformancesSearchButton.Size = new System.Drawing.Size(153, 32);
            this.PerformancesSearchButton.TabIndex = 3;
            this.PerformancesSearchButton.Text = "Search";
            this.PerformancesSearchButton.UseVisualStyleBackColor = true;
            this.PerformancesSearchButton.Click += new System.EventHandler(this.PerformancesSearchButton_Click);
            // 
            // PerformancesDataGridView
            // 
            this.PerformancesDataGridView.AutoGenerateColumns = false;
            this.PerformancesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformancesDataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            this.PerformancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRFNAMEDataGridViewTextBoxColumn,
            this.pRFIDDataGridViewTextBoxColumn,
            this.pRFDATEDataGridViewTextBoxColumn,
            this.pRFPLACEDataGridViewTextBoxColumn,
            this.pRFPERFORMERIDDataGridViewTextBoxColumn,
            this.pRFSONGIDDataGridViewTextBoxColumn});
            this.PerformancesDataGridView.DataSource = this.pERFORMANCEBindingSource;
            this.PerformancesDataGridView.Location = new System.Drawing.Point(0, 68);
            this.PerformancesDataGridView.Name = "PerformancesDataGridView";
            this.PerformancesDataGridView.RowTemplate.Height = 24;
            this.PerformancesDataGridView.Size = new System.Drawing.Size(908, 373);
            this.PerformancesDataGridView.TabIndex = 2;
            this.PerformancesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerformancesDataGridView_CellClick);
            this.PerformancesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PerformancesDataGridView_DataError);
            this.PerformancesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PerformancesDataGridView_RowsAdded);
            // 
            // ButtonDeletePerformances
            // 
            this.ButtonDeletePerformances.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeletePerformances.Location = new System.Drawing.Point(249, 18);
            this.ButtonDeletePerformances.Name = "ButtonDeletePerformances";
            this.ButtonDeletePerformances.Size = new System.Drawing.Size(105, 32);
            this.ButtonDeletePerformances.TabIndex = 1;
            this.ButtonDeletePerformances.Text = "Delete";
            this.ButtonDeletePerformances.UseVisualStyleBackColor = true;
            this.ButtonDeletePerformances.Click += new System.EventHandler(this.ButtonDeletePerformances_Click);
            // 
            // ButtonSavePerformances
            // 
            this.ButtonSavePerformances.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSavePerformances.Location = new System.Drawing.Point(58, 18);
            this.ButtonSavePerformances.Name = "ButtonSavePerformances";
            this.ButtonSavePerformances.Size = new System.Drawing.Size(105, 32);
            this.ButtonSavePerformances.TabIndex = 0;
            this.ButtonSavePerformances.Text = "Save";
            this.ButtonSavePerformances.UseVisualStyleBackColor = true;
            this.ButtonSavePerformances.Click += new System.EventHandler(this.ButtonSavePerformances_Click);
            // 
            // ComposersTab
            // 
            this.ComposersTab.BackColor = System.Drawing.Color.Bisque;
            this.ComposersTab.Controls.Add(this.ComposerSearchButton);
            this.ComposersTab.Controls.Add(this.ComposersDataGridView);
            this.ComposersTab.Controls.Add(this.ButtonDeleteComposers);
            this.ComposersTab.Controls.Add(this.ButtonSaveComposers);
            this.ComposersTab.Location = new System.Drawing.Point(4, 25);
            this.ComposersTab.Name = "ComposersTab";
            this.ComposersTab.Size = new System.Drawing.Size(904, 441);
            this.ComposersTab.TabIndex = 3;
            this.ComposersTab.Text = "Composers";
            // 
            // ComposerSearchButton
            // 
            this.ComposerSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComposerSearchButton.Location = new System.Drawing.Point(629, 18);
            this.ComposerSearchButton.Name = "ComposerSearchButton";
            this.ComposerSearchButton.Size = new System.Drawing.Size(153, 32);
            this.ComposerSearchButton.TabIndex = 3;
            this.ComposerSearchButton.Text = "Search";
            this.ComposerSearchButton.UseVisualStyleBackColor = true;
            this.ComposerSearchButton.Click += new System.EventHandler(this.ComposerSearchButton_Click);
            // 
            // ComposersDataGridView
            // 
            this.ComposersDataGridView.AutoGenerateColumns = false;
            this.ComposersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComposersDataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            this.ComposersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComposersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMPFULLNAMEDataGridViewTextBoxColumn,
            this.cMPIDDataGridViewTextBoxColumn,
            this.cMPNATIONALITYDataGridViewTextBoxColumn,
            this.cMPBIRTHDATEDataGridViewTextBoxColumn,
            this.sONGsDataGridViewTextBoxColumn});
            this.ComposersDataGridView.DataSource = this.cOMPOSERBindingSource;
            this.ComposersDataGridView.Location = new System.Drawing.Point(0, 68);
            this.ComposersDataGridView.Name = "ComposersDataGridView";
            this.ComposersDataGridView.RowTemplate.Height = 24;
            this.ComposersDataGridView.Size = new System.Drawing.Size(908, 373);
            this.ComposersDataGridView.TabIndex = 2;
            this.ComposersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComposersDataGridView_CellClick);
            this.ComposersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ComposersDataGridView_RowsAdded);
            // 
            // ButtonDeleteComposers
            // 
            this.ButtonDeleteComposers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteComposers.Location = new System.Drawing.Point(249, 18);
            this.ButtonDeleteComposers.Name = "ButtonDeleteComposers";
            this.ButtonDeleteComposers.Size = new System.Drawing.Size(105, 32);
            this.ButtonDeleteComposers.TabIndex = 1;
            this.ButtonDeleteComposers.Text = "Delete";
            this.ButtonDeleteComposers.UseVisualStyleBackColor = true;
            this.ButtonDeleteComposers.Click += new System.EventHandler(this.ButtonDeleteComposers_Click);
            // 
            // ButtonSaveComposers
            // 
            this.ButtonSaveComposers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSaveComposers.Location = new System.Drawing.Point(58, 18);
            this.ButtonSaveComposers.Name = "ButtonSaveComposers";
            this.ButtonSaveComposers.Size = new System.Drawing.Size(105, 32);
            this.ButtonSaveComposers.TabIndex = 0;
            this.ButtonSaveComposers.Text = "Save";
            this.ButtonSaveComposers.UseVisualStyleBackColor = true;
            this.ButtonSaveComposers.Click += new System.EventHandler(this.ButtonSaveComposers_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPanel.BackgroundImage = global::Composers_Database_EF.Properties.Resources._1521283512_31922056;
            this.BackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackPanel.Location = new System.Drawing.Point(325, -2);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(585, 208);
            this.BackPanel.TabIndex = 2;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackgroundImage = global::Composers_Database_EF.Properties.Resources.multicolor_bright_music_background_notes_blurry_lights_48074667;
            this.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHeader.Location = new System.Drawing.Point(0, -2);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(327, 184);
            this.PanelHeader.TabIndex = 1;
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
            this.sNGNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNGGENREDataGridViewTextBoxColumn
            // 
            this.sNGGENREDataGridViewTextBoxColumn.DataPropertyName = "SNG_GENRE";
            this.sNGGENREDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.sNGGENREDataGridViewTextBoxColumn.Name = "sNGGENREDataGridViewTextBoxColumn";
            this.sNGGENREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNGDURATIONDataGridViewTextBoxColumn
            // 
            this.sNGDURATIONDataGridViewTextBoxColumn.DataPropertyName = "SNG_DURATION";
            this.sNGDURATIONDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.sNGDURATIONDataGridViewTextBoxColumn.Name = "sNGDURATIONDataGridViewTextBoxColumn";
            this.sNGDURATIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // pFNAMEDataGridViewTextBoxColumn
            // 
            this.pFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PF_NAME";
            this.pFNAMEDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.pFNAMEDataGridViewTextBoxColumn.Name = "pFNAMEDataGridViewTextBoxColumn";
            this.pFNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pFIDDataGridViewTextBoxColumn
            // 
            this.pFIDDataGridViewTextBoxColumn.DataPropertyName = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.HeaderText = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.Name = "pFIDDataGridViewTextBoxColumn";
            this.pFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pFDATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "PF_DATE_OF_BIRTH";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.Name = "pFDATEOFBIRTHDataGridViewTextBoxColumn";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pFNATIONALITYDataGridViewTextBoxColumn
            // 
            this.pFNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "PF_NATIONALITY";
            this.pFNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.pFNATIONALITYDataGridViewTextBoxColumn.Name = "pFNATIONALITYDataGridViewTextBoxColumn";
            this.pFNATIONALITYDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pERFORMANCEsDataGridViewTextBoxColumn1
            // 
            this.pERFORMANCEsDataGridViewTextBoxColumn1.DataPropertyName = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn1.HeaderText = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn1.Name = "pERFORMANCEsDataGridViewTextBoxColumn1";
            this.pERFORMANCEsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pERFORMERBindingSource
            // 
            this.pERFORMERBindingSource.DataSource = typeof(ComposersLibrary_EF.PERFORMER);
            // 
            // pRFNAMEDataGridViewTextBoxColumn
            // 
            this.pRFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRF_NAME";
            this.pRFNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pRFNAMEDataGridViewTextBoxColumn.Name = "pRFNAMEDataGridViewTextBoxColumn";
            this.pRFNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRFIDDataGridViewTextBoxColumn
            // 
            this.pRFIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.HeaderText = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.Name = "pRFIDDataGridViewTextBoxColumn";
            this.pRFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFDATEDataGridViewTextBoxColumn
            // 
            this.pRFDATEDataGridViewTextBoxColumn.DataPropertyName = "PRF_DATE";
            this.pRFDATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.pRFDATEDataGridViewTextBoxColumn.Name = "pRFDATEDataGridViewTextBoxColumn";
            this.pRFDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRFPLACEDataGridViewTextBoxColumn
            // 
            this.pRFPLACEDataGridViewTextBoxColumn.DataPropertyName = "PRF_PLACE";
            this.pRFPLACEDataGridViewTextBoxColumn.HeaderText = "Place";
            this.pRFPLACEDataGridViewTextBoxColumn.Name = "pRFPLACEDataGridViewTextBoxColumn";
            this.pRFPLACEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRFPERFORMERIDDataGridViewTextBoxColumn
            // 
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataSource = this.pERFORMERBindingSource;
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DisplayMember = "PF_NAME";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.HeaderText = "Performer\'s Name";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Name = "pRFPERFORMERIDDataGridViewTextBoxColumn";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.ValueMember = "PF_ID";
            // 
            // pRFSONGIDDataGridViewTextBoxColumn
            // 
            this.pRFSONGIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.DataSource = this.sONGBindingSource;
            this.pRFSONGIDDataGridViewTextBoxColumn.DisplayMember = "SNG_NAME";
            this.pRFSONGIDDataGridViewTextBoxColumn.HeaderText = "Song Name";
            this.pRFSONGIDDataGridViewTextBoxColumn.Name = "pRFSONGIDDataGridViewTextBoxColumn";
            this.pRFSONGIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRFSONGIDDataGridViewTextBoxColumn.ValueMember = "SNG_ID";
            // 
            // pERFORMANCEBindingSource
            // 
            this.pERFORMANCEBindingSource.DataSource = typeof(ComposersLibrary_EF.PERFORMANCE);
            // 
            // cMPFULLNAMEDataGridViewTextBoxColumn
            // 
            this.cMPFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CMP_FULL_NAME";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.Name = "cMPFULLNAMEDataGridViewTextBoxColumn";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cMPIDDataGridViewTextBoxColumn
            // 
            this.cMPIDDataGridViewTextBoxColumn.DataPropertyName = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.HeaderText = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.Name = "cMPIDDataGridViewTextBoxColumn";
            this.cMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPNATIONALITYDataGridViewTextBoxColumn
            // 
            this.cMPNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "CMP_NATIONALITY";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.Name = "cMPNATIONALITYDataGridViewTextBoxColumn";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cMPBIRTHDATEDataGridViewTextBoxColumn
            // 
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "CMP_BIRTH_DATE";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.Name = "cMPBIRTHDATEDataGridViewTextBoxColumn";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sONGsDataGridViewTextBoxColumn
            // 
            this.sONGsDataGridViewTextBoxColumn.DataPropertyName = "SONGs";
            this.sONGsDataGridViewTextBoxColumn.HeaderText = "SONGs";
            this.sONGsDataGridViewTextBoxColumn.Name = "sONGsDataGridViewTextBoxColumn";
            this.sONGsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMPOSERBindingSource
            // 
            this.cOMPOSERBindingSource.DataSource = typeof(ComposersLibrary_EF.COMPOSER);
            // 
            // AppearenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(910, 638);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.DTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(928, 685);
            this.MinimumSize = new System.Drawing.Size(928, 685);
            this.Name = "AppearenceForm";
            this.Text = "Appearance Database";
            this.DTab.ResumeLayout(false);
            this.SongsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).EndInit();
            this.PerformersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformersDataGridView)).EndInit();
            this.PerformancesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformancesDataGridView)).EndInit();
            this.ComposersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComposersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl DTab;
        private System.Windows.Forms.TabPage SongsTab;
        private System.Windows.Forms.TabPage PerformersTab;
        private System.Windows.Forms.TabPage PerformancesTab;
        private System.Windows.Forms.TabPage ComposersTab;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Button ButtonSaveSongs;
        private System.Windows.Forms.Button ButtonDeleteSongs;
        private System.Windows.Forms.DataGridView SongsDataGridView;
        private System.Windows.Forms.Button ButtonDeletePerformers;
        private System.Windows.Forms.Button ButtonSavePerformers;
        private System.Windows.Forms.DataGridView PerformersDataGridView;
        private System.Windows.Forms.DataGridView PerformancesDataGridView;
        private System.Windows.Forms.Button ButtonDeletePerformances;
        private System.Windows.Forms.Button ButtonSavePerformances;
        private System.Windows.Forms.DataGridView ComposersDataGridView;
        private System.Windows.Forms.Button ButtonDeleteComposers;
        private System.Windows.Forms.Button ButtonSaveComposers;
        private System.Windows.Forms.BindingSource sONGBindingSource;
        private System.Windows.Forms.BindingSource pERFORMERBindingSource;
        private System.Windows.Forms.BindingSource pERFORMANCEBindingSource;
        private System.Windows.Forms.BindingSource cOMPOSERBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFORMANCEsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRFPERFORMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRFSONGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPBIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchSongsButton;
        private System.Windows.Forms.Button SearchPerformersButton;
        private System.Windows.Forms.Button PerformancesSearchButton;
        private System.Windows.Forms.Button ComposerSearchButton;
    }
}

