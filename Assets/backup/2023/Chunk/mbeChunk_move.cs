using UnityEditor;
using UnityEngine;
namespace chunk2023
{
    /// <summary>
    /// текущий чанк
    /// </summary>
    public class curtChunk
    {
        /// <summary>
        /// текущий вектор
        /// </summary>
        private Vector3 VECTOR_current;
        /// <summary>
        /// окружающие чанки
        /// </summary>
        private dictChunk_cube[,,] CHs = new dictChunk_cube[3, 3, 3];
        public dictChunk_cube ТекущийЧанк => CHs[1, 1, 1];
        public void ИзменениеВектора(Vector3 v)
        {
            VECTOR_current = v;
        }
    }

    public class mbeChunk_move : mbPosition_step
    {
        public void Инспектор()
        {

        }
        /// <summary>
        /// editor
        /// </summary>
        [CustomEditor(typeof(mbeChunk_move))]
        public new class gui : mbPosition_step.gui
        {
            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();
                (target as mbeChunk_move).Инспектор();
            }
        }
    }
}