namespace Composers_Database_EF
{
    partial class Performers_Search
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
            this.PerformerNameLabel = new System.Windows.Forms.Label();
            this.PerformerNationalityLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PerformerSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.pERFORMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANCEsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PerformerSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformerNameLabel
            // 
            this.PerformerNameLabel.AutoSize = true;
            this.PerformerNameLabel.Location = new System.Drawing.Point(31, 81);
            this.PerformerNameLabel.Name = "PerformerNameLabel";
            this.PerformerNameLabel.Size = new System.Drawing.Size(45, 17);
            this.PerformerNameLabel.TabIndex = 0;
            this.PerformerNameLabel.Text = "Name";
            // 
            // PerformerNationalityLabel
            // 
            this.PerformerNationalityLabel.AutoSize = true;
            this.PerformerNationalityLabel.Location = new System.Drawing.Point(31, 130);
            this.PerformerNationalityLabel.Name = "PerformerNationalityLabel";
            this.PerformerNationalityLabel.Size = new System.Drawing.Size(74, 17);
            this.PerformerNationalityLabel.TabIndex = 1;
            this.PerformerNationalityLabel.Text = "Nationality";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(174, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(193, 22);
            this.NameTextBox.TabIndex = 3;
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(174, 130);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(193, 22);
            this.NationalityTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(539, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(147, 39);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PerformerSearchDataGridView
            // 
            this.PerformerSearchDataGridView.AutoGenerateColumns = false;
            this.PerformerSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformerSearchDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.PerformerSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformerSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERFORMANCEsDataGridViewTextBoxColumn,
            this.pFIDDataGridViewTextBoxColumn,
            this.pFNAMEDataGridViewTextBoxColumn,
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn,
            this.pFNATIONALITYDataGridViewTextBoxColumn});
            this.PerformerSearchDataGridView.DataSource = this.pERFORMERBindingSource;
            this.PerformerSearchDataGridView.Location = new System.Drawing.Point(0, 219);
            this.PerformerSearchDataGridView.Name = "PerformerSearchDataGridView";
            this.PerformerSearchDataGridView.RowTemplate.Height = 24;
            this.PerformerSearchDataGridView.Size = new System.Drawing.Size(802, 343);
            this.PerformerSearchDataGridView.TabIndex = 7;
            // 
            // pERFORMERBindingSource
            // 
            this.pERFORMERBindingSource.DataSource = typeof(ComposersLibrary_EF.PERFORMER);
            // 
            // sONGBindingSource
            // 
            this.sONGBindingSource.DataSource = typeof(ComposersLibrary_EF.SONG);
            // 
            // pERFORMANCEsDataGridViewTextBoxColumn
            // 
            this.pERFORMANCEsDataGridViewTextBoxColumn.DataPropertyName = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn.HeaderText = "PERFORMANCEs";
            this.pERFORMANCEsDataGridViewTextBoxColumn.Name = "pERFORMANCEsDataGridViewTextBoxColumn";
            this.pERFORMANCEsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pFIDDataGridViewTextBoxColumn
            // 
            this.pFIDDataGridViewTextBoxColumn.DataPropertyName = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.HeaderText = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.Name = "pFIDDataGridViewTextBoxColumn";
            this.pFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pFNAMEDataGridViewTextBoxColumn
            // 
            this.pFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PF_NAME";
            this.pFNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pFNAMEDataGridViewTextBoxColumn.Name = "pFNAMEDataGridViewTextBoxColumn";
            // 
            // pFDATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "PF_DATE_OF_BIRTH";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.Name = "pFDATEOFBIRTHDataGridViewTextBoxColumn";
            // 
            // pFNATIONALITYDataGridViewTextBoxColumn
            // 
            this.pFNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "PF_NATIONALITY";
            this.pFNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.pFNATIONALITYDataGridViewTextBoxColumn.Name = "pFNATIONALITYDataGridViewTextBoxColumn";
            // 
            // Performers_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.PerformerSearchDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NationalityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PerformerNationalityLabel);
            this.Controls.Add(this.PerformerNameLabel);
            this.Name = "Performers_Search";
            this.ShowIcon = false;
            this.Text = "Performers Search";
            ((System.ComponentModel.ISupportInitialize)(this.PerformerSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PerformerNameLabel;
        private System.Windows.Forms.Label PerformerNationalityLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NationalityTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView PerformerSearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERFORMANCEsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pERFORMERBindingSource;
        private System.Windows.Forms.BindingSource sONGBindingSource;
    }
}