using go2023;
using gui2023;
using UnityEngine;

public interface IBlock8_vs_border : IBlock8_vs
{
    static private string name = "border";
    static private bool border = true;
    static private float MAX => LIB.cs2305181649.IClass.MAX;
    static public Vector3[] ���������������������������������� => LIB.st2305151543.Class.field230515154300_���������������������������������;
    static private spBuild.Cube256.Int EDIT => spBuild.Block.mbBlock_edit.���;
    static private GameObject GO => EDIT.GO;
    public void ����������()
    {
        stBool.����������(ref border,(bool b)=> ����������������(GO),"border", 10);
    }
    static public bool ����������(Vector3 v) => v.x < 0 || v.y < 0 || v.z < 0;
    static public bool �������������������(Vector3 v) => ����������(v) || v.x > MAX - 1 || v.y > MAX - 1 || v.z > MAX - 1;
    public byte ��������������������(Vector3 v, System.Func<Vector3, bool> ����������)
    {
        float code = 0;
        for (var i = 0; i < ����������������������������������.Length; i++)
        {
            var next = v + ����������������������������������[i];
            code += ����������(next) ? 0 : (�����������������(next) ? Mathf.Pow(2, i) : 0);
        }
        return (byte)code;
    }
    public bool ���������(Vector3 v) => v.x == MAX - 1 || v.y == MAX - 1 || v.z == MAX - 1;
    public void ����������������(GameObject go)
    {
        LIB.st2305221205.Class.fun230522120500/*��������*/(go,name);
        if (!border) return;
        ���������������������();
        �����������������������������();
        ���������������(go);
    }
    public void ���������������������()
    {
        if (this.�������.Count < 1) return;
        for (var x = -1; x < MAX; x++)
            for (var y = -1; y < MAX; y++)
                for (var z = -1; z < MAX; z++)
                {
                    if (x < 0 || y < 0 || z < 0)
                    {
                        var ���������� = new Vector3(x, y, z);
                        byte �������� = ��������������������(����������, ����������);
                        EDIT.���������(����������, ��������);
                    }
                }
    }
    public void �����������������������������()
    {
        if (this.�������.Count > 0) return;
        for (var x = -1; x <MAX; x++)
            for (var y = -1; y < MAX; y++)
                for (var z = -1; z < MAX; z++)
                {
                    var ���������� = new Vector3(x, y, z);
                    if (x < 0 || y < 0 || z < 0 || ���������(����������))
                    {
                        byte �������� = ��������������������(����������, �������������������);
                        EDIT.���������(����������, ��������);
                    }
                }
    }
    public void ���������������(GameObject go)
    {
        var children = new GameObject();
        children.name = name;
        children.transform.SetParent(go.transform);
        children.transform.localPosition = Vector3.zero;
        EDIT.������(children,"");
    }
}
