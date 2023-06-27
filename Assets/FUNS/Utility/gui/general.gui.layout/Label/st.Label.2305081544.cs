//empty
//empty
//stGUI.Layout.Label надпись
using UnityEngine;
namespace LIB.st2305081544
{
    /// <summary>
    /// gui2023.cs2305081544
    /// stLabel
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// lab
        /// </summary>
        /// <param name="text"></param>
        static public void fun230508154400_lab(string text = "lab") => GUILayout.Label(text);
        /// <summary>
        /// lab + width
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        static public void fun230508154401_lab_w(string text = "lab", ushort width = 100)
        {
            GUILayout.Label(text, new GUILayoutOption[] { GUILayout.Width(width) });
        }
        ///exit
    }
}