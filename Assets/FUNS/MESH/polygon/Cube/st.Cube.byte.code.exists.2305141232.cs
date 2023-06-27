//empty
//empty
//cube2023.stCube256_code
using UnityEngine;
namespace LIB.st2305141232
{
    /// <summary>
    /// stMesh.cube_byte.code.exists.cs2305141232
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// код не чётный
        /// ПервыйИндексКодаСуществует
        /// </summary>
        /// <param name="КОД"></param>
        /// <returns></returns>
        public static bool fun230514123200(this byte КОД) => (КОД % 2) != 0;
        /// <summary>
        /// ПервыйИндексКодаСуществует
        /// </summary>
        /// <param name="КОД"></param>
        /// <returns></returns>
        public static bool fun230514123201(this float КОД) => (КОД % 2) != 0;
        /// <summary>
        /// Между
        /// </summary>
        /// <param name="КОД"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool fun230514123202(this byte КОД, float min, float max) => КОД >= min && КОД <= max;
        /// <summary>
        /// НомерВершиныСуществуетВКоде
        /// </summary>
        /// <param name="n">индекс вершины блока</param>
        /// <param name="КОД">код блока от 0 до 255</param>
        /// <returns></returns>
        public static bool fun230514123203(this byte n, byte КОД)
        {
            switch (n)
            {
                case 0: return fun230514123200(КОД);
                //(2^6,2^7)||(2^6+2^7,2^8)
                case 6: return КОД.fun230514123202(64, 127) || КОД.fun230514123202(192, 255);
                //x>=2^7
                case 7: return КОД >= 128;
            }

            var pow = Mathf.Pow(2, n);
            var next = pow - 1;
            var pow2 = 2 * pow;

            System.Func<bool> f = () =>
            {
                if (КОД.fun230514123202(pow, pow + next)) return true;
                pow += pow2;
                return false;
            };

            if (f())
                return true;
            while (pow < byte.MaxValue)
                if (f())
                    return true;
            return false;
        }
        ///exit
    }
}