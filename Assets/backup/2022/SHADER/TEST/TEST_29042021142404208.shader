Shader "Custom/SHADER_29042021142404208"
{
    Properties
    {
        _Color("Color", Color) = (1, 1, 1, 1)
        _MainTex("Albedo (RGB)", 2D) = "white" { }
        _Glossiness("Smoothness", Range(0, 1)) = 0.5
        _Metallic("Metallic", Range(0, 1)) = 0.0
        _k("k", Range(0.001, 2)) = 0.00
    }
    SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200
        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows
        #pragma target 3.0
        sampler2D _MainTex;
        struct Input
        {
            float2 uv_MainTex;
        };
        half _Glossiness;
        half _Metallic;
        float _k;
        fixed4 _Color;
        UNITY_INSTANCING_BUFFER_START(Props)
        UNITY_INSTANCING_BUFFER_END(Props)
        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            float2 uv = IN.uv_MainTex;
            int x = (int)(uv.x + 0.01);
            int y = (int)(uv.y + 0.01);

            int X = x %2==0 ? 0 : 1;
            int Y = y %2==0 ? 0 : 1;

            //uv = IN.uv_MainTex;
            if (Y == 1)
            {
                //uv.y = 0.9 - frac(uv.y);

            } 
            else
            {
                //uv.y = uv.y + 1.03;
            }
            if (X == 1)
            {
                //x = frac(uv.x);
                //if (x>0.1)
                //uv.x = 1 - frac(uv.x);
            }
            else 
            {
                //uv.x = 1;
            }
            //uv.x = 0;
            //uv.y = 0;
            //if (uv.x < 0.5) uv.x = 0;
            //if (uv.y < 0.5) uv.y = 0;

            fixed4 c = tex2D(_MainTex, uv) * _Color;
            o.Albedo = c.rgb;
            //o.Metallic = _Metallic;
            //o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
