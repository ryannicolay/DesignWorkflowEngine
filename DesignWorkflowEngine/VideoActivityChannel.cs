using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWorkflowEngine
{
    public class VideoActivityChannel : IActivityChannel
    {
        public void Execute(Action action)
        {
            Console.WriteLine("Uploading Video....");
        }
    }
}
