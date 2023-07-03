//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307011306_ТекстураЗемли
{
    /// <summary>
    /// Текстура Земли
    /// </summary>
    public interface IClass : cs2307011446_ТекстураФайл.IClass
    {
        public static byte РадиусВидимости = 32;
        int ОтЦентра(int x);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2307011446_ТекстураФайл.Class, IClass
    {
        static new public string INFO = "INFO";
        public override string PATH => "world.zero/texture" + SIZE;
        #region ПараметрыКласса
        public cs2307031639_ВидимыеЧанкиТекстуры.IClass ВидимыеЧанкиТекстуры;
        public Class(GameObject go)
        {
            ВидимыеЧанкиТекстуры = new cs2307031639_ВидимыеЧанкиТекстуры.Class(go,this);
        }
        #endregion
        #region СтатФункции
        static int ОпределениеСмещенияНачальнойВысоты => Random.Range(0, byte.MaxValue);
        static int ОпределениеСмещенияВысоты => Random.Range(-1, 1);
        static public Vector3Int ВекторПервойВершиныПоОси = Vector3Int.zero;
        static public Vector3Int ВекторПоследнейВершиныПоОси = Vector3Int.zero;
        #endregion
        #region ФункцииКласса
        public int ОтЦентра(int x) => R + x;
        static Vector3Int Вычисление(int x, int z)
        {
            if (z == -IClass.РадиусВидимости & x == -IClass.РадиусВидимости) return ВычислениеПервойВершины;
            if (x == -IClass.РадиусВидимости) return ВычислениеСледующейЗетВершины;
            return ВычислениеСледующейВершины;
        }
        static Vector3Int ВычислениеПервойВершины
        {
            get
            {
                ВекторПервойВершиныПоОси = new Vector3Int(0, ОпределениеСмещенияНачальнойВысоты, 0);
                ВекторПоследнейВершиныПоОси = ВекторПервойВершиныПоОси;
                return ВекторПоследнейВершиныПоОси;
            }
        }
        static Vector3Int ВычислениеСледующейЗетВершины
        {
            get
            {
                ВекторПервойВершиныПоОси += new Vector3Int(0, ОпределениеСмещенияВысоты, 0);
                ВекторПоследнейВершиныПоОси = ВекторПервойВершиныПоОси;
                return ВекторПоследнейВершиныПоОси;
            }
        }
        static Vector3Int ВычислениеСледующейВершины
        {
            get
            {
                ВекторПоследнейВершиныПоОси += new Vector3Int(0, ОпределениеСмещенияВысоты, 0);
                return ВекторПоследнейВершиныПоОси;
            }
        }
        #endregion
        public void Сбросить()
        {
            ВидимыеЧанкиТекстуры.Очистить();
            ВекторПоследнейВершиныПоОси = Vector3Int.zero;
            ВекторПервойВершиныПоОси = Vector3Int.zero;
        }
        public virtual void ПостроитьВидимуюПоверхностьСНуля(GameObject go)
        {
            Сбросить();

            var tex = ТЕКСТУРА;
            Vector3Int v;
            for (var z = -IClass.РадиусВидимости; z <= IClass.РадиусВидимости; z++)
            {
                for (var x = -IClass.РадиусВидимости; x <= IClass.РадиусВидимости; x++)
                {
                    Вычисление(x, z);
                    v = new Vector3Int(ОтЦентра(x), ВекторПоследнейВершиныПоОси.y, ОтЦентра(z));
                    tex.SetPixel(v.x, v.z, new Color32(0, 0, 0, (byte)v.y));
                    ВидимыеЧанкиТекстуры.Добавить(v);
                }
            }
            ВидимыеЧанкиТекстуры.ПостроитьВсюПоверхностьЗемли();
        }
    }
}
