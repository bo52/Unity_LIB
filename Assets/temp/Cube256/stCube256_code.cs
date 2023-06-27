using UnityEngine;
namespace cube2023
{
    public static class stCube256_code
    {
        //код не чётный
        public static bool ПервыйИндексКодаСуществует(this byte КОД) => (КОД % 2) != 0;
        public static bool ПервыйИндексКодаСуществует(this float КОД) => (КОД % 2) != 0;
        public static bool Между(this byte КОД, float min, float max) => КОД >= min && КОД <= max;
        public static bool НомерВершиныСуществуетВКоде(this byte n, byte КОД)
        {
            switch (n)
            {
                case 0: return ПервыйИндексКодаСуществует(КОД);
                case 6: return КОД.Между(64, 127) || КОД.Между(192, 255);
                case 7: return КОД >= 128;
            }

            var pow = Mathf.Pow(2, n);
            var next = pow - 1;
            var pow2 = 2 * pow;

            System.Func<bool> f = () =>
            {
                if (КОД.Между(pow, pow + next)) return true;
                pow += pow2;
                return false;
            };

            if (f())
                return true;
            while (pow < byte.MaxValue)
                if (f())
                    return true;
            return false;
        }
    }
}