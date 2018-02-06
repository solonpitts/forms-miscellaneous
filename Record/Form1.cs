using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Asg3_sxp146230
{
    public partial class Form1 : Form
    {
        String fileName;
        String outputFile = "CS6326Asg3.txt";
        List<String> startTimes = new List<String>();
        List<String> endTimes = new List<String>();
        int numBackSpaces;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            analyzeButton.Enabled = false;
            fileName = "";
            numBackSpaces = 0;
            this.CenterToScreen();
        }

        /*
         * When the button is clicked, try to open the file and analyze()
         * */
        private void analyzeBox_Click(object sender, EventArgs e)
        {
            outputFile = outputBox.Text;
            fileName = filenameBox.Text;
            if (File.Exists(fileName))
            {
                debugLabel.Text = "";
                using (StreamReader sr = File.OpenText(fileName))
                {
                    String line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] fields = line.Split('\t');
                        startTimes.Add(fields[12]);
                        endTimes.Add(fields[13]);
                        int back = 0;
                        int.TryParse(fields[14], out back);
                        numBackSpaces += back;
                    }
                }
                Analyze();
            }
            //file does not exist
            else
                debugLabel.Text = "The file does not exist.";
        }


        /*
         * Performs all the calculations for times, and prints them
         * */
        private void Analyze()
        {
            int numRecords = startTimes.Count;
            int minEntryTime = 100000;
            int maxEntryTime = 0;
            int avgEntryTime = 0;
            //for avg calc
            int totalEntryTime = 0;
            int minInterTime = 100000;
            int maxInterTime = 0;
            int avgInterTime = 0;
            //for avg calc
            int totalInterTime = 0;
            int totalTime = 0;
            String backSpaces = numBackSpaces.ToString();
            int lastTime =0;

            foreach(String time in startTimes)
            {
                String[] sTimes = time.Split(':');
                String[] eTimes = endTimes.ElementAt(startTimes.IndexOf(time)).Split(':');
                int sHour = 0;
                int.TryParse(sTimes[0], out sHour);
                int eHour = 0;
                int.TryParse(eTimes[0], out eHour);
                int sMin = 0;
                int.TryParse(sTimes[1],out sMin);
                int eMin = 0;
                int.TryParse(eTimes[1], out eMin);
                int sSec = 0;
                int.TryParse(sTimes[2], out sSec);
                int eSec = 0;
                int.TryParse(eTimes[2], out eSec);
                
                int timeOfStart = sSec + (60 * sMin) + (60 * 60 * sHour);
                int timeOfEnd = eSec + (60 * eMin) + (60 * 60 * eHour);
                
                int interTimeInSeconds = 0;
                
                //get the inter-entry Time
                if (lastTime != 0)
                {
                    interTimeInSeconds = timeOfStart - lastTime;
                    totalTime += interTimeInSeconds;
                }
                    
                lastTime = timeOfEnd;

                int differenceInSeconds = timeOfEnd - timeOfStart;
                
                totalTime += differenceInSeconds;

                totalEntryTime += differenceInSeconds;
                if (differenceInSeconds < minEntryTime)
                    minEntryTime = differenceInSeconds;
                if (differenceInSeconds > maxEntryTime)
                    maxEntryTime = differenceInSeconds;

                if(interTimeInSeconds!= 0)
                {
                    totalInterTime += interTimeInSeconds;
                    if (interTimeInSeconds < minInterTime)
                        minInterTime = interTimeInSeconds;
                    if (interTimeInSeconds > maxInterTime)
                        maxInterTime = interTimeInSeconds;
                }   
            }
            avgEntryTime = totalEntryTime / numRecords;
            avgInterTime = totalInterTime / (numRecords-1);
            //debugLabel.Text = differenceInSeconds.ToString();

            using (StreamWriter sw = File.CreateText(outputFile))
            {
                sw.WriteLine("Number of Records: " + numRecords.ToString());
                numRecordBox.Text = numRecords.ToString();

                int minutes = minEntryTime / 60;
                if (minEntryTime < 60)
                    minutes = 0;
                int seconds = minEntryTime - (minutes * 60);
                String field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Minimum entry time: " + field);
                minEntryBox.Text = field;

                if (maxEntryTime > 60)
                    minutes = maxEntryTime / 60;
                else
                    minutes = 0;
                seconds = maxEntryTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Maximum entry time: "+ field);
                maxEntryBox.Text = field;

                if (avgEntryTime > 60)
                    minutes = avgEntryTime / 60;
                else
                    minutes = 0;
                seconds = avgEntryTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Average entry time: " + field);
                avgEntryBox.Text = field;

                if (minInterTime > 60)
                    minutes = minInterTime / 60;
                else
                    minutes = 0;
                seconds = minInterTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Minimum Inter-Entry time: " + field);
                minInterBox.Text = field;

                if (maxInterTime > 60)
                    minutes = maxInterTime / 60;
                else
                    minutes = 0;
                seconds = maxInterTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Maximum Inter-Entry time: " + field);
                maxInterBox.Text = field;

                if (avgInterTime > 60)
                    minutes = avgInterTime / 60;
                else
                    minutes = 0;
                seconds = avgInterTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Avg Inter-Entry time: " + field);
                avgInterBox.Text = field;

                if (totalTime > 60)
                    minutes = totalTime / 60;
                else
                    minutes = 0;
                seconds = totalTime - (minutes * 60);
                field = minutes.ToString() + ":" + seconds.ToString();
                sw.WriteLine("Total time: " + field);
                totalTimeBox.Text = field;

                sw.WriteLine("Number of backspaces: " + backSpaces);
                backBox.Text = backSpaces;
            }

        }

        /*
         * Checks if there is data in both fields in order to activate the button
         * */
        private void Box_TextChanged(object sender, EventArgs e)
        {
            if (filenameBox.Text.Equals("") || outputBox.Text.Equals(""))
                analyzeButton.Enabled = false;
            else
                analyzeButton.Enabled = true;
        }
    }
}
