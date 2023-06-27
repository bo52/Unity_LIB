//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.go2305211505
{
    public interface IInspector: go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    public class Inspector: go2305081120.Inspector, go2305081120.IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        override public bool Выполнить()
        {
            СЦЕНА.ИзменитьРаботу();
            СЦЕНА.ПоказатьРаботу();
            return base.Выполнить();
        }
    }
}
