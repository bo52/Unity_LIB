//empty
//empty
//построить куб
using UnityEngine;
namespace LIB.cs2305141202
{
    /// <summary>
    /// interface Закрыть МЕШ
    /// </summary>
    public interface IClass
    {
        cs2305141215.IClass Редактор { get; }
        Vector3 v1 { get; set; }
        Vector3 v2 { get; set; }
        Vector3 v3 { get; set; }
        void ДобавитьТреугольник();
    }
    /// <summary>
    /// ВершиныТреугольника
    /// </summary>
    public class Class : IClass
    {
        private cs2305141215.IClass _edit; public cs2305141215.IClass Редактор => _edit;
        private Vector3 _v1 = Vector3.zero; public Vector3 v1 { get => _v1; set => _v1 = value; }
        private Vector3 _v2 = Vector3.right; public Vector3 v2 { get => _v2; set => _v2 = value; }
        private Vector3 _v3 = Vector3.forward; public Vector3 v3 { get => _v3; set => _v3 = value; }
        public Class(cs2305141215.IClass edit)
        {
            this._edit = edit;
        }
        public Class(cs2305141215.IClass edit, cs2306301359.Class ВершиныТреугольника)
        {
            this._edit = edit;
            this.v1 = ВершиныТреугольника.v1;
            this.v2 = ВершиныТреугольника.v2;
            this.v3 = ВершиныТреугольника.v3;
        }
        public void ДобавитьТреугольник()
        {
            Редактор.ДобавитьВершину(v1);
            Редактор.ДобавитьВершину(v2);
            Редактор.ДобавитьВершину(v3);
        }
    }
}