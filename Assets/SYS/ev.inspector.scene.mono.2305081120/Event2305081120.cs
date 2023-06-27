//empty
//empty
//empty
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.go2305081120
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEvent
    {
        IInspector ОбъктМира { get; set; }
        bool Выполнить();
    }
    /// <summary>
    /// 
    /// </summary>
    public class MyEvent : Object, IEvent
    {
        private IInspector ObjectWorld;
        public IInspector ОбъктМира
        {
            get => ObjectWorld;
            set => ObjectWorld = value;
        }
        public virtual bool Выполнить()
        {
            return false;
        }
    }
}