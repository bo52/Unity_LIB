//Bo52_06112020121754847.STAT.NUMBER.
namespace utility2022
{
    using UnityEngine;
    static public class stTexture2d_number
    {
        static public string INFO = "ЧИСЛО.ТЕКСТУРА";
        static public string PRODUCT = "координата ТЕКСТУРЫ в число и обратно (256-256)";
        static byte MAX = byte.MaxValue;
        static public void test()
        {
            var id=new Vector2Int(23, 56).get_id();
            var v= get_v(id);
            Debug.Log(id);
            Debug.Log(v);
        }

        /// вектор конвертировать в идентификатор       
        static public ushort get_id(this Vector2Int v)=>(ushort)(v.x + (MAX + 1) * v.y);
        static public Vector2Int get_v(this ushort id)
        {
            int y = id / (MAX + 1);
            int x = id - (MAX + 1) * y;
            return new Vector2Int(x, y);
        }
    }
}
