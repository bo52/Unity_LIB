using cube2023;
using gui2023;
using mesh2023;
using UnityEditor;
using UnityEngine;
using utility2023;

public interface IBlock8_vs_file : IBlock8_vs
{
    static public GameObject GO => spBuild.Block.mbBlock_edit.Экз.GO;
    public void СформироватьМеш(int i)
    {
        //СформироватьВершиныКарты();
        //СохранитьМеш(ПолучитьМеш());
    }
    public void ИнспекторЗагрузитьКарту(ref byte РазнБлока, System.Action fun_load)
    {

        var b = РазнБлока;
        МоделиБлоков[b].Кнопки();
    }
    public void Кнопки()
    {
        GUILayout.BeginHorizontal();
        stBtn.btn("ЗагрузитьБлок", () => Загрузить());
        stBtn.btn("СохранитьБлок", () => СохранитьБлок());
        GUILayout.EndHorizontal();
    }
    static private string Файл(int i) => "block" + i;
    #region load
    public void загрузить()
    {
        ВосстановитьБлок();
    }
    public void Загрузить()
    {
        загрузить();
        var file = "Block" + НомерМодели.ToString();
        var m = КомпонентыМеша.Загрузить(file, GO);
        //(this as IBlock8_vs_border).ПостроитьГраницы(GO);
    }
    private void ЗагрузитьИзСтроки(string str)
    {
        var id = System.Convert.ToUInt32(str);
        var vertec=new Block8_v(this, id);
    }
    public void ВосстановитьБлок()
    {
        Вершины.Clear();
        LIB.st2305221142.Class.fun230522114203/*ЗагрузитьТекстом*/(Файл(НомерМодели), ЗагрузитьИзСтроки);
    }
    public void ВосстановитьБлок(Mesh m)
    {
        if (m == null) return;
        Вершины.Clear();
        for (var i = 0; i < m.vertices.Length; i++)
        {
            var Координата = new Vector3(m.uv2[i].x, m.uv2[i].y, m.uv3[i].x);
            var ид = КоординатаВершины(Координата);
            var code = (byte)m.uv3[i].y;
            if (code.ПервыйИндексКодаСуществует()) this.ПостроитьВершину(ид, Координата);
        }
    }
    #endregion
    #region save
    public void СохранитьМешОбъекта() => СохранитьМеш(GO.GetComponent<MeshFilter>().sharedMesh);
    public void СохранитьМеш(Mesh m)
    {
        if (m == null) return;
        var f=LIB.st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(Файл(НомерМодели));
        AssetDatabase.CreateAsset(m, f);
    }
    private string СохранитьВСтрокуСтроки(uint id, Block8_v vertec) => id.ToString();
    public void Сохранить()=> LIB.st2305221142.Class.fun230522114202/*СохранитьТекстом*/(Файл(НомерМодели), Вершины, СохранитьВСтрокуСтроки);
    public void СохранитьБлок()
    {
        СохранитьМешОбъекта();
        Сохранить();
    }
    #endregion
}
