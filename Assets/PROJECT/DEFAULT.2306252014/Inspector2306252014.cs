﻿//empty
//empty
//empty
using UnityEngine;

namespace LIB.go2306252014
{
    public interface IInspector : go2305081120.IInspector
    {
        new IScene СЦЕНА { get; }
        static public cs2307051626_ЗЕМЛЯ.IClass ЗЕМЛЯ = new cs2307051626_ЗЕМЛЯ.Class();
    }
    /// <summary>
    /// Список Миров
    /// </summary>
    public class Inspector : go2305081120.Inspector, IInspector
    {
        new public IScene СЦЕНА => объектСЦЕНА as IScene;
        public Inspector()
        {
        }
    }
}
