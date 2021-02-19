using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookManagementForm
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

        }

        public void LoadSearchTable(List<Book> list)
        {
            tableSearch.Rows.Clear();
            foreach (Book book in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(tableSearch);
                row.SetValues(book.Id, book.Name, book.IsNativeBook, book.Author, book.Price, book.Quantity, book.NumOfReprints, book.PublishDate);
                tableSearch.Rows.Add(row);
            }
        }
    }
}
