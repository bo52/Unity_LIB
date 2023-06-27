using gui2023;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class stRegion_curr
{
    #region Текущий
    static public Transform Region_tr => spBuild.Block.mbBlock_edit.MO.gameObject.transform.parent;
    static public GameObject Region_go => Region_tr.gameObject;
    static public IRegion10 Region => Region_go.GetComponent<IRegion10>();
    static public Vector3 ТекВектор => (spBuild.Block.mbBlock_edit.MO.GetComponent<mbPosition_step>()).Координата;
    static public uint ТекВекторКод => IRegion10_bs.КоординатаБлока(ТекВектор);
    static public void ДобавитьТекНеСущБлок() => Region.ДобавитьНеСущБлок(ТекВекторКод);
    static public bool СущБлок => Region.СуществуетБлок(ТекВекторКод);
    #endregion
    #region custom
    public static void инс_РаботаСБлокомВРегионе(ref byte РазнБлока)
    {
        Region.Кнопки();
        //if (СущБлок)
            //IBlock_edit.Block_edit.ПройтиПоКарте(ref РазнБлока, Region.ВосстановитьРегион);
        //else
            //stBtn.btn("ДобавитьБлок", ДобавитьТекНеСущБлок);
    }
    #endregion
}
