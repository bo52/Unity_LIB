//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306291245
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306291123.Class, IClass
    {
        static new public string INFO = "INFO";
        cs2306291207.Class.Struct Параметры;
        public Class(cs2306291207.Class.Struct Параметры, GameObject go, System.Action<cs2305141202.IClass> ФункцияПостройки) : base(go, ФункцияПостройки)
        {
            this.Параметры = Параметры;
        }
        public override Mesh Закрыть()
        {
            var M = base.Закрыть();
            Параметры.Сохранить(M);
            return M;
        }
    }
}
