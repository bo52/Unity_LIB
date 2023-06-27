using gui2023;
using scr2023;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utility2022;

public interface IRegion10_vs_file: IRegion10_build
{
    public void ������()
    {
        GUILayout.BeginHorizontal();
        stLabel.lab("������:");
        stBtn.btn("���������", () => ������������������());
        stBtn.btn("���������", () => ���������������());
        GUILayout.EndHorizontal();
    }
    #region save
    public void �����������������(uint id)
    {
        spBlock.edit.stCustom.��������� = 255;
        ������������.Add(id, spBlock.edit.stCustom.���������);
        ���������������();
    }
    private MonoBehaviour MO => this as MonoBehaviour;
    private string ���� => "region" + stVector_min_max.stGET_ID(MO.transform.position);
    private string ����������������������(uint id, byte ������������) => id.ToString() + "|" + ������������;
    public void ���������������()
    {
        IBlock_edit.��������������������();
        stSerillization_StreamWriter.���������(����, ������������, ����������������������);
    }
    #endregion
    #region load
    public void �����������������(string str)
    {
        var arr=str.Split('|');
        var id = System.Convert.ToUInt16(arr[0]);
        ������������.Add(id, System.Convert.ToByte(arr[1]));
    }
    public void ������������������()
    {
        ������������.Clear();
        IBlock_edit.��������������������();
        stSerillization_StreamWriter.���������(����, �����������������);
        �������();
    }
    #endregion
}
