//Bo52_16102020134253967.STAT.VECTOR
namespace utility2022
{
    using UnityEngine;
    /// <summary>
    /// работа с Вектором
    /// </summary>
    static public class stVector_mathf
    {
        static public Vector3 ABS(this Vector3 v)
        {
            return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
        }
        static public Vector3 Нормаль(this Vector3 v, Vector3 A, Vector3 B)
        {

            Vector3 Side1 = new Vector3(A.x - v.x, A.y - v.y, A.z - v.z);
            Vector3 Side2 = new Vector3(B.x - A.x, B.y - A.y, B.z - A.z);
            Vector3 Perp = Vector3.Cross(Side1, Side2);
            float perpLength = Perp.magnitude;
            return Perp / perpLength;
        }
    }
}
