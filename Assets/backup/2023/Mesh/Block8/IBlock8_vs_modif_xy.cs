using gui2023;
using UnityEngine;
/// <summary>
/// варианты модификации "ѕоƒвумќс€м"
/// </summary>
public interface IBlock8_vs_modif_xy:IBlock8_vs
{
    static byte Z_current = 0;
    public void ”далить(uint id) => this.¬ершины.Remove(id);
    public void ѕоƒвумќс€м(bool Ёто”даление)
    {
        var MAX = LIB.cs2305181649.IClass.MAX;
        for (var y = MAX - 1; y >= 0; y--)
            for (var x = 0; x < MAX; x++)
            {
                var координата = new Vector3(x, y, Z_current);
                var ид =  оордината¬ершины(координата);
                if (Ёто”даление) ”далить(ид); 
                else ѕостроить¬ершину(ид, координата);
            }
    }
    public bool «аполнитьѕоƒвумќс€м()
    {
        GUILayout.BeginHorizontal();
        var b = stBtn.btn("«аполнить", () => ѕоƒвумќс€м(false)) || stBtn.btn("”далить", () => ѕоƒвумќс€м(true));
        GUILayout.EndHorizontal();
        return b;
    }
}
