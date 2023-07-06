//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2306271146_РедакторПаралепипеда
{
    public interface IClass
    {
        public static int R = cs2307061242_СловарныйЧанк.IClass.РазмерЧанка;
        public static int r = (int)(0.5f * R - 1);
        bool СуществуетВершина(Vector3 v);
        bool ИнтерфейсПоУмолчанию();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class: IClass
    {
        Вектор D = new Вектор("ДЛИННА");
        Вектор W = new Вектор("ШИРИНА");
        class Вектор
        {
            private bool Развернуть = false;
            private Vector2 _v; public int Левая { get => (int)_v.x; set => _v.x = value; } public int Правая { get => (int)_v.y; set => _v.y = value; }
            private string name_x = "x";
            private string name_z = "z";
            private int x_min = 0;
            private int z_min = 0;
            private int x_max = 100;
            private int z_max = 100;
            private string header = "Вектор";
            public Вектор(string header)
            {
                this.header = header;
                x_min = 0;
                name_x = "x=левая "+ header;
                name_z = "x=правая "+ header;
                z_min = 0;
                x_max = IClass.r;
                z_max = IClass.r;            
            }
            public bool Показать(System.Action<Vector3> fun = null)
            {
                var b = false;
                var v = _v;
                st2305161246.Class.fun230516124600(() =>
                {
                    var x = (int)v.x;
                    var z = (int)v.y;
                    GUILayout.BeginVertical();
                    var X = st2305141354.Class.fun230514135400_slider_int(ref x, name_x, x_min, x_max);
                    var Z = st2305141354.Class.fun230514135400_slider_int(ref z, name_z, z_min, z_max);
                    GUILayout.EndVertical();
                    if (X || Z)
                    {
                        v = new Vector3(x, z);
                        b = true;
                        return;
                    }
                    b = false;
                }, header, ref Развернуть);
                if (b)
                {
                    _v = v;
                    fun?.Invoke(v);
                }
                return b;
            }
        }
        static public string INFO = "INFO";
        int h = 1;
        public Class()
        {
            ИзменитьНастройки.Add("ПоУмолчанию", () => {
                D.Левая = 0;
                D.Правая = 0;
                W.Левая = 0;
                W.Правая = 0;
                h = 1;
            });
            //ИзменитьНастройки.Add("left", () => { v0 = Vector3.zero; hlw.x = 0.5f * R; hlw.y = R; hlw.z = R; });
            //ИзменитьНастройки.Add("right", () => { v0 = 0.5f * R * Vector3.right; hlw.x = 0.5f * R; hlw.y = R; hlw.z = R; });
            //ИзменитьНастройки.Add("up", () => { v0 = 0.5f * R * Vector3.up; hlw.x = R; hlw.y = 0.5f * R; hlw.z = R; });
            //ИзменитьНастройки.Add("center", () => { v0 = 0.25f * R * Vector3.one; hlw.x = 0.5f * R; hlw.y = 0.5f * R; hlw.z = 0.5f * R; });
            //ИзменитьНастройки.Add("down", () => { v0 = Vector3.zero; hlw.x = R; hlw.y = 0.5f * R; hlw.z = R; });
            //ИзменитьНастройки.Add("back", () => { v0 = Vector3.zero; hlw.x = R; hlw.y = R; hlw.z = 0.5f * R; });
            //ИзменитьНастройки.Add("forward", () => { v0 = 0.5f * R * Vector3.forward; hlw.x = R; hlw.y = R; hlw.z = 0.5f * R; });
        }
        private Dictionary<string, System.Action> ИзменитьНастройки = new Dictionary<string, System.Action>();
        public bool ПоказатьИзменитьНастройки()
        {
            var b = false;
            GUILayout.BeginHorizontal();
            foreach (var val in ИзменитьНастройки)
            {
                st2305161151.Class.fun230516115102_btn_name(val.Key, () =>
                {
                    val.Value();
                    b = true;
                });
            }
            GUILayout.EndHorizontal();
            return b;
        }
        public bool СуществуетВершина(Vector3 v)
        {
            if (v.x > IClass.R - D.Правая || v.x < D.Левая) return false;
            if (v.z > IClass.R - W.Правая || v.z < W.Левая) return false;
            if (v.y > h + 1) return false;
            return true;
        }
        public bool ИнтерфейсПоУмолчанию()
        {
            GUILayout.BeginVertical();
            var b0 = ПоказатьИзменитьНастройки();
            var b1 = st2305141354.Class.fun230514135400_slider_int(ref h, "Высота", 1, cs2307061242_СловарныйЧанк.IClass.ГраничныйРазмерЧанка);
            var b2 = D.Показать();
            var b3 = W.Показать();
            GUILayout.EndVertical();
            return b0 || b1 || b2 || b3;

        }
        //exit
    }
}
