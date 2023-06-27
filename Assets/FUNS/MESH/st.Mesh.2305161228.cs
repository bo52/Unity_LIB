//empty
//empty
//СобратьОбъект по мешу
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// КомпонентыМеша
/// </summary>
namespace LIB.cs2305161228
{
    static public class Class
    {
        /// <summary>
        /// Собрать меш по массивам
        /// </summary>
        /// <param name="vs"></param>
        /// <param name="ts"></param>
        /// <param name="uvs"></param>
        /// <returns></returns>
        static public Mesh fun230516122800(List<Vector3> vs, List<int> ts, List<Vector2>[] uvs)
        {
            //m.colors = cs.ToArray();
            var m = new Mesh();
            m.vertices = vs.ToArray();
            m.triangles = ts.ToArray();
            m.uv = uvs[0].ToArray();
            m.RecalculateBounds();
            m.RecalculateNormals();
            return m;
        }
        /// <summary>
        /// static public Class2208111319/*Mesh*/<Class2208111307/*Square_map_req*/> instance = new Class2208111319/*Mesh*/<Class2208111307/*Square_map_req*/>();
        /// СобратьОбъект по мешу с сохранением
        /// </summary>
        /// <param name="go"></param>
        /// <param name="m"></param>
        /// <param name="save"></param>
        static public void fun230516122801(GameObject go, Mesh m, bool save)
        {
            var mr = go.GetComponent<MeshRenderer>();
            if (mr == null)
                go.AddComponent<MeshRenderer>();
            var mf = go.GetComponent<MeshFilter>();
            if (mf == null)
                mf = go.AddComponent<MeshFilter>();
            mf.sharedMesh = m;
            if (save)
            {
                var f = "Assets/Resources/Codes/region-" + (int)go.transform.position.x + "-" + (int)go.transform.position.y + "-" + (int)go.transform.position.z + ".asset";
                UnityEditor.AssetDatabase.CreateAsset(m, f);
            }
        }
        /// <summary>
        /// СобратьОбъект по мешу с сохранением через абстр.функцию
        /// </summary>
        /// <param name="go"></param>
        /// <param name="СобратьМеш"></param>
        /// <param name="save"></param>
        static public void fun230516122802(GameObject go, System.Func<Mesh> СобратьМеш, bool save) => fun230516122801(go, СобратьМеш(), save);
        ///exit
    }
}