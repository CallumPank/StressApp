using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment
{
    public class Data
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string NameOfContact { get; set; }

        public string Relationship { get; set; }

        public string MobileNumber { get; set; }

        public string HomeNumber { get; set; }
    }
}
