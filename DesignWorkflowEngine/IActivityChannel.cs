namespace DesignWorkflowEngine
{
    public interface IActivityChannel
    {
        void Execute(Action action);
    }
}