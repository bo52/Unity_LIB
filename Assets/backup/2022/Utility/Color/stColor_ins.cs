using UnityEditor;
using UnityEngine;
namespace utility2022
{
    /// <summary>
    /// GUI ���������� ������
    /// </summary>
    static public class stColor_ins
    {
        static public string INFO = "����������";
        static public sbyte ������ = 1;
        static public Color matColor = stColor.����������;
        static public bool drawing;
        static public bool ����(this ref Color �)
        {
            Color new_color = EditorGUILayout.ColorField(�);
            if (new_color != �)
            {
                � = new_color;
                return true;
            }
            return false;
        }
        static public void �����_����������������������(ref Color c)
        {
            if (!drawing)
                return;
            if (Event.current.keyCode == KeyCode.F1)
                stColor.�������(ref c, -1);
            if (Event.current.keyCode == KeyCode.F2)
                stColor.�������(ref c, 1);

            if (Event.current.keyCode == KeyCode.F3)
                ������++;
            if (Event.current.keyCode == KeyCode.G)
            {
                c = Color.green;
                stColor.�������(ref c, 0);
            }

            if (Event.current.keyCode == KeyCode.Keypad1)
            {
                c = Color.red;
                stColor.�������(ref c, 0);
            }

            if (Event.current.keyCode == KeyCode.F4)
                ������--;

            if (Event.current.keyCode == KeyCode.B)
            {
                c = Color.blue;
                stColor.�������(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.Y)
            {
                c = Color.yellow;
                stColor.�������(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.K)
            {
                c = stColor.����������;
                stColor.�������(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.C)
            {
                c = Color.cyan;
                stColor.�������(ref c, 0);
            }
            if (Event.current.keyCode == KeyCode.Keypad0)
            {
                c = Color.gray;
                stColor.�������(ref c, 0);
            }
        }

        static public bool ���������_�����() => �����(ref matColor, ref drawing);
        static public bool �����(ref Color c, ref bool drawing)
        {
            if (!drawing)
            {
                return false;
                //Bo52_30122020123429952.REGION.����������������();
            }

            c = EditorGUILayout.ColorField("New Color", c);
            var old_c = c;
            //�������
            var new_v = stColor.���������������;
            if (new_v != stColor.���������������)
            {
                stColor.�������(ref c, 0);
                stColor.��������������� = new_v;
            }

            stSlider_gui.��������(ref ������, 0, 100);
            GUILayout.BeginHorizontal();
            GUI.color = Color.black;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.gray;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.green;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.blue;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.cyan;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.yellow;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.magenta;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = Color.red;
            if (stButton_gui.������("", 50))
                c = GUI.color;
            GUI.color = new Color(0.85f, 0.7f, 0.4f);
            if (stButton_gui.������("", 50))
                c = GUI.color;
            if (old_c != c)
                stColor.�������(ref c, 0);

            GUI.color = Color.white;
            GUILayout.EndHorizontal();
            return true;
        }
    }
}
