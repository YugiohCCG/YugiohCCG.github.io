namespace UnityEngine;

public class ColorGamutUtility
{

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static ColorPrimaries GetColorPrimaries(ColorGamut gamut) { }

	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "GetColorEncodingForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static TransferFunction GetTransferFunction(ColorGamut gamut) { }

	[CalledBy(Type = "UnityEngine.Rendering.HDROutputUtils", Member = "GetColorSpaceForGamut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorGamut), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction(IsThreadSafe = True)]
	public static WhitePoint GetWhitePoint(ColorGamut gamut) { }

}

