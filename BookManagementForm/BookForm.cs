using System;
using System.Windows.Forms;

namespace BookManagementForm
{
    public partial class BookForm : Form
    {
        BookManagement bookManagement = null;
        public BookForm()
        {
            bookManagement = new BookManagement();
            InitializeComponent();
            removeBtn.Enabled = false;
            updateBtn.Enabled = false;
            exportBtn.Enabled = false;
            bookTypeCbx.SelectedIndex = 0;
        }

        public void showSearch(string name, int choice)
        {
            SearchForm sf = new SearchForm();
            sf.LoadSearchTable(bookManagement.SearchByNameAndRangeOfDate(name, choice));
            sf.ShowDialog();
        }

        public void loadTable()
        {
            tableBook.Rows.Clear();
            foreach (Book book in bookManagement.GetListBook())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tableBook);
                row.SetValues(book.Id, book.Name, book.IsNativeBook, book.Author, book.Price, book.Quantity, book.NumOfReprints, book.PublishDate);
                tableBook.Rows.Add(row);
            }
            if (bookManagement.GetListBook().Count == 0)
            {
                exportBtn.Enabled = false;
            }
            else
            {
                exportBtn.Enabled = true;
            }
        }

        public void addBook()
        {
            String id = IdTxt.Text.Trim();
            String name = nameTxt.Text.Trim();
            String author = authorTxt.Text.Trim();
            String price = priceTxt.Text.Trim();
            DateTime publishDate = publishDateTxt.Value;
            decimal quantity = quantityTxt.Value;
            decimal rePublisher = republisherTxt.Value;
            bool isNative = true;
            if (isNativeBookRadio.Checked)
            {
                isNative = true;
            }
            if (isTranslateBookRadio.Checked)
            {
                isNative = false;
            }
            Book book = new Book(id, name, publishDate, (int)rePublisher, float.Parse(price), (int)quantity, author, isNative);
            bookManagement.AddBook(book);
            loadTable();
        }

        public void updateBook()
        {
            String id = IdTxt.Text.Trim();
            String name = nameTxt.Text.Trim();
            String author = authorTxt.Text.Trim();
            String price = priceTxt.Text.Trim();
            DateTime publishDate = publishDateTxt.Value;
            decimal quantity = quantityTxt.Value;
            decimal rePublisher = republisherTxt.Value;
            bool isNative = true;
            if (isNativeBookRadio.Checked)
            {
                isNative = true;
            }
            if (isTranslateBookRadio.Checked)
            {
                isNative = false;
            }
            Book book = new Book(id, name, publishDate, (int)rePublisher, float.Parse(price), (int)quantity, author, isNative);
            bookManagement.UpdateBook(book);
            loadTable();
        }

        public void clearInput()
        {
            IdTxt.Enabled = true;
            IdTxt.Focus();
            IdTxt.Clear();
            nameTxt.Clear();
            authorTxt.Clear();
            priceTxt.Clear();
            publishDateTxt.Value = DateTime.Now;
            quantityTxt.Value = 1;
            republisherTxt.Value = 0;
            isNativeBookRadio.Checked = false;
            isTranslateBookRadio.Checked = false;
            tableBook.ClearSelection();
            AddBtn.Enabled = true;
            removeBtn.Enabled = false;
            updateBtn.Enabled = false;
        }

        public bool validateInput(bool isForUpdate)
        {
            errorProvider1.Clear();
            String id = IdTxt.Text.Trim();
            String name = nameTxt.Text.Trim();
            String author = authorTxt.Text.Trim();
            String price = priceTxt.Text.Trim();
            DateTime publishDate = publishDateTxt.Value;
            decimal quantity = quantityTxt.Value;
            decimal rePublisher = republisherTxt.Value;

            bool bError = false;
            if (Validation.isEmpty(id))
            {
                errorProvider1.SetError(IdTxt, "ID is not null!");
                bError = true;
            }

            if (!isForUpdate)
            {
                if (bookManagement.GetBookById(id) != null)
                {
                    errorProvider1.SetError(IdTxt, "ID is available!");
                    bError = true;
                }
            }


            if (Validation.isEmpty(name))
            {
                errorProvider1.SetError(nameTxt, "Name is not null!");
                bError = true;
            }

            if (Validation.isEmpty(author))
            {
                errorProvider1.SetError(authorTxt, "Author is not null!");
                bError = true;
            }

            if (!Validation.isDouble(price, 0.1, double.MaxValue))
            {
                errorProvider1.SetError(priceTxt, "Price is a double!");
                bError = true;
            }

            if (!Validation.isPast(publishDate))
            {
                errorProvider1.SetError(publishDateTxt, "Publisher Date is in past!");
                bError = true;
            }

            if (!isNativeBookRadio.Checked && !isTranslateBookRadio.Checked)
            {
                errorProvider1.SetError(isTranslateBookRadio, "Please choose one!");
                bError = true;
            }

            if (!Validation.isInteger(quantity.ToString(), 1, 100))
            {
                errorProvider1.SetError(quantityTxt, quantity.ToString() + "Quantity is from 1 to 100!");
                bError = true;
            }

            if (!Validation.isInteger(rePublisher.ToString(), 0, 100))
            {
                errorProvider1.SetError(republisherTxt, rePublisher.ToString() + "Republisher time is from 0 to 100!");
                bError = true;
            }

            if (bError)
            {
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!validateInput(false))
            {
                return;
            }
            else
            {
                addBook();
                clearInput();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this book ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string id = IdTxt.Text.Trim();
                bool check = bookManagement.RemoveBook(id);
                if (check)
                {
                    loadTable();
                    clearInput();
                }
                else
                {
                    return;
                }
            }
            return;
        }

        private void tableBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableBook.CurrentRow == null)
            {
                return;
            }
            tableBook.CurrentRow.Selected = true;
            if(e.RowIndex < 0)
            {
                return;
            }
            string id = tableBook.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
            Book selectedBook = bookManagement.GetBookById(id);
            if (selectedBook != null)
            {
                IdTxt.Text = selectedBook.Id;
                nameTxt.Text = selectedBook.Name;
                authorTxt.Text = selectedBook.Author;
                priceTxt.Text = selectedBook.Price.ToString();
                quantityTxt.Value = selectedBook.Quantity;
                republisherTxt.Value = selectedBook.NumOfReprints;
                publishDateTxt.Value = selectedBook.PublishDate;
                bool isNative = selectedBook.IsNativeBook;
                if (isNative)
                {
                    isNativeBookRadio.Checked = true;
                    isTranslateBookRadio.Checked = false;
                }
                else
                {
                    isNativeBookRadio.Checked = false;
                    isTranslateBookRadio.Checked = true;
                }
                IdTxt.Enabled = false;
                removeBtn.Enabled = true;
                AddBtn.Enabled = false;
                updateBtn.Enabled = true;
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this book ??",
                                     "Confirm Update!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (!validateInput(true))
                {
                    return;
                }
                else
                {
                    updateBook();
                    clearInput();
                }
            }
            return;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Data files|*.dat|Text files|*.txt|Both files|*.dat;*.txt";
            DialogResult rs = saveFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                bookManagement.ExportData(saveFileDialog.FileName);
            }
            else
            {
                return;
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Data files|*.dat|Text files|*.txt|Both files|*.dat;*.txt|All files|*.*";
            DialogResult rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (bookManagement.GetListBook().Count == 0)
                {
                    bookManagement.ImportData(openFileDialog.FileName, true);
                }
                else
                {
                    var confirmResult = MessageBox.Show("Do you want to rewrite ??",
                                    "RewriteConfirm!",
                                    MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bookManagement.ImportData(openFileDialog.FileName, true);
                    }
                    if (confirmResult == DialogResult.No)
                    {
                        bookManagement.ImportData(openFileDialog.FileName, false);
                    }
                }
                loadTable();
            }
            else
            {
                return;
            }
        }

        private void nameSearchLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = 0;
            if(bookTypeCbx.SelectedItem.ToString().ToLower().Equals("native book"))
            {
                choice = 1;
            }
            if (bookTypeCbx.SelectedItem.ToString().ToLower().Equals("translate book"))
            {
                choice = 2;
            }
            showSearch(searchTxt.Text.Trim(), choice);
        }
    }
}
