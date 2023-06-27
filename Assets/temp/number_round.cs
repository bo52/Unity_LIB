using UnityEngine;
namespace utility2023
{
    public static class number_round_down
    {
        static public int МинимальноеЧисло_вниз(this float X)
        {
            int k = X < 0 ? -1 : 1;
            var cel = (int)Mathf.Abs(X);
            if (cel == 0)
            {
                return k == -1 ? k : 0;
            }
            if (cel > 0)
                return cel;

            //-1.5f -> -2
            //-0.6f -> -1
            //-0.4f -> -1
            //+0.4f -> +0
            //+0.6f -> +0
            //+1.5f -> +1
            return k * cel - 1;
        }
        static public Vector3 ОкруглитьВектор_вниз(this Vector3 v)
        {

            return new Vector3(v.x.МинимальноеЧисло_вниз(), v.y.МинимальноеЧисло_вниз(), v.z.МинимальноеЧисло_вниз());
        }
    }
}