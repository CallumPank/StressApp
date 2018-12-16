using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment
{
    public class Data
    {
        //Contact Page
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string NameOfContact { get; set; }

        public string Relationship { get; set; }

        public string MobileNumber { get; set; }

        public string HomeNumber { get; set; }

        public string NameOfContact2 { get; set; }

        public string Relationship2 { get; set; }

        public string MobileNumber2 { get; set; }

        public string HomeNumber2 { get; set; }

        public int SliderDataDistressed { get; set; }

        public string SwitchDataDistressed { get; set; }
    }
}
