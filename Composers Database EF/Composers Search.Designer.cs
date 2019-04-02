namespace Composers_Database_EF
{
    partial class Composers_Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ComposerSearchDataGridView = new System.Windows.Forms.DataGridView();
            this.cMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPBIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPOSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComposerSearchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nationality";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(210, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(174, 22);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(210, 136);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(174, 22);
            this.NationalityTextBox.TabIndex = 3;
            this.NationalityTextBox.TextChanged += new System.EventHandler(this.NationalityTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(521, 98);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 29);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ComposerSearchDataGridView
            // 
            this.ComposerSearchDataGridView.AutoGenerateColumns = false;
            this.ComposerSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComposerSearchDataGridView.BackgroundColor = System.Drawing.Color.IndianRed;
            this.ComposerSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComposerSearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMPIDDataGridViewTextBoxColumn,
            this.cMPFULLNAMEDataGridViewTextBoxColumn,
            this.cMPNATIONALITYDataGridViewTextBoxColumn,
            this.cMPBIRTHDATEDataGridViewTextBoxColumn,
            this.sONGsDataGridViewTextBoxColumn});
            this.ComposerSearchDataGridView.DataSource = this.cOMPOSERBindingSource;
            this.ComposerSearchDataGridView.Location = new System.Drawing.Point(0, 211);
            this.ComposerSearchDataGridView.Name = "ComposerSearchDataGridView";
            this.ComposerSearchDataGridView.RowTemplate.Height = 24;
            this.ComposerSearchDataGridView.Size = new System.Drawing.Size(800, 338);
            this.ComposerSearchDataGridView.TabIndex = 5;
            // 
            // cMPIDDataGridViewTextBoxColumn
            // 
            this.cMPIDDataGridViewTextBoxColumn.DataPropertyName = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.HeaderText = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.Name = "cMPIDDataGridViewTextBoxColumn";
            this.cMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPFULLNAMEDataGridViewTextBoxColumn
            // 
            this.cMPFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CMP_FULL_NAME";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.Name = "cMPFULLNAMEDataGridViewTextBoxColumn";
            // 
            // cMPNATIONALITYDataGridViewTextBoxColumn
            // 
            this.cMPNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "CMP_NATIONALITY";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.Name = "cMPNATIONALITYDataGridViewTextBoxColumn";
            // 
            // cMPBIRTHDATEDataGridViewTextBoxColumn
            // 
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "CMP_BIRTH_DATE";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.Name = "cMPBIRTHDATEDataGridViewTextBoxColumn";
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
            // Composers_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.ComposerSearchDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NationalityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Composers_Search";
            this.ShowIcon = false;
            this.Text = "Composers Search";
            ((System.ComponentModel.ISupportInitialize)(this.ComposerSearchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NationalityTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ComposerSearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPBIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cOMPOSERBindingSource;
    }
}