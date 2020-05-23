using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LSP
{
    interface ISwitch {
        public void On();
        public void Off();
        
        public void Regular();
    }

    public class Fan : ISwitch
    {
        public void Off()
        {
            
        }

        public void On()
        {
            
        }

        public void Regular()
        {
            
        }
    }

    public class Cooler : ISwitch
    {
        public void Off()
        {
            
        }

        public void On()
        {
            
        }

        public void Regular()
        {
         
        }
    }

    public class Bulp : ISwitch
    {
        public void Off()
        {

        }

        public void On()
        {

        }

        public void Regular()
        {
            throw new NotImplementedException();
        }
    }

    public class RemoteControl
    {
        public void Main() {
            
            List<ISwitch> startSwitch = new List<ISwitch>();
            startSwitch.Add(new Cooler());
            startSwitch.Add(new Fan());
            startSwitch.Add(new Bulp());

            foreach (var o in startSwitch)
            {
                o.Regular();
            }

        }
    }
}
