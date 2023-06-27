using UnityEngine;
namespace mesh2023
{
    using cube2023;
    public static class stCube256_adges
    {
        static public string INFO = "ARRAY";
        static public string PRODUCT = "массивы триангуляции";
        /// <summary>
        /// три направленные оси точки (для определения граневая точка куба)
        /// </summary>
        public static readonly Vector3[] ТриОси = new Vector3[3]
        {
            Vector3.right,
            Vector3.up,
            Vector3.forward
        };
        /// <summary>
        /// строка - грань куба
        /// x - по номеру грани определить связанную ОтносительнуюВершинуКуба или точку
        /// y - номеру ОСИ, где располагается точка грани, которая связана с ВершинойКуба (0..7)
        /// </summary>
        static public readonly byte[,] ИндексВершиныИНомерОси = new byte[,]
        {
        { 0, 0 },
        { 2, 0 },
        { 0, 1 },
        { 1, 1 },
        { 0, 2 },
        { 2, 2 },
        { 1, 2 },
        { 3, 2 },
        { 4, 0 },
        { 6, 0 },
        { 4, 1 },
        { 5, 1 },
        };
        #region fun
        static public Vector3 ВершинаГраниБлокаОси(byte ИндексВершины, byte НомерОсиБлока)
        {
            var ВекторВершины = stCube_verteces_8.ВершиныОтносительноКоординатыБлока[ИндексВершины];
            Vector3 v = ВекторВершины - 0.5f * Vector3.one;
            if (НомерОсиБлока != byte.MaxValue)
                v += 0.5f * ТриОси[НомерОсиБлока];
            return v;
        }
        static public Vector3 ВекторТреугольника(ushort ИндексУникальногоТреугольника, byte НомерОсиУникальногоТреугольника)
        {
            var НомерГрани = ИндексУникальногоТреугольника.ТочкаТреугольника(НомерОсиУникальногоТреугольника);
            return ВершинаГраниБлокаОси(ИндексВершиныИНомерОси[НомерГрани, 0], ИндексВершиныИНомерОси[НомерГрани, 1]);
        }
        #endregion
    }
}