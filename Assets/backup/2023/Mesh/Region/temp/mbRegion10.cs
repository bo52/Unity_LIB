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
    public Dictionary<uint, byte> ������������ => bs;
    #endregion

    public void ���������()
    {
        IRegion_edit.���(gameObject);
        stBtn.btn("��������� �����", (this as IRegion10_build).��������������);
    }
    #region edit
    [CustomEditor(typeof(mbRegion10))]
    public class gui : Editor
    {
        public override void OnInspectorGUI() => (target as mbRegion10).���������();
    }
    #endregion
}
