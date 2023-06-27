using UnityEngine;
namespace LIB.st2305211650
{
    /// <summary>
    /// stVector_min_max
    /// v3.MinMax.ulong
    /// ulong в Вектор и обратно (с ushort min,max)
    /// </summary>
    static public class Class
    {
        #region МЕТОДЫ
        #region st
        /// <summary>
        /// stM
        /// </summary>
        static public ulong field230521165000 = 2 * ushort.MaxValue + 1;
        /// <summary>
        /// stMM
        /// </summary>
        static public ulong field230521165001 = field230521165000 * field230521165000;
        /// <summary>
        /// stGET_ID
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public ulong fun230521165002(this Vector3 v)
        {
            ulong x = (ulong)v.x + field230521165000;
            ulong y = (ulong)v.y + field230521165000;
            ulong z = (ulong)v.z + field230521165000;
            return x + field230521165000 * y + field230521165001 * z;
        }
        /// <summary>
        /// stGET_V
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Vector3Int fun230521165003(this ulong id)
        {
            ulong z = id / field230521165001;
            ulong y = (id - field230521165001 * z) / field230521165000;
            ulong x = id - field230521165000 * y - field230521165001 * z;
            return new Vector3Int((int)x, (int)y, (int)z) - (int)field230521165000 * Vector3Int.one;
        }
        #endregion
        /// <summary>
        /// GET_ID
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...255 без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...255 и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public ulong fun230521165004(this Vector3Int v) => fun230521165007(v, ushort.MaxValue, ushort.MaxValue);
        /// <summary>
        /// GET_ID
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public ulong fun230521165005(this Vector3 v) => fun230521165007(v, ushort.MaxValue, ushort.MaxValue);
        /// <summary>
        /// GET_V
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Vector3Int fun230521165006(this string id) => fun230521165008(System.Convert.ToUInt64(id), ushort.MaxValue, ushort.MaxValue);
        /// <summary>
        /// GET_ID
        /// </summary>
        /// <param name="v"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public ulong fun230521165007(this Vector3 v, ulong min, ulong max)
        {
            ulong x = (ulong)v.x + min;
            ulong y = (ulong)v.y + min;
            ulong z = (ulong)v.z + min;
            ulong M = max + min + 1;
            return x + M * (y + M * z);
        }
        /// <summary>
        /// GET_V
        /// </summary>
        /// <param name="id"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public Vector3Int fun230521165008(this ulong id, ushort min, ushort max)
        {
            ulong M = (ulong)(max + min + 1);
            ulong MM = M * M;

            ulong z = id / MM;
            ulong y = (id - MM * z) / M;
            ulong x = id - M * y - MM * z;
            return new Vector3Int((int)x, (int)y, (int)z) - min * Vector3Int.one;
        }
        /// <summary>
        /// test
        /// </summary>
        /// <param name="v"></param>
        static public void fun230521165009(Vector3 v)
        {
            ushort max = 20;
            //v = new Vector3(0,0,-4104);
            ulong id = v.fun230521165007(max, max);
            Vector3 V = id.fun230521165008(max, max);
            //Debug.Log(id + ":(" + v.x + "," + v.y + "," + v.z + ")=(" + V.x + "," + V.y + "," + V.z + ")");
        }
        #endregion
    }
}