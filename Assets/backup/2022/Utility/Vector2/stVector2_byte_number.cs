//Bo52_24102020150243142.STAT.NUMBER.
namespace utility2022
{
    using UnityEngine;
    static public class stVector2_byte_number
    {
        static public string INFO = "Byte";
        static public string PRODUCT = "вектор (X,Y) с максималным byte.maxValye";
        /// <summary>
        /// вектор конвертировать в идентификатор
        /// </summary>
        /// <param name="v">вектор для конвертирования</param>
        /// <param name="min">граница - минимальная положительная целая координата (от 0,1...255 без знака минус)</param>
        /// <param name="max">граница - максимальная положительная целая координата(от 1,2...255 и т.д)</param>
        /// <returns>идентификатор в диапазоне (0...18446744073709551615)</returns>
        static public ushort get_id(byte x,byte y)=>(ushort)(x + (byte.MaxValue + 1) * y);
        static public Vector2 get_v(this ushort id)
        {
            var y = id / 256;
            var x = id - 256 * y;
            return new Vector2(x, y);
        }
        static public void test()
        {
            var id = get_id(1,255);
            var V = get_v(id);
            Debug.Log(id + "(1,255)=" + id + "=(" + V.x + "," + V.y + ")");
        }
    }
}
