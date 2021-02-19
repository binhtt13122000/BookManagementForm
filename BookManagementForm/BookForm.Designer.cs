
namespace BookManagementForm
{
    partial class BookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.publishDateTxt = new System.Windows.Forms.DateTimePicker();
            this.republisherTxt = new System.Windows.Forms.NumericUpDown();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isTranslateBookRadio = new System.Windows.Forms.RadioButton();
            this.isNativeBookRadio = new System.Windows.Forms.RadioButton();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.publishDateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rePublishLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.nameSearchLabel = new System.Windows.Forms.Label();
            this.tableBook = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NativeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RePublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.startTxt = new System.Windows.Forms.DateTimePicker();
            this.endTxt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.republisherTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.importBtn);
            this.splitContainer1.Panel1.Controls.Add(this.exportBtn);
            this.splitContainer1.Panel1.Controls.Add(this.updateBtn);
            this.splitContainer1.Panel1.Controls.Add(this.removeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.AddBtn);
            this.splitContainer1.Panel1.Controls.Add(this.newBtn);
            this.splitContainer1.Panel1.Controls.Add(this.publishDateTxt);
            this.splitContainer1.Panel1.Controls.Add(this.republisherTxt);
            this.splitContainer1.Panel1.Controls.Add(this.quantityTxt);
            this.splitContainer1.Panel1.Controls.Add(this.priceTxt);
            this.splitContainer1.Panel1.Controls.Add(this.authorTxt);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.nameTxt);
            this.splitContainer1.Panel1.Controls.Add(this.IdTxt);
            this.splitContainer1.Panel1.Controls.Add(this.publishDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.typeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.rePublishLabel);
            this.splitContainer1.Panel1.Controls.Add(this.authorLabel);
            this.splitContainer1.Panel1.Controls.Add(this.quantityLabel);
            this.splitContainer1.Panel1.Controls.Add(this.priceLabel);
            this.splitContainer1.Panel1.Controls.Add(this.nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.IdLabel);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.tableBook);
            this.splitContainer1.Size = new System.Drawing.Size(1338, 645);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 0;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(234, 573);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(102, 31);
            this.importBtn.TabIndex = 21;
            this.importBtn.Text = "Import Data";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(52, 573);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(115, 31);
            this.exportBtn.TabIndex = 20;
            this.exportBtn.Text = "Export Data";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(340, 510);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 31);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(234, 510);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(85, 31);
            this.removeBtn.TabIndex = 18;
            this.removeBtn.Text = "Remove";
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(129, 510);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(85, 31);
            this.AddBtn.TabIndex = 17;
            this.AddBtn.Text = "Add Book";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.Add_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(27, 510);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(85, 31);
            this.newBtn.TabIndex = 16;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // publishDateTxt
            // 
            this.publishDateTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.publishDateTxt.Location = new System.Drawing.Point(159, 435);
            this.publishDateTxt.Name = "publishDateTxt";
            this.publishDateTxt.Size = new System.Drawing.Size(132, 27);
            this.publishDateTxt.TabIndex = 15;
            // 
            // republisherTxt
            // 
            this.republisherTxt.Location = new System.Drawing.Point(159, 384);
            this.republisherTxt.Name = "republisherTxt";
            this.republisherTxt.Size = new System.Drawing.Size(55, 27);
            this.republisherTxt.TabIndex = 14;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(159, 332);
            this.quantityTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(55, 27);
            this.quantityTxt.TabIndex = 13;
            this.quantityTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(159, 277);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(170, 27);
            this.priceTxt.TabIndex = 12;
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(159, 230);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(170, 27);
            this.authorTxt.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.isTranslateBookRadio);
            this.panel1.Controls.Add(this.isNativeBookRadio);
            this.panel1.Location = new System.Drawing.Point(94, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 63);
            this.panel1.TabIndex = 10;
            // 
            // isTranslateBookRadio
            // 
            this.isTranslateBookRadio.AutoSize = true;
            this.isTranslateBookRadio.Location = new System.Drawing.Point(139, 19);
            this.isTranslateBookRadio.Name = "isTranslateBookRadio";
            this.isTranslateBookRadio.Size = new System.Drawing.Size(127, 24);
            this.isTranslateBookRadio.TabIndex = 1;
            this.isTranslateBookRadio.TabStop = true;
            this.isTranslateBookRadio.Text = "Translate Book";
            this.isTranslateBookRadio.UseVisualStyleBackColor = true;
            // 
            // isNativeBookRadio
            // 
            this.isNativeBookRadio.AutoSize = true;
            this.isNativeBookRadio.Location = new System.Drawing.Point(11, 19);
            this.isNativeBookRadio.Name = "isNativeBookRadio";
            this.isNativeBookRadio.Size = new System.Drawing.Size(111, 24);
            this.isNativeBookRadio.TabIndex = 0;
            this.isNativeBookRadio.TabStop = true;
            this.isNativeBookRadio.Text = "Native Book";
            this.isNativeBookRadio.UseVisualStyleBackColor = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(159, 71);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(170, 27);
            this.nameTxt.TabIndex = 9;
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(159, 31);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(170, 27);
            this.IdTxt.TabIndex = 8;
            // 
            // publishDateLabel
            // 
            this.publishDateLabel.AutoSize = true;
            this.publishDateLabel.Location = new System.Drawing.Point(38, 440);
            this.publishDateLabel.Name = "publishDateLabel";
            this.publishDateLabel.Size = new System.Drawing.Size(92, 20);
            this.publishDateLabel.TabIndex = 6;
            this.publishDateLabel.Text = "Publish Date";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(52, 117);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(78, 20);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Book Type";
            // 
            // rePublishLabel
            // 
            this.rePublishLabel.AutoSize = true;
            this.rePublishLabel.Location = new System.Drawing.Point(52, 386);
            this.rePublishLabel.Name = "rePublishLabel";
            this.rePublishLabel.Size = new System.Drawing.Size(73, 20);
            this.rePublishLabel.TabIndex = 7;
            this.rePublishLabel.Text = "RePublish";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(76, 233);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 20);
            this.authorLabel.TabIndex = 4;
            this.authorLabel.Text = "Author";
            this.authorLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(27, 334);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(103, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Book Quantity";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(51, 280);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(79, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Book Price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Book Name";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(106, 34);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 20);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.endTxt);
            this.panel2.Controls.Add(this.startTxt);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchTxt);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.nameSearchLabel);
            this.panel2.Location = new System.Drawing.Point(64, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 224);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(488, 183);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 31);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(194, 42);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(170, 27);
            this.searchTxt.TabIndex = 22;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(44, 109);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(110, 20);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "Search by Time";
            // 
            // nameSearchLabel
            // 
            this.nameSearchLabel.AutoSize = true;
            this.nameSearchLabel.Location = new System.Drawing.Point(37, 45);
            this.nameSearchLabel.Name = "nameSearchLabel";
            this.nameSearchLabel.Size = new System.Drawing.Size(117, 20);
            this.nameSearchLabel.TabIndex = 22;
            this.nameSearchLabel.Text = "Search by Name";
            this.nameSearchLabel.Click += new System.EventHandler(this.nameSearchLabel_Click);
            // 
            // tableBook
            // 
            this.tableBook.AllowUserToAddRows = false;
            this.tableBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.NativeBook,
            this.Author,
            this.Price,
            this.Quantity,
            this.RePublish,
            this.PublishDate});
            this.tableBook.Location = new System.Drawing.Point(0, 0);
            this.tableBook.Name = "tableBook";
            this.tableBook.RowHeadersWidth = 51;
            this.tableBook.RowTemplate.Height = 29;
            this.tableBook.Size = new System.Drawing.Size(885, 356);
            this.tableBook.TabIndex = 0;
            this.tableBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBook_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // NativeBook
            // 
            this.NativeBook.HeaderText = "Native Book";
            this.NativeBook.MinimumWidth = 6;
            this.NativeBook.Name = "NativeBook";
            this.NativeBook.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // RePublish
            // 
            this.RePublish.HeaderText = "RePublish";
            this.RePublish.MinimumWidth = 6;
            this.RePublish.Name = "RePublish";
            this.RePublish.Width = 125;
            // 
            // PublishDate
            // 
            this.PublishDate.HeaderText = "Publish Date";
            this.PublishDate.MinimumWidth = 6;
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // startTxt
            // 
            this.startTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTxt.Location = new System.Drawing.Point(232, 104);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(132, 27);
            this.startTxt.TabIndex = 22;
            // 
            // endTxt
            // 
            this.endTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTxt.Location = new System.Drawing.Point(232, 172);
            this.endTxt.Name = "endTxt";
            this.endTxt.Size = new System.Drawing.Size(132, 27);
            this.endTxt.TabIndex = 24;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 645);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "BookForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.republisherTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label rePublishLabel;
        private System.Windows.Forms.Label publishDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.DateTimePicker publishDateTxt;
        private System.Windows.Forms.NumericUpDown republisherTxt;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.DataGridView tableBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NativeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RePublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton isTranslateBookRadio;
        private System.Windows.Forms.RadioButton isNativeBookRadio;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameSearchLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox sear;
        private System.Windows.Forms.TextBox ch;
        private System.Windows.Forms.DateTimePicker endTxt;
        private System.Windows.Forms.DateTimePicker startTxt;
    }
}

