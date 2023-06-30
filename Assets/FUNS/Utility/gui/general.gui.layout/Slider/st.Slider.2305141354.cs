//empty
//empty
//stGUI.layout.slider
using UnityEngine;
namespace LIB.st2305141354
{
    /// <summary>
    /// stGUI.layout.slider.cs2305141354
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ползунок
        /// </summary>
        /// <param name="i"></param>
        /// <param name="name"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public bool fun230514135400_slider_int(ref int i, string name = "default", int min = 1, int max = 5)
        {
            GUILayout.BeginHorizontal();
            st2305081544.Class.fun230508154400_lab(name);
            var b = st2305141358.Class.fun230514135805(ref i, min, max);
            GUILayout.EndHorizontal();
            return b;
        }
        /// <summary>
        /// ПолзунокВектор
        /// </summary>
        /// <param name="i"></param>
        /// <param name="B"></param>
        /// <param name="name"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="fun"></param>
        /// <returns></returns>
        static public bool fun230514135401_Вектор(this ref Vector3 i, ref bool B, string header = "Вектор", int min = 1, int max = 5, System.Action<Vector3> fun = null, string name = "default")
        {
            var b = false;
            var v = i;
            st2305161246.Class.fun230516124600(() =>
            {
                var x = (int)v.x;
                var y = (int)v.y;
                var z = (int)v.z;
                GUILayout.BeginVertical();
                st2305081544.Class.fun230508154400_lab(name);
                var X = fun230514135400_slider_int(ref x, "x", min, max);
                var Y = fun230514135400_slider_int(ref y, "y", min, max);
                var Z = fun230514135400_slider_int(ref z, "z", min, max);
                GUILayout.EndVertical();
                if (X || Y || Z)
                {
                    v = new Vector3(x, y, z);
                    b = true;
                    return;
                }
                b = false;
            }, header, ref B);
            if (b)
            {
                i = v;
                fun?.Invoke(v);
            }
            return b;
        }
        ///exit
    }
}
