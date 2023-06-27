using go2023;
using mb2023;
using UnityEditor;
using UnityEngine;
using Utility2022;

public class Block_edit : Block8
{
    public Block_edit(int i) :base(i){}
    //public void »нс()=> spBlock.edit.stCustom.»нс();
    public void —ц()=> spBlock.edit.stCustom.—ц();
    [CustomEditor(typeof(Block_edit))]
    public class gui : Editor
    {
        //public override void OnInspectorGUI() => (target as Block_edit).»нс();
        //public void OnSceneGUI() => (target as Block_edit).—ц();
    }
}

public interface IBlock_edit: spBlock.edit.stCustom, IBlock8_ins
{
    #region одиночный
    #endregion
    static void ќбновить(Vector3 v)
    {
        spBuild.IVertices.–ед оординатаЅлока = v;
    }
}
