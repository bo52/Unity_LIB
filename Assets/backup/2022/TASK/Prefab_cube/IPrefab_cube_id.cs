using System.Collections;
using UnityEngine;
namespace task2022
{
    using utility2022;
    public interface IPrefab_cube_id
    {
        static public ulong ������������������������� => ������������������(Vector3Int.zero);
        static public ulong ������������������(Vector3 v) => stVector_number_h8.GET_ID(v);
        static public Vector3 ������������������(ulong id) => stVector_number_h8.GET_V(id);
        static public ulong �����������������������������(Vector3 v) => stVector_number_h8.GET_ID(v);
        static public Vector3 �����������������������������(ulong v) => stVector_number_h8.GET_V(v);
    }
}