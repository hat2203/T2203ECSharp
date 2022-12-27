﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.session4
{
    public class DemoEvent
    {
        public event StringToVoid Print;
        public event StringToVoid Action;
        public event StringToVoid Touch;
        public event StringToVoid Swipe;
         public DemoEvent()
        {
            Print += DemoDelegate.SayHello;
            Print += new DemoDelegate().ShowInfor;
        }

        public void Invoke()
        {
            Print("Hello wordl");
        }
    }
}
