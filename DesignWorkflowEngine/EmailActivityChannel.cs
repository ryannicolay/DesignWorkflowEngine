using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWorkflowEngine
{
    public class EmailActivityChannel : IActivityChannel
    {
        public void Execute(Action action)
        {
            Console.WriteLine("Sending Email....");
        }
    }
}
