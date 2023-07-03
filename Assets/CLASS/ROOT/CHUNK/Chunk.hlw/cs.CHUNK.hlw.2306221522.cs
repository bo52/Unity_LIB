//empty
//empty
//empty
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2306221522
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2305071643_Chunk_default.IClass
    {
    }
    /// <summary>
    /// рекурсивный куб с координатой
    /// </summary>
    public class Class : cs2305071643_Chunk_default.Class, IClass
    {
        static new public string INFO = "INFO";
        #region ПараметрыКласса
        Vector3 hlw = Vector3.one;
        bool hlw_btn = false;
        Vector3 v0 = Vector3.zero;
        bool v0_btn = false;
        private byte R => IClass.Chunk_R;
        private Dictionary<string, System.Action> ИзменитьНастройки = new Dictionary<string, System.Action>();
        public Class(GameObject go):base(go)
        {
            ИзменитьНастройки.Add("ПоУмолчанию", () => { v0 = Vector3.zero; hlw.x = R; hlw.y = 1; hlw.z = R; });
            ИзменитьНастройки.Add("left", () => { v0 = Vector3.zero; hlw.x = 0.5f * R; hlw.y = R; hlw.z = R; });
            ИзменитьНастройки.Add("right", () => { v0 = 0.5f * R * Vector3.right; hlw.x = 0.5f * R; hlw.y = R; hlw.z = R; });
            ИзменитьНастройки.Add("up", () => { v0 = 0.5f * R * Vector3.up; hlw.x = R; hlw.y = 0.5f * R; hlw.z = R; });
            ИзменитьНастройки.Add("center", () => { v0 = 0.25f * R * Vector3.one; hlw.x = 0.5f * R; hlw.y = 0.5f * R; hlw.z = 0.5f * R; });
            ИзменитьНастройки.Add("down", () => { v0 = Vector3.zero; hlw.x = R; hlw.y = 0.5f * R; hlw.z = R; });
            ИзменитьНастройки.Add("back", () => { v0 = Vector3.zero; hlw.x = R; hlw.y = R; hlw.z = 0.5f * R; });
            ИзменитьНастройки.Add("forward", () => { v0 = 0.5f * R * Vector3.forward; hlw.x = R; hlw.y = R; hlw.z = 0.5f * R; });
        }
        public void ПоказатьИзменитьНастройки()
        {
            GUILayout.BeginHorizontal();
            foreach (var val in ИзменитьНастройки)
                st2305161151.Class.fun230516115102_btn_name(val.Key, () =>
                {
                    val.Value();
                    Построить(ИгровойОбъект);
                });
            GUILayout.EndHorizontal();
        }
        private cs2306271146.Class СобранныеПараметры => new cs2306271146.Class(R, new cs2306271320.Class(this.hlw), this.v0);
        #endregion
        public override bool ИнтерфейсПоУмолчанию()
        {
            ПоказатьИзменитьНастройки();
            GUILayout.BeginVertical();
            var b_hlw = st2305141354.Class.fun230514135401_Вектор(ref hlw, ref hlw_btn, "hlw", 0, R);
            var b_v0 = st2305141354.Class.fun230514135401_Вектор(ref v0, ref v0_btn, "v0", 0, R);
            GUILayout.EndVertical();

            if (b_hlw || b_v0) Построить(ИгровойОбъект);
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edit"></param>
        public override void ФункцияПостройки(cs2305141215.IClass edit) => СобранныеПараметры.СобратьЧанк(edit);
    }
}
