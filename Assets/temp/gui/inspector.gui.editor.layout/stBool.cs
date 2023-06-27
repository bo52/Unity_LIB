using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace gui2023
{
    static public class stBool
    {
        #region bool
        static public bool ЛОГИЧЕСКИЙ(this ref bool b, string text = "bool", byte width = 80)
        {
            bool new_b = EditorGUILayout.Toggle(text, b, new GUILayoutOption[] { GUILayout.Width(width) });
            if (new_b != b)
            {
                b = new_b;
                return true;
            }
            return false;
        }
        static public bool логический(this bool b, string text = "bool", byte width = 80)
        {
            bool new_b = EditorGUILayout.Toggle(text, b, new GUILayoutOption[] { GUILayout.Width(width) });
            if (new_b != b)
                return true;
            return false;
        }
        static public bool логический(this bool b, System.Action<bool> act, string text = "bool", byte width = 80, System.Func<GUIStyle> style = null)
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
        static public bool логический(ref List<bool> bs, byte cnt)
        {
            EditorGUILayout.BeginVertical();
            bool B = false;

            for (byte i = 0; i < cnt; i++)
            {
                if (bs.Count != cnt) bs.Add(false);
                if (!B)
                {
                    var b = bs[i];
                    if (b.логический(i.ToString()))
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
        #endregion
    }
}
