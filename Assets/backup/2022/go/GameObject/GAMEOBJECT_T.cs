namespace go2022
{
    using class2022;
    /// <summary>
    /// CLASS<T>
    /// привязка абстрактного моно класса
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GAMEOBJECT<T> : GAMEOBJECT
    {
        public override System.Type МоноКЛАСС => typeof(T); 
        public GAMEOBJECT(object[] atr) : base(atr)
        {
        }
        public GAMEOBJECT() : base(null)
        {
        }

        public T MONO=>this.МоноМодуль<T>();
    }
}
