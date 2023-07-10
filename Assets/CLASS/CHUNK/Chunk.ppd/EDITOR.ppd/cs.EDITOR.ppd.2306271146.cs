//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2306271146_РедакторПаралепипеда
{
    public interface IClass
    {
        public static int R = cs2307061242_Чанк_Интерфейс.IClass.РазмерЧанка;
        bool СуществуетВершина(Vector3 v);
        bool ИнтерфейсПоУмолчанию();
        cs2307071130_ВысотаПаралепипеда.IClass H { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public class Class: IClass
    {
        cs2307071119_ВекторПаралепипеда.IClass D = new cs2307071119_ВекторПаралепипеда.Class("ДЛИННА");
        cs2307071119_ВекторПаралепипеда.IClass W = new cs2307071119_ВекторПаралепипеда.Class("ШИРИНА");
        cs2307071130_ВысотаПаралепипеда.IClass _H = new cs2307071130_ВысотаПаралепипеда.Class(); public cs2307071130_ВысотаПаралепипеда.IClass H => _H;
        static public string INFO = "INFO";
        public Class()
        {
            ИзменитьНастройки.Add("ПоУмолчанию", () => {
                D.Левая = 0;
                D.Правая = 0;
                W.Левая = 0;
                W.Правая = 0;
                H.Высота = 1;
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
            if (v.y > H.Высота + 1) return false;
            return true;
        }
        public bool ИнтерфейсПоУмолчанию()
        {
            GUILayout.BeginVertical();
            var b0 = ПоказатьИзменитьНастройки();
            var b1 = H.Показать();
            var b2 = D.Показать();
            var b3 = W.Показать();
            GUILayout.EndVertical();
            return b0 || b1 || b2 || b3;

        }
        //exit
    }
}
