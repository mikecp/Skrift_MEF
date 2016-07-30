namespace SkriftMEF.Logging.Interface
{
    public interface ILogger
    {
        string Name { get; }
        void Log(int level, string message);
    }

}
