//empty
//empty
//empty
using UnityEngine;
namespace LIB.cs2305181555
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass: cs2305141202.IClass
    {
        Vector3 v4 { get; set; }
        void ДобавитьКвадрат();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2305141202.Class, IClass
    {
        private Vector3 _v4 = Vector3.forward; public Vector3 v4 { get => _v4; set => _v4 = value; }
        public Class(cs2305141215.IClass edit) : base(edit)
        {
        }
        public Class(cs2305141215.IClass edit, cs2306301359.Class Triangle, Vector3 v4) : base(edit, Triangle)
        {
            _v4 = v4;
        }
        public void ДобавитьОбратныйТреугольник()
        {
            Редактор.ДобавитьВершину(v2);
            Редактор.ДобавитьВершину(v4);
            Редактор.ДобавитьВершину(v3);
        }
        public void ДобавитьКвадрат()
        {
            ДобавитьТреугольник();
            ДобавитьОбратныйТреугольник();
        }
    }
}
