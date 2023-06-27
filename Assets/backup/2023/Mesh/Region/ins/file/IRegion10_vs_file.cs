using gui2023;
using scr2023;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utility2022;

public interface IRegion10_vs_file: IRegion10_build
{
    public void  нопки()
    {
        GUILayout.BeginHorizontal();
        stLabel.lab("–егион:");
        stBtn.btn("«агрузить", () => ¬осстановить–егион());
        stBtn.btn("—охранить", () => —охранить–егион());
        GUILayout.EndHorizontal();
    }
    #region save
    public void ƒобавитьЌе—ущЅлок(uint id)
    {
        spBlock.edit.stCustom.–азнЅлока = 255;
        Ѕлоки–егиона.Add(id, spBlock.edit.stCustom.–азнЅлока);
        —охранить–егион();
    }
    private MonoBehaviour MO => this as MonoBehaviour;
    private string ‘айл => "region" + stVector_min_max.stGET_ID(MO.transform.position);
    private string —охранить¬—троку—троки(uint id, byte Ќомер–егиона) => id.ToString() + "|" + Ќомер–егиона;
    public void —охранить–егион()
    {
        IBlock_edit.—охранить“екущийЅлок();
        stSerillization_StreamWriter.—ќ’–јЌ»“№(‘айл, Ѕлоки–егиона, —охранить¬—троку—троки);
    }
    #endregion
    #region load
    public void «агрузить»з—троки(string str)
    {
        var arr=str.Split('|');
        var id = System.Convert.ToUInt16(arr[0]);
        Ѕлоки–егиона.Add(id, System.Convert.ToByte(arr[1]));
    }
    public void ¬осстановить–егион()
    {
        Ѕлоки–егиона.Clear();
        IBlock_edit.«агрузить“екущийЅлок();
        stSerillization_StreamWriter.«ј√–”«»“№(‘айл, «агрузить»з—троки);
        —обрать();
    }
    #endregion
}
