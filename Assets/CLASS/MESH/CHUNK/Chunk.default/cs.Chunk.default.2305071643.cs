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
        GameObject ИгровойОбъект { get; }
        cs2305141208.IClass.Редактор ТипРедактора { get; }
        Mesh ПостроитьСЗакрытием();
        void ФункцияПостройки(cs2305141215.IClass edit);
    }
    /// <summary>
    /// универсальный класс по получению информации
    /// </summary>
    public abstract class Class : cs2307031414_Default.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string ИмяКнопки => "ПостроитьБезСохранения";
        private GameObject _go; public GameObject ИгровойОбъект => _go;
        public Class()
        {
            _go = st2306251639.Class.prop230625163904_НовыйОбъектВКорнеМира;
        }
        public virtual cs2305141208.IClass.Редактор ТипРедактора => cs2305141208.IClass.Редактор.Block;
        private cs2307031203_ПараметрыПостройки.Class _param_build => new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки, ТипРедактора);
        public virtual Mesh ПостроитьСЗакрытием() => new cs2306291123.Class(ИгровойОбъект, _param_build).Закрыть();
        public override void Выполнить() => ПостроитьСЗакрытием();
        public abstract void ФункцияПостройки(cs2305141215.IClass edit);
    }
}