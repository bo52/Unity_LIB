using UnityEngine;
namespace gui2023
{
static public class stLabel
{
    static public void lab(string text = "lab", ushort width = 100)
    {
        GUILayout.Label(text, new GUILayoutOption[] { GUILayout.Width(width) });
    }
}
}