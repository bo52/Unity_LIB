//empty
//empty
//empty
using UnityEngine;

namespace LIB.go2306252014
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    /// <summary>
    /// Список Миров
    /// </summary>
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        private cs2307031414_Default.IClass _X; public cs2307031414_Default.IClass X {
            get
            {
                if (_X==null) _X = new cs2306221522_ЧанкПаралепипеда.Class();
                return _X;
            } 
        }
        override public bool Выполнить()
        {
            X.ИнтерфейсПоУмолчанию();
            return base.Выполнить();
        }
    }
}
