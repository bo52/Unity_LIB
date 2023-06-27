//empty
//empty
//Vertices.size.delta
using UnityEngine;
namespace LIB.cs2305181649
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClass: cs2305141215.IClass
    {
        /// <summary>
        /// выбранная точка редактирования
        /// </summary>
        static Vector3 РедКоординатаБлока = Vector3.zero;
        /// <summary>
        /// кубический размер количества блоков
        /// </summary>
        static sbyte SIZE = 3;
        /// <summary>
        /// восемь блоков по одной оси при SIZE = 3
        /// </summary>
        static float MAX => Mathf.Pow(2, SIZE);
        /// <summary>
        /// отступ между кубами 1/8 при SIZE = 3
        /// </summary>
        static float Дельта => 1 / MAX;
        static Vector3 Смещение => 0.5f * Vector3.one * (Дельта - 1);
        new Vector3 ВычислениеВектора(Vector3 dv) => РедКоординатаБлока + Дельта * (this as cs2305141215.IClass).ВычислениеВектора(dv) + Смещение;
    }
    /// <summary>
    ///
    /// </summary>
    public class Class: cs2305141215.Class, IClass
    {
        static public string INFO = "INFO";
    }
}
