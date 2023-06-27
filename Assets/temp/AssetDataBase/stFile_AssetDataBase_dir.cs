using UnityEditor;
using UnityEngine;
namespace utility2023
{
    using mesh2023;
    public static class stFile_AssetDataBase_dir
    {

        public static T AssetDataBase_dir<T>(this string path) where T : Object => AssetDatabase.LoadAssetAtPath(path, typeof(T)) as T;
        public static void AssetDataBase_dir<T>(this string PATH, System.Func<ulong, T, GameObject> act) where T : Object
        {
            foreach (var path in System.IO.Directory.GetFiles(PATH, "*.asset", System.IO.SearchOption.TopDirectoryOnly))
                act(System.Convert.ToUInt64(System.IO.Path.GetFileNameWithoutExtension(path)), AssetDatabase.LoadAssetAtPath(path, typeof(T)) as T);
        }
        public static Mesh AssetDataBase_mesh(this GameObject go, string Path)
        {
            var mesh = Path.AssetDataBase_dir<Mesh>();
            go.Связать(mesh, false);
            return mesh;
        }
    }
}