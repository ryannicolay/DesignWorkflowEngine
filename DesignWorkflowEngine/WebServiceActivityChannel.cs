using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWorkflowEngine
{
    public class WebServiceActivityChannel : IActivityChannel
    {
        public void Execute(Action action)
        {
            Console.WriteLine("Calling the Web Service");
        }
    }
}
