//Bo52_16102020135015468.STAT.NUMBER.
namespace utility2022
{
    using UnityEngine;
    static public class stVector2_ulong_uint_min_max
    {
        static public string INFO = "v2.MinMax.ulong";
        static public string PRODUCT = "ulong в Вектор и обратно (uint min,max)";
        #region МЕТОДЫ
        static private ulong MAX(uint min, uint max)=>max + min;
        static private ulong mx(uint min, uint max)=>MAX(min, max) + 1;
        /// <summary>
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="h">на сколько координата делится h=1->целый,h=2->две части или по 0.5f,h=4->четыре части или по 0.25f,h=8->восемь частей или по 0.125f и т.д.) частей</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...n без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...n и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public ulong GET_ID_MAX_MIN(this Vector2 v, uint min, uint max)=>(ulong)(v.x + min) + mx(min, max) * (ulong)(v.y + min);
        static public Vector2 GET_V_MAX_MIN(this ulong id, uint min, uint max)
        {
            ulong _mx = mx(min, max);

            ulong y = id / _mx;
            ulong x = id - _mx * y;
            float X = x - min;
            float Y = y - min;
            return new Vector2(X, Y);
        }
        static public void test()
        {
            uint min = 50000;
            uint max = 50000;

            Vector2 v = new Vector2(max, max);
            ulong id = v.GET_ID_MAX_MIN(min, max);
            Vector2 V = id.GET_V_MAX_MIN(min, max);
        }
        #endregion
    }
}
