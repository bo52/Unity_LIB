//empty
//empty
//универсальный класс по получению информации
using UnityEditor;
using UnityEngine;
/// <summary>
/// CLASS
/// </summary>
namespace LIB.cs2305071643_Default
{
    public interface IClass
    {
        bool ИнтерфейсПоУмолчанию(GameObject go, string name = "Построить");
        abstract void Построить(GameObject go);
    }
    /// <summary>
    /// универсальный класс по получению информации
    /// </summary>
    public abstract class Class: IClass
    {
        static public string INFO = "INFO";
        public abstract void Построить(GameObject go);
        public virtual bool ИнтерфейсПоУмолчанию(GameObject go, string name = "Построить")
        {
            return st2305161151.Class.fun230516115102_btn_name(name, () => Построить(go));
        }
    }
}