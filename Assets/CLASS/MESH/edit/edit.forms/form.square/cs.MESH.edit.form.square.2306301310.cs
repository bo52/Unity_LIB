//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306301310
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2305141215.IClass
    {
        public void ADD(cs2306301359.Class Triangle, Vector3 v4);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2305141215.Class, IClass
    {
        static public string INFO = "INFO";
        private cs2305181555.IClass ВершиныКвадрата;
        public Class(cs2305141208.Class.ПараметрыПостройки param) : base(param)
        {
            ВершиныКвадрата = new cs2305181555.Class(this);
        }
        public void ADD(cs2306301359.Class Triangle,Vector3 v4)
        {
            ВершиныКвадрата.v1 = Triangle.v1;
            ВершиныКвадрата.v2 = Triangle.v2;
            ВершиныКвадрата.v3 = Triangle.v3;
            ВершиныКвадрата.v4 = v4;
            ВершиныКвадрата.ДобавитьКвадрат();
        }
        public void Интерфейс()
        {
            //st2305141354.Class.fun230514135401_Вектор(ref )
        }
    }
}
