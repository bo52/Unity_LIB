//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306282324
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// ФайлМеша
        /// </summary>
        /// <param name="asset"></param>
        /// <param name="Сохранен"></param>
        /// <returns></returns>
        static public Mesh fun230628232400_ЗагрузитьМеш(string asset, bool Сохранен) => Сохранен ? (Mesh)AssetDatabase.LoadAssetAtPath(asset, typeof(Mesh)) : null;
        /// <summary>
        /// ФАЙЛ_МЕША
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Mesh fun230628232401_ЗагрузитьМешПоИмени(string NameFile, string path)
        {
            var asset = st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(NameFile, path);
            var Сохранен = st2305161618.Class.fun230516161800_СуществуетЛиФайл(asset);

            return fun230628232400_ЗагрузитьМеш(asset, Сохранен);
        }
        ///exit
    }
}
