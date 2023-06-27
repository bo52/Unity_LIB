//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.go2306252014
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        override public bool Выполнить()
        {
            return base.Выполнить();
        }
    }
}
