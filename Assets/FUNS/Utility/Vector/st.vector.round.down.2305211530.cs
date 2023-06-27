using UnityEngine;
namespace LIB.st2305211530
{
    /// <summary>
    /// works
    /// stNumber_round_down
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// МинимальноеЧисло_вниз
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        static public int fun230521153000(this float X)
        {
            int k = X < 0 ? -1 : 1;
            var num=Mathf.Abs(X);
            var cel = (int)num;
            if (X > 0)
                return cel;

            if (cel == 0)
            {
                return k == -1 ? k : 0;
            }
            //-1.5f -> -2
            //-0.6f -> -1
            //-0.4f -> -1
            //+0.4f -> +0
            //+0.6f -> +0
            //+1.5f -> +1
            return k * cel+(num == cel? 0 : -1);
        }
        /// <summary>
        /// ОкруглитьВектор_вниз
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public Vector3 fun230521153001(this Vector3 v)
        {

            return new Vector3(v.x.fun230521153000(), v.y.fun230521153000(), v.z.fun230521153000());
        }
        ///exit
    }
}