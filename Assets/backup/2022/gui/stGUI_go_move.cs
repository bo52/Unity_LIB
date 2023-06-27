//empty
//empty
//pov stGUI_go_move Bo52_08022021130000157.GUI.
using UnityEngine;
namespace LIB.st2305211432
{
    /// <summary>
    /// MOVE.Z
    /// движение назад и вперед объекта
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// POV
        /// </summary>
        static sbyte prop230521143200 => IRotation_param.pov;
        /// <summary>
        /// arr_forward
        /// </summary>
        static readonly Vector3[] field230521143201 = new Vector3[]
        {
            Vector3.forward,
            Vector3.left,
            Vector3.back,
            Vector3.right,
        };
        /// <summary>
        /// arr_back
        /// </summary>
        static readonly Vector3[] field230521143202 = new Vector3[]
        {
            Vector3.back,
            Vector3.right,
            Vector3.forward,
            Vector3.left,
        };
        /// <summary>
        /// ДвижениеНазад_Следующий
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool fun230521143203(ref Vector3 v)
        {
            var b = stButton_gui.кнопка("Z--", 35);
            if (!b)
                return b;
            v = field230521143202[prop230521143200];
            return b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool ДвижениеНазад(ref Vector3 v)
        {
            var b = stButton_gui.кнопка("z-", 25);
            if (!b)
                return b;
            v = field230521143202[prop230521143200];
            return b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool ДвижениеВперед(ref Vector3 v)
        {
            var b = stButton_gui.кнопка("z+", 25);
            if (!b)
                return false;
            v = field230521143201[prop230521143200];
            return b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool ДвижениеВперед_Следующий(ref Vector3 v)
        {
            var b = stButton_gui.кнопка("Z++", 35);
            if (!b)
                return false;
            v = field230521143201[prop230521143200];
            return b;
        }
    }
}