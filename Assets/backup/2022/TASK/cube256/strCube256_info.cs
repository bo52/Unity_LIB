using UnityEngine;
namespace task2022
{
    using mathf2022;
    public struct strCube256_info
    {
        public bool Существует;
        public Vector3 НулевойВекторБлока;
        public bool НомерВершиныСуществует;

        public Vector3 ВекторБлока;
        public byte КодБлока;
        public byte НомерВершины;
        public strCube256_info(bool b, byte n, Vector3 v0, Vector3 v, byte k)
        {
            Существует = b;
            НомерВершины = n;
            КодБлока = k;
            НомерВершиныСуществует = stMathf_Cube256_exists.НомерВершиныСуществуетВКоде(НомерВершины, КодБлока);

            НулевойВекторБлока = v0;
            ВекторБлока = v;
        }
    }
}
