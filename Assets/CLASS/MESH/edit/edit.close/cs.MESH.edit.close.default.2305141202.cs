//empty
//empty
//построить куб
using UnityEngine;
namespace LIB.cs2305141202
{
    /// <summary>
    /// interface Закрыть МЕШ
    /// </summary>
    public interface IClass
    {
        System.Action<cs2305141208.IClass> ФункцияПостройки { get; }
        Mesh Закрыть(cs2305141208.IClass editor);
    }
    public class Class
    {
        private System.Action<cs2305141208.IClass> _fun_build;
        public System.Action<cs2305141208.IClass> ФункцияПостройки => _fun_build;
        public Class(System.Action<cs2305141208.IClass> ФункцияПостройки)
        {
            this._fun_build = ФункцияПостройки;
        }
        public virtual Mesh Закрыть(cs2305141208.IClass editor)
        {
            ФункцияПостройки(this as cs2305141208.IClass);
            return editor.ПолучитьМеш();
        }
    }
}