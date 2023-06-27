//empty
//empty
//игровые объекты на сцене
using UnityEngine;
namespace LIB.st2305221214
{
    /// <summary>
    /// stGo_scene
    /// </summary>
    public static class Class
    {
        /// <summary>
        /// content
        /// </summary>
        private static GameObject field230522121400;
        /// <summary>
        /// Контент
        /// </summary>
        static GameObject fun230522121401
        {
            get
            {
                if (field230522121400 == null)
                {
                    field230522121400 = GameObject.Find("content");
                    if (field230522121400 == null)
                    {
                        field230522121400 = new GameObject();
                        field230522121400.name = "content";
                    }
                }
                return field230522121400;
            }
        }
        /// <summary>
        /// terra
        /// </summary>
        private static GameObject field230522121402;
        /// <summary>
        /// Земля
        /// </summary>
        public static GameObject field230522121403
        {
            get
            {
                if (field230522121402 == null)
                {
                    field230522121402 = GameObject.Find("terra");
                    if (field230522121402 == null)
                    {
                        field230522121402 = new GameObject();
                        field230522121402.name = "terra";
                        field230522121402.transform.SetParent(fun230522121401.transform);
                        //terra.AddComponent<mbChunk_info>();
                    }
                }
                return field230522121402;
            }
        }
        ///exit
    }
}