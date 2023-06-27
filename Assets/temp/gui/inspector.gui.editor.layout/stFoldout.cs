using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace gui2023
{
    public class stFoldout : MonoBehaviour
    {
        static public bool Foldout(System.Action выполнить, string Заголовок, ref bool but)
        {
            var b = EditorGUILayout.Foldout(but, Заголовок) != but;
            if (b)
            {
                but = !but;
            }


            if (but)
                if (Selection.activeTransform)
                    выполнить();
            if (!Selection.activeTransform)
                but = false;
            return b;
        }
        static public void Foldout(System.Action[] выполнить, string[] Name, ref bool[] showPosition)
        {
            List<string> f = new List<string>();
            for (byte i = 0; i < showPosition.Length; i++)
            {
                showPosition[i] = EditorGUILayout.Foldout(showPosition[i], Name[i]);
                if (showPosition[i])
                    if (Selection.activeTransform)
                        выполнить[i]();
                if (!Selection.activeTransform)
                    showPosition[i] = false;
            }
        }
    }
}
