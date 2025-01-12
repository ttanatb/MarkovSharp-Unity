namespace MarkovSharp
{
    public class ILog
    {
        public void Debug(string msg)
        {
            Info(msg);
        }
        public void Info(string msg)
        {
            UnityEngine.Debug.Log(msg);
        }

        public void Warn(string msg)
        {
            UnityEngine.Debug.LogError(msg);
        }
    }
    public class LogManager
    {
        public static ILog GetLogger(object _)
        {
            return new ILog();
        }
    }
}
