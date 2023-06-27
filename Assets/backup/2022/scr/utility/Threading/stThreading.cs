using System.Threading;
namespace utility2022
{
    /// <summary>
    /// для потоков sync
    /// </summary>
    public class stThreading
    {
        static public string INFO = "ПОТОК";
        static public SynchronizationContext sync = SynchronizationContext.Current;
    }
}
