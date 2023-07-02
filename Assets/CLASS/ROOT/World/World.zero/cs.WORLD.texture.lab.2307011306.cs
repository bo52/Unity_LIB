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
        static int ОпределениеСмещенияНачальнойВысоты => Random.Range(0, byte.MaxValue);
        static int ОпределениеСмещенияВысоты => Random.Range(-1, 1);
        static public Vector3Int ВекторПервойВершиныПоОси = Vector3Int.zero;
        static public Vector3Int ВекторПоследнейВершиныПоОси = Vector3Int.zero;

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
        static Vector3Int Вычисление(int x, int z)
        {
            if (z == -IClass.РадиусВидимости & x == -IClass.РадиусВидимости) return ВычислениеПервойВершины;
            if (x == -IClass.РадиусВидимости) return ВычислениеСледующейЗетВершины;
            return ВычислениеСледующейВершины;
        }
        public int ОтЦентра(int x) => R + x;
        public override void Построить(GameObject go)
        {
            ВекторПоследнейВершиныПоОси = Vector3Int.zero;
            ВекторПервойВершиныПоОси = Vector3Int.zero;
            var tex = ТЕКСТУРА;
            for (var z = -IClass.РадиусВидимости; z <= IClass.РадиусВидимости; z++)
            {
                for (var x = -IClass.РадиусВидимости; x <= IClass.РадиусВидимости; x++)
                {
                    Вычисление(x, z);
                    tex.SetPixel(ОтЦентра(x), ОтЦентра(z), new Color32(0, 0, 0, (byte)ВекторПоследнейВершиныПоОси.y));
                }
            }
            base.Построить(go);
        }
    }
}
