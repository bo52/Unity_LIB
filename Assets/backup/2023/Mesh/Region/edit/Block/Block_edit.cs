using go2023;
using mb2023;
using UnityEditor;
using UnityEngine;
using Utility2022;

public class Block_edit : Block8
{
    public Block_edit(int i) :base(i){}
    //public void ���()=> spBlock.edit.stCustom.���();
    public void ��()=> spBlock.edit.stCustom.��();
    [CustomEditor(typeof(Block_edit))]
    public class gui : Editor
    {
        //public override void OnInspectorGUI() => (target as Block_edit).���();
        //public void OnSceneGUI() => (target as Block_edit).��();
    }
}

public interface IBlock_edit: spBlock.edit.stCustom, IBlock8_ins
{
    #region ���������
    #endregion
    static void ��������(Vector3 v)
    {
        spBuild.IVertices.������������������ = v;
    }
}
