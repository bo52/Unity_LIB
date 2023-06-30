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
    public interface IClass: cs2306301501.IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306301501.Class, IClass
    {
        static new public string INFO = "LIB.cs2306282238.Class";
        #region БазовыеПараметры
        public override IClass.Редактор ТипРедактора => IClass.Редактор.Block;
        /// <summary>
        /// Путь файла
        /// </summary>
        public override string Path => "default/";
        /// <summary>
        /// имя файла
        /// </summary>
        public override string NameFile => "chunk." + КодПоУмолчанию + "." + Chunk_R;
        #endregion
        #region ПараметрыКласса
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
        #endregion
        #region Показать
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public override bool ИнтерфейсПоУмолчанию(GameObject go, string name)
        {
            return base.ИнтерфейсПоУмолчанию(go, "ОдинЧанкМираПоУмолчанию");
        }
        #endregion
        #region Постройка
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
            Vector3 v;
            cs2306262134.Class b;
            for (var z = 0; z <= Chunk_R; z++)
                for (var x = 0; x <= Chunk_R; x++)
                {
                    v = new Vector3(x, НулеваяВысота, z);
                    b = new cs2306262134.Class(v, КодПоУмолчанию);
                    edit.ДОБАВИТЬ(b);
                }
        }
        #endregion
    }
}
