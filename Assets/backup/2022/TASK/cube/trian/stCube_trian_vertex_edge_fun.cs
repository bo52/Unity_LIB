//Bo52_15102020190725904.STAT.TRIANGULATION.
//Bo52_15102020190725904.stat.TRIAN
//FUN_15102020190725904
namespace task2022
{
    using UnityEngine;
    /// <summary>
    /// функции Кубической Триангуляции
    /// </summary>
    static public class stCube_trian_vertex_edge_fun
    {
        #region МЕТОДЫ
        static public byte ТочкаТреугольника(ushort ИндексУникальногоТреугольника, byte НомерОси)=>stCube_trian_vertex_edge.УниикальныеТреугольники[ИндексУникальногоТреугольника, НомерОси];
        static public Vector3 ВершинаГраниБлокаОси(Vector3 ВекторВершины,byte НомерОсиБлока)
        {
            Vector3 v = ВекторВершины - 0.5f * Vector3.one;
            if (НомерОсиБлока != byte.MaxValue) 
                v += 0.5f * stCube_trian_vertex_edge.ТриОси[НомерОсиБлока];
            return v;
        }
        static public Vector3 ВекторТреугольника(ushort ИндексУникальногоТреугольника, byte НомерОсиУникальногоТреугольника)
        {
            var НомерГрани = ТочкаТреугольника(ИндексУникальногоТреугольника, НомерОсиУникальногоТреугольника);
            var ИндексВершины = stCube_trian_vertex_edge.НомерГрани_ИндексВершиныИНомерОси[НомерГрани, 0];
            var НомерОсиБлока = stCube_trian_vertex_edge.НомерГрани_ИндексВершиныИНомерОси[НомерГрани, 1];

            var b = stCube_trian_vertex_edge.ВершиныОтносительноКоординатыБлока[ИндексВершины];
            //var B = СледующийБлокВМире(ref b);

            return ВершинаГраниБлокаОси(b,НомерОсиБлока);
        }
        #endregion
    }
}
