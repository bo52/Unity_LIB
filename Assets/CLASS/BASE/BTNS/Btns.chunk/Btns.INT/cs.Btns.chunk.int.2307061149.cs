//БлокиЧанка.Интерфейс [Блоки,РедакторБлоков,СозданиеМеша]
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061149_БлокиЧанка_Интерфейс
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307031414_Default.IClass
    {
        cs2307091713_Блоки_Добавление.IClass Блоки { get; }
    }
    public interface IClass<TFILE, TMESH, TEDIT> : IClass
        where TFILE : cs2307091136_ИгровойОбъектФайл.Class, new()
        where TMESH : cs2307061139_СозданиеМеша.Class<TFILE>, new()
        where TEDIT : cs2307091511_РедакторБлоков.Class, new()

    {
        TMESH СозданиеМеша { get; }
        TEDIT РедакторБлоков { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<TFILE, TMESH, TEDIT> : cs2307031414_Default.Class, IClass<TFILE, TMESH, TEDIT>
        where TFILE : cs2307091136_ИгровойОбъектФайл.Class, new()
        where TMESH : cs2307061139_СозданиеМеша.Class<TFILE>, new()
        where TEDIT : cs2307091511_РедакторБлоков.Class, new()
    {
        static new public string INFO = "INFO";
        #region Блоки
        private cs2307091713_Блоки_Добавление.IClass _btns;
        public cs2307091713_Блоки_Добавление.IClass Блоки => _btns;
        #endregion
        #region РедакторБлоков
        private TEDIT _edit;
        public TEDIT РедакторБлоков => _edit;
        #endregion
        #region СозданиеМеша
        private TMESH _create_mesh;
        public TMESH СозданиеМеша => _create_mesh;
        #endregion
        public Class(object ЧАНК)
        {
            //this.ЧАНК = ЧАНК as cs2307061242_Чанк_Интерфейс.IClass;
            _btns = new cs2307091713_Блоки_Добавление.Class();
            _create_mesh = СоздатьЭкземпляр<TMESH>(this);
            _edit = СоздатьЭкземпляр<TEDIT>(this);
        }
        public override bool СценаПоУмолчанию()
        {
            if (_edit.СценаПоУмолчанию())
                _create_mesh.ПостроитьСЗакрытием();
            return false;
        }
    }
}
