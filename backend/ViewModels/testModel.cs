using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
  
namespace backend.ViewModels
{
    public class testJsonString
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string vek { get; set; }
        public Dictionary<string, string> veci  { get; set; }
    }
}