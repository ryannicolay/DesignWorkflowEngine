using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWorkflowEngine
{
    public class ChangeStatusOfVideoActivityChannel : IActivityChannel
    {
        public void Execute(Action action)
        {
            Console.WriteLine("Changing status to Processing....");
        }
    }
}
