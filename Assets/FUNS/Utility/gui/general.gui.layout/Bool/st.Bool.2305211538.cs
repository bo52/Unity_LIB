//empty
//empty
//stBool.gui
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.st2305211538
{
    /// <summary>
    ///stBool_gui
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// ЛОГИЧЕСКИЙ
        /// </summary>
        /// <param name="b"></param>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static public bool fun230521153800(this ref bool b, string text = "bool", byte width = 80)
        {
            bool new_b = EditorGUILayout.Toggle(text, b, new GUILayoutOption[] { GUILayout.Width(width) });
            if (new_b != b)
            {
                b = new_b;
                return true;
            }
            return false;
        }
        /// <summary>
        /// логический
        /// </summary>
        /// <param name="b"></param>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static public bool fun230521153801(this bool b, string text = "bool", byte width = 80)
        {
            bool new_b = EditorGUILayout.Toggle(text, b, new GUILayoutOption[] { GUILayout.Width(width) });
            if (new_b != b)
                return true;
            return false;
        }
        /// <summary>
        /// логический
        /// </summary>
        /// <param name="b"></param>
        /// <param name="act"></param>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <param name="style"></param>
        /// <returns></returns>
        static public bool fun230521153802(this bool b, System.Action<bool> act, string text = "bool", byte width = 80, System.Func<GUIStyle> style = null)
        {
            var s = style == null ? null : style();
            bool new_b = s == null ?
                EditorGUILayout.Toggle(text, b, new GUILayoutOption[] { GUILayout.Width(width) }) : EditorGUILayout.Toggle(text, b, s, new GUILayoutOption[] { GUILayout.Width(width) });
            if (new_b != b)
            {
                act(new_b);
                return true;
            }
            return false;
        }
        /// <summary>
        /// логический
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="cnt"></param>
        /// <returns></returns>
        static public bool fun230521153803(ref List<bool> bs, byte cnt)
        {
            EditorGUILayout.BeginVertical();
            bool B = false;
            bool b;

            for (byte i = 0; i < cnt; i++)
            {
                if (bs.Count != cnt) bs.Add(false);
                if (!B)
                {
                    b = bs[i];
                    if (fun230521153801(b,i.ToString()))
                    {

                        bs[i] = b;
                        B = true;
                        break;
                    }
                }
            }
            EditorGUILayout.EndVertical();
            return B;
        }
        ///exit
    }
}
