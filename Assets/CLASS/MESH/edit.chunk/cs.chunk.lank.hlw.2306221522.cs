//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306221522
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
        void ИнтерфейсПостроитьПоВДШ(GameObject go);
    }
    /// <summary>
    /// рекурсивный куб с координатой
    /// </summary>
    public class Class : IClass
    {
        static public string INFO = "INFO";
        Vector3 hlw = Vector3.one;
        bool hlw_btn = false;
        Vector3 v0 = Vector3.zero;
        bool v0_btn = false;
        private void ПоУмолчанию(byte R)
        {
            v0 = Vector3.zero;
            hlw.x = R;
            hlw.y = 1;
            hlw.z = R;
        }
        private void left()
        {

        }
        private void right()
        {

        }
        private void up()
        {

        }
        private void center()
        {

        }
        private void down()
        {

        }
        private void back()
        {

        }
        private void forward()
        {

        }
        public void ИнтерфейсПостроитьПоВДШ(GameObject go) => ИнтерфейсПостроитьПоВДШ(go, st2306262206.Class.field230626220601_Chunk_R);
        public void ИнтерфейсПостроитьПоВДШ(GameObject go, byte R)
        {
            GUILayout.BeginVertical();
            if (st2306262206.Class.fun230626220605_ИнтерфейсПоУмолчанию(go)) ПоУмолчанию(R);
            var b_hlw = st2305141354.Class.fun230514135401_Вектор(ref hlw, ref hlw_btn, "hlw", 0, R);
            var b_v0 = st2305141354.Class.fun230514135401_Вектор(ref v0, ref v0_btn, "v0", 0, R);
            GUILayout.EndVertical();
            if (b_hlw || b_v0) ПостроитьПоВДШ(go, R);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go"></param>
        /// <param name="h"></param>
        /// <param name="l"></param>
        /// <param name="w"></param>
        /// <param name="v0"></param>
        public void ПостроитьПоВДШ(GameObject go, byte R)
        {
            var s = new cs2306271146.Class(R, new cs2306271320.Class(hlw), v0);
            s.СобратьЧанк(go);
        }
    }
}
