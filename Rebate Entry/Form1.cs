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

namespace Asg2_sxp146230
{
    public partial class Form1 : Form
    {
        private bool wrongInput = false;
        List<Record> records = new List<Record>();
        private String startTime;
        private String endTime;
        private String fileName = "CS6326Asg2.txt";
        private Record currentRecord;

        public Form1()
        {
            InitializeComponent();
            
        }

        /*
         * Sets the default values and loads the stored records from the text file
         * */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            startTime = DateTime.Now.ToString("HH:mm:ss");
            datePicker.MaxDate = DateTime.Now;
            datePicker.Value = DateTime.Now;
            
            deleteButton.Enabled = false;
            saveButton.Enabled = false;

            if(File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    String line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        Record r = new Record(line);
                        records.Add(r);
                        addToListView(r);
                    }
                }
            }
            recordList.FullRowSelect = true;
        }

        /*
         * Adds a given record, r, to the recordList ListView
         * */
        private void addToListView(Record r)
        {
            String[] str = new String[2];
            str[0] = r.firstName + " ";
            if (r.middleInitial != "")
                str[0] += r.middleInitial + " ";
            str[0] += r.lastName;
            str[1] = r.phoneNumber;
            recordList.Items.Add(new ListViewItem(str));
        }

        /*
         * Returns true if there is another record with the same first and last names, and middle initial
         * */
        private bool isDuplicate()
        {
            if(currentRecord != null && currentRecord.firstName.Equals(firstNameBox.Text) && currentRecord.lastName.Equals(lastNameBox.Text)
                && currentRecord.middleInitial.Equals(middleIntitialBox.Text))
            return false;
            else
                foreach(Record r in records)
                {
                    if (r.firstName.Equals(firstNameBox.Text) && r.lastName.Equals(lastNameBox.Text)
                        && r.middleInitial.Equals(middleIntitialBox.Text))
                        return true;
                }

            return false;
        }

        /*
         * If there is a currently selected record, save the fields
         * If there is no currently selected record, then create a new record with the data in the fields
         * */
        public void createRecord()
        {
            if (currentRecord != null) //we are modifying a record
            {
                currentRecord.firstName = firstNameBox.Text;
                currentRecord.lastName = lastNameBox.Text;
                currentRecord.middleInitial = middleIntitialBox.Text;
                currentRecord.addressOne = address1Box.Text;
                currentRecord.addressTwo = address2Box.Text;
                currentRecord.city = cityBox.Text;
                currentRecord.state = stateBox.Text;
                currentRecord.email = emailBox.Text;
                currentRecord.zipcode = zipBox.Text;
                currentRecord.phoneNumber = phoneBox.Text;
                currentRecord.proofOfPurchase = proofOfPurchaseCheckbox.Checked;
                currentRecord.date = datePicker.Value.ToShortDateString();
                warningLabel.Text = "";

                //replace it in the listview
                recordList.Items.RemoveAt(records.IndexOf(currentRecord));

                String[] str = new String[2];
                str[0] = currentRecord.firstName + " ";
                if (currentRecord.middleInitial != "")
                    str[0] += currentRecord.middleInitial + " ";
                str[0] += currentRecord.lastName;
                str[1] = currentRecord.phoneNumber;
                recordList.Items.Insert(records.IndexOf(currentRecord), new ListViewItem(str));
            }
            else //a new record
            {
                String record = "";
                record += firstNameBox.Text + "\t" + lastNameBox.Text + "\t" + middleIntitialBox.Text + "\t" +
                    address1Box.Text + "\t" + address2Box.Text + "\t" + cityBox.Text + "\t" + stateBox.Text
                    + "\t" + zipBox.Text + "\t" + phoneBox.Text + "\t" + emailBox.Text + "\t";
                if (proofOfPurchaseCheckbox.Checked)
                    record += "true" + "\t";
                else
                    record += "false" + "\t";
                record += datePicker.Value.ToShortDateString() + "\t" + startTime + "\t" + endTime;

                Record r = new Record(record);

                records.Add(r);
                addToListView(r);
                warningLabel.Text = "";
            }
        }

        /*
         * Can press when selecting the checkbox to check it
         * */
        private void proofOfPurchaseCheckbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                proofOfPurchaseCheckbox.Checked = !proofOfPurchaseCheckbox.Checked;
                e.Handled = true;
            }
        }

        /*
         * Marks any input other than letters as invalid
         * */
        private void charOnlyBox_KeyDown(object sender, KeyEventArgs e)
        {
            wrongInput = false;
            if (e.KeyValue > 90 || e.KeyValue < 65 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Return)
                wrongInput = true;
        }

        /*
         * Marks any input other than letter and spaces as invalid
         * */
        private void charWithSpacesBox_KeyDown(object sender, KeyEventArgs e)
        {
            wrongInput = false;
            if (e.KeyValue > 90 || e.KeyValue < 65 && e.KeyCode != Keys.Back && e.KeyCode != Keys.Return && e.KeyCode != Keys.Space)
                wrongInput = true;
        }

        /*
         * Marks any input other than numbers as invalid
         * */
        private void numbersOnlyBox_KeyDown(object sender, KeyEventArgs e)
        {
            wrongInput = false;
            if (e.Shift || (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && e.KeyCode != Keys.Back)
                wrongInput = true;
        }

        /*
         * Ignores any incorrect input
         * */
        private void inputSensitiveBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (wrongInput)
                e.Handled = true;
            
        }

        /*
         * Deletes the currently selected record from the list and the text file
         * */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(currentRecord != null)
            {
                recordList.Items.RemoveAt(records.IndexOf(currentRecord));
                records.Remove(currentRecord);
               
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (Record r in records)
                    {
                        sw.WriteLine(r.getRecordAsString());
                    }
                }
            }
            clear();
        }


        /*
         * If the record is a duplicate, inform the user
         * Otherwise create the record and write it to the file
         * */
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isDuplicate())
            {
                warningLabel.Text = "You are trying to save a record with the same name as a pre-existing record.";
                firstNameBox.BackColor = Color.LightPink;
                lastNameBox.BackColor = Color.LightPink;
                middleIntitialBox.BackColor = Color.LightPink;
            }
            else
            {
                endTime = DateTime.Now.ToString("HH:mm:ss");
                createRecord();
                currentRecord = null;
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    foreach (Record r in records)
                    {
                        sw.WriteLine(r.getRecordAsString());
                    }
                }
                clear();
            }
        }

        /*
         * Calls the clear method
         * */
        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        /*
         * Resets all defaults and clears all fields
         * */
        private void clear()
        {
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            middleIntitialBox.Text = "";
            address1Box.Text = "";
            address2Box.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            emailBox.Text = "";
            zipBox.Text = "";
            phoneBox.Text = "";
            proofOfPurchaseCheckbox.Checked = false;
            datePicker.MaxDate = DateTime.Now;
            datePicker.Value = DateTime.Now;
            startTime = DateTime.Now.ToString("HH:mm:ss");
            currentRecord = null;
            deleteButton.Enabled = false;
            firstNameBox.BackColor = Color.White;
            lastNameBox.BackColor = Color.White;
            middleIntitialBox.BackColor = Color.White;
        }

        /*
         * When an item in the list is selected by double-clicking, make it the currently selected Record
         * */
        private void recordList_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = recordList.SelectedItems;

            foreach (ListViewItem item in items)
            {
                foreach (Record r in records)
                {
                    String[] name = item.SubItems[0].Text.Split(' ');
                    if (r.firstName.Equals(name[0]))
                        if (name.Length == 2 && r.lastName.Equals(name[1]))
                            currentRecord = r;
                        else if (name.Length == 3 && r.lastName.Equals(name[2]) && r.middleInitial.Equals(name[1]))
                            currentRecord = r;
                }
            }
            populateFields(currentRecord);
            deleteButton.Enabled = true;
        }

        /*
         * Change the text fields to match the currently selected record
         * */
        private void populateFields(Record r)
        {
            if(r != null)
            {
                firstNameBox.Text = r.firstName;
                lastNameBox.Text = r.lastName;
                middleIntitialBox.Text = r.middleInitial;
                address1Box.Text = r.addressOne;
                address2Box.Text = r.addressTwo;
                cityBox.Text = r.city;
                stateBox.Text = r.state;
                emailBox.Text = r.email;
                phoneBox.Text = r.phoneNumber;
                zipBox.Text = r.zipcode;
                if (r.proofOfPurchase)
                    proofOfPurchaseCheckbox.Checked = true;
                else
                    proofOfPurchaseCheckbox.Checked = false;
                datePicker.Value = DateTime.Parse(r.date);
            }
        }


        /*
         * Only activates the save button when every required field has data
         * */
        private void Box_TextChanged(object sender, EventArgs e)
        {
            if (firstNameBox.Text.Equals("") || lastNameBox.Text.Equals("") || cityBox.Text.Equals("") || address1Box.Text.Equals("")
                || stateBox.Text.Length != 2 || zipBox.Text.Length < 5 || phoneBox.Text.Equals("") || emailBox.Text.Equals(""))
                saveButton.Enabled = false;
            else if(emailBox.Text.Count(x => x == '@') != 1 || emailBox.Text.Count(x => x == '.') != 1)
                saveButton.Enabled = false;
            else
                saveButton.Enabled = true;
        }
    }
}
