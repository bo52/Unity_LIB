using gui2023;
using UnityEngine;
/// <summary>
/// �������� ����������� "����������"
/// </summary>
public interface IBlock8_vs_modif_xy:IBlock8_vs
{
    static byte Z_current = 0;
    public void �������(uint id) => this.�������.Remove(id);
    public void ����������(bool �����������)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        for (var y = MAX - 1; y >= 0; y--)
            for (var x = 0; x < MAX; x++)
            {
                var ���������� = new Vector3(x, y, Z_current);
                var �� = �����������������(����������);
                if (�����������) �������(��); 
                else ����������������(��, ����������);
            }
    }
    public bool �������������������()
    {
        GUILayout.BeginHorizontal();
        var b = stBtn.btn("���������", () => ����������(false)) || stBtn.btn("�������", () => ����������(true));
        GUILayout.EndHorizontal();
        return b;
    }
}
