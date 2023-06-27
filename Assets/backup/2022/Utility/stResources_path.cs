using UnityEngine;
namespace utility2022
{
    static public class stResources_path
    {
        static public string PATH_resources => Application.dataPath + "/Resources/";
        static public string PATH_resources_local(string full_path) => full_path.Replace(PATH_resources, "");
    }
}
