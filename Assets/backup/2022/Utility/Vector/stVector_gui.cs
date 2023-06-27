using UnityEditor;
using UnityEngine;
namespace utility2022
{
    /// <summary>
    /// ���������� �������� ��� ���������� � �����
    /// </summary>
    static public class stVector_gui
    {
        static public bool ������(this ref Vector2 v, string name = "v")
        {
            Vector2 new_v = EditorGUILayout.Vector2Field(name, v);
            if (new_v != v)
            {
                v = new_v;
                return true;
            }
            return false;
        }
        static public bool ������(this ref Vector3 v, string name = "v")
        {
            Vector3 new_v = EditorGUILayout.Vector3Field(name, v);
            if (new_v != v)
            {
                v = new_v;
                return true;
            }
            return false;
        }
    }
}