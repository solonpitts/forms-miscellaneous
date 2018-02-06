using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_sxp146230
{

    class Record
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String middleInitial { get; set; }
        public String addressOne { get; set; }
        public String addressTwo { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zipcode { get; set; }
        public String phoneNumber { get; set; }
        public String email { get; set; }
        public bool proofOfPurchase { get; set; }
        public String date { get; set; }
        private String startTime;
        private String endTime;


        /*
         * Creates a record from a single string of tab seperated fields
         * */
        public Record(String data)
        {
            String[] fields = data.Split('\t');
            firstName = fields[0];
            lastName = fields[1];
            middleInitial = fields[2];
            addressOne = fields[3];
            addressTwo = fields[4];
            city = fields[5];
            state = fields[6];
            zipcode = fields[7];
            phoneNumber = fields[8];
            email = fields[9];
            if (fields[10].Equals("true"))
                proofOfPurchase = true;
            else
                proofOfPurchase = false;
            date = fields[11];
            startTime = fields[12];
            endTime = fields[13];
        }

        /*
         * Returns the record as a single string of tab seperated fields
         * */
        public String getRecordAsString()
        {
            String record = "";
            record = firstName + "\t" + lastName + "\t" + middleInitial + "\t" +addressOne
                + "\t" + addressTwo + "\t" + city + "\t" + state + "\t" + zipcode
                + "\t" + phoneNumber + "\t" + email + "\t";
            if (proofOfPurchase)
                record += "true" + "\t";
            else
                record += "false" + "\t";
            record+= date + "\t" + startTime + "\t"+ endTime;
            return record;
        }

    }
}
