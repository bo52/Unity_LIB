using UnityEngine;
namespace go2023
{
    public static class stGo_scene
    {
        private static GameObject terra;
        private static GameObject content;
        static GameObject Контент
        {
            get
            {
                if (content == null)
                {
                    content = GameObject.Find("content");
                    if (content == null)
                    {
                        terra = new GameObject();
                        terra.name = "content";
                    }
                }
                return content;
            }
        }

        public static GameObject Земля
        {
            get
            {
                if (terra == null)
                {
                    terra = GameObject.Find("terra");
                    if (terra == null)
                    {
                        terra = new GameObject();
                        terra.name = "terra";
                        terra.transform.SetParent(Контент.transform);
                        //terra.AddComponent<mbChunk_info>();
                    }
                }
                return terra;
            }
        }
    }
}