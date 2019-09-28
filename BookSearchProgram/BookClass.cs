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

namespace BookSearchProgram
{   //Class of books
    class BookClass
    {   //Attributes of a book
        //Author of book
        String hiddenAuthor = "";
        //Title of book
        String hiddenTitle = "";
        //Keywords of book
        String hiddenKeywords = "";

        //Constructor for book class
        public BookClass(String title, String author, String keywords)
        {
            hiddenTitle = title;
            hiddenAuthor = author;
            hiddenKeywords = keywords;
        }//End constructor

        //Split keyword of the object into a string array
        public String[] splitKeywords()
        {
            String[] stringArray = hiddenKeywords.Split();
            for (int i = 0; i < stringArray.Length; i++)
            {
                String tempString = stringArray[i].Trim();
                stringArray[i] = tempString;
            }
            return stringArray;
        }//End SplitKeyword method

        //Compares keyword of the string array assembled from attribute hiddenKeywords and the parameter keyword
        public Boolean compareKeywords(String[] array, String keyword)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(keyword))
                {
                    return true;
                }
            }
            return false;
        }//End compareKeywords method

        //Creates a string concatenated from the attributes and separated by asterisks for write
        public String getString()
        {
            String bookString = hiddenTitle + " * " + hiddenAuthor + " * " + hiddenKeywords;
            return bookString;
        }//End getString method

        //Creates a string concatenated from the attributes for messagebox
        public String toString()
        {
            String bookString = "Title: " + hiddenTitle + "\nAuthor: " + hiddenAuthor + "\nKeywords:  " + hiddenKeywords;
            return bookString;
        }//End getString method

    }
}
