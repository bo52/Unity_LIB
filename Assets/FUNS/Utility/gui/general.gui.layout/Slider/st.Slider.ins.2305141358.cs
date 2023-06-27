//empty
//empty
//GUI.layout.slider
using UnityEditor;
using UnityEngine;
namespace LIB.st2305141358
{
    /// <summary>
    /// stGUI.layout.slider.cs2305141358
    /// ползунки в инспекторе
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="start"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static public bool fun230514135800(this ref float lv, sbyte start = 0, byte n = byte.MaxValue)
        {
            var i = (int)(lv * 255.0f);
            var new_lv = EditorGUILayout.IntSlider(i, start, 128 + n);
            if (new_lv != i)
            {
                lv = new_lv / 255.0f;
                return true;
            }
            return false;
        }
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        static public float fun230514135801(this float lv)
        {
            var i = (int)(lv * 255.0f);
            var new_lv = EditorGUILayout.IntSlider(i, 1, byte.MaxValue);
            if (new_lv != lv)
            {
                return new_lv / 255.0f;
            }
            return new_lv;
        }
        /// <summary>
        /// ПолзунокБайты
        /// </summary>
        /// <param name="b"></param>
        /// <param name="start"></param>
        /// <param name="n"></param>
        /// <param name="act"></param>
        /// <returns></returns>
        static public bool fun230514135802(this ref byte b, byte start = 0, byte n = byte.MaxValue, System.Action<byte> act = null)
        {
            byte new_lv = (byte)(EditorGUILayout.IntSlider(b, start, n));
            if (new_lv != b)
            {
                b = new_lv;
                act?.Invoke(b);
                return true;
            }
            return false;
        }
        /// <summary>
        /// ПолзунокБайты
        /// </summary>
        /// <param name="i"></param>
        /// <param name="act"></param>
        /// <returns></returns>
        static public bool fun230514135803(this ref int i, System.Action act = null)
        {
            byte new_lv = (byte)(EditorGUILayout.IntSlider(i, 1, 32));
            if (new_lv != i)
            {
                i = new_lv;
                act?.Invoke();
                return true;
            }
            return false;
        }
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="b"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public bool fun230514135804(this ref sbyte b, int min = 1, int max = 5)
        {
            sbyte new_lv = (sbyte)(EditorGUILayout.IntSlider(b, min, max));
            if (new_lv != b)
            {
                b = new_lv;
                return true;
            }
            return false;
        }
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="i"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public bool fun230514135805(this ref int i, int min = 1, int max = 5)
        {
            int new_lv = EditorGUILayout.IntSlider(i, min, max);
            if (new_lv != i)
            {
                i = new_lv;
                return true;
            }
            return false;
        }
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static public bool fun230514135806(this ref Vector3 v)
        {
            var x = v.x;
            var y = v.y;
            var z = v.z;

            var bx = fun230514135800(ref x);
            var by = fun230514135800(ref y);
            var bz = fun230514135800(ref z);
            if (bx || by || bz)
            {
                v = new Vector3(x, y, z);
                return true;
            }
            return false;
        }
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="b"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public bool fun230514135807(this ref byte b, int min = 1, int max = 5)
        {
            byte new_lv = (byte)(EditorGUILayout.IntSlider(b, min, max));
            if (new_lv != b)
            {
                b = new_lv;
                return true;
            }
            return false;
        }
        ///exit
    }
}
