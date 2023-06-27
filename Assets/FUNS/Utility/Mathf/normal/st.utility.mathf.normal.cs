//empty
//empty
//вычисление нормали
using UnityEngine;
namespace LIB.st2305221202
{
    /// <summary>
    /// stMathf_normal
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// НормальТриугольника
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        static public Vector3 НормальТриугольника(Vector3 A, Vector3 B, Vector3 C)
        {
            var vx1 = A.x - B.x;
            var vy1 = A.y - B.y;
            var vz1 = A.z - B.z;
            var vx2 = B.x - C.x;
            var vy2 = B.y - C.y;
            var vz2 = B.z - C.z;

            Vector3 N = new Vector3(vy1 * vz2 - vz1 * vy2, vz1 * vx2 - vx1 * vz2, vx1 * vy2 - vy1 * vx2);
            var wrki = Mathf.Sqrt(Mathf.Pow(vy1 * vz2 - vz1 * vy2, 2) + Mathf.Pow(vz1 * vx2 - vx1 * vz2, 2) + Mathf.Pow(vx1 * vy2 - vy1 * vx2, 2));
            N.x = N.x / wrki;
            N.y = N.y / wrki;
            N.z = N.z / wrki;
            return N;
        }
        ///exit
    }
}
