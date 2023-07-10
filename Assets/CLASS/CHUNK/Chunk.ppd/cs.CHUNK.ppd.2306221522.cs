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
    public interface IClass : cs2307061242_Чанк_Интерфейс.IClass
    {
        cs2306271146_РедакторПаралепипеда.IClass РедакторПаралепипеда { get; }
    }
    /// <summary>
    /// рекурсивный куб с координатой
    /// </summary>
    public class Class : cs2307061242_Чанк_Интерфейс.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string ИмяКнопки => "ПостроитьЧанкПаралепипед";
        #region ПараметрыКласса
        private cs2306271146_РедакторПаралепипеда.IClass _editor = new cs2306271146_РедакторПаралепипеда.Class(); 
        public cs2306271146_РедакторПаралепипеда.IClass РедакторПаралепипеда { get => _editor; }
        public override string ИмяИгровогоОбъекта => "ЧанкПаралепипед";
        public Class(int h) : base(h)
        {
        }
        #endregion
        public override bool ИнтерфейсПоУмолчанию()
        {
            if (РедакторПаралепипеда.ИнтерфейсПоУмолчанию()) Выполнить();
            return base.ИнтерфейсПоУмолчанию();
        }

        public override bool СуществуетВершина(Vector3 v, object arg) => РедакторПаралепипеда.СуществуетВершина(v);
    }
}
