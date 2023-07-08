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
        static int MAXВысотаЧанка = 4;
        int Высота { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306221522_ЧанкПаралепипеда.Class, IClass
    {
        static new public string INFO = "INFO";

        private Vector2Int _v; 
        public Vector2Int Координата => _v;
        private ulong ПолучитьНомер(Vector2 v) => st2305211702.Class.fun230521170203_ПолучитьНомер(v);
        public virtual Vector3 ВычисляемыеКоординаты => IClass.ДлинаЧанкаЗемли * new Vector3(_v.x, 0, _v.y) + IClass.MAXВысотаЧанка * Высота * Vector3.up;
        #region Высота
        private int _h = 1; 
        public int Высота { get => _h; set => _h = value; }
        #endregion

        private ulong _code;
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
        private cs2307051626_ЗЕМЛЯ.IClass Словарь;
        public Class(cs2307051626_ЗЕМЛЯ.IClass Словарь, Vector2Int v, int h):base(IClass.MAXВысотаЧанка)
        {
            _h = h;
            this.Словарь = Словарь;
            _v = v;
            _code = ПолучитьНомер(_v);
        }
        public int ВысотаСоседа(Vector2 next) => Словарь.Высота(_v + next);
        public override object СобратьПараметры()
        {
            return ВычислениеМинимальнойВысоты;
        }
        public bool[] ВычислениеМинимальнойВысоты
        {
            get
            {
                return
                    new bool[]{
                        ВысотаСоседа(Vector2.left)>Высота,
                        ВысотаСоседа(Vector2.right)>Высота,
                        ВысотаСоседа(Vector2.down)>Высота,
                        ВысотаСоседа(Vector2.up)>Высота,
                    };
            }
        }
        public override bool СуществуетВершина(Vector3 v, object arg)
        {
            //var min_y = (bool[])arg;
            //if (v.x == 0) return min_y[0];
            //if (v.x == IClass.ДлинаЧанкаЗемли - 1) return min_y[1];
            //if (v.z == 0) return min_y[2];
            //if (v.z == IClass.ДлинаЧанкаЗемли - 1) return min_y[3];
            //выбираем минимальную высоту -x,+x,-z,+z,0
            var b = base.СуществуетВершина(v, arg);

            //go2306252014.IInspector.ЗЕМЛЯ.Найти
            return b;
        }
    }
}
