//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306282238
{
    /// <summary>
    ///
    /// </summary>
    public interface IDefault
    {
        bool ИнтерфейсПоУмолчанию(GameObject go);
    }
    /// <summary>
    ///
    /// </summary>
    public interface IClass: IDefault
    {
        public bool СуществуетМеш { get; }
        public void ПривязатьМеш(GameObject go);
        void ПостроитьОдинЧанкЗемлиПоУмолчанию(GameObject go);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "LIB.cs2306282238.Class";
        /// <summary>
        /// 
        /// </summary>
        static public byte Chunk_R = 32;
        /// <summary>
        /// координата по оси y по умолчанию земли
        /// </summary>
        static public int НулеваяВысота = 1;
        /// <summary>
        /// код земли
        /// </summary>
        static public byte КодПоУмолчанию = 51;
        /// <summary>
        /// 
        /// </summary>
        cs2306291207.Class.Struct ПараметрыЧанка = new cs2306291207.Class.Struct("chunk." + КодПоУмолчанию + "." + Chunk_R, "default/");
        /// <summary>
        ///
        /// </summary>
        public bool СуществуетМеш => st2305161619.Class.fun230516161901_СуществуетМеш(ПараметрыЧанка.namefile);

        public void ПривязатьМеш(GameObject go) => st2305072046.Class.fun230507204602_ПривязатьМешОтФайлаПоИмени(ПараметрыЧанка.namefile, go, ПараметрыЧанка.path);

        public void ФункцияПостройки(cs2305141202.IClass edit)
        {
            Vector3 v;
            for (var z = 0; z <= Chunk_R; z++)
                for (var x = 0; x <= Chunk_R; x++)
                {
                    v = new Vector3(x, НулеваяВысота, z);
                    edit.ИзменитьТекущийБлокИПостроить(new cs2306262134.Class(v, КодПоУмолчанию));
                }
        }
        /// <summary>
        ///
        /// </summary>
        public virtual void ПостроитьОдинЧанкЗемлиПоУмолчанию(GameObject go) => ПараметрыЧанка.ПостроитьМеш(ФункцияПостройки, go);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public bool ИнтерфейсПоУмолчанию(GameObject go)
        {
            return st2305161151.Class.fun230516115102_btn_name("ОдинЧанкМираПоУмолчанию", () => ПостроитьОдинЧанкЗемлиПоУмолчанию(go));
        }
    }
}
