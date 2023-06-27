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
        void Треугольник(cs2305141215.IClass Редактор);
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
        public virtual void Треугольник(cs2305141215.IClass Редактор)
        {
            var arr = ФункцияВерстки == null ? st2306261718.Class.fun230626171800_ВерсткаБлока(Редактор) : ФункцияВерстки(Редактор);
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
