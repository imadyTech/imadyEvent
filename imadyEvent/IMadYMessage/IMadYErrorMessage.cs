using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMadY.Message
{
    public class IMadYErrorMessage<T> : IMadYMessageBase where T : class
    {
        public T messageBody { get; set; }

        public IMadYErrorMessage(T message)
        {
            messageBody = message;
        }
    }
}
