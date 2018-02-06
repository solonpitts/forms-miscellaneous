/*
*  Written by Solon Pitts for CS6326.001, assignment 5, starting Nov 9, 2017.
*  NetID: sxp146230
*  
*  Reader.cs: This class is what is managed by the thread, and the FindMatch method specifically is run by the background worker
*  It finds each matching line in the given file and passes that information to the main thread.
* */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSearch
{
    class Reader
    {
        /*
         * A class for passing the line number and current line to the main thread
         * */
        public class CurrentState
        {
            public int lineNumber;
            public String currentLine;
        }

        public Boolean wait;
        public string sourceFile;
        public string searchString;
        private String currentLine;
        private int lineNumber;

        /*
         * Reads through the file and finds all matching strings, passing them to the main thread through worker.reportProgress
         * */
        public void findMatch(
            System.ComponentModel.BackgroundWorker worker,
            System.ComponentModel.DoWorkEventArgs e)
        {
            CurrentState state = new CurrentState();
            string line = "";

            if (searchString == null ||
                searchString == System.String.Empty)
            {
                throw new Exception("SearchString not specified.");
            }

            //opens a streamreader
            using (System.IO.StreamReader myStream = new System.IO.StreamReader(sourceFile))
            {
                // Process lines while there are lines remaining in the file. 
                while (!myStream.EndOfStream)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else if(!wait) //when this thread is not waiting, read the next line and handle it
                    {
                        System.Threading.Thread.Sleep(1);
                        line = myStream.ReadLine();
                        currentLine = line;
                        lineNumber += 1;
                        state.lineNumber = lineNumber;

                        if (currentLine.ToUpper().Contains(searchString.ToUpper())) //where the string is found
                        {
                            state.currentLine = currentLine;
                        } 
                        else
                            state.currentLine = "";
                        wait = true;
                        worker.ReportProgress(0, state);
                    }
                    
                }
            }
        }
    }
}
