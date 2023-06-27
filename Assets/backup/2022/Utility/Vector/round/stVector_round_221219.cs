namespace utility2022
{
    using UnityEngine;
    static public class stVector_round_221219
    {
        static public string INFO = "Округлить";
        static public string PRODUCT = "Окрулить Вперёд по абсолютному числу (OLD)";
        #region МЕТОДЫ
        static public int МинимальноеЧисло(this float X)
        {
            if (X == 0) return 0;
            int k = X < 0 ? -1 : 1;
            float abs = Mathf.Abs(X);
            var x = (int)(k < 0 ? System.Math.Ceiling(abs) : abs);

            return k * x;
        }
        static public Vector3 ОкруглитьВектор(this Vector3 v)=>new Vector3(v.x.МинимальноеЧисло(), v.y.МинимальноеЧисло(), v.z.МинимальноеЧисло());

        static public float Целое(this float x)
        {
            if (x == 0)
                return 0;

            var abs_x = Mathf.Abs((float)System.Math.Ceiling(x));
            return x < 0 ? abs_x *= -1 : abs_x -= 1;
        }
        static public Vector3 Целое(this Vector3 v)
        {
            //Ceiling
            //+7.50f->8.0f
            //+7.01f->8.0f
            //+0.01f->1.0f
            //-0.01f->0.0f
            Vector3 abs = new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
            abs.x = Целое(v.x);
            abs.y = Целое(v.y);
            abs.z = Целое(v.z);

            return abs;
        }
        #endregion
    }
}
