//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307031414_Default
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        public string ИмяКнопки { get; }
        public GameObject ИгровойОбъект { get; }
        public void Выполнить() { }
        bool ИнтерфейсПоУмолчанию();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        private GameObject _go; public GameObject ИгровойОбъект => _go;
        public virtual string ИмяКнопки => "Выполнить";
        public Class(GameObject go)
        {
            _go = go;
        }
        public virtual void Выполнить() { }
        public virtual bool ИнтерфейсПоУмолчанию()
        {
            return st2305161151.Class.fun230516115102_btn_name(ИмяКнопки, Выполнить);
        }
    }
}
