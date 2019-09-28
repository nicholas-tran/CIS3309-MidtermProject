/*Nicholas Tran
 * February 28, 2018
 * Mid-Term Lab Section
 * CIS 3309 Friedman
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSearchProgram
{   //Class containing a list of book objects
    class BookListClass
    {   //Attributes of the book list
        //Counter for successful searches
        int successCounter = 0;
        //Counter for failed searches
        int failCounter = 0;
        //Counter for amount of adds to list
        int addCounter = 0;
        //List to store book objects
        List<BookClass> internalList = new List<BookClass>();
        //File directory
        private static string updatedBookFilePath = "updatedBookFile.txt";
        //Constructor for the book reader
        public static updatedFileClass updatedBookFile = new
            updatedFileClass(updatedBookFilePath);

        //Constructor for BookListClass
        public BookListClass()
        {
            internalList = new List<BookClass>();
        }

        //Creates a book object from book constructor, adds to list and increments an add counter
        public void createBookObject(String Title, String Author, String Keyword)
        {
            BookClass tempBook = new BookClass(Title, Author, Keyword);
            internalList.Add(tempBook);
            addCounter++;
        }

        //Getter for successful searches
        public int getSuccessCounter()
        {
            return successCounter;
        }
        //Getter for failed searches
        public int getFailureCounter()
        {
            return failCounter;
        }
        //Getter for add searches
        public int getAddCounter()
        {
            return addCounter;
        }

        //Searches list for a book keyword
        public bool searchListForBook(String Keyword)
        {
            BookClass currentBook;
            String errorString = "No matches found.";
            String[] stringArray;
            for (int i = 0; i < internalList.Count; i++)
            {
                currentBook = internalList.ElementAt(i);
                stringArray = currentBook.splitKeywords();
                if (currentBook.compareKeywords(stringArray, Keyword))
                {
                    successCounter++;
                    MessageBox.Show(currentBook.toString());
                    return true;

                }
            }
            failCounter++;
            MessageBox.Show(errorString);
            return false;
        }//End searchListForBook method

        //Writes to file
        public void writeToFile()
        {
            BookClass tempBook;
            for (int i = 0; i < internalList.Count; i++)
            {
                tempBook = internalList.ElementAt(i);
                
                String bookString = tempBook.getString();

                updatedBookFile.writeNextRecord(bookString);
            }
            updatedBookFile.closeFile();
        }//End writeToFile method
    }
}
