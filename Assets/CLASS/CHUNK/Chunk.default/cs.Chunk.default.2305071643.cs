//empty
//empty
//универсальный класс по получению информации
using UnityEngine;
/// <summary>
/// CLASS
/// </summary>
namespace LIB.cs2305071643_Chunk_default
{
    public interface IClass : cs2307031414_Default.IClass
    {
        cs2305141208.IClass.Редактор ТипРедактора { get; }
        cs2307091120_ИгровойОбъект.IClass GO { get; }
        Mesh ПостроитьСЗакрытием();
        void ФункцияПостройки(cs2305141215.IClass edit);
    }
    /// <summary>
    /// универсальный класс по получению информации
    /// </summary>
    public abstract class Class<TFILE> : cs2307031414_Default.Class, IClass where TFILE : cs2307091136_GO_file.Class, new()
    {
        #region Кнопка
        public override string ИмяКнопки => "ПостроитьСЗакрытием";
        public virtual Mesh ПостроитьСЗакрытием() => new cs2306291123.Class(GO.ИгровойОбъект, _param_build).Закрыть();
        public override bool ИнтерфейсПоУмолчанию()
        {
            GUILayout.BeginHorizontal();
            _go.ИнтерфейсПоУмолчанию();
            base.ИнтерфейсПоУмолчанию();
            GUILayout.EndHorizontal();
            return true;
        }
        #endregion
        #region ИгровойОбъект
        private cs2307091120_ИгровойОбъект.IClass _go;
        public cs2307091120_ИгровойОбъект.IClass GO => _go;
        #endregion
        static new public string INFO = "INFO";
        public Class()
        {
            _go = new cs2307091120_ИгровойОбъект.Class<TFILE>();
        }
        public virtual cs2305141208.IClass.Редактор ТипРедактора => cs2305141208.IClass.Редактор.Block;
        private cs2307031203_ПараметрыПостройки.Class _param_build => new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки, ТипРедактора);
        public abstract void ФункцияПостройки(cs2305141215.IClass edit);
    }
}