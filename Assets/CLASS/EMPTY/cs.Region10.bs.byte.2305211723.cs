//empty
//empty
//Region10.Block8.Cube256 в кубе 10*10*10
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305211723
{
    /// <summary>
    /// IRegion10_bs
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// радиус региона (количество блоков по одной оси)
        /// </summary>
        static public byte R = 10;
        public Dictionary<uint, byte> Ѕлоки–егиона { get; }
        #region  оордината
        public bool —уществуетЅлок(Vector3 v) => —уществуетЅлок( оординатаЅлока(v));
        public bool —уществуетЅлок(uint id) => Ѕлоки–егиона.ContainsKey(id);
        public uint  оординатаЅлока(Vector3 v);
        public Vector3  оординатаЅлока(uint id);
        #endregion
    }
    public class Class
    {
        public uint  оординатаЅлока(Vector3 v) => st2305211717.Class.fun230521171703(v);
        public Vector3  оординатаЅлока(uint id) => st2305211717.Class.fun230521171704(id);
    }
}
