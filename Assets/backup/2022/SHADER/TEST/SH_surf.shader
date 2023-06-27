Shader "Custom/SH_surf"
{
    SubShader
    {
        CGPROGRAM
        #pragma surface surf Standard
        sampler2D _MainTex;

        struct Input
        {
            float3 color : RED;
        };
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo = IN.color;
            o.Alpha = 1;
        }
        ENDCG
    }
}