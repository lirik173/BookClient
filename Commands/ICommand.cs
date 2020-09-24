using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Commands
{
    interface ICommand
    {
        public void Execute();  
    }
}
