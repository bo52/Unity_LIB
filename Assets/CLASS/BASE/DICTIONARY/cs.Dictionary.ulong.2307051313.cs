//Словарь[ulong,Вектор].[Добавить,ПолучитьНомерВектор,Обойти,Сосед,Существует,Очистить]
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
        #region Добавить2
        Vector2 ПолучитьВектор2(ulong id);
        public t Найти2<t>(Vector2 v) where t : class;
        void Добавить2(Vector2 v, object obj);
        #endregion
        #region Добавить3
        bool Существует3(Vector3 v);
        void Добавить3<t>(cs2307081134_Координата3.Struct Координата3) where t : class;
        void Добавить3(Vector3 v, object obj);
        void Добавить3<t>(Vector3 v, t obj) where t : class;
        void Добавить3<t>(ulong id, t obj) where t : class;
        ulong ПолучитьНомер3(Vector3 v);
        Vector3 ПолучитьВектор3(ulong id);
        #endregion
        #region обойти
        void Обойти<t>(System.Func<t, bool> Выполнить) where t : class;
        void Обойти<t>(System.Func<Vector3, t, bool> Выполнить) where t : class;
        void Обойти(System.Func<ulong, object, bool> Выполнить);
        void Обойти(System.Func<Vector3, object, bool> Выполнить);
        #endregion
        void Очистить();
        public bool Существует(ulong id);
    }
    /// <summary>
    ///
    /// </summary>
    public class Class<T> : Dictionary<ulong, T>, IClass where T : cs2307081134_Координата3.Class
    {
        static public string INFO = "INFO";
        public void Очистить() => this.Clear();
        #region Сосед
        public bool СуществуетСосед(T el, Vector3 dv)
        {
            var Координата = new cs2307081134_Координата3.Struct(el.Координата.v + dv);
            return this.ContainsKey(Координата.id);
        }
        #endregion

        #region Добавить2
        public t Найти2<t>(Vector2 v) where t : class
        {
            var code = ПолучитьНомер2(v);
            return this.ContainsKey(code) ? this[code] as t : null;
        }
        public ulong ПолучитьНомер2(Vector2 v) => st2305211702.Class.fun230521170206_ПолучитьНомер2(v);
        public Vector2 ПолучитьВектор2(ulong id) => st2305211702.Class.fun230521170207_ПолучитьВектор2(id);
        public virtual void Добавить2(Vector2 v, object obj) => this.Add(ПолучитьНомер2(v), (T)obj);
        #endregion
        #region Добавить3
        public bool Существует3(Vector3 v) => this.ContainsKey(ПолучитьНомер3(v));
        public ulong ПолучитьНомер3(Vector3 v) => st2305211702.Class.fun230521170203_ПолучитьНомер3(v);
        public Vector3 ПолучитьВектор3(ulong id) => st2305211702.Class.fun230521170204_ПолучитьВектор3(id);
        public virtual void Добавить3<t>(cs2307081134_Координата3.Struct Координата3) where t : class => this.Add(Координата3.id, st2307091409.Class.fun230709140901_СоздатьЭкземпляр<t>(Координата3) as T);
        public virtual void Добавить3<t>(ulong id, t obj) where t : class => this.Add(id, obj as T);
        public virtual void Добавить3<t>(Vector3 v, t obj) where t : class => Добавить3(ПолучитьНомер3(v), obj);
        public virtual void Добавить3(Vector3 v, object obj) => this.Add(ПолучитьНомер3(v), (T)obj);
        #endregion
        #region обойти
        public void Обойти(System.Func<ulong, object, bool> Выполнить)
        {
            foreach (var val in this)
                if (!Выполнить(val.Key, val.Value)) return;
        }
        public void Обойти<t>(System.Func<t, bool> Выполнить) where t : class
        {
            foreach (var val in this)
                if (!Выполнить(val.Value as t)) return;
        }
        public void Обойти(System.Func<Vector3, object, bool> Выполнить)
        {
            foreach (var val in this)
                if (!Выполнить(ПолучитьВектор3(val.Key), val.Value)) return;
        }
        public void Обойти<t>(System.Func<Vector3, t, bool> Выполнить) where t : class
        {
            foreach (var val in this)
                if (!Выполнить(ПолучитьВектор3(val.Key), val.Value as t)) return;
        }
        #endregion
        public bool Существует(ulong id) => this.ContainsKey(id);
    }
}
