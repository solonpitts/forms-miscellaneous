/*
*  Written by Solon Pitts for CS6326.001, assignment 5, starting Nov 9, 2017.
*  NetID: sxp146230
*  
*  This program allows the user to specify any text file and any string to search for within that file. The program creates a
*  background worker to handle the reading of the file while the main thread updates the list for display in the listview.
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextSearch
{
    public partial class Form1 : Form
    {
        private String filename;
        private String searchString;
        //total number of lines in the file
        private int fileLength;
        private int lastLineNumber;
        //the total count of matching lines found
        private int count;
        private Reader reader;

        public Form1()
        {
            InitializeComponent();
            filename = "";
            searchString = "";
        }

        /*
         * When the search button is clicked, its text is changed to "cancel" and vice versa.
         * Also disables all input except the cancel button, and calls the start thread method
         * */
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchButton.Text.Equals("Search"))
            {
                lastLineNumber = -1;
                listView.Items.Clear();
                filename = filenameBox.Text;
                filenameBox.Enabled = false;
                searchString = searchBox.Text;
                searchBox.Enabled = false;
                searchButton.Text = "Cancel";
                fileBrowseButton.Enabled = false;
                fileLength = File.ReadLines(filename).Count();
                progressBar.Maximum = fileLength;
                progressBar.Value = 0;
                progressLabel.Text = "0 of 0 Lines Read";
                count = 0;
                StartThread();
            }
            else //"Cancel"
            {
                this.backgroundWorker1.CancelAsync();
            }
        }

        /*
         * Adds a given line and line number to the ListView
         * also updates the progress bar
         * */
        private void addToListView(Reader.CurrentState cs)
        {
            if (!cs.currentLine.Equals("") && cs.lineNumber > lastLineNumber)
            {
                String[] str = new String[2];
                str[0] = cs.lineNumber.ToString();
                str[1] = cs.currentLine;
                listView.Items.Add(new ListViewItem(str));
                count++;
                lastLineNumber = cs.lineNumber;
            }
            progressBar.PerformStep();
            progressLabel.Text = cs.lineNumber.ToString() + " of " + fileLength + " Lines Read";
        }

        /*
         * If there is text in both input boxes, enable the search button
         * */
        private void box_TextChanged(object sender, EventArgs e)
        {
            if (filenameBox.Text.Length > 0 && searchBox.Text.Length > 0)
                searchButton.Enabled = true;
            else
                searchButton.Enabled = false;
        }

        /*
         * When the thread completes or is cancelled, reset all the inputs
         * and display the total lines found
         * */
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // This event handler is called when the background thread finishes. 
            // This method runs on the main thread. 
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            filenameBox.Enabled = true;
            searchBox.Enabled = true;
            searchButton.Text = "Search";
            fileBrowseButton.Enabled = true;
            progressLabel.Text = "Total Lines Found:" + count.ToString();
        }

        /*
         * Called whenever the thread updates its progress, which is every line it reads
         * */
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // This method runs on the main thread.
            Reader.CurrentState state =
                (Reader.CurrentState)e.UserState;
            addToListView(state);
            reader.wait = false;
        }

        /*
         * This is run by the thread, and it calls the reader.findMatch method which actually searches the file for the string
         * */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker worker;
            worker = (System.ComponentModel.BackgroundWorker)sender;
            
            Reader reader = (Reader)e.Argument;
            reader.findMatch(worker, e);
        }

        /*
         * Creates a new reader and runs the backgroundworker with it
         * */
        private void StartThread()
        {
            // This method runs on the main thread. 

            // Initialize the object that the background worker calls.
            reader = new Reader();
            reader.searchString = searchString;
            reader.sourceFile = filename;
            reader.wait = false;

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(reader);
        }

        /*
         * Opens the browse file dialogue menu
         * */
        private void fileBrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filenameBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
