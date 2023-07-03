using UnityEngine;
namespace LIB.st2305211702
{
    /// <summary>
    /// stVector256_ulong
    /// </summary>
    static public class CLASS
    {
        /// <summary>
        /// n
        /// </summary>
        static private ulong field230521170200 = 256;
        /// <summary>
        /// nn
        /// </summary>
        static private ulong field230521170201 = 513;
        /// <summary>
        /// nnn
        /// </summary>
        static private ulong field230521170202 = 513 * 513;
        /// <summary>
        /// GET_ID
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...255 без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...255 и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public ulong fun230521170203_ПолучитьНомер(this Vector3 v) => (ulong)(v.x + field230521170200) + field230521170201 * (ulong)(v.y + field230521170200) + field230521170202 * (ulong)(v.z + field230521170200);
        /// <summary>
        /// GET_V
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Vector3 fun230521170204_ПолучитьВектор(this ulong id)
        {

            ulong z = id / field230521170202;
            ulong y = (id - field230521170202 * z) / field230521170201;
            ulong x = id - field230521170201 * y - field230521170202 * z;
            return new Vector3(x, y, z) - field230521170200 * Vector3.one;
        }
        static public void test(Vector3 v)
        {
            ulong id = v.fun230521170203_ПолучитьНомер();
            Vector3 V = id.fun230521170204_ПолучитьВектор();
            Debug.Log(id + ":(" + v.x + "," + v.y + "," + v.z + ")=(" + V.x + "," + V.y + "," + V.z + ")");
        }

    }
}