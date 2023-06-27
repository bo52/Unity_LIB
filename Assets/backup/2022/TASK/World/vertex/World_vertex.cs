//using Bo52.constr.PROJ.CLASS;
//namespace Bo52_1510202013173769.CLASS
namespace task2022
{
    using utility2022;
    using UnityEngine;
    /// <summary>
    /// Вершина
    /// мировая простая вершина
    /// </summary>
    public class World_vertex
    {
        [SerializeField] 
        public ulong ИД = 0;
        [SerializeField] 
        public Vector3 КООРДИНАТА = Vector3.zero;
        [SerializeField] 
        public Vector3[] СМЕЩЕНИЕ = new Vector3[] {Vector3.zero, Vector3.zero, Vector3.zero };
        public World_vertex()
        {
        }
        public void Update(ulong id, Vector3 v)
        {
            КООРДИНАТА = v;
            ИД = id;
        }
        public World_vertex(Vector3 v)=>Update(v);
        public World_vertex(ulong id)=>Update(id);
        public World_vertex(ulong id, Vector3 v)=>Update(id,v);
        public void Update(Vector3 v)=>Update(stVector_number_h8.GET_ID(v), v);
        public void Update(ulong id)=>Update(id, stVector_number_h8.GET_V(id));
    }
}
