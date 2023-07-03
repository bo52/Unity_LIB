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
        /// <summary>
        /// РадиусЧанка
        /// </summary>
        static public byte Chunk_R = 32;
        cs2305141208.IClass.Редактор ТипРедактора { get; }
        void Построить(GameObject go);
        void ФункцияПостройки(cs2305141215.IClass edit);
    }
    /// <summary>
    /// универсальный класс по получению информации
    /// </summary>
    public abstract class Class : cs2307031414_Default.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string ИмяКнопки => "ПостроитьБезСохранения";
        public Class(GameObject go) : base(go)
        {
        }
        public virtual cs2305141208.IClass.Редактор ТипРедактора => cs2305141208.IClass.Редактор.Block;
        private cs2307031203_ПараметрыПостройки.Class _param_build => new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки, ТипРедактора);
        public virtual void Построить(GameObject go)
        {
            cs2305141208.IClass edit = new cs2306291123.Class(go, _param_build);
            edit.Закрыть();
        }
        public override void Выполнить() => Построить(ИгровойОбъект);
        public abstract void ФункцияПостройки(cs2305141215.IClass edit);
    }
}