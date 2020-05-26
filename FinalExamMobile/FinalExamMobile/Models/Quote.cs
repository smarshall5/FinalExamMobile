using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamMobile.Models
{
    
   public class Quote
    {
      
        public string quote { get; set; }
        
        public string author { get; set; }
 
        public string category { get; set; }

        public string imageURL { get; set; }
    }
}
