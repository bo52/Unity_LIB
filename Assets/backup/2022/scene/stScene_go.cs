using UnityEngine;
namespace scene2022
{
    static public class stScene_go
    {
        static private GameObject _Content;
        static public GameObject CONTENT
        {
            get
            {
                if (_Content == null)
                {
                    _Content = GameObject.Find("Content");
                    if (_Content == null)
                        _Content = new GameObject();
                }
                return _Content;
            }
        }
    }
}
