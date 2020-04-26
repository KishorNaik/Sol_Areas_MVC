using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Areas.Admin.Context
{
    public interface IMessage
    {
        String GetMessage();
    }

    public class Message : IMessage
    {
        string IMessage.GetMessage()
        {
            return "Hello";
        }
    }
}
