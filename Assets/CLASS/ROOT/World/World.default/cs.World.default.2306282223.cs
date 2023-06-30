//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306282223
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass
    {
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2306282238.Class, IClass
    {
        static new public string INFO = "INFO";
        /// <summary>
        /// радиус мира
        /// </summary>
        static public byte Work_R = 16;
        /// <summary>
        /// 
        /// </summary>
        public void СоздатьНачалоСуществованияМира()
        {
            Vector3 v;
            st2306251639.Class.fun230625163902_ОчиститьКореньМира();
            Построить(null);
            for (var z = 0; z <= Work_R; z++)
                for (var x = -Work_R; x <= Work_R; x++)
                {
                    v = new Vector3(x * Chunk_R, 0, z * Chunk_R);
                    НовыйОбъект(v);
                }
        }
        public void НовыйОбъект(Vector3 v)
        {
            var go = new GameObject();
            go.transform.parent = st2306251639.Class.prop230625163901_ОбъектКореньМира.transform;
            go.name = "chunk." + v.x + "." + v.y + "." + v.z;
            go.transform.position = v;
            ПривязатьМеш(go);
        }
        public override void Построить(GameObject go)
        {
            if (!СуществуетМеш) base.Построить(go);
        }
        public void Интерфейс(GameObject go)
        {
            GUILayout.BeginHorizontal();
            ИнтерфейсПоУмолчанию(null);
            st2305161151.Class.fun230516115102_btn_name("СброситьНаНачалоМира", () => СоздатьНачалоСуществованияМира());
            GUILayout.EndHorizontal();
        }
    }
}
