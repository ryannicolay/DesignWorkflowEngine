using System;

namespace DesignWorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkflowEngine();

            workflow.RegisterActivityChannel(new VideoActivityChannel());
            workflow.RegisterActivityChannel(new WebServiceActivityChannel());
            workflow.RegisterActivityChannel(new EmailActivityChannel());
            workflow.RegisterActivityChannel(new ChangeStatusOfVideoActivityChannel());
            workflow.Run();

            Console.ReadLine();
        }
    }
}
