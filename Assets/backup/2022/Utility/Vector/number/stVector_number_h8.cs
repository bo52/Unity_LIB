//Bo52_16102020134605759.stat.VECTOR
//Bo52.constr.PROJ.CLASS.STAT.VECTOR.NAMBER
using UnityEngine;
namespace utility2022
{
    static public class stVector_number_h8
    {
        static public string INFO = "ЧИСЛО";
        static public string PRODUCT = "ulong в Вектор и обратно (uint h,min,max)";
        /// <summary>
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="h">на сколько координата делится h=1->целый,h=2->две части или по 0.5f,h=4->четыре части или по 0.25f,h=8->восемь частей или по 0.125f и т.д.) частей</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...n без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...n и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static float H = 8;
        static ulong M = 16 * ushort.MaxValue + 1;
        static ulong MM = M * M;
        static ulong MMM = 8 * ushort.MaxValue * (MM + M + 1);
        public struct STRUCT
        {
            public Vector3 v;
            public ulong id;
            public STRUCT(Vector3 v)
            {
                this.v = v;
                id = GET_ID(v);
            }
            public STRUCT(float x, float y, float z)
            {
                v = new Vector3(x, y, z);
                id = GET_ID(v);
            }
            public STRUCT(int x, int y, int z)
            {
                v = new Vector3(x, y, z);
                id = GET_ID(v);
            }
            public STRUCT(ulong id)
            {
                this.id = id;
                v = GET_V(id);
            }
            public void test() => Debug.Log(id + "=" + v.x + "=" + v.y + "=" + v.z);
        }
        static public ulong GET_ID(Vector3 v) => (ulong)(H * v.x) + M * (ulong)(H * v.y) + MM * (ulong)(H * v.z) + MMM;
        static public Vector3 GET_V(ulong id)
        {
            ulong z = id / MM;
            ulong y = (id - MM * z) / M;
            ulong x = id - M * y - MM * z;

            return 1 / H * new Vector3(x, y, z) - ushort.MaxValue * Vector3.one;
        }
        static public void test()
        {
            Vector3 v = new Vector3(-1.5f, 0.5f, 2.5f);
            ulong id = GET_ID(v);
            Vector3 V = GET_V(id);
            Debug.Log(id + "=" + v.x + "," + v.y + "," + v.z + "=" + V.x + "," + V.y + "," + V.z);
        }
    }
}