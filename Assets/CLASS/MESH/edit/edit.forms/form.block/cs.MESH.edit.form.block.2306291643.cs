//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306291643
{
    /// <summary>
    /// Форма блока
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// блок
        /// </summary>
        cs2306262134.Class ТекущийБлок { get; set; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2305141209.Class, IClass
    {
        static public string INFO = "INFO";
        private cs2306262134.Class _b;
        public cs2306262134.Class ТекущийБлок { get => _b; set => _b = value; }
        public virtual Vector3 ВычислениеВектора(Vector3 dv) => ТекущийБлок.Центр + dv;
        public virtual Vector3 ВычислениеВектора(ushort ИндексУникальногоТреугольника, byte i) => ВычислениеВектора(ТочкаУникальногоТреугольника(ИндексУникальногоТреугольника, i));
        public virtual ВершиныТреугольника ВычислениеВекторов(ushort ИндексУникальногоТреугольника) => new ВершиныТреугольника(ВычислениеВектора(ИндексУникальногоТреугольника, 0), ВычислениеВектора(ИндексУникальногоТреугольника, 1), ВычислениеВектора(ИндексУникальногоТреугольника, 2));
        /// <summary>
        /// ВершинаГраниБлокаОси
        /// </summary>
        /// <param name="ИндексВершины"></param>
        /// <param name="НомерОсиБлока"></param>
        /// <returns></returns>
        static public Vector3 fun230514115902(byte ИндексВершины, byte НомерОсиБлока)
        {
            var v = st2305151543.Class.fun230515154302_ВекторВершиныПоЦентруКуба(ИндексВершины);
            if (НомерОсиБлока != byte.MaxValue)
                v += 0.5f * st2305141159.Class.field230514115900_ВекторПоТремОсям[НомерОсиБлока];
            return v;
        }
        /// <summary>
        /// ВекторТреугольника
        /// </summary>
        /// <param name="ИндексУникальногоТреугольника"></param>
        /// <param name="НомерОсиУникальногоТреугольника"></param>
        /// <returns></returns>
        static public Vector3 ТочкаУникальногоТреугольника(ushort ИндексУникальногоТреугольника, byte НомерОси)
        {
            var НомерГрани = st2305141153.Class.fun230514115300_НомерГраниКуба(ИндексУникальногоТреугольника, НомерОси);
            return fun230514115902(st2305141159.Class.field230514115901_НомерВершиныКубаПоНомеруГрани[НомерГрани, 0], st2305141159.Class.field230514115901_НомерВершиныКубаПоНомеруГрани[НомерГрани, 1]);
        }
        /// <summary>
        ///собрать куб в списки vs,ns,uvs
        /// </summary>
        public void Добавить()
        {
            if (ТекущийБлок.Код == 0) return;
            //треугольники
            foreach (var ИндексУникальногоТреугольника in st2305141315.Class.field230514131500_БлокИзТреугольников[ТекущийБлок.Код])
            {
                ДобавитьТреугольник(ВычислениеВекторов(ИндексУникальногоТреугольника));
            }
        }
        /// <summary>
        /// добавить вершину cube256 в блок по координате
        /// </summary>
        /// <param name="Редактор"></param>
        /// <param name="КодВершиныБлока"></param>
        /// <param name="КоординатаВершиныБлока"></param>
        public void ИзменитьИДобавить(cs2306262134.Class b)
        {
            ТекущийБлок = b;
            Добавить();
        }
    }
}
