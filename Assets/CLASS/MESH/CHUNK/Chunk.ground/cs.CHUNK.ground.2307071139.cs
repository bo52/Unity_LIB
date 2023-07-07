//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

namespace LIB.cs2307071139_ЧанкЗемли
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2306221522_ЧанкПаралепипеда.IClass
    {
        Vector2Int Координата { get; }
        static int ДлинаЧанкаЗемли = 32;
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306221522_ЧанкПаралепипеда.Class, IClass
    {
        static new public string INFO = "INFO";

        private ulong ПолучитьНомер(Vector2 v) => st2305211702.Class.fun230521170203_ПолучитьНомер(v);
        private Vector2Int _v; public Vector2Int Координата => _v;
        private ulong _code;
        public virtual Vector3 ВычисляемыеКоординаты => IClass.ДлинаЧанкаЗемли * new Vector3(_v.x, 0, _v.y);
        public override string ФайлИгровогоОбъекта => "CHUNK.ground/CHUNK.ground" + _code;
        public override string ИмяИгровогоОбъекта => base.ИмяИгровогоОбъекта + _code;
        public override GameObject НовыйИгровойОбъект
        {
            get
            {
                var go = base.НовыйИгровойОбъект;
                go.transform.position = ВычисляемыеКоординаты;
                var mb = st2305141614.Class.fun230514161407_ПривязатьМоноКОбъекту(go);
                mb.ОбъектМира.Объект = this;
                return go;
            }
        }
        public Class(Vector2Int v)
        {
            _v = v;
            _code = ПолучитьНомер(_v);
        }
        public override bool СуществуетВершина(Vector3 v)
        {
            //выбираем минимальную высоту -x,+x,-z,+z,0
            var b = base.СуществуетВершина(v);

            //go2306252014.IInspector.ЗЕМЛЯ.Найти
            return b;
        }
    }
}
