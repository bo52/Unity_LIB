//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2307051313_Словарь_Ulong
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass:IDictionary
    {
        void Добавить(Vector3 v, object obj);
        Vector3 ПолучитьВектор(ulong id);
        public ulong ПолучитьНомер(Vector3 v);
        public void Обойти(System.Func<ulong, object, bool> Выполнить);
        void Очистить();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<T> : Dictionary<ulong, T>, IClass
    {
        static public string INFO = "INFO";
        #region ФункцииКласса
        public void Очистить() => this.Clear();
        public virtual void Добавить(Vector3 v, object obj) => this.Add(ПолучитьНомер(v), (T)obj);
        public Vector3 ПолучитьВектор(ulong id) => st2305211702.CLASS.fun230521170204_ПолучитьВектор(id);
        public ulong ПолучитьНомер(Vector3 v) => st2305211702.CLASS.fun230521170203_ПолучитьНомер(v);
        public void Обойти(System.Func<ulong, object, bool>Выполнить) {
            foreach (var val in this)
                if (!Выполнить(val.Key,val.Value)) return;
        }
        #endregion
    }
}
