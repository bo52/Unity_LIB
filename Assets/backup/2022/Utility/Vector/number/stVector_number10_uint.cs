//Bo52_30122020142720560.REGION.
namespace utility2022
{
    using UnityEngine;
    /// <summary>
    /// REGION.КООРДИНАТА.ИД
    /// uint в Вектор и обратно (max=16)
    /// </summary>
    static public class stVector_number10_uint
    {
        static public ushort MAX=10;
        static public ushort MAX2=(ushort)(MAX + 1);
        static public uint MAX4 = (uint)MAX2 * MAX2;
        /// <summary>
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...255 без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...255 и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public uint GET_ID(this Vector3 v)=>(uint)(v.x + v.y* MAX2 + v.z * MAX4);
        static public Vector3Int GET_V(this string id)=>GET_V(System.Convert.ToUInt32(id));
        static public Vector3Int GET_V(this uint id)
        {
            uint z = (id / MAX4);
            uint y = ((id - MAX4 * z) / MAX2);
            uint x = (id - MAX2 * y - MAX4 * z);
            return new Vector3Int((int)x, (int)y, (int)z);
        }
        static public void test(Vector3 v)
        {
            //v = new Vector3(0,0,-4104);
            uint id = GET_ID(v);
            Vector3 V = GET_V(id);
            //Debug.Log(id + ":(" + v.x + "," + v.y + "," + v.z + ")=(" + V.x + "," + V.y + "," + V.z + ")");
        }
    }
}
