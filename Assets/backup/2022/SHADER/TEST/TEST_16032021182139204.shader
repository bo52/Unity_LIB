Shader "Custom/SHADER_16032021182139204"
{
    Properties
    {
        _pov("pov", int) = 0
        _x("x", int) = 0
        _y("y", int) = 0
        _z("z", int) = 0
        _Color("Color", Color) = (1, 1, 1, 1)
        _offset("offset",int) = 1
        _cut("cut",int) = 1
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
        SubShader
        {
            Tags { "RenderType" = "Opaque" }
            LOD 200

            CGPROGRAM
            #include "UnityCG.cginc"        
            #pragma surface surf Lambert vertex:vert fullforwardshadows
            #pragma target 5.0
            sampler2D _MainTex;
            bool _offset;
            int _cut;
            int _pov;
            int _x;
            int _y;
            int _z;
            fixed4 _Color;

            struct Input
            {
                float2 uv_MainTex;
                float2 CubeUV1;
                float2 CubeUV2;
                float2 CubeUV3;
                float2 CubeUV5;
                //float2 CubeUV6;
                //float closeB;
                float3 w;
            };
            struct appdata
            {
                float4 vertex    : POSITION;  // The vertex position in model space.
                float3 normal    : NORMAL;    // The vertex normal in model space.
                float4 texcoord0 : TEXCOORD0; // The first UV coordinate.
                float4 texcoord1 : TEXCOORD1; // The second UV coordinate.
                float4 texcoord2 : TEXCOORD2; // The third UV coordinate.
                float4 texcoord3 : TEXCOORD3; // The fourfth UV coordinate.
                float4 texcoord4 : TEXCOORD4; // The fifth UV coordinate. // requires Unity 2018.2+
                float4 texcoord5 : TEXCOORD5; // The sixth UV coordinate. // requires Unity 2018.2+
                float4 texcoord6 : TEXCOORD6; // The seventh UV coordinate. // requires Unity 2018.2+
                float4 texcoord7 : TEXCOORD7; // The eigthieth UV coordinate. // requires Unity 2018.2+ // maximum amount of channels supported              
                float4 tangent   : TANGENT;   // The tangent vector in Model Space (used for normal mapping).
                float4 color     : COLOR;     // Per-vertex color
            };

            // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
            // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
            // #pragma instancing_options assumeuniformscaling
            UNITY_INSTANCING_BUFFER_START(Props)
                // put more per-instance properties here
            UNITY_INSTANCING_BUFFER_END(Props)

            void vert(inout appdata v,out Input o)
            {
                UNITY_INITIALIZE_OUTPUT(Input, o);
                o.CubeUV1 = v.texcoord0;
                o.CubeUV2 = v.texcoord1;
                o.CubeUV3 = v.texcoord2;
                o.CubeUV5 = v.texcoord4;
                //o.CubeUV6 = v.texcoord5;
                //o.closeB = v.texcoord7.y;
                //текущая координата вершины
                if (_offset == 0) 
                {
                    float4 w = mul(unity_ObjectToWorld, v.vertex);
                    w.xyz = float3(v.texcoord6.x, v.texcoord6.y, v.texcoord7.x);
                    v.vertex = mul(unity_WorldToObject, w);
                }
            }

            int my_clip(Input IN)
            {
                //
                //нулевой вектор
                //вектор блока
                int d = -1;
                int k = 1;
                switch (_pov)
                {
                case 0:
                    if (_z < 1) k = 0;
                    d = _z == 1?-1:
                        _z == 0? 1: 
                        _z < 0? 1 : 1;
                    break;
                case 1:
                    if (_x < 1) k = 0;
                    d = _x == -1 ? 1 : _x+1 > 0?1:-1;
                    break;
                case 2:
                    if (_z < 1) k = 0;
                    d = _z == -1 ? 1: _z < 0 ?-1:1 ;
                    break;
                case 3:
                    if (_x < 1) k = 0;
                    d = _x == 1 ? -1 : 1;
                    break;
                }
                int X = (int)(IN.CubeUV5.x + d * 0.001);
                int Z = (int)(IN.CubeUV5.y + d * 0.001);

                int x = (int)(IN.CubeUV2.x + d * 0.001);
                int z = (int)(IN.CubeUV3.x + d * 0.001);
                switch (_pov)
                {
                case 0:return Z + z + k < _z ? -1 : 1;
                case 1:return X + x - k > _x ? -1 : 1;
                case 2:return Z + z - k > _z ? -1 : 1;
                case 3:return X + x + k < _x ? -1 : 1;
                }
                return 1;
            }

            void surf(Input IN, inout SurfaceOutput o)
            {
                clip(_cut==1?1:my_clip(IN));
                fixed4 c = tex2D(_MainTex, IN.CubeUV1)*_Color;
                if (
                    frac(IN.CubeUV1.x)>0.5&& frac(IN.CubeUV1.x)<0.51 && 
                    frac(IN.CubeUV1.y) > 0.5 && frac(IN.CubeUV1.y) < 0.51)
                    c = fixed4 (0.8, 0, 0, 1);

                o.Albedo = c.rgb;
                o.Alpha = 1;
        }
        ENDCG
        }
//FallBack "Diffuse"
}
