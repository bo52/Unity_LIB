//empty
//empty
//получить Меш
using System.IO;
using UnityEngine;
namespace LIB.st2305161619
{
    /// <summary>
    /// stMesh_path
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// PATH_mesh
        /// </summary>
        static public string field230516161900_РазделМешей => "Assets/Resources/MESHES/";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="namefile"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        static public bool fun230516161901_СуществуетМеш(string namefile, string path = "default/") => File.Exists(Application.dataPath + "/" + field230516161900_РазделМешей + path + namefile + ".asset");
        /// <summary>
        /// ПолучитьМеш
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Mesh fun230516161902(this string id) => st2305161642.Class.fun230516164200<Mesh>(id);
        ///exit
    }
}