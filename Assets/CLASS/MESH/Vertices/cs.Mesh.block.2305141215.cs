//empty
//empty
//IVertices строим по вертексу
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305141215
{
    /// <summary>
    /// stMesh.build.vertices.cs2305141215
    /// строим по вертексу
    /// </summary>
    public interface IClass : cs2305141222.IClass
    {
        /// <summary>
        /// блок
        /// </summary>
        cs2306262134.Class ТекущийБлок { get; set; }
        /// <summary>
        /// набор вершин
        /// </summary>
        List<Vector3> vs{get;}
        /// <summary>
        /// нумерация вершин
        /// </summary>
        List<int> ts{get;}
        /// <summary>
        /// нормали
        /// </summary>
        List<Vector3> ns{get;}
        public virtual Vector3 ВычислениеВектора(Vector3 dv)=> ТекущийБлок.Центр + dv;
        /// <summary>
        /// Добавить вершину для постройки куба
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="ФункцияВерстки"></param>
        public void ДобавитьВершинуДляБлока(Vector3 dv)
        {
            var v = ВычислениеВектора(dv);
            //новый вертекс
            vs.Add(v);
            //индексы вертексов
            ts.Add(vs.Count - 1);
            //нормали
            ns.Add(v.normalized);
            Треугольник(this);
        }
        public new void Очистить()
        {
            vs.Clear();
            ts.Clear();
            ns.Clear();
            (this as cs2305141222.IClass).Очистить();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Class : cs2305141222.Class, IClass
    {
        private cs2306262134.Class _b; public cs2306262134.Class ТекущийБлок { get => _b; set => _b=value; }
        /// <summary>
        /// вертексы
        /// </summary>
        private List<Vector3> _vs = new List<Vector3>(); public List<Vector3> vs => _vs;
        /// <summary>
        /// индексы
        /// </summary>
        private List<int> _ts = new List<int>(); public List<int> ts => _ts;
        /// <summary>
        /// нормали
        /// </summary>
        private List<Vector3> _ns = new List<Vector3>(); 
        public List<Vector3> ns => _ns;
    }
}
