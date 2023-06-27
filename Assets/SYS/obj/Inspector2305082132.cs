//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
namespace LIB.go2305082132
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInspector
    {
    MonoBehaviour Моно { get; set; }
        bool Выполнить();
        T field<T>(ref T val) where T : class, new();
    }
    /// <summary>
    /// 
    /// </summary>
    public class Inspector : Object, IInspector
    {
        public Inspector() { }
        public Inspector(MonoBehaviour MB) => this.MB = MB;
        private MonoBehaviour MB;
        public MonoBehaviour Моно
        {
            get => MB;
            set => MB = value;
        }
        #region Выполненение
        public virtual bool Тест() => false;
        public virtual bool Выполнить()
        {
            var btn = GUILayout.Button("test");
            if (btn) this.Тест();
            return btn;
        }
        #endregion
        public virtual T field<T>(ref T val) where T : class, new()
        {
            if (val == null) val = new T();
            return val;
        }
        public virtual T field<T>(ref T val, object[] args) where T : class
        {
            System.Type TestType = typeof(T);
            //если класс не найден
            if (TestType == null) return null;
            //получаем конструктор
            var ts = new List<System.Type>();
            foreach (var arg in args) ts.Add(arg.GetType());

            System.Reflection.ConstructorInfo ci = TestType.GetConstructor(ts.ToArray());
            //вызываем конструтор
            return ci.Invoke(args) as T;
        }
    }
}