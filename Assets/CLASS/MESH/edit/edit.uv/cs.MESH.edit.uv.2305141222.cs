//empty
//empty
//Mesh.uv развертка текстуры
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305141222
{
    /// <summary>
    /// stMesh.build.uv.cs2305141222
    /// </summary>
    public interface IClass
    {
        System.Func<cs2305141215.IClass, Vector2[]> ФункцияВерстки { get; set; }
        List<Vector2>[] Развёртка { get; }
        void ТреугольникВерстки(cs2305141215.IClass Редактор);
        void Очистить();
    }
    public class Class
    {
        private List<Vector2>[] _uv = new List<Vector2>[8]
        {
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
            new List<Vector2>(),
        };
        public List<Vector2>[] Развёртка => _uv;
        /// <summary>
        /// 
        /// </summary>
        private System.Func<cs2305141215.IClass, Vector2[]> fun; public System.Func<cs2305141215.IClass, Vector2[]> ФункцияВерстки { get => fun; set => fun = value; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Редактор"></param>
        public virtual void ТреугольникВерстки(cs2305141215.IClass Редактор)
        {
            Vector2[]arr;
            if (ФункцияВерстки != null) arr = ФункцияВерстки(Редактор); else
            {
                switch (Редактор.ПараметрыПостройки.НомерРедактора)
                {
                    case 1:
                        arr = st2306261718.Class.fun230626171800_ВерсткаБлока(Редактор as cs2306291643.Class);
                        break;
                    default:
                        arr=new Vector2[8] { Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero };
                        break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Развёртка[i].Add(arr[i]);
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Очистить()
        {
            for (var i = 0; i < Развёртка.Length; i++)
                Развёртка[i].Clear();
        }
    }
}
