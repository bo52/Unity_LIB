//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307061242_СловарныйЧанк
{
    public interface IClass: cs2307031414_Default.IClass
    {
        int РазмерЧанка { get; }
        cs2307061149_БлокиЧанка.IClass БлокиЧанка { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public interface IClass<TCHUNK_crust> : IClass
    {
        TCHUNK_crust КораЧанка { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class<TFILE, TCHUNK_crust> : cs2307031414_Default.Class, IClass<TCHUNK_crust>
        where TFILE : cs2307091136_GO_file.Class, new()
        where TCHUNK_crust : cs2307061139_КораЧанка.Class<TFILE>, new()
    {
        static new public string INFO = "INFO";
        /// <summary>
        /// РазмерЧанка
        /// </summary>
        public int РазмерЧанка => 32;
        public int ГраничныйРазмерЧанка => РазмерЧанка - 2;
        public int ПоловинаРазмераЧанка => (int)(РазмерЧанка/2.0f) - 1;
        #region Блоки
        public cs2307061149_БлокиЧанка.IClass _btns;
        public cs2307061149_БлокиЧанка.IClass БлокиЧанка => _btns;
        #endregion
        #region КораЧанка
        private TCHUNK_crust _crust;
        public TCHUNK_crust КораЧанка => _crust;
        #endregion
        public Class() : base()
        {
            _btns = СоздатьЭкземпляр<cs2307061149_БлокиЧанка.Class>(this);
            _crust = СоздатьЭкземпляр<TCHUNK_crust>(this);
        }
        public override bool СценаПоУмолчанию()
        {
            if (_btns.РедакторБлоков.СценаПоУмолчанию())
                _crust.ПостроитьСЗакрытием();
            return false;
        }
    }
}
