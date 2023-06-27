using gui2023;
using UnityEngine;
using utility2022;

namespace mesh2023
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">дженерик вертекс</typeparam>
    public class MESH : IMesh
    {
        static public MESH Конструктор = new MESH();
        private GameObject _go;
        public GameObject GO{get => _go; set => _go = value;}
        private spBuild.IVertices _vertecs;
        public spBuild.IVertices Вертексы { get => _vertecs; set => _vertecs=value; }

        #region test
        public static class Test
        {
            public static class Cube
            {
                static private Vector3 Координата = Vector3.zero;
                static private bool Координата_блок = false;
                static private byte КодБлока = 0;
                static private GameObject _go;
                static public void инс(GameObject go)
                {
                    _go = go;
                    //if (Координата.ползунок_вектор(ref Координата_блок, "Координата", -10, +10)) фун(КодБлока);

                    stBtn.btn("построить землю", () =>
                    {
                        КодБлока = 51;
                        //фун(КодБлока);
                    });
                    //КодБлока.ползунок_байты(0, 255, фун);
                }
                //Координата, КодБлока
                //static public void фун(byte b) =>(Конструктор as IMesh).СобратьВертекс<Cube256_vs>(_go,new object[] { Координата, b });
            }
        }
        #endregion
    }
}