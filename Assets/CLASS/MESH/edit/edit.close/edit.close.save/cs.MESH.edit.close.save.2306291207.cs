//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306291207
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2305141208.IClass
    {
    }
    /// <summary>
    /// Только Сохранить
    /// </summary>
    public class Class : cs2305141208.Class, IClass
    {
        static public string INFO = "INFO";
        cs2306301504.Class Параметры;
        public Class(cs2306301504.Class Параметры, cs2307031203_ПараметрыПостройки.Struct param_build) : base(param_build)
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
