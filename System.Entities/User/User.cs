using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Entities
{
    public class User : DefaultDbo
    {
        public int Id { get; set; }
        public int Type { get; set; }

        public string Message { get; set; }
        public string JsonContent { get; set; }

    }

}
