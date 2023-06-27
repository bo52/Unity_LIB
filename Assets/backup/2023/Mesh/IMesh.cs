using class2022;
using UnityEngine;
namespace mesh2023
{
    public interface IMesh
    {
        spBuild.IVertices Вертексы
        {
            get;
            set;
        }
        public void СобратьВертекс<T>(GameObject go, object [] arg=null,string name= "Построить", string файл= "") where T: class,new()
        {
            var obj = new T();
            Вертексы = obj as spBuild.IVertices;
            //Вертексы.GO = go;
            //Вертексы.FILE = файл;

            obj.ВыполнитьМетод(name, new object[] { arg });
        }
    }
}