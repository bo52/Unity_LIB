using gui2023;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class stRegion_curr
{
    #region �������
    static public Transform Region_tr => spBuild.Block.mbBlock_edit.MO.gameObject.transform.parent;
    static public GameObject Region_go => Region_tr.gameObject;
    static public IRegion10 Region => Region_go.GetComponent<IRegion10>();
    static public Vector3 ��������� => (spBuild.Block.mbBlock_edit.MO.GetComponent<mbPosition_step>()).����������;
    static public uint ������������ => IRegion10_bs.���������������(���������);
    static public void ��������������������() => Region.�����������������(������������);
    static public bool ������� => Region.��������������(������������);
    #endregion
    #region custom
    public static void ���_���������������������(ref byte ���������)
    {
        Region.������();
        //if (�������)
            //IBlock_edit.Block_edit.�������������(ref ���������, Region.������������������);
        //else
            //stBtn.btn("������������", ��������������������);
    }
    #endregion
}
