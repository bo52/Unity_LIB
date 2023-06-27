using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using mb2022;

#region Label
static public class stLab_gui
{
    static public void lab(string text = "lab", ushort width = 100)=>GUILayout.Label(text, new GUILayoutOption[] { GUILayout.Width(width) });
}
#endregion
#region button
static public class stButton_gui
{
    static public bool test => (GUILayout.Button("ТЕСТ"));
    static public bool btnTEST(System.Action proc)
    {
        var b = GUILayout.Button("ТЕСТ");
        if (b)
            proc();
        return b;
    }
    static public bool btn(string name = "test", System.Action proc = null)
    {
        var b = GUILayout.Button(name);
        if (b)
            proc?.Invoke();
        return b;
    }
    static public bool кнопка(bool b, string name = "test") => b ? кнопка(name) : true;
    static public bool кнопка(string name = "button", ushort width = 100) => (GUILayout.Button(name, new GUILayoutOption[] { GUILayout.Width(width) }));
    static public bool кнопка(ref bool B, string name = "button")
    {
        bool b = (GUILayout.Button(name));
        if (b)
            B = !B;
        return b;
    }
}
static public class stButton_act
{
    static public string INFO = "GameObject";
    static public string PRODUCT = "Работа Объекта";

    static public bool РаботаОбъекта(string s, bool кнопка = false, System.Action a = null)
    {
        if (!stButton_gui.кнопка(кнопка, s))
            return false;
        if (a == null)
            return false;
        a();
        return true;
    }
    static public bool РаботаОбъекта(string s, bool кнопка = false, System.Action<object> a = null, object atr = null)
    {
        if (!stButton_gui.кнопка(кнопка, s))
            return false;
        a?.Invoke(atr);
        return true;
    }
    static public bool РаботаОбъекта(string s, bool кнопка = false, System.Action<bool> a = null, bool atr = false)
    {
        if (!stButton_gui.кнопка(кнопка, s))
            return false;
        a?.Invoke(atr);
        return true;
    }
    static public T РаботаОбъекта<T>(string s, bool кнопка = false, System.Func<object[], T> a = null, object[] arg = null)
    {
        if (!stButton_gui.кнопка(кнопка, s))
            return default;
        if (a == null)
            return default;

        return a.Invoke(arg);
    }
}

static public class stButton_fun_new
{
    static public GameObject Новый(bool кнопка = false, object[] arg = null) => stButton_act.РаботаОбъекта("Новый", кнопка, stMono_go_new.method_new, arg);
}
#endregion
#region ползунок
static public class stSlider_gui
{
    static public bool ползунок(this ref float lv, sbyte n0 = 0, byte n = byte.MaxValue)
    {
        var i = (int)(lv * 255.0f);
        var new_lv = EditorGUILayout.IntSlider(i, n0, 128 + n);
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
    static public bool ползунок(this ref byte lv)
    {
        byte new_lv = (byte)(EditorGUILayout.IntSlider(lv, 0, byte.MaxValue));
        if (new_lv != lv)
        {
            lv = new_lv;
            return true;
        }
        return false;
    }
    static public bool ползунок(this ref sbyte lv, int min = 1, int max = 5)
    {
        sbyte new_lv = (sbyte)(EditorGUILayout.IntSlider(lv, min, max));
        if (new_lv != lv)
        {
            lv = new_lv;
            return true;
        }
        return false;
    }
    static public bool ползунок(this ref int lv, int min = 1, int max = 5)
    {
        int new_lv = EditorGUILayout.IntSlider(lv, min, max);
        if (new_lv != lv)
        {
            lv = new_lv;
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
    static public bool ползунок(this ref byte lv, int min = 1, int max = 5)
    {
        byte new_lv = (byte)(EditorGUILayout.IntSlider(lv, min, max));
        if (new_lv != lv)
        {
            lv = new_lv;
            return true;
        }
        return false;
    }
}
#endregion
#region text
static public class stText_gui
{
    static public bool Текстовый(ref string tex)
    {
        var out_tex = GUILayout.TextField(tex);
        var b = (out_tex == tex);
        if (b == false)
            tex = out_tex;
        return b;
    }
}
#endregion
#region Grid
static public class stGrid_gui
{
    static public bool SelectionGrid(this ref byte val_byte, string[] ops)
    {
        byte new_byte = (byte)(GUILayout.SelectionGrid(val_byte, ops, 6, "toggle"));
        if (new_byte != val_byte)
        {
            val_byte = new_byte;
            return true;
        }
        return false;
    }
    static public bool SelectionGrid(this ref byte val_byte)
    {
        byte new_byte = (byte)(GUILayout.SelectionGrid(val_byte, new string[] { }, 6, "toggle"));
        if (new_byte != val_byte)
        {
            val_byte = new_byte;
            return true;
        }
        return false;
    }
}
#endregion