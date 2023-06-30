//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306301442
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
    public class Class : cs2306301501.Class,IClass
    {
        static new public string INFO = "INFO";
        #region БазовыеПараметры
        public override IClass.Редактор ТипРедактора => IClass.Редактор.square;
        /// <summary>
        /// Путь файла
        /// </summary>
        public override string Path => "default/";
        /// <summary>
        /// имя файла
        /// </summary>
        public override string NameFile => "chunk.world.zero";
        #endregion
        #region ПараметрыКласса

        #endregion
        #region Показать
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public override bool ИнтерфейсПоУмолчанию(GameObject go, string name)
        {
            return base.ИнтерфейсПоУмолчанию(go, "ПлоскаяЗемля");
        }
        #endregion
        #region Постройка
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
        }
        #endregion
    }
}
