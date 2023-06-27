//Bo52_31122020141256939.DICTIONARY.
namespace dictionary2022
{
    using UnityEngine;
    using System.Collections.Generic;
    /// <summary>
    /// Найти
    /// Найти Элемент в DICTIONARY
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DICTIONARY_f<T>: Dictionary<ulong, T>
    {
        private System.Func<Vector3, ulong> get_id;
        public DICTIONARY_f()
        {

        }
        ///Bo52_30122020142720560.REGION.GET_ID(v)=stVector_number10_uint
        /// <summary>
        /// 
        /// </summary>
        /// <param name="get_id"></param>
        public DICTIONARY_f(System.Func<Vector3,ulong> get_id)=>this.get_id = get_id;
        public virtual T Найти(Vector3 v)=>Найти(get_id(v));
        public virtual T Найти(ulong id)
        {
            var найден = ContainsKey(id);
            if (найден == true)
            {
                if (this[id].Equals(null))
                {
                    Remove(id);
                    return default;
                }
                return this[id];
            }
            return default;
        }
    }
}
