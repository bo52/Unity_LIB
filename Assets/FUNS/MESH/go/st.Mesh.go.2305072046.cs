//empty
//empty
//привязать Mesh к игровому объекту
using UnityEngine;
namespace LIB.st2305072046
{
    /// <summary>
    /// stMesh.go.cs2305072046
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// НастроитьИгровойОбъект
        /// </summary>
        /// <param name="m"></param>
        /// <param name="go"></param>
        static public void fun230507204600_ПривязатьМешКОбъекту(this Mesh m, GameObject go)
        {
            //GameObject
            if (go == null) return;
            //{
            //go = new GameObject();
            //go.transform.SetParent(GameObject.Find("contnent").transform);
            //}

            //MeshFilter
            var filter = go.GetComponent<MeshFilter>();
            if (filter == null)
                filter = go.AddComponent<MeshFilter>();
            //MeshCollider
            var col = go.GetComponent<MeshCollider>();
            if (col == null)
                col = go.AddComponent<MeshCollider>();
            //MeshRenderer
            var ren = go.GetComponent<MeshRenderer>();
            if (ren == null)
                ren = go.AddComponent<MeshRenderer>();
            //sharedMaterial
            if (ren.sharedMaterial == null)
                ren.sharedMaterial = Resources.Load("MATERIALS/default", typeof(Material)) as Material;

            filter.sharedMesh = m;
            col.sharedMesh = m;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edit"></param>
        static public Mesh fun230507204601_ПривязатьМешОтРедактора(this cs2306291123.Class edit)
        {
            var M = edit.ПолучитьМеш();
            if (edit.GO != null)
            {
                fun230507204600_ПривязатьМешКОбъекту(M, edit.GO);
            }
            return M;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="NameFile"></param>
        /// <param name="go"></param>
        /// <returns></returns>
        static public Mesh fun230507204602_ПривязатьМешОтФайлаПоИмени(string NameFile, GameObject go, string path)
        {
            var m = st2306282324.Class.fun230628232401_ЗагрузитьМешПоИмени(NameFile, path);
            fun230507204600_ПривязатьМешКОбъекту(m, go);
            return m;
        }
        ///exit
    }
}