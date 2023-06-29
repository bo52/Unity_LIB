//empty
//empty
//вычислить вектор куба
using UnityEngine;
namespace LIB.st2305141159
{
    /// <summary>
    /// stMesh.Cube_byte.adges.cs2305141159
    /// вычислить вектор куба
    /// </summary>
    static public class Class
    {
        static public string INFO = "ARRAY";
        static public string PRODUCT = "массивы триангуляции";
        /// <summary>
        /// ТриОси
        /// три направленные оси точки (для определения граневая точка куба)
        /// </summary>
        static public readonly Vector3[] field230514115900_ВекторПоТремОсям = new Vector3[3]
        {
            Vector3.right,
            Vector3.up,
            Vector3.forward
        };
        /// <summary>
        /// ИндексВершиныИНомерОси
        /// строка - ребро куба или линия
        /// x - по номеру грани определить связанную ОтносительнуюВершинуКуба или точку
        /// y - номеру ОСИ, где располагается точка ребра куба, которая связана с ВершинойКуба (0..7)
        /// </summary>
        static public readonly byte[,] field230514115901_НомерВершиныКубаПоНомеруГрани = new byte[,]
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
        ///exit
    }
}