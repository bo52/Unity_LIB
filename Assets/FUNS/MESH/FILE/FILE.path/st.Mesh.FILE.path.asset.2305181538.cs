//empty
//empty
//mesh_path_asset получить path меша
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.st2305181538
{
/// <summary>
/// получить path меша
/// </summary>
static public class Class
{
        static public string INFO = "INFO";
        /// <summary>
        /// mesh_path_asset
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public string fun230518153801_ПолучитьФайлМешаПоИмени(this string id, string path = "") => st2305161617.Class.fun230516161700_ПолучитьФайлПоАргументам(st2305161619.Class.field230516161900_РазделМешей + path, id, "asset");
        /// <summary>
        /// mesh_path_asset.go
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        static public string fun230518153802_ПолучитьФайлМешаПоОбъекту(this GameObject go) => st2305161617.Class.fun230516161700_ПолучитьФайлПоАргументам(st2305161619.Class.field230516161900_РазделМешей, go.name, "asset");
        ///exit
    }
}
