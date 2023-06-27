//namespace Bo52_08102020105344293
//Bo52_08102020105344293.CLASS: Bo52_15102020130526926.CLASS
namespace task2022 {
    using UnityEngine;
    using utility2022;
    using System.Collections.Generic;

    public static class stWorld_block_rec27
    {
        static public byte MAX_LEVEL = 3;
        static public Vector3 КоординатаВершины => (Mathf.Pow(3, MAX_LEVEL) + Mathf.Pow(2, MAX_LEVEL)) * new Vector3(-1, -1);
        static public readonly Vector3[] МассивИндексовБлоков = new Vector3[]
        {
            new Vector3(-1,-1,-1),new Vector3(0,-1,-1),new Vector3(1,-1,-1),new Vector3(-1,-1,0),new Vector3(0,-1,0),new Vector3(1,-1,0),new Vector3(-1,-1,1),new Vector3(0,-1,1),new Vector3(1,-1,1),
            new Vector3(-1,0,-1),new Vector3(0,0,-1),new Vector3(1,0,-1),new Vector3(-1,0,0),new Vector3(0,0,0),new Vector3(1,0,0),new Vector3(-1,0,1),new Vector3(0,0,1),new Vector3(1,0,1),
            new Vector3(-1,1,-1),new Vector3(0,1,-1),new Vector3(1,1,-1),new Vector3(-1,1,0),new Vector3(0,1,0),new Vector3(1,1,0),new Vector3(-1,1,1),new Vector3(0,1,1),new Vector3(1,1,1),
        };
    }
    public static class stWorld_block_rec27_prop
    {
        static public float КоличествоБлоковДоСоседа(this World_block_rec27 ex) => Mathf.Pow(3, ex.УРОВЕНЬ);
        static public float Уровень_множетель(this World_block_rec27 ex) => Mathf.Pow(3, ex.УРОВЕНЬ);
        static public Vector3 КоординатаВершины(this World_block_rec27 ex, byte Индекс) => КоординатаВершины(ex, Индекс, Уровень_множетель(ex));
        static public Vector3 КоординатаВершины(this World_block_rec27 ex, byte Индекс, float n) => ex.УРОВЕНЬ == stWorld_block_rec27.MAX_LEVEL ? stWorld_block_rec27.КоординатаВершины : ex.РОДИТЕЛЬ.КоординатаВершины + n * new Vector3(1, 1) + n * stWorld_block_rec27.МассивИндексовБлоков[Индекс];
        static public Vector3 КоординатаЦентраВершины(this World_block_rec27 ex)=> ex.УРОВЕНЬ == stWorld_block_rec27.MAX_LEVEL ? Vector3.zero : ex.РОДИТЕЛЬ.КоординатаЦентраВершины + ex.Уровень_множетель ()* stWorld_block_rec27.МассивИндексовБлоков[ex.ИНДЕКС];
    }
    public static class stWorld_block_rec27_fun
    {
        static public void СоздатьВложенныеБлоки(this World_block_rec27 ex)
        {
            if (ex.УРОВЕНЬ > 0)
                for (byte i = 0; i < 27; i++)
                {
                    //определить какие блоки создавать
                    ex.БЛОКИ.Add(i, new World_block_rec27(ex, i));
                }
        }
        static public void ПостроитьБлок(this World_block_rec27 ex)
        {
            if (ex.ОТКРЫТЫЙ == true)
                return;
            stMesh_triangle_cub.СобратьКубМеш(ex.КООРДИНАТА, ex.КоличествоБлоковДоСоседа());
        }
    }
    /// <summary>
    /// БЛОК.составной
    /// СоздатьБлокСВложеннымиБлоками27СУровнем
    /// </summary>
    public class World_block_rec27: World_block
    {
        public World_block_rec27 РОДИТЕЛЬ = null;
        public byte ИНДЕКС;
        public byte УРОВЕНЬ;
        public Dictionary<byte, World_block_rec27> БЛОКИ = new Dictionary<byte, World_block_rec27>();
        public bool ОТКРЫТЫЙ = true;
        public Vector3 КоординатаЦентраВершины;
        public Vector3 КоординатаВершины;
        /// <summary>
        /// ПервыйВерхнийБлок
        /// </summary>
        public World_block_rec27()
        {
            РОДИТЕЛЬ = null;
            УРОВЕНЬ = stWorld_block_rec27.MAX_LEVEL;
            this.СоздатьВложенныеБлоки();
        }
        public World_block_rec27(World_block_rec27 родитель, byte Индекс)
        {
            РОДИТЕЛЬ = родитель;
            УРОВЕНЬ = (byte)(РОДИТЕЛЬ.УРОВЕНЬ - 1);
            this.СоздатьВложенныеБлоки();
        }
    }
}
