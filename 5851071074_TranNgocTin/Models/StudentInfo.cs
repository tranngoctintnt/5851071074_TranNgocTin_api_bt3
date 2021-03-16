using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5851071074_TranNgocTin.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Masv")]
        public string Masv { get; set; }

        [DataMember(Name = "NamSinh")]
        public int Namsinh { get; set; }


        [DataMember(Name = "Age")]
        public int Age { get; set; }
    }
}