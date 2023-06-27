using UnityEngine;
namespace LIB.st2305211717
{
    /// <summary>
    /// stVector_number100
    /// v3.uint.100
    /// uint в Вектор и обратно (MAX=100)
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// MAX
        /// </summary>
        static readonly byte field230521171700 = 100;
        /// <summary>
        /// MAX1
        /// </summary>
        static readonly byte field230521171701 = (byte)(field230521171700 + 1);
        /// <summary>
        /// MAX2
        /// </summary>
        static readonly uint field230521171702 = (uint)((field230521171700 + 1) * (field230521171700 + 1));
        /// <summary>
        /// GET_ID
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public uint fun230521171703(this Vector3 v) => (uint)(v.x + v.y * field230521171701 + v.z * field230521171702);
        /// <summary>
        /// GET_V
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Vector3 fun230521171704(this uint id)
        {
            uint z = (id / field230521171702);
            uint y = ((id - field230521171702 * z) / field230521171701);
            uint x = (id - field230521171701 * y - field230521171702 * z);
            return new Vector3(x, y, z);
        }
        static public void test(Vector3 v)
        {
            //v = new Vector3(0,0,-4104);
            uint id = fun230521171703(v);
            Vector3 V = fun230521171704(id);
            //Debug.Log(id + ":(" + v.x + "," + v.y + "," + v.z + ")=(" + V.x + "," + V.y + "," + V.z + ")");
        }
    }
}