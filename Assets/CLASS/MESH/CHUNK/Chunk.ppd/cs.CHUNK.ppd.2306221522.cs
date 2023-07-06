//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2306221522_ЧанкПаралепипеда
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307061242_СловарныйЧанк.IClass
    {
    }
    /// <summary>
    /// рекурсивный куб с координатой
    /// </summary>
    public class Class : cs2307061242_СловарныйЧанк.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string ИмяКнопки => "ПостроитьЧанкПаралепипед";
        #region ПараметрыКласса
        private cs2306271146_РедакторПаралепипеда.IClass РедакторПаралепипеда = new cs2306271146_РедакторПаралепипеда.Class();
        public override string ИмяИгровогоОбъекта => "ЧанкПаралепипед";
        public Class() : base()
        {
        }
        #endregion
        public override bool ИнтерфейсПоУмолчанию()
        {
            if (РедакторПаралепипеда.ИнтерфейсПоУмолчанию()) Выполнить();
            return base.ИнтерфейсПоУмолчанию();
        }

        public override bool СуществуетВершина(Vector3 v) => РедакторПаралепипеда.СуществуетВершина(v);
    }
}
