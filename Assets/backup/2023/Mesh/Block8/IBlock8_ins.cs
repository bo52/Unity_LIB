using gui2023;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB
{
    public interface IBlock8_ins : IBlock8_vs_modif_xy, IBlock8_vs_file, IBlock8_vs_border
    {
        static GUILayoutOption[] width = new GUILayoutOption[] { GUILayout.Width(18) };
        static float MAX => LIB.cs2305181649.IClass.MAX;
        public void �������������(ref byte ���������, System.Action fun_load)
        {
            �����������������������(ref ���������, fun_load);
            ��������������();
        }
        public void ��������������()
        {
            GUILayout.BeginHorizontal();
            st2305081544.Class.fun230508154400_lab("������������������=" + �����������);
            //stBtn.btn("�������", () => ��������������());
            GUILayout.EndHorizontal();

            this.����������();
            var ����������� = (this as IBlock8_vs_modif_xy).�������������������();
            GUILayout.BeginVertical();
            st2305141358.Class.fun230514135802(ref Z_current, 0, (byte)(MAX - 1));
            for (var y = MAX - 1; y >= 0; y--)
            {
                GUILayout.BeginHorizontal(width);
                for (var x = 0; x < MAX; x++)
                {
                    EditorGUILayout.LabelField(x.ToString() + y.ToString(), width);

                    GUILayout.BeginVertical();
                    GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(10) });

                    var ���������� = new Vector3(x, y, Z_current);
                    var �� = �����������������(����������);
                    var ������� = �������������(��);
                    var ��� = ������� != null;
                    var new_x = EditorGUILayout.Toggle("", ���, width);

                    if (new_x != ���)
                    {
                        ����������� = true;
                        ���������������(��, ����������);
                    }
                    GUILayout.EndHorizontal();
                    GUILayout.EndVertical();
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndVertical();
            if (�����������)
            ��������������();
        }
    }
}
