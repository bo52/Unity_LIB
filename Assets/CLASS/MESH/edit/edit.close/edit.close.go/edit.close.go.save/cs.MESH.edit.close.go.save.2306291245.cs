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
        cs2306301504.Class Параметры;
        public Class(cs2306301504.Class Параметры, GameObject go, cs2307031203_ПараметрыПостройки.Struct param_build) : base(go, param_build)
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
