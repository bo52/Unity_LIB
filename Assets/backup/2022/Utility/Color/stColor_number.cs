//Bo52_06112020115349244.STAT.NUMBER.
//Bo52_06112020115349244.STAT
namespace utility2022
{
    using UnityEngine;
    static public class stColor_number
    {
        static public string INFO = "ЧИСЛО.Цвет";
        static public string PRODUCT = "цвет в число и обратно (255-255-255)";
        static byte MAX = byte.MaxValue; 
        static public void test()
        {
            var id = new Vector3Int(255, 255, 255).get_id();
            var v = id.get_v();
            Debug.Log(id);
            Debug.Log(v);
        }
        /// вектор конвертировать в идентификатор       
        static public uint get_id(this Vector3Int v)=>(uint)(v.x + (MAX + 1) * v.y + Mathf.Pow(MAX + 1, 2) * v.z);
        static public Vector3Int get_v(this uint id)
        {
            int _mx = MAX + 1;
            int _my = (int)Mathf.Pow(_mx, 2);

            int z = (int)id / _my;
            int y = (int)(id - _my * z) / _mx;
            int x = (int)id - _mx * y - _my * z;
            return new Vector3Int(x, y, z);
        }
    }
}
