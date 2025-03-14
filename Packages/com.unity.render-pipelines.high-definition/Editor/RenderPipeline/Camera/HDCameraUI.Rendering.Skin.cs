using UnityEngine;

namespace UnityEditor.Rendering.HighDefinition
{
    static partial class HDCameraUI
    {
        partial class Rendering
        {
            class Styles
            {
                public static readonly GUIContent antialiasing = EditorGUIUtility.TrTextContent("Post Anti-aliasing", "The postprocess anti-aliasing method to use.");
                public static readonly GUIContent antialiasingContentFallback = EditorGUIUtility.TrTextContent("Fallback Post Anti-aliasing", "The postprocess anti-aliasing method to use as a fallback.");

                public static readonly GUIContent SMAAQualityPresetContent = EditorGUIUtility.TrTextContent("Quality Preset", "The quality preset for SMAA, low has the best performance but worst quality, High has the highest quality but worst performance.");

                public static readonly GUIContent TAASharpen = EditorGUIUtility.TrTextContent("Sharpen Strength", "The intensity of the sharpen filter used to counterbalance the blur introduced by TAA. A high value might create artifacts such as dark lines depending on the frame content.");
                public static readonly GUIContent TAARingingReduction = EditorGUIUtility.TrTextContent("Ringing Reduction", "How much the sharpening result is taken from the result without ringing. This reduces unnatural dark outlines, but might also decrease the impact of sharpening. Values above 0.0 lead to extra cost.");

                public static readonly GUIContent TAAHistorySharpening = EditorGUIUtility.TrTextContent("History Sharpening", "Values closer to 0 lead to softer look when movement is detected, but can further reduce aliasing. Values closer to 1 lead to sharper results, with the risk of reintroducing a bit of aliasing.");
                public static readonly GUIContent TAAAntiFlicker = EditorGUIUtility.TrTextContent("Anti-flickering", "With high values flickering might be reduced, but it can lead to more ghosting or disocclusion artifacts.");
                public static readonly GUIContent TAAMotionVectorRejection = EditorGUIUtility.TrTextContent("Speed Rejection", "Higher this value, more likely history will be rejected when current and reprojected history motion vector differ by a substantial amount. High values can decrease ghosting but will also reintroduce aliasing on the aforementioned cases.");
                public static readonly GUIContent TAAQualityLevel = EditorGUIUtility.TrTextContent("Quality Preset", "Low quality is fast, but can lead to more ghosting and blurrier output when moving, Medium quality has better ghosting handling and sharper results upon movement, High allows for velocity rejection policy, has better antialiasing and has mechanism to combat ringing for over sharpening the history.");
                public static readonly GUIContent TAASharpeningMode = EditorGUIUtility.TrTextContent("Sharpening Mode", "Low quality is fast, but is prone to artifact and sub-optimal results, PostSharpen is more expensive, but leads to higher quality sharpening. Finally CAS will also be of higher quality than Low Quality option, offering strong sharpening but limited control.");
                public static readonly GUIContent TAAAntiRinging = EditorGUIUtility.TrTextContent("Anti-ringing", "When enabled, ringing artifacts (dark or strangely saturated edges) caused by history sharpening will be improved. This comes at a potential loss of sharpness upon motion.");
                // Advanced TAA
                public static readonly GUIContent TAABaseBlendFactor = EditorGUIUtility.TrTextContent("Base Blend Factor", "Determines how much the history buffer is blended together with current frame result. Higher values means more history contribution, which leads to better anti aliasing, but also more prone to ghosting.");
                public static readonly GUIContent TAAJitterScale = EditorGUIUtility.TrTextContent("Jitter Scale", "Determines the scale to the jitter applied when TAA is enabled. Lowering this value will lead to less visible flickering and jittering, but also will produce more aliased images.");

                public static readonly GUIContent renderingPath = EditorGUIUtility.TrTextContent("Custom Frame Settings", "Define custom values for Frame Settings for this Camera to use.");
                public static readonly GUIContent fullScreenPassthrough = EditorGUIUtility.TrTextContent("Fullscreen Passthrough", "This will skip rendering settings to directly rendering in fullscreen(for instance: Useful for video)");
                public static readonly GUIContent exposureTarget = EditorGUIUtility.TrTextContent("Exposure Target", "The object used as a target for centering the Exposure's Procedural Mask metering mode when target object option is set (See Exposure Volume Component).");

                public static readonly GUIContent allowDynamicResolution = EditorGUIUtility.TrTextContent("HDRP Dynamic Resolution", "Whether to support HDRP dynamic resolution.");
                public const string taauInfoBox = "When TAA Upsample is enabled, TAA is run as antialiasing algorithm and uses High Quality as base, to select other anti-aliasing methods please change upscale filter for dynamic resolution.";

                public const string DLSSFeatureDetectedMsg = "Unity detected NVIDIA Deep Learning Super Sampling and will ignore the Fallback Anti Aliasing Method.";
                public const string DLSSFeatureNotDetectedMsg = "Unity cannot detect NVIDIA Deep Learning Super Sampling and will use the Fallback Anti Aliasing Method instead.";
                public const string DLSSNotEnabledInQualityAsset = "The quality asset in this project does not have NVIDIA Deep Learning Super Sampling (DLSS) enabled. DLSS will not be running on this camera.";
                public static readonly GUIContent DLSSAllow = EditorGUIUtility.TrTextContent("Allow DLSS", "Allows DLSS for this camera. For the effect to be enabled, it must be set in the quality asset of this project.");
                public static readonly GUIContent DLSSCustomQualitySettings = EditorGUIUtility.TrTextContent("Use DLSS Custom Quality", "");
                public static readonly GUIContent DLSSUseCustomAttributes = EditorGUIUtility.TrTextContent("Use DLSS Custom Attributes", "");
                public static readonly GUIContent fsrOverrideSharpness = EditorGUIUtility.TrTextContent("Override FSR Sharpness", "Overrides the FSR sharpness value for this camera.");
                public static readonly GUIContent FSR2Allow = EditorGUIUtility.TrTextContent("Allow FSR2", "Allows FSR2 for this camera. For the effect to be enabled, it must be set in the quality asset of this project.");
                public static readonly GUIContent FSR2CustomQualitySettings = EditorGUIUtility.TrTextContent("Use FSR2 Custom Quality", "");
                public static readonly GUIContent FSR2UseCustomAttributes = EditorGUIUtility.TrTextContent("Use FSR2 Custom Attributes", "");
                public static GUIContent overrideSettingText { get; } = EditorGUIUtility.TrTextContent("", "If enabled, this camera setting will be used instead of the one specified in the quality asset of this project.");

                public const string FSR2FeatureDetectedMsg = "Unity detected AMD Fidelity FX 2 Super Resolution and will ignore the Fallback Anti Aliasing Method.";
                public const string FSR2FeatureNotDetectedMsg = "Unity cannot detect AMD Fidelity FX 2 Super Resolution and will use the Fallback Anti Aliasing Method instead.";
                public const string FSR2NotEnabledInQualityAsset = "The quality asset in this project does not have Fidelity FX 2 Super Resolution (FSR2) enabled. FSR2 will not be running on this camera.";

            }
        }
    }
}
