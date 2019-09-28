/*Nicholas Tran
 * February 28, 2018
 * Mid-Term Lab Section
 * CIS 3309 Friedman
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookSearchProgram
{
    class updatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;   // Reference variable of type SW
        private int recordWriteCount;

        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public updatedFileClass(string filePath)
        {
            recordWriteCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Cannot open file " + updatedFilePath + " Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } // end currentFileClass Constructor 



        // Write a record from the current file
        public void writeNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "IO error in file write. Terminate program.",
                                "File Write Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } // end try and catch

            recordWriteCount++; // increment the record written count
        } // end putNextRecord()


        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWriteCount;
        } // end getRecordsWrittenCount



        // Close the output file
        public void closeFile()
        {
            updatedFileSW.Close();
        }  // end closeFile


        // Rewind the output file
        public void rewindFile()
        {
            recordWriteCount = 0;
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.Flush();
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }  // end rewindFile

    } // end currentFileClass
} // end namespace
