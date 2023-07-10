//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307091136_ИгровойОбъектФайл
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2307031414_Default.IClass
    {
        cs2307091120_ИгровойОбъект.IClass GO { get; }
        string ФайлИгровогоОбъекта { get; }
        cs2307091132_GO_file_save.IClass Сохранение { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307031414_Default.Class, IClass
    {
        static public new string INFO = "INFO";
        public override string ИмяКнопки => "Открыть";
        public void Открыть() => st2306261354.Class.fun230626135400_ОткрытьФайл(ФайлИгровогоОбъекта);
        public virtual string ФайлИгровогоОбъекта => "empty";
        #region go
        private cs2307091120_ИгровойОбъект.IClass _go;
        public cs2307091120_ИгровойОбъект.IClass GO => _go;
        #endregion
        #region save
        private cs2307091132_GO_file_save.IClass _save;
        public cs2307091132_GO_file_save.IClass Сохранение => _save;
        #endregion
        public Class(cs2307091120_ИгровойОбъект.IClass go)
        {
            _go = go;
            _save = new cs2307091132_GO_file_save.Class(this);
        }
        public override bool ИнтерфейсПоУмолчанию()
        {
            GUILayout.BeginHorizontal();
            _save.ИнтерфейсПоУмолчанию();
            base.ИнтерфейсПоУмолчанию();
            GUILayout.EndHorizontal();
            return true;
        }
    }
}
