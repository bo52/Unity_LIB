//Bo52_16102020131333172.STAT.NUMBER.
namespace utility2022
{
    using UnityEngine;
    static public class stCube256_vertex8_number
    {
        static public string INFO = "Byte";
        static public string PRODUCT = "Byte в Список<7> Bool и Обратно";
        static public byte GET_ID(this bool[] Вершины)
        {
            byte cnt = 0;
            float КОД = 0;
            foreach (var b in Вершины)
            {
                if (b == true)
                    КОД += Mathf.Pow(2, cnt);
                cnt++;
            }
            return (byte)КОД;
        }
        static public bool[] GET_V(this byte id)
        {
            bool[] bs = new bool[8];
            if (id == 0)
                return bs;
            float m;
            float Остаток = id;
            for (byte i = 7; i >= 0; i--)
            {
                m = Mathf.Pow(2, i);
                bs[i] = Остаток / m < 1 ? false : true;
                if (bs[i])
                {
                    Остаток -= m;
                }
                if (Остаток <= 0)
                    break;
            }
            return bs;
        }
    }
}
