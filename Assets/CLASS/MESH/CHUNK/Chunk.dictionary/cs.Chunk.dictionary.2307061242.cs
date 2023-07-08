//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307061242_СловарныйЧанк
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2305071643_Chunk_default.IClass
    {
        /// <summary>
        /// РазмерЧанка
        /// </summary>
        static public byte РазмерЧанка = 32;
        static public byte ГраничныйРазмерЧанка = 30;
        static public byte ПоловинаРазмераЧанка = 14;
        cs2307061139_КораЧанка.IClass КораЧанка { get; }
        int ВысотаЧанка { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : cs2305071643_Chunk_default.Class, IClass
    {
        static new public string INFO = "INFO";
        #region ВЫСОТА
        private int _h = IClass.РазмерЧанка; 
        public int ВысотаЧанка { get => _h; }
        #endregion
        #region КораЧанка
        private cs2307061139_КораЧанка.IClass _crust = new cs2307061139_КораЧанка.Class(IClass.РазмерЧанка); 
        public cs2307061139_КораЧанка.IClass КораЧанка => _crust;
        #endregion
        public Class(int h) : base()
        {
            _h = h;
        }
        public override Mesh ПостроитьСЗакрытием()
        {
            СформироватьСловарьЧанка();
            return base.ПостроитьСЗакрытием();
        }
        public override void ФункцияПостройки(cs2305141215.IClass edit)
        {
            _crust.Обойти((Vector3 v, cs2307051205_ЦветнойКодБлока.Class b) =>
            {
                edit.ДОБАВИТЬ(new cs2306262134.Class(v, b.КОД));
                return true;
            });
        }
        public void СформироватьСловарьЧанка()
        {
        }
        public virtual object СобратьПараметры()
        {
            return null;
        }
        public abstract bool СуществуетВершина(Vector3 v, object arg);
    }
}
