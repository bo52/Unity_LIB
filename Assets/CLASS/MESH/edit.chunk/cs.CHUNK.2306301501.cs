﻿//empty
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
    public interface IDefault
    {
        bool ИнтерфейсПоУмолчанию(GameObject go, string name = "Построить");
    }
    /// <summary>
    ///
    /// </summary>
    public interface IClass : IDefault
    {
        public enum Редактор { empty, Block, square, triangle };
        Редактор ТипРедактора { get; }
        cs2306301504.Class ПараметрыЧанка { get; }
        string NameFile { get; }
        string Path { get; }
        void ФункцияПостройки(cs2305141215.IClass edit);
        public void Построить(GameObject go);
    }
    /// <summary>
    ///
    /// </summary>
    public abstract class Class : IClass
    {
        static public string INFO = "INFO";
        public virtual IClass.Редактор ТипРедактора => IClass.Редактор.Block;
        public virtual string Path => "default/";
        public virtual string NameFile => "chunk";
        protected cs2306301504.Class _param_chunk; public cs2306301504.Class ПараметрыЧанка => _param_chunk;
        public Class()
        {
            _param_chunk = new cs2306301504.Class(NameFile, Path);
        }
        public virtual void Построить(GameObject go) => ПараметрыЧанка.ПостроитьМеш(new cs2305141208.Class.ПараметрыПостройки(ФункцияПостройки, (byte)ТипРедактора), go);
        public abstract void ФункцияПостройки(cs2305141215.IClass edit);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public virtual bool ИнтерфейсПоУмолчанию(GameObject go, string name = "Построить")
        {
            return st2305161151.Class.fun230516115102_btn_name(name, () => Построить(go));
        }
    }
}
