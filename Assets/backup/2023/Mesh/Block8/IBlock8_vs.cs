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
        BLOCK.Вершины.Add(id, this);
    }
}
/// <summary>
/// блок состоит из восьми cube256 по одной оси (8^3)
/// каждый куб проверяется на существование и считается вертексом в классе куба
/// </summary>
public class Block8: IBlock8_vs_file
{
    public Block8(int i) => this._index = (byte)i;
    private byte _index = 0; public byte НомерМодели => _index;
    private Dictionary<uint, Block8_v> _vertices = new Dictionary<uint, Block8_v>(); public Dictionary<uint, Block8_v> Вершины => _vertices;
}
public interface IBlock8_vs
{
    public enum РазнБлока
    {
        Заполнен = 255,
        Поверхность = 51,
    }
    byte НомерМодели { get; }
    static IBlock8_vs_file[] МоделиБлоков = СозданиеБлоков();
    static public IBlock8_vs_file[] СозданиеБлоков()
    {
        //stRegion_curr.Region.ВосстановитьРегион();
        var max = byte.MaxValue + 1;
        var arr = new IBlock8_vs_file[max];
        for (var i = 0; i < max; i++)
            arr[i] = new Block8(i);


        return arr;
    }
    Dictionary<uint, Block8_v> Вершины { get; }
    #region Координата
    public Block8_v ЕстьЛиВершина(uint id) => СуществуетВершина(id) ? Вершины[id] : null;
    public bool СуществуетВершина(Vector3 v) => СуществуетВершина(КоординатаВершины(v));
    public bool СуществуетВершина(uint id) => Вершины.ContainsKey(id);
    public uint КоординатаВершины(Vector3 v) => stVector_number100.GET_ID(v);
    public Vector3 КоординатаВершины(uint id) => stVector_number100.GET_V(id);
    #endregion
    #region code
    public byte СформироватьКодБлока_51_255(Vector3 v) => НомерМодели == 51 && v.y == LIB.cs2305181649.IClass.SIZE - 1 ? (byte)РазнБлока.Поверхность : (byte)РазнБлока.Заполнен;
    #endregion
    #region Работа с Вершинами
    public Block8_v ИнверсияВершины(uint id, Vector3 координата)
    {
        var bol = СуществуетВершина(id);
        Block8_v vertec = null;
        if (bol) this.Вершины.Remove(id); else vertec = new Block8_v(this, id);
        return vertec;
    }
    /// <summary>
    /// добавить в справочник или получить ВершинуБлока(Куб)
    /// </summary>
    /// <param name="id"></param>
    /// <param name="координата"></param>
    /// <returns></returns>
    public Block8_v ПостроитьВершину(uint id, Vector3 координата) => СуществуетВершина(id) ? Вершины[id] : new Block8_v(this, id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="edit">spBuild.Cube256.Int</param>
    /// <param name="id"></param>
    /// <param name="координата"></param>
    /// <param name="КодБлока"></param>
    /// <returns></returns>
    public Block8_v ПостроитьВершину(LIB.cs2305141202.IClass edit, uint id, Vector3 координата, byte КодБлока)
    {
        var вершина = ПостроитьВершину(id, координата);
        LIB.st2305202041.Class.fun230520204101_СобратьБлокПоТекущему/*добавить cube256*/(edit, new LIB.cs2306262134.Class(координата,КодБлока));
        return вершина;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="edit">spBuild.Cube256.Int </param>
    /// <param name="КодБлока"></param>
    /// <param name="ПолучитьКод"></param>
    public void СобратьВертекс(LIB.cs2305141202.IClass edit, byte КодБлока, System.Func<Vector3, System.Func<Vector3, bool>,byte> ПолучитьКод=null)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        if (ПолучитьКод == null) ПолучитьКод= LIB.st2306271209.Class.fun230627120900_СформироватьКодБлока;
        edit.Очистить();
        //обход по кубам
        for (var x = 0; x < MAX; x++)
            for (var y = 0; y < MAX; y++)
                for (var z = 0; z < MAX; z++)
                {
                    //координата вершины блока
                    var координата = new Vector3(x, y, z);
                    var Код = ПолучитьКод(координата, СуществуетВершина);
                    LIB.st2305202041.Class.fun230520204101_СобратьБлокПоТекущему/*добавить cube256*/(edit,new LIB.cs2306262134.Class(координата, Код));
                }
    }
    /// <summary>
    /// spBuild.Cube256.Int
    /// </summary>
    /// <param name="edit"></param>
    public void ПоказатьВсеТочки(LIB.cs2305141202.IClass edit)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        LIB.st2305231603.Class.fun230523160306(edit.GO);
        for (var x = 0; x < MAX; x++)
            for (var y = 0; y < MAX; y++)
                for (var z = 0; z < MAX; z++)
                {
                    var координата = new Vector3(x, y, z);
                    if (LIB.st2305231603.Class.fun230523160307(this,координата))
                    {
                        ИнверсияВершины(КоординатаВершины(координата), координата);
                        СобратьВертекс(edit, LIB.st2306271209.Class.fun230627120900_СформироватьКодБлока(координата, СуществуетВершина));
                        edit.Закрыть();
                    }
                }
    }
    #endregion
}
