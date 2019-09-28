using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSearchProgram
{
    public partial class frmBookSearch : Form
    {
        public frmBookSearch()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Globals.myBookList.writeToFile();
            MessageBox.Show("Number of books: " + Globals.myBookList.getAddCounter() 
                + "\nSucessful Searches: " + Globals.myBookList.getSuccessCounter() 
                + "\nFailed Searches: " + Globals.myBookList.getFailureCounter());
            this.Close();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Cannot be blank.");
                txtName.Clear();
                txtName.Focus();
                return;

            }
            else
            {
                MessageBox.Show("Welcome " + name + ".");
                txtName.ReadOnly = true;
                btnAdd.Visible = true;
                btnSearch.Visible = true;
                btnName.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlAdd.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlSearch.Enabled = true;
        }

        private void btnProcessAdd_Click(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            if (String.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Cannot be blank.");
                txtTitle.Clear();
                txtTitle.Focus();
                return;
            }
            String author = txtAuthor.Text;
            if (String.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Cannot be blank.");
                txtAuthor.Clear();
                txtAuthor.Focus();
                return;
            }
            String keywords = txtAddKeywords.Text;
            if (String.IsNullOrWhiteSpace(keywords))
            {
                MessageBox.Show("Cannot be blank.");
                txtAddKeywords.Clear();
                txtAddKeywords.Focus();

                return;
            }
            else
            {
                Globals.myBookList.createBookObject(txtTitle.Text, txtAuthor.Text, txtAddKeywords.Text);
                MessageBox.Show("Added Book.");
                txtTitle.Clear();
                txtAddKeywords.Clear();
                txtAuthor.Clear();
                pnlAdd.Visible = false;
                pnlAdd.Enabled = false;

            }
        }

        private void btnProcessSearch_Click(object sender, EventArgs e)
        {
            String keywords = txtSearchKeyword.Text;
            if (String.IsNullOrWhiteSpace(keywords))
            {
                MessageBox.Show("Cannot be blank.");
                txtSearchKeyword.Clear();
                txtSearchKeyword.Focus();
                return;
            }
            else
            {
                Globals.myBookList.searchListForBook(txtSearchKeyword.Text);
                txtSearchKeyword.Clear();
                txtSearchKeyword.Focus();
                pnlSearch.Visible = false;
                pnlSearch.Enabled = false;
            }
        }
    }
}
