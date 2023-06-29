//empty
//empty
//сохранить меш в AssetDatabase
using UnityEditor;
using UnityEngine;
namespace LIB.st2305161716
{
    /// <summary>
    /// stFile_mesh_save
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// 
        /// </summary>
        static public void fun230516171600_СохранитьМеш(this Mesh M,string asset)
        {
            if (System.IO.File.Exists(asset))
                AssetDatabase.SaveAssets();
            else
                AssetDatabase.CreateAsset(M, asset);
        }
        /// <summary>
        /// СохранитьСвойМешОбъекта
        /// go.GetComponent<MeshFilter>().sharedMesh
        /// </summary>
        /// <param name="go"></param>
        static public void fun230516171601_ПереСохранитьМешОбъекта(this GameObject go)
        {
            go.GetComponent<MeshFilter>().sharedMesh.fun230516171600_СохранитьМеш(st2305181538.Class.fun230518153802_ПолучитьФайлМешаПоОбъекту(go));
        }
        /// <summary>
        /// СохранитьМешОбъекта
        /// </summary>
        /// <param name="go"></param>
        /// <param name="m"></param>
        static public void fun230516171602_СохранитьМешПоИмениОбъекта(this GameObject go, Mesh m)
        {
            m.fun230516171600_СохранитьМеш(st2305181538.Class.fun230518153802_ПолучитьФайлМешаПоОбъекту(go));
        }
        /// <summary>
        /// СохранитьМешФайлом
        /// </summary>
        /// <param name="M"></param>
        /// <param name="index"></param>
        static public void fun230516171603_СохранитьМешПоИндексу(Mesh M, int index)
        {
            if (M == null) return;
            if (index < 0) return;
            M.fun230516171600_СохранитьМеш(st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(index.ToString()));
        }
        /// <summary>
        /// СохранитьМешПоИмени
        /// </summary>
        /// <param name="M"></param>
        /// <param name="id"></param>
        /// <param name="path"></param>
        static public void fun230516171604_СохранитьМешПоИмени(Mesh M, string namefile, string path="")
        {
            M.fun230516171600_СохранитьМеш(st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(namefile, path));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="namefile"></param>
        /// <param name="path"></param>
        static public void fun230516171605_СохранитьМешПоИмениОтРедактора(this cs2306291123.Class edit, string namefile, string path = "default/")
        {
            var M = edit.ПолучитьМеш();
            st2305161716.Class.fun230516171604_СохранитьМешПоИмени(M, namefile, path);
            if (edit.GO != null)
            {
                st2305072046.Class.fun230507204600_ПривязатьМешКОбъекту(M, edit.GO);
            }
        }
        ///exit
    }
}
