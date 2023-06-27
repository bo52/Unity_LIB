//empty
//empty
//stFoldout_gui
using System.Collections.Generic;
using UnityEditor;
namespace LIB.st2305161246
{
    /// <summary>
    /// stFoldout_gui
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// Foldout
        /// </summary>
        /// <param name="выполнить"></param>
        /// <param name="Заголовок"></param>
        /// <param name="but"></param>
        /// <returns></returns>
        static public bool fun230516124600(System.Action выполнить, string Заголовок, ref bool but)
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
        /// <summary>
        /// Foldout
        /// </summary>
        /// <param name="выполнить"></param>
        /// <param name="Name"></param>
        /// <param name="showPosition"></param>
        static public void fun230516124601(System.Action[] выполнить, string[] Name, ref bool[] showPosition)
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
        ///exit
    }
}
