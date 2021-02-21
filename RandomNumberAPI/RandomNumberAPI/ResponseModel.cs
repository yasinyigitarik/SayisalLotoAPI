using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomNumberAPI
{
    public class ResponseModel
    {
        public  ResponseModel()
        {
            Numbers = new List<string>();
        }
        public bool Status { get; set; }
        public List<String> Numbers { get; set; }
    }

}
