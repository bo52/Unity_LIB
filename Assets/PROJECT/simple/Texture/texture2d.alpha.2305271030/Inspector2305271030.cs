//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.go2305271030
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
    }
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;

        public override bool Тест()
        {
            //st2306262206.Class.fun230626220600_ПостроитьОдинЧанкЗемлиПоУмолчанию(this.Моно.gameObject);
            return false;
        }
        override public bool Выполнить()
        {
            return base.Выполнить();
        }
    }
}
