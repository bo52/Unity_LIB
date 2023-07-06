//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.cs2306301501
{
    /// <summary>
    ///
    /// </summary>
    public interface IClass : cs2305071643_Chunk_default.IClass
    {
        cs2306301504.Class ПараметрыЧанка { get; }
        string NameFile { get; }
        string Path { get; }
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : cs2305071643_Chunk_default.Class, IClass
    {
        static new public string INFO = "INFO";
        public virtual string Path => "default/";
        public virtual string NameFile => "chunk";
        public Class():base()
        {
            _param_chunk = new cs2306301504.Class(NameFile, Path);
        }
        protected cs2306301504.Class _param_chunk; 
        public cs2306301504.Class ПараметрыЧанка => _param_chunk;
        public override void ПостроитьСЗакрытием() => ПараметрыЧанка.ПостроитьМеш(new cs2307031203_ПараметрыПостройки.Class(ФункцияПостройки, (byte)ТипРедактора), ИгровойОбъект);
    }
}
