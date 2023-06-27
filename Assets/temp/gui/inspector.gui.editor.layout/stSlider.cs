using UnityEditor;
using UnityEngine;

namespace gui2023
{
    static class stSlider_lab
    {
        static public bool ползунок(ref int i, string name = "default", int min = 1, int max = 5)
        {
            GUILayout.BeginHorizontal();
            stLabel.lab(name);
            var b = i.ползунок(min, max);
            GUILayout.EndHorizontal();
            return b;
        }
        static public bool ползунок_вектор(this ref Vector3 i, ref bool B, string name = "default", int min = 1, int max = 5)
        {
            var b = false;
            var v = i;
            stFoldout.Foldout(() =>
            {
                var x = (int)v.x;
                var y = (int)v.y;
                var z = (int)v.z;
                GUILayout.BeginVertical();
                stLabel.lab(name);
                var X = ползунок(ref x, "x", min, max);
                var Y = ползунок(ref y, "y", min, max);
                var Z = ползунок(ref z, "z", min, max);
                GUILayout.EndVertical();
                if (X || Y || Z)
                {
                    v = new Vector3(x, y, z);
                    b = true;
                    return;
                }
                b = false;
            }, "Векторы", ref B);
            if (b) i = v;
            return b;
        }
    }
    /// <summary>
    /// ползунки в инспекторе
    /// </summary>
    static class stSlider
    {
        static public bool ползунок(this ref float lv, sbyte start = 0, byte n = byte.MaxValue)
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
        static public float ползунок(this float lv)
        {
            var i = (int)(lv * 255.0f);
            var new_lv = EditorGUILayout.IntSlider(i, 1, byte.MaxValue);
            if (new_lv != lv)
            {
                return new_lv / 255.0f;
            }
            return new_lv;
        }
        static public bool ползунок_байты(this ref byte b, byte start = 0, byte n = byte.MaxValue, System.Action act = null)
        {
            byte new_lv = (byte)(EditorGUILayout.IntSlider(b, start, n));
            if (new_lv != b)
            {
                b = new_lv;
                act?.Invoke();
                return true;
            }
            return false;
        }
        static public bool ползунок_байты(this byte lv, byte start = 0, byte n = byte.MaxValue, System.Action<byte> act = null)
        {
            byte new_val = (byte)(EditorGUILayout.IntSlider(lv, start, n));
            if (new_val != lv)
            {
                act?.Invoke(new_val);
                return true;
            }
            return false;
        }
        static public bool ползунок_байты(this ref int i, System.Action act = null)
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
        static public bool ползунок(this ref sbyte b, int min = 1, int max = 5)
        {
            sbyte new_lv = (sbyte)(EditorGUILayout.IntSlider(b, min, max));
            if (new_lv != b)
            {
                b = new_lv;
                return true;
            }
            return false;
        }
        static public bool ползунок(this ref int i, int min = 1, int max = 5)
        {
            int new_lv = EditorGUILayout.IntSlider(i, min, max);
            if (new_lv != i)
            {
                i = new_lv;
                return true;
            }
            return false;
        }
        static public bool ползунок(this ref Vector3 v)
        {
            var x = v.x;
            var y = v.y;
            var z = v.z;

            var bx = ползунок(ref x);
            var by = ползунок(ref y);
            var bz = ползунок(ref z);
            if (bx || by || bz)
            {
                v = new Vector3(x, y, z);
                return true;
            }
            return false;
        }
        static public bool ползунок(this ref byte b, int min = 1, int max = 5)
        {
            byte new_lv = (byte)(EditorGUILayout.IntSlider(b, min, max));
            if (new_lv != b)
            {
                b = new_lv;
                return true;
            }
            return false;
        }
    }
}
