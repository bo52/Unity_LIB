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
    }
    /// <summary>
    /// универсальный класс по получению информации
    /// </summary>
    public class Class: IClass
    {
        static public string INFO = "INFO";
        public virtual bool ИнтерфейсПоУмолчанию(GameObject go, string name = "Построить")
        {
            return false;
        }
    }
}