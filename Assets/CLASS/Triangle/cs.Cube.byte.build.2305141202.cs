//empty
//empty
//построить куб
using UnityEngine;
namespace LIB.cs2305141202
{
    /// <summary>
    /// interface постройки куба
    /// </summary>
    public interface IClass : cs2305141208.IClass
    {
        void СобратьВертекс(byte КодБлока);
        void ИзменитьТекущийБлокИПостроить(cs2306262134.Class b);
    }
    public class Class : cs2305141208.Class, IClass
    {
        public Class(GameObject go): base(go)
        {
        }
        /// <summary>
        /// Одинаковые методы класса и интерфейса зацикливают выполнение метода класса
        /// при вызове интерфейсного метода в методе класса
        /// </summary>
        /// <param name="КодБлока"></param>
        public virtual void СобратьВертекс(byte КодБлока) {
            ИзменитьТекущийБлокИПостроить(new cs2306262134.Class(this.ТекущийБлок.Центр, КодБлока));
            Закрыть();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        public void ИзменитьТекущийБлокИПостроить(cs2306262134.Class b)
        {
            this.ТекущийБлок = b;
            st2305202041.Class.fun230520204100_СобратьБлок(this);
        }
    }
}