//empty
//empty
//empty
using System.Collections.Generic;
namespace LIB.st2307091409
{
    /// <summary>
    ///
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// СоздатьЭкземпляр
        /// </summary>
        static public T fun230709140900_СоздатьЭкземпляр<T>(object[] args) where T : class
        {
            System.Type TestType = typeof(T);
            if (TestType == null) return null;
            var ts = new List<System.Type>();
            foreach (var arg in args) ts.Add(arg.GetType());
            System.Reflection.ConstructorInfo ci = TestType.GetConstructor(ts.ToArray());
            return ci.Invoke(args) as T;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        /// <returns></returns>
        static public T fun230709140901_СоздатьЭкземпляр<T>(object arg) where T : class => fun230709140900_СоздатьЭкземпляр<T>(new object[] { arg });
        ///exit
    }
}
