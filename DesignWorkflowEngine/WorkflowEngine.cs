using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWorkflowEngine
{
    class WorkflowEngine
    {
        private readonly IList<IActivityChannel> _activityChannels;

        public WorkflowEngine()
        {
            _activityChannels = new List<IActivityChannel>();
        }

        public void Run()
        {
            foreach (var channel in _activityChannels)
                channel.Execute(new Action());
        }

        public void RegisterActivityChannel(IActivityChannel channel)
        {
            _activityChannels.Add(channel);
        }
    }
}
