﻿namespace code.Forms
{
    partial class FormMarket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formTitle = new code.FormTitle();
            this.txtSearch = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new code.StyledButton();
            this.dataGridViewListings = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dropdownSortByName = new System.Windows.Forms.ComboBox();
            this.dropdownSortBySeller = new System.Windows.Forms.ComboBox();
            this.dropdownSortByPrice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Black;
            this.formTitle.Location = new System.Drawing.Point(12, 24);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(221, 26);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Ринок нерухомості";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(17, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(620, 29);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Пошук за назвою чи описом...";
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(643, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnExecuteSearch_Click);
            // 
            // dataGridViewListings
            // 
            this.dataGridViewListings.AllowUserToAddRows = false;
            this.dataGridViewListings.AllowUserToDeleteRows = false;
            this.dataGridViewListings.AllowUserToOrderColumns = true;
            this.dataGridViewListings.AllowUserToResizeRows = false;
            this.dataGridViewListings.AutoGenerateColumns = false;
            this.dataGridViewListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewListings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewListings.ColumnHeadersHeight = 35;
            this.dataGridViewListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewListings.DataSource = this.listingBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListings.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewListings.EnableHeadersVisualStyles = false;
            this.dataGridViewListings.Location = new System.Drawing.Point(17, 135);
            this.dataGridViewListings.Name = "dataGridViewListings";
            this.dataGridViewListings.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewListings.RowHeadersVisible = false;
            this.dataGridViewListings.RowTemplate.Height = 50;
            this.dataGridViewListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListings.Size = new System.Drawing.Size(757, 414);
            this.dataGridViewListings.TabIndex = 3;
            this.dataGridViewListings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListings_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Опис";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Продавець";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = "0";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn.FillWeight = 70F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listingBindingSource1
            // 
            this.listingBindingSource1.DataSource = typeof(code.Listing);
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataSource = typeof(code.Listing);
            // 
            // dropdownSortByName
            // 
            this.dropdownSortByName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownSortByName.FormattingEnabled = true;
            this.dropdownSortByName.Items.AddRange(new object[] {
            "Сортування за назвою",
            "А-Я",
            "Я-А"});
            this.dropdownSortByName.Location = new System.Drawing.Point(17, 100);
            this.dropdownSortByName.Name = "dropdownSortByName";
            this.dropdownSortByName.Size = new System.Drawing.Size(216, 21);
            this.dropdownSortByName.TabIndex = 4;
            // 
            // dropdownSortBySeller
            // 
            this.dropdownSortBySeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownSortBySeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownSortBySeller.FormattingEnabled = true;
            this.dropdownSortBySeller.Items.AddRange(new object[] {
            "Сортування за продавцем",
            "А-Я",
            "Я-А"});
            this.dropdownSortBySeller.Location = new System.Drawing.Point(239, 100);
            this.dropdownSortBySeller.Name = "dropdownSortBySeller";
            this.dropdownSortBySeller.Size = new System.Drawing.Size(202, 21);
            this.dropdownSortBySeller.TabIndex = 4;
            // 
            // dropdownSortByPrice
            // 
            this.dropdownSortByPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownSortByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownSortByPrice.FormattingEnabled = true;
            this.dropdownSortByPrice.Items.AddRange(new object[] {
            "Сортування за ціною",
            "За зростанням",
            "За спаданням"});
            this.dropdownSortByPrice.Location = new System.Drawing.Point(447, 100);
            this.dropdownSortByPrice.Name = "dropdownSortByPrice";
            this.dropdownSortByPrice.Size = new System.Drawing.Size(208, 21);
            this.dropdownSortByPrice.TabIndex = 4;
            // 
            // FormMarket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.dropdownSortByPrice);
            this.Controls.Add(this.dropdownSortBySeller);
            this.Controls.Add(this.dropdownSortByName);
            this.Controls.Add(this.dataGridViewListings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.formTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormMarket";
            this.Text = "FormMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormTitle formTitle;
        private System.Windows.Forms.RichTextBox txtSearch;
        private StyledButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewListings;
        private System.Windows.Forms.BindingSource listingBindingSource;
        private System.Windows.Forms.BindingSource listingBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox dropdownSortByName;
        private System.Windows.Forms.ComboBox dropdownSortBySeller;
        private System.Windows.Forms.ComboBox dropdownSortByPrice;
    }
}