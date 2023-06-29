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
    public interface IClass: cs2305141202.IClass
    {
    }
    /// <summary>
    /// Только Сохранить
    /// </summary>
    public class Class : cs2305141202.Class, IClass
    {
        static public string INFO = "INFO";
        public struct Struct
        {
            public string path;
            public string namefile;
            public Struct(string ИмяМеша, string ПатчМеша="")
            {
                this.path = ПатчМеша;
                this.namefile = ИмяМеша;
            }
            public void Сохранить(Mesh M) => st2305161716.Class.fun230516171604_СохранитьМешПоИмени(M, namefile, path);
            public void ПостроитьМеш(System.Action<cs2305141202.IClass> ФункцияПостройки, GameObject go = null)
            {
                cs2305141202.IClass edit = go == null ? new cs2306291207.Class(this, ФункцияПостройки)/*Save*/ : new cs2306291245.Class(this, go, ФункцияПостройки)/*Save+go*/;
                edit.Закрыть();
            }
        }
        Struct Параметры;
        public Class(Struct Параметры, System.Action<cs2305141202.IClass> ФункцияПостройки) :base(ФункцияПостройки)
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
