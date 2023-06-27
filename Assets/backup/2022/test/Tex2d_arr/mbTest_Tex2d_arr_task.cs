//Bo52_2412202017254547.PROTOTYPE.
namespace test2022
{
    using test2022;
    using utility2022;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnityEditor;
    using UnityEngine;
    /// <summary>
    /// Texture2DArray
    /// генерация,сохранение,загрузка Texture2DArray в размере 1024
    /// </summary>
    public class mbTest_Tex2d_arr_task:MonoBehaviour
    {
        static ushort РазмерТекстуры = 256;
        static ushort ПоловинаТекстуры = 128;
        [SerializeField]
        public Texture2DArray ТЕКСТУРА;
        public class WorkerMultiTask
        {
            private int _z;
            private Texture2DArray _p;
            public WorkerMultiTask(Texture2DArray p, int z)
            {
                _z = z;
                _p = p;
            }
            public int Work()
            {
                Color[] cs = new Color[РазмерТекстуры * РазмерТекстуры];
                var R=new System.Random();
                
                //потоки
                for (var x = 0; x < РазмерТекстуры; x++)
                    for (var y = 0; y < РазмерТекстуры; y++)
                    {
                            cs[x + РазмерТекстуры * y] = new Color32(
                                (byte)R.Next(0, byte.MaxValue),
                                (byte)R.Next(0, byte.MaxValue),
                                (byte)R.Next(0, byte.MaxValue),
                                (byte)(y > ПоловинаТекстуры ? 0 : byte.MaxValue)
                                );
                    }
                stThreading.sync.Post(delegate {
                    _p.SetPixels(cs, _z);
                }, null);
                return _z;
            }
        }
        public void СохранитьТекстуру()
        {
            ТЕКСТУРА.Apply();
            string namefile = "Assets/prototype/test.asset";
            AssetDatabase.CreateAsset(ТЕКСТУРА, namefile);
        }
        public async void multiStart()
        {
            ТЕКСТУРА = new Texture2DArray(РазмерТекстуры, РазмерТекстуры, РазмерТекстуры, TextureFormat.RGBAFloat, false);
            List<Task<int>> tasks = new List<Task<int>>();
            for (int z = 0; z < РазмерТекстуры; z++)
            {
                var worker = new WorkerMultiTask(this.ТЕКСТУРА,z);

                Task<int> task = Task<int>.Factory.StartNew(worker.Work);
                tasks.Add(task);
            }
            try
            {
                int result = await Task<int>.Factory.ContinueWhenAll(tasks.ToArray(), ts => {
                    stThreading.sync.Post(delegate {
                        СохранитьТекстуру();
                    }, null);
                    return 0;
                });
            }
            catch (System.AggregateException ex)
            {
            }
        }
        static public void ГенерацияРегионаНаСцене()
        {
            var name = "Prototype2412202017254547";
            GameObject go = GameObject.Find(name);
            if (go == null)
            {
                go = new GameObject();
                go.name = name;
                go.AddComponent<mbTest_Tex2d_arr_task>();
            }
            
            go.GetComponent<mbTest_Tex2d_arr_task>().multiStart();
        }
        static public void test()
        {
            string namefile = "Assets/prototype/test.asset";
            Texture2DArray img = (Texture2DArray)AssetDatabase.LoadAssetAtPath(namefile, typeof(Texture2DArray));
            var cs = img.GetPixels(1);
            var x = 1;
            var y = 1;
            var i = x + РазмерТекстуры * y;
            Debug.Log(cs[i].r + "=" + cs[i].g + "=" + cs[i].b + "=" + cs[i].a);
        }
    }
}
