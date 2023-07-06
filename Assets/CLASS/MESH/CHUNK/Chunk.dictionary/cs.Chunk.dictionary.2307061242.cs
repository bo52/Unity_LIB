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
        cs2307061149_БлокиЧанка.IClass БлокиЧанка { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : cs2305071643_Chunk_default.Class, IClass
    {
        static new public string INFO = "INFO";
        private cs2307061139_КораЧанка.IClass _crust = new cs2307061139_КораЧанка.Class(); public cs2307061139_КораЧанка.IClass КораЧанка => _crust;
        public cs2307061149_БлокиЧанка.IClass _btns = new cs2307061149_БлокиЧанка.Class(); public cs2307061149_БлокиЧанка.IClass БлокиЧанка => _btns;
        public Class() : base()
        {
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
            _crust.Clear();
            _btns.Clear();

            Vector3 v;
            byte КОД;
            for (var x = 0; x < IClass.РазмерЧанка; x++)
                for (var y = 0; y < IClass.РазмерЧанка; y++)
                    for (var z = 0; z < IClass.РазмерЧанка; z++)
                    {
                        v = new Vector3(x, y, z);
                        КОД = st2306271209.Class.fun230627120900_СформироватьКодБлока(v, СуществуетВершина);
                        if (КОД == 0) continue;
                        if (КОД == byte.MaxValue)
                            _btns.Добавить(v);
                        else
                            _crust.Добавить(v, КОД);
                    }
        }
        public abstract bool СуществуетВершина(Vector3 v);
    }
}
