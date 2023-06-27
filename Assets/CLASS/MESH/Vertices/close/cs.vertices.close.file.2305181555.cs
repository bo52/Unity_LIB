//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace LIB.cs2305181555
{
/// <summary>
///
/// </summary>
public interface IClass:cs2305141208.IClass
{
        string FILE { get; set; }
        public new virtual Mesh Закрыть(string f)
        {
            if (FILE != "") GO.name = f;
            return (this as cs2305141208.IClass).Закрыть;
        }
    }
/// <summary>
///
/// </summary>
public class Class: cs2305141208.Class,IClass
    {
        static public string INFO = "INFO";
        public void СтроимМеш()
        {
            if (vs.Count > 65000) Закрыть();
        }
        private string _f;public string FILE { get=>_f; set=>_f=value; }
    }
}
