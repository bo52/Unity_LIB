//empty
//empty
//IVertices строим по вертексу
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace LIB.cs2305141215
{
    /// <summary>
    /// stMesh.build.vertices.cs2305141215
    /// строим по вертексу
    /// </summary>
    public interface IClass : cs2305141222.IClass
    {
        void ДОБАВИТЬ(object arg);
        void ДОБАВИТЬ(object[] args);
        /// <summary>
        /// набор вершин
        /// </summary>
        List<Vector3> vs { get; }
        /// <summary>
        /// нумерация вершин
        /// </summary>
        List<int> ts { get; }
        /// <summary>
        /// нормали
        /// </summary>
        List<Vector3> ns { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void ДобавитьВершину(Vector3 v);
        public new void Очистить()
        {
            vs.Clear();
            ts.Clear();
            ns.Clear();
            (this as cs2305141222.IClass).Очистить();
        }
        void ФункцияПостройки();
        cs2305141208.Class.ПараметрыПостройки ПараметрыПостройки { get; }
    }
    /// <summary>
    /// 
    /// </summary>
    public abstract class Class : cs2305141222.Class, IClass
    {
        private cs2305141208.Class.ПараметрыПостройки _param; public cs2305141208.Class.ПараметрыПостройки ПараметрыПостройки => _param;
        public void ФункцияПостройки() => _param.ФункцияПостройки(this);
        public Class(cs2305141208.Class.ПараметрыПостройки param)
        {
            _param = param;
        }
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
        private List<Vector3> _ns = new List<Vector3>(); public List<Vector3> ns => _ns;
        /// <summary>
        /// Добавить вершину для постройки куба
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="ФункцияВерстки"></param>
        public void ДобавитьВершину(Vector3 v)
        {
            //новый вертекс
            vs.Add(v);
            //индексы вертексов
            ts.Add(vs.Count - 1);
            //нормали
            ns.Add(v.normalized);
            ТреугольникВерстки(this);
        }
        public void ДОБАВИТЬ(object[] args)
        {
            System.Reflection.MethodBase ci = this.GetType().GetMethod("ADD", (from x in args select x.GetType()).ToArray());
            ci.Invoke(this, args);
        }
        public void ДОБАВИТЬ(object arg) => ДОБАВИТЬ(new object[] { arg });
    }
}
