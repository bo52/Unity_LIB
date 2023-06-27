//empty
//empty
//рекурсионный блок
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305221237
{
    /// <summary>
    /// IBlock
    /// </summary>
    public interface IClass
    {
        cs2305211707.Class Координата {get;}
        bool существует {get; }
        byte Код {get;set;}
        Dictionary<ulong, IClass> Карта {get;}
    }
    /// <summary>
    /// Block
    /// </summary>
    public class Class : IClass
    {
        private byte code = 0;
        private Dictionary<ulong, IClass> map;
        private cs2305211707.Class координата; public cs2305211707.Class Координата => координата;
        public byte Код
        {
            get => code;
            set => code = value;
        }
        public bool существует => st2305141232.Class.fun230514123200(Код);
        public Dictionary<ulong, IClass> Карта => map;
        public Class(Vector3 v, ulong id, Dictionary<ulong, IClass> map, byte code = 0)
        {
            this.map = map;
            координата = new cs2305211707.Class(v, id);
            Код = code;
            map.Add(координата.ид, this);
            //работа с соедями
        }
        public void ИзменитьКод()
        {
            st2305221228.Class.fun230522122802(this);
        }
    }
}