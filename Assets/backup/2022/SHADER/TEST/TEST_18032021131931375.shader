Shader "Custom/SHADER_18032021131931375"
{
    Properties
    {
        _Color("Color", Color) = (1, 1, 1, 1)
        _offset("Offset",int) = 1
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

        CGPROGRAM
       #include "UnityCG.cginc"        
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Lambert vertex:vert fullforwardshadows
        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 5.0
        //RWStructuredBuffer<float3> _myBuffer : register(u1);
        sampler2D _MainTex;
        bool _offset;
        fixed4 _Color;

        struct Input
        {
            float2 uv_MainTex;
            float2 CubeUV1;
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
            //текущая координата вершины
            if (_offset == 0)
            {
                float4 w = mul(unity_ObjectToWorld, v.vertex);
                w.xyz = float3(v.texcoord6.x, v.texcoord6.y, v.texcoord7.x);
                v.vertex = mul(unity_WorldToObject, w);
            }
        }

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.CubeUV1) * _Color;
            o.Albedo = c.rgb;
            o.Alpha = 1;
    }
    ENDCG
    }
        FallBack "Diffuse"
}

