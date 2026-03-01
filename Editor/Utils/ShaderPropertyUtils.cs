using System.Linq;

namespace net.puk06.ShadowSyncer.Editor.Utils
{
    internal static class ShaderPropertyUtils
    {
        /*

        // Copyright (c) 2020-present lilxyzw
        // This code is borrowed from liltoon(https://github.com/lilxyzw/lilToon)
        // liltoon is licensed under the MIT License. https://github.com/lilxyzw/lilToon/blob/master/Assets/lilToon/LICENSE

        [lilToggleLeft] _UseShadow                  ("sShadow", Int) = 0
                        _ShadowStrength             ("sStrength", Range(0, 1)) = 1
        [NoScaleOffset] _ShadowStrengthMask         ("sStrength", 2D) = "white" {}
        [lilLOD]        _ShadowStrengthMaskLOD      ("LOD", Range(0, 1)) = 0
        [NoScaleOffset] _ShadowBorderMask           ("sBorder", 2D) = "white" {}
        [lilLOD]        _ShadowBorderMaskLOD        ("LOD", Range(0, 1)) = 0
        [NoScaleOffset] _ShadowBlurMask             ("sBlur", 2D) = "white" {}
        [lilLOD]        _ShadowBlurMaskLOD          ("LOD", Range(0, 1)) = 0
        [lilFFFF]       _ShadowAOShift              ("1st Scale|1st Offset|2nd Scale|2nd Offset", Vector) = (1,0,1,0)
        [lilFF]         _ShadowAOShift2             ("3rd Scale|3rd Offset", Vector) = (1,0,1,0)
        [lilToggle]     _ShadowPostAO               ("sIgnoreBorderProperties", Int) = 0
        [lilEnum]       _ShadowColorType            ("sShadowColorTypes", Int) = 0
                        _ShadowColor                ("Shadow Color", Color) = (0.82,0.76,0.85,1.0)
        [NoScaleOffset] _ShadowColorTex             ("Shadow Color", 2D) = "black" {}
                        _ShadowNormalStrength       ("sNormalStrength", Range(0, 1)) = 1.0
                        _ShadowBorder               ("sBorder", Range(0, 1)) = 0.5
                        _ShadowBlur                 ("sBlur", Range(0, 1)) = 0.1
                        _ShadowReceive              ("sReceiveShadow", Range(0, 1)) = 0
                        _Shadow2ndColor             ("2nd Color", Color) = (0.68,0.66,0.79,1)
        [NoScaleOffset] _Shadow2ndColorTex          ("2nd Color", 2D) = "black" {}
                        _Shadow2ndNormalStrength    ("sNormalStrength", Range(0, 1)) = 1.0
                        _Shadow2ndBorder            ("sBorder", Range(0, 1)) = 0.15
                        _Shadow2ndBlur              ("sBlur", Range(0, 1)) = 0.1
                        _Shadow2ndReceive           ("sReceiveShadow", Range(0, 1)) = 0
                        _Shadow3rdColor             ("3rd Color", Color) = (0,0,0,0)
        [NoScaleOffset] _Shadow3rdColorTex          ("3rd Color", 2D) = "black" {}
                        _Shadow3rdNormalStrength    ("sNormalStrength", Range(0, 1)) = 1.0
                        _Shadow3rdBorder            ("sBorder", Range(0, 1)) = 0.25
                        _Shadow3rdBlur              ("sBlur", Range(0, 1)) = 0.1
                        _Shadow3rdReceive           ("sReceiveShadow", Range(0, 1)) = 0
                        _ShadowBorderColor          ("sShadowBorderColor", Color) = (1,0.1,0,1)
                        _ShadowBorderRange          ("sShadowBorderRange", Range(0, 1)) = 0.08
                        _ShadowMainStrength         ("sContrast", Range(0, 1)) = 0
                        _ShadowEnvStrength          ("sShadowEnvStrength", Range(0, 1)) = 0
        [lilEnum]       _ShadowMaskType             ("sShadowMaskTypes", Int) = 0
                        _ShadowFlatBorder           ("sBorder", Range(-2, 2)) = 1
                        _ShadowFlatBlur             ("sBlur", Range(0.001, 2)) = 1
        */

        internal static string[] LILTOON_SHADOW_SETTINGS_KEYS = new string[]
        {
            "_UseShadow",
            "_ShadowStrength",
            "_ShadowStrengthMask",
            "_ShadowStrengthMaskLOD",
            "_ShadowBorderMask",
            "_ShadowBorderMaskLOD",
            "_ShadowBlurMask",
            "_ShadowBlurMaskLOD",
            "_ShadowAOShift",
            "_ShadowAOShift2",
            "_ShadowPostAO",
            "_ShadowColorType",
            "_ShadowColor",
            "_ShadowColorTex",
            "_ShadowNormalStrength",
            "_ShadowBorder",
            "_ShadowBlur",
            "_ShadowReceive",
            "_Shadow2ndColor",
            "_Shadow2ndColorTex",
            "_Shadow2rdNormalStrength",
            "_Shadow2ndBorder",
            "_Shadow2ndBlur",
            "_Shadow2ndReceive",
            "_Shadow3rdColor",
            "_Shadow3rdColorTex",
            "_Shadow3rdNormalStrength",
            "_Shadow3rdBorder",
            "_Shadow3rdBlur",
            "_Shadow3rdReceive",
            "_ShadowBorderColor",
            "_ShadowBorderRange",
            "_ShadowMainStrength",
            "_ShadowEnvStrength",
            "_ShadowMaskType",
            "_ShadowFlatBorder",
            "_ShadowFlatBlur"
        };

        internal static bool IsShadowProperty(string propertyName) => LILTOON_SHADOW_SETTINGS_KEYS.Contains(propertyName);
    }
}
