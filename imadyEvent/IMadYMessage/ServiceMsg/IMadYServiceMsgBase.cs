using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMadY.Message
{
    public class IMadYServiceMsgBase<T> 
    {
        public bool success { get; set; }

        public T msgBody { get; set; }

        public string msg { get; set; }
    }

}
