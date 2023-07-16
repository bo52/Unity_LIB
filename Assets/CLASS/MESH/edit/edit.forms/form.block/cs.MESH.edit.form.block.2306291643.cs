//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2306291643
{
    /// <summary>
    /// Форма блока
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// форма блок для меша
        /// </summary>
        cs2306262134.Class ТекущийБлок { get; set; }
        void ADD(cs2306262134.Class b);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2305141209.Class, IClass
    {
        static public string INFO = "INFO";
        public Class(cs2307031203_ПараметрыПостройки.Struct param) : base(param)
        {

        }
        private cs2306262134.Class _b;
        public cs2306262134.Class ТекущийБлок { get => _b; set => _b = value; }
        public virtual Vector3 ВычислениеВектора(Vector3 dv) => ТекущийБлок.Центр + dv;
        public virtual Vector3 ВычислениеВектора(ushort ИндексУникальногоТреугольника, byte i) => ВычислениеВектора(ТочкаУникальногоТреугольника(ИндексУникальногоТреугольника, i));
        /// <summary>
        /// ВершинаГраниБлокаОси
        /// </summary>
        /// <param name="ИндексВершины"></param>
        /// <param name="НомерОсиБлока"></param>
        /// <returns></returns>
        static public Vector3 ВычислениеВектора(byte ИндексВершины, byte НомерОсиБлока)
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
            return ВычислениеВектора(st2305141159.Class.field230514115901_НомерВершиныКубаПоНомеруГрани[НомерГрани, 0], st2305141159.Class.field230514115901_НомерВершиныКубаПоНомеруГрани[НомерГрани, 1]);
        }
        /// <summary>
        ///собрать куб в списки vs,ns,uvs
        /// </summary>
        public void ADD(cs2306262134.Class b)
        {
            if (b.Код == 0) return;
            ТекущийБлок = b;
            //треугольники
            Vector3 v1, v2, v3;
            foreach (var ИндексУникальногоТреугольника in st2305141315.Class.field230514131500_БлокИзТреугольников[ТекущийБлок.Код])
            {
                v1 = ВычислениеВектора(ИндексУникальногоТреугольника, 0);
                v2 = ВычислениеВектора(ИндексУникальногоТреугольника, 1);
                v3 = ВычислениеВектора(ИндексУникальногоТреугольника, 2);
                ADD(new cs2306301359.Struct(v1, v2, v3));
            }
        }
    }
}
