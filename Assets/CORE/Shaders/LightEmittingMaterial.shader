Shader "Custom/LightEmittingMaterial"
{
    Properties
    {
        _EmissionMap ("Emission Map", 2D) = "white" {}
        _EmissionColor ("Emission Color", Color) = (1, 1, 1, 1)
        _EmissionStrength ("Emission Strength", Range(0, 10)) = 1
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            sampler2D _EmissionMap;
            float4 _EmissionColor;
            float _EmissionStrength;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            half4 frag (v2f i) : SV_Target
            {
                half4 col = tex2D(_EmissionMap, i.uv) * _EmissionColor;
                col.rgb *= _EmissionStrength; // Ajustar la intensidad de la emisión
                return col;
            }
            ENDCG
        }
    }
}
