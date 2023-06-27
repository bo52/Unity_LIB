using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace spBuild
{
    public interface IBlock8_close : LIB.cs2305141208.IClass
    {
        public void Закрыть(GameObject go)
        {
            (this as LIB.cs2305141208.IClass).Закрыть();
            (this as IBlock8_vs_border).ПостроитьГраницы(go);
        }
    }
}