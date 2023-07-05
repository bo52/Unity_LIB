//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2307051233_ПостроитьЧанкКорыОбъекта
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        cs2307031649.IClass ОткрытьРедактор{ get; }
        void ЗакрытьРедактор(cs2307031649.IClass edit);
        void ФункцияПостройки(cs2305141215.IClass edit);
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : IClass
    {
        static public string INFO = "INFO";
        #region ПараметрыКласса
        private cs2307031203_ПараметрыПостройки.Class _param_build => new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки);
        private GameObject _go; public GameObject GO => _go;
        public Class(GameObject go)
        {
            this._go = go;
        }
        #endregion
        public virtual cs2307031649.IClass ОткрытьРедактор => new cs2307031649.Class(GO, _param_build);
        public virtual void ЗакрытьРедактор(cs2307031649.IClass edit) => edit.Закрыть();
        public abstract void ФункцияПостройки(cs2305141215.IClass edit);
    }
}
