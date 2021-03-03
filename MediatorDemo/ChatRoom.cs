using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " [" + user.GetName() + "] : " + message);
        }
    }
}
