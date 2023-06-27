//Bo52_27122020144547700.BLOCK.
namespace utility2022
{
    using UnityEngine;
    static public class stVector_number1000_uint
    {
        static public string INFO = "ИД";
        static public string PRODUCT = "uint в Вектор и обратно (MAX=1000)";
        static readonly uint MAX = 1000;
        static readonly uint MAX1 = MAX + 1;
        static readonly uint MAX2 = (MAX + 1) * (MAX + 1);
        /// <summary>
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public uint GET_ID(this Vector3 v)=>(uint)(v.x + v.y * MAX1 + v.z * MAX2);
        static public Vector3 GET_V(this uint id)
        {
            uint z = (id / MAX2);
            uint y = ((id - MAX2 * z) / MAX1);
            uint x = (id - MAX1 * y - MAX2 * z);
            Vector3 v = new Vector3(x, y, z);
            return v;
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
