//empty
//empty
//Bo52_09012021190756321.STAT.COLOR.
using UnityEngine;
namespace LIB.st2305221154
{
    /// <summary>
    /// stColor_new
    /// Color.Создание 
    /// </summary>
    static public class Class
    {
        static public string INFO = "ГЕНЕРАЦИЯ";
        static public string PRODUCT = "ГЕНЕРАЦИЯ";
        /// <summary>
        /// Новый
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        static public Color32[] fun230522115400(uint d)
        {
            var cs = new Color32[d* d];
            for (var z = 0; z < d; z++)
                for (var x = 0; x < d; x++)
                {
                    cs[x + d * z] = new Color32(0, 0, 0, byte.MaxValue);
                }
            return cs;
        }
        ///exit
    }
}
