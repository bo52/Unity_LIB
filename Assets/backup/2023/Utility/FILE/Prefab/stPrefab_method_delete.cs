namespace scr2022
{
    static public class stPrefab_method_delete
    {
        static public void ”далить¬сеѕрефабы»зѕапки(this string PATH)
        {
            var f = stPrefab_path.PATH_Prefab(PATH);
            foreach (var path in System.IO.Directory.GetFiles(f, "*.prefab"))
            {
                System.IO.File.Delete(path);
                System.IO.File.Delete(path + ".meta");
            }
        }
    }
}