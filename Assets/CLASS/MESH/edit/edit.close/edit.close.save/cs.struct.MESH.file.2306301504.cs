//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306301504
{
    /// <summary>
    ///
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public string path;
        public string namefile;
        public Class(string ИмяМеша, string ПатчМеша = "")
        {
            this.path = ПатчМеша;
            this.namefile = ИмяМеша;
        }
        public bool СуществуетМеш => st2305161619.Class.fun230516161901_СуществуетМеш(namefile);
        public void ПривязатьМеш(GameObject go) => st2305072046.Class.fun230507204602_ПривязатьМешОтФайлаПоИмени(namefile, go, path);
        public void Сохранить(Mesh M) => st2305161716.Class.fun230516171604_СохранитьМешПоИмени(M, namefile, path);
        public void ПостроитьМеш(cs2307031203_ПараметрыПостройки.Class param_build, GameObject go = null)
        {
            //var param_build = new cs2305141208.Class.ПараметрыПостройки(ФункцияПостройки, НомерРедактора);
            cs2305141208.IClass edit = go == null ? new cs2306291207.Class(this, param_build)/*Save*/ : new cs2306291245.Class(this, go, param_build)/*Save+go*/;
            edit.Закрыть();
        }
    }
}
