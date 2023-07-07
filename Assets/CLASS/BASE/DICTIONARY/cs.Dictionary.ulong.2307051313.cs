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
    public interface IClass : IDictionary
    {
        public t Найти<t>(Vector2 v) where t : class;
        void Добавить(Vector3 v, object obj);
        void Добавить(Vector2 v, object obj);
        void Добавить<T>(Vector3 v, T obj) where T : class;
        Vector3 ПолучитьВектор(ulong id);
        Vector2 ПолучитьВЕКТОР(ulong id);
        ulong ПолучитьНомер(Vector3 v);
        void Обойти<T>(System.Func<Vector3, T, bool> Выполнить) where T : class;
        void Обойти(System.Func<ulong, object, bool> Выполнить);
        void Обойти(System.Func<Vector3, object, bool> Выполнить);
        void Очистить();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<T> : Dictionary<ulong, T>, IClass where T:class
    {
        static public string INFO = "INFO";
        #region ФункцииКласса
        public t Найти<t>(Vector2 v) where t : class
        {
            var code = ПолучитьНомер(v);
            return this.ContainsKey(code) ? this[code] as t : null;
        }
        public void Очистить() => this.Clear();
        public virtual void Добавить(Vector3 v, object obj) => this.Add(ПолучитьНомер(v), (T)obj);
        public virtual void Добавить(Vector2 v, object obj) => this.Add(ПолучитьНомер(v), (T)obj);
        public virtual void Добавить<t>(Vector3 v, t obj) where t:class => this.Add(ПолучитьНомер(v), obj as T);
        public Vector3 ПолучитьВектор(ulong id) => st2305211702.Class.fun230521170204_ПолучитьВектор(id);
        public Vector2 ПолучитьВЕКТОР(ulong id) => st2305211702.Class.fun230521170207_ПолучитьВектор(id);
        public ulong ПолучитьНомер(Vector3 v) => st2305211702.Class.fun230521170203_ПолучитьНомер(v);
        public ulong ПолучитьНомер(Vector2 v) => st2305211702.Class.fun230521170206_ПолучитьНомер(v);
        public void Обойти(System.Func<ulong, object, bool> Выполнить)
        {
            foreach (var val in this)
                if (!Выполнить(val.Key, val.Value)) return;
        }
        public void Обойти(System.Func<Vector3, object, bool> Выполнить)
        {
            foreach (var val in this)
                if (!Выполнить(ПолучитьВектор(val.Key), val.Value)) return;
        }
        public void Обойти<t>(System.Func<Vector3, t, bool> Выполнить) where t : class
        {
            foreach (var val in this)
                if (!Выполнить(ПолучитьВектор(val.Key), val.Value as t)) return;
        }
        #endregion
    }
}
