using gui2023;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public interface IRegion10 : IRegion10_vs_file
{


}

public class mbRegion10 : MonoBehaviour,IRegion10,IRegion_edit
{
    #region interface
    private Dictionary<uint, byte> bs = new Dictionary<uint, byte>();
    public Dictionary<uint, byte> Ѕлоки–егиона => bs;
    #endregion

    public void »нспектор()
    {
        IRegion_edit.»нс(gameObject);
        stBtn.btn("построить землю", (this as IRegion10_build).ѕостроить«емлю);
    }
    #region edit
    [CustomEditor(typeof(mbRegion10))]
    public class gui : Editor
    {
        public override void OnInspectorGUI() => (target as mbRegion10).»нспектор();
    }
    #endregion
}
