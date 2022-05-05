using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMadY.Message
{
    public class IMadYServiceMsg : IMadYServiceMsgBase<object>
    {
        public IMadYServiceMsg()
        {
            base.msg = "";
            base.msgBody = null;
            base.success = false;
        }

        public IMadYServiceMsg(bool success): this()
        {
            base.success = success;
        }
        public IMadYServiceMsg(string msg) : this()
        {
            base.msg = msg;
        }
        public IMadYServiceMsg(string msg, bool success): this(msg)
        {
            base.success = success;
        }

        public IMadYServiceMsg(object value) : this()
        {
            base.msgBody = value;
            base.success = true;
        }

        public IMadYServiceMsg(object value, string msg) : this(msg)
        {
            base.msgBody = value;
            base.success = true;
        }

    }
}
