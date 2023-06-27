using UnityEngine;
namespace gui2023
{
static public class stBtn
{
    #region button
    static public bool test
    {
        get
        {
            return (GUILayout.Button("ТЕСТ"));
        }
    }
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
    static public bool кнопка(bool b, string name = "test")
    {
        return b ? кнопка(name) : true;
    }
    static public bool кнопка(string name = "button", ushort width = 100)
    {
        return (GUILayout.Button(name, new GUILayoutOption[] { GUILayout.Width(width) }));
    }
    static public bool кнопка(ref bool B, string name = "button")
    {
        bool b = (GUILayout.Button(name));
        if (b)
            B = !B;
        return b;
    }
    #endregion
}
}