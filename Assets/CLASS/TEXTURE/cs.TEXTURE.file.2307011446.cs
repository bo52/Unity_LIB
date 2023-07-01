﻿//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace LIB.cs2307011446_ТекстураФайл
{
    /// <summary>
    /// Текстура файл
    /// </summary>
    public interface IClass : cs2305071643_Default.IClass
    {
        string PATH { get; }
        void Сохранить();
    }
    /// <summary>
    ///
    /// </summary>
    public class Class : cs2305071643_Default.Class, IClass
    {
        static new public string INFO = "INFO";
        public int SIZE = 8192;
        Texture2D НоваяТекстура => new Texture2D(SIZE, SIZE, TextureFormat.RGBA32, false);
        Texture2D _tex; public Texture2D ТЕКСТУРА
        {
            get
            {
                if (_tex == null)
                {
                    if (!Загрузить)
                    {
                        _tex = НоваяТекстура;
                        Сохранить();
                    }
                }
                return _tex;
            }
        }
        protected string _path = "test"; public virtual string PATH => _path;
        public string Файл => "TEXTURES/" + _path + ".png";
        public void Сохранить()
        {
            st2306252021.Class.fun230625202100_SaveTextureToFile(ТЕКСТУРА, "Assets/Resources/" + Файл);
        }
        public bool Загрузить
        {
            get
            {
                if (!File.Exists(Файл)) return false;
                _tex = Resources.Load(Path.GetFileName(Файл), typeof(Texture)) as Texture2D;
                return true;
            }
        }

    }
}