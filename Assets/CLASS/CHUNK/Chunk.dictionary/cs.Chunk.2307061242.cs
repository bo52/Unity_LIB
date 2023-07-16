//Чанк.Интерфейс
//empty
//empty
using UnityEngine;
namespace LIB.cs2307061242_Чанк_Интерфейс
{
    public interface IClass
    {
        int РазмерЧанка { get; }
    }
    public interface IClass<TFILE, TMESH, TEDIT, TBtns> : cs2307031414_Default.IClass, IClass
        where TFILE : cs2307091136_ИгровойОбъектФайл.Class, new()
        where TMESH : cs2307061139_СозданиеМеша.Class<TFILE>, new()
        where TEDIT : cs2307091511_РедакторБлоков.Class, new()
        where TBtns : cs2307061149_БлокиЧанка_Интерфейс.Class<TFILE, TMESH, TEDIT>, new()
    {
        TBtns БлокиЧанка_Интерфейс { get; } 
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class<TFILE, TMESH, TEDIT, TBtns> : cs2307031414_Default.Class, IClass<TFILE, TMESH, TEDIT, TBtns>
        where TFILE : cs2307091136_ИгровойОбъектФайл.Class, new()
        where TMESH : cs2307061139_СозданиеМеша.Class<TFILE>, new()
        where TEDIT : cs2307091511_РедакторБлоков.Class, new()
        where TBtns : cs2307061149_БлокиЧанка_Интерфейс.Class<TFILE, TMESH, TEDIT>, new()
    {
        static new public string INFO = "INFO";
        #region Размер
        public int РазмерЧанка => 32;
        public int ГраничныйРазмерЧанка => РазмерЧанка - 2;
        public int ПоловинаРазмераЧанка => (int)(РазмерЧанка / 2.0f) - 1;
        #endregion
        #region Блоки
        public TBtns _btns; public TBtns БлокиЧанка_Интерфейс => _btns;
        #endregion
        public Class() : base()
        {
            _btns = СоздатьЭкземпляр<TBtns>(this);
        }
    }
}
