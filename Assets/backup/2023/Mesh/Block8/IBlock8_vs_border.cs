using go2023;
using gui2023;
using UnityEngine;

public interface IBlock8_vs_border : IBlock8_vs
{
    static private string name = "border";
    static private bool border = true;
    static private float MAX => LIB.cs2305181649.IClass.MAX;
    static public Vector3[] ¬ершиныќтносительно оординатыЅлока => LIB.st2305151543.Class.field230515154300_¬екторќт÷ентра убаѕоЌомеру¬ершины;
    static private spBuild.Cube256.Int EDIT => spBuild.Block.mbBlock_edit.Ёкз;
    static private GameObject GO => EDIT.GO;
    public void »нсЅордера()
    {
        stBool.логический(ref border,(bool b)=> ѕостроить√раницы(GO),"border", 10);
    }
    static public bool «а√раницей(Vector3 v) => v.x < 0 || v.y < 0 || v.z < 0;
    static public bool «а√раницейѕолностью(Vector3 v) => «а√раницей(v) || v.x > MAX - 1 || v.y > MAX - 1 || v.z > MAX - 1;
    public byte —формировать одЅлока(Vector3 v, System.Func<Vector3, bool> «а√раницей)
    {
        float code = 0;
        for (var i = 0; i < ¬ершиныќтносительно оординатыЅлока.Length; i++)
        {
            var next = v + ¬ершиныќтносительно оординатыЅлока[i];
            code += «а√раницей(next) ? 0 : (—уществует¬ершина(next) ? Mathf.Pow(2, i) : 0);
        }
        return (byte)code;
    }
    public bool ѕоследний(Vector3 v) => v.x == MAX - 1 || v.y == MAX - 1 || v.z == MAX - 1;
    public void ѕостроить√раницы(GameObject go)
    {
        LIB.st2305221205.Class.fun230522120500/*”даление*/(go,name);
        if (!border) return;
        ѕостроить√раницыЅлока();
        ѕостроить√раницы«аполненности();
        —озданиеќбъекта(go);
    }
    public void ѕостроить√раницыЅлока()
    {
        if (this.¬ершины.Count < 1) return;
        for (var x = -1; x < MAX; x++)
            for (var y = -1; y < MAX; y++)
                for (var z = -1; z < MAX; z++)
                {
                    if (x < 0 || y < 0 || z < 0)
                    {
                        var координата = new Vector3(x, y, z);
                        byte кодблока = —формировать одЅлока(координата, «а√раницей);
                        EDIT.ѕостроить(координата, кодблока);
                    }
                }
    }
    public void ѕостроить√раницы«аполненности()
    {
        if (this.¬ершины.Count > 0) return;
        for (var x = -1; x <MAX; x++)
            for (var y = -1; y < MAX; y++)
                for (var z = -1; z < MAX; z++)
                {
                    var координата = new Vector3(x, y, z);
                    if (x < 0 || y < 0 || z < 0 || ѕоследний(координата))
                    {
                        byte кодблока = —формировать одЅлока(координата, «а√раницейѕолностью);
                        EDIT.ѕостроить(координата, кодблока);
                    }
                }
    }
    public void —озданиеќбъекта(GameObject go)
    {
        var children = new GameObject();
        children.name = name;
        children.transform.SetParent(go.transform);
        children.transform.localPosition = Vector3.zero;
        EDIT.—троим(children,"");
    }
}
