//Bo52_09012021190756321.STAT.COLOR.
namespace Color2022
{
    using UnityEngine;
    /// <summary>
    /// Color.Создание 
    /// </summary>
    public class stColor_new
    {
        static public string INFO = "ГЕНЕРАЦИЯ";
        static public string PRODUCT = "ГЕНЕРАЦИЯ";
        static public bool FIXED = false;
        static public Color32[] Новый(uint d)
        {
            var cs = new Color32[d* d];
            for (var z = 0; z < d; z++)
                for (var x = 0; x < d; x++)
                {
                    cs[x + d * z] = new Color32(0, 0, 0, byte.MaxValue);
                }
            return cs;
        }
    }
}
