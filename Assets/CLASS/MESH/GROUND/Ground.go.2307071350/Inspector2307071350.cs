//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.go2307071350
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        public Inspector()
        {
            Объект = new cs2307051626_ЗЕМЛЯ.Class() as cs2307031414_Default.IClass;
        }
        override public bool Выполнить()
        {
            return base.Выполнить();
        }
    }
}
