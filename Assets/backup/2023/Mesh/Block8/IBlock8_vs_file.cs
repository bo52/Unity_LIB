using cube2023;
using gui2023;
using mesh2023;
using UnityEditor;
using UnityEngine;
using utility2023;

public interface IBlock8_vs_file : IBlock8_vs
{
    static public GameObject GO => spBuild.Block.mbBlock_edit.���.GO;
    public void ���������������(int i)
    {
        //������������������������();
        //������������(�����������());
    }
    public void �����������������������(ref byte ���������, System.Action fun_load)
    {

        var b = ���������;
        ������������[b].������();
    }
    public void ������()
    {
        GUILayout.BeginHorizontal();
        stBtn.btn("�������������", () => ���������());
        stBtn.btn("�������������", () => �������������());
        GUILayout.EndHorizontal();
    }
    static private string ����(int i) => "block" + i;
    #region load
    public void ���������()
    {
        ����������������();
    }
    public void ���������()
    {
        ���������();
        var file = "Block" + �����������.ToString();
        var m = ��������������.���������(file, GO);
        //(this as IBlock8_vs_border).����������������(GO);
    }
    private void �����������������(string str)
    {
        var id = System.Convert.ToUInt32(str);
        var vertec=new Block8_v(this, id);
    }
    public void ����������������()
    {
        �������.Clear();
        LIB.st2305221142.Class.fun230522114203/*����������������*/(����(�����������), �����������������);
    }
    public void ����������������(Mesh m)
    {
        if (m == null) return;
        �������.Clear();
        for (var i = 0; i < m.vertices.Length; i++)
        {
            var ���������� = new Vector3(m.uv2[i].x, m.uv2[i].y, m.uv3[i].x);
            var �� = �����������������(����������);
            var code = (byte)m.uv3[i].y;
            if (code.��������������������������()) this.����������������(��, ����������);
        }
    }
    #endregion
    #region save
    public void �������������������() => ������������(GO.GetComponent<MeshFilter>().sharedMesh);
    public void ������������(Mesh m)
    {
        if (m == null) return;
        var f=LIB.st2305181538.Class.fun230518153801_�����������������������(����(�����������));
        AssetDatabase.CreateAsset(m, f);
    }
    private string ����������������������(uint id, Block8_v vertec) => id.ToString();
    public void ���������()=> LIB.st2305221142.Class.fun230522114202/*����������������*/(����(�����������), �������, ����������������������);
    public void �������������()
    {
        �������������������();
        ���������();
    }
    #endregion
}
