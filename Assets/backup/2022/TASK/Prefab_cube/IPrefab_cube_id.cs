using System.Collections;
using UnityEngine;
namespace task2022
{
    using utility2022;
    public interface IPrefab_cube_id
    {
        static public ulong Ќулевой»дентификаторЅлока => »дентификаторЅлока(Vector3Int.zero);
        static public ulong »дентификаторЅлока(Vector3 v) => stVector_number_h8.GET_ID(v);
        static public Vector3 »дентификаторЅлока(ulong id) => stVector_number_h8.GET_V(id);
        static public ulong ќбщий»дентификатор–ебраЅлоков(Vector3 v) => stVector_number_h8.GET_ID(v);
        static public Vector3 ќбщий»дентификатор–ебраЅлоков(ulong v) => stVector_number_h8.GET_V(v);
    }
}