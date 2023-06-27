//empty
//empty
//empty
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.cs2305221415
{
    /// <summary>
    /// Cube_buid
    /// </summary>
    public interface IClass
    {
        List<cs2305221354.IClass> Части { get; }
        bool[,,] ЦИКЛ { get; }
        go2305221347.IInspector mb { get; }
    }
    /// <summary>
    /// Cube_buid
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        static byte MAX => st2305221401.Class.field230522140100;
        private go2305221347.IInspector _mb; public go2305221347.IInspector mb => _mb;
        private List<cs2305221354.IClass> _part = new List<cs2305221354.IClass>();public List<cs2305221354.IClass> Части =>_part;
        private bool[,,] _round = new bool[MAX, MAX, MAX]; public bool[,,] ЦИКЛ => _round;

        public Class(go2305221347.IInspector mb)
        {
            this._mb = mb;
        }
        public void Пустой()
        {
            for (byte x = 0; x < MAX; x++)
                for (byte y = 0; y < MAX; y++)
                    for (byte z = 0; z < MAX; z++)
                        mb.СобранныеТочки.SetPixel(x, y, z, new Color(0, 0, 0, 1.0f));
            mb.СобранныеТочки.Apply();
            AssetDatabase.CreateAsset(mb.СобранныеТочки, st2305221401.Class.field230522140102);
        }
        public void test(GameObject go)
        {
            Пустой();
            mb.СобранныеТочки.SetPixel(0, 0, 0, st2305221401.Class.field230522140101);
            mb.СобранныеТочки.SetPixel(0, 1, 1, st2305221401.Class.field230522140101);
            Собрать(go);
        }
        public Mesh Собрать(GameObject go)
        {
            st2305221410.Class.fun230522141010(this);
            var m = st2305221401.Class.fun230522140107(Части);
            st2305072046.Class.fun230507204600_ПривязатьМешКОбъекту(m, go);
            return m;
        }
    }

}