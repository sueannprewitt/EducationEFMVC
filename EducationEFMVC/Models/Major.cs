using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEFMVC.Models
{
    public class Major
    {
        public int Id { get; set; }
        public string Description { get; set; }

        //this fixed the recursive filling of student information when using Json
        [JsonIgnore]
        public ICollection<Student> Students { get; set; }
    }
}