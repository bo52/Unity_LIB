namespace task2022
{
    static public class stContent_file
    {
        static public string �����������(string ����, string id) => stContent_path.PATH_prefab + ���� + id + ".prefab";
        static public string ��������������(string id) => �����������("0.UI/UI_", id);
        static public string ��������(string id) => �����������("1.MESH/MESH_", id);
    }
}
