//empty
//empty
//stFile_AssetDataBase_dir
using UnityEditor;
using UnityEngine;
namespace LIB.st2305161642
{
    /// <summary>
    /// stFile_AssetDataBase_dir
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// AssetDataBase_dir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T fun230516164200<T>(this string path) where T : Object => AssetDatabase.LoadAssetAtPath(path, typeof(T)) as T;
        /// <summary>
        /// AssetDataBase_dir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PATH"></param>
        /// <param name="act"></param>
        public static void fun230516164201<T>(this string PATH, System.Func<ulong, T, GameObject> act) where T : Object
        {
            foreach (var path in System.IO.Directory.GetFiles(PATH, "*.asset", System.IO.SearchOption.TopDirectoryOnly))
                act(System.Convert.ToUInt64(System.IO.Path.GetFileNameWithoutExtension(path)), AssetDatabase.LoadAssetAtPath(path, typeof(T)) as T);
        }
        /// <summary>
        /// AssetDataBase_mesh
        /// </summary>
        /// <param name="go"></param>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static Mesh fun230516164202(this GameObject go, string Path)
        {
            var mesh = fun230516164200<Mesh>(Path);
            mesh.НастроитьИгровойОбъект(go);
            return mesh;
        }
        ///exit
    }
}