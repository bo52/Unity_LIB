using spBuild;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utility2022;

public class Block8_v
{
    public IBlock8_vs BLOCK;
    public Block8_v(IBlock8_vs b, uint id)
    {
        BLOCK = b;
        BLOCK.�������.Add(id, this);
    }
}
/// <summary>
/// ���� ������� �� ������ cube256 �� ����� ��� (8^3)
/// ������ ��� ����������� �� ������������� � ��������� ��������� � ������ ����
/// </summary>
public class Block8: IBlock8_vs_file
{
    public Block8(int i) => this._index = (byte)i;
    private byte _index = 0; public byte ����������� => _index;
    private Dictionary<uint, Block8_v> _vertices = new Dictionary<uint, Block8_v>(); public Dictionary<uint, Block8_v> ������� => _vertices;
}
public interface IBlock8_vs
{
    public enum ���������
    {
        �������� = 255,
        ����������� = 51,
    }
    byte ����������� { get; }
    static IBlock8_vs_file[] ������������ = ��������������();
    static public IBlock8_vs_file[] ��������������()
    {
        //stRegion_curr.Region.������������������();
        var max = byte.MaxValue + 1;
        var arr = new IBlock8_vs_file[max];
        for (var i = 0; i < max; i++)
            arr[i] = new Block8(i);


        return arr;
    }
    Dictionary<uint, Block8_v> ������� { get; }
    #region ����������
    public Block8_v �������������(uint id) => �����������������(id) ? �������[id] : null;
    public bool �����������������(Vector3 v) => �����������������(�����������������(v));
    public bool �����������������(uint id) => �������.ContainsKey(id);
    public uint �����������������(Vector3 v) => stVector_number100.GET_ID(v);
    public Vector3 �����������������(uint id) => stVector_number100.GET_V(id);
    #endregion
    #region code
    public byte ��������������������_51_255(Vector3 v) => ����������� == 51 && v.y == LIB.cs2305181649.IClass.SIZE - 1 ? (byte)���������.����������� : (byte)���������.��������;
    #endregion
    #region ������ � ���������
    public Block8_v ���������������(uint id, Vector3 ����������)
    {
        var bol = �����������������(id);
        Block8_v vertec = null;
        if (bol) this.�������.Remove(id); else vertec = new Block8_v(this, id);
        return vertec;
    }
    /// <summary>
    /// �������� � ���������� ��� �������� ������������(���)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="����������"></param>
    /// <returns></returns>
    public Block8_v ����������������(uint id, Vector3 ����������) => �����������������(id) ? �������[id] : new Block8_v(this, id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="edit">spBuild.Cube256.Int</param>
    /// <param name="id"></param>
    /// <param name="����������"></param>
    /// <param name="��������"></param>
    /// <returns></returns>
    public Block8_v ����������������(LIB.cs2305141202.IClass edit, uint id, Vector3 ����������, byte ��������)
    {
        var ������� = ����������������(id, ����������);
        LIB.st2305202041.Class.fun230520204101_���������������������/*�������� cube256*/(edit, new LIB.cs2306262134.Class(����������,��������));
        return �������;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="edit">spBuild.Cube256.Int </param>
    /// <param name="��������"></param>
    /// <param name="�����������"></param>
    public void ��������������(LIB.cs2305141202.IClass edit, byte ��������, System.Func<Vector3, System.Func<Vector3, bool>,byte> �����������=null)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        if (����������� == null) �����������= LIB.st2306271209.Class.fun230627120900_��������������������;
        edit.��������();
        //����� �� �����
        for (var x = 0; x < MAX; x++)
            for (var y = 0; y < MAX; y++)
                for (var z = 0; z < MAX; z++)
                {
                    //���������� ������� �����
                    var ���������� = new Vector3(x, y, z);
                    var ��� = �����������(����������, �����������������);
                    LIB.st2305202041.Class.fun230520204101_���������������������/*�������� cube256*/(edit,new LIB.cs2306262134.Class(����������, ���));
                }
    }
    /// <summary>
    /// spBuild.Cube256.Int
    /// </summary>
    /// <param name="edit"></param>
    public void ����������������(LIB.cs2305141202.IClass edit)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        LIB.st2305231603.Class.fun230523160306(edit.GO);
        for (var x = 0; x < MAX; x++)
            for (var y = 0; y < MAX; y++)
                for (var z = 0; z < MAX; z++)
                {
                    var ���������� = new Vector3(x, y, z);
                    if (LIB.st2305231603.Class.fun230523160307(this,����������))
                    {
                        ���������������(�����������������(����������), ����������);
                        ��������������(edit, LIB.st2306271209.Class.fun230627120900_��������������������(����������, �����������������));
                        edit.�������();
                    }
                }
    }
    #endregion
}
