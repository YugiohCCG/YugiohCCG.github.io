namespace UnityEngine;

[UsedByNativeCode]
public struct WebCamDevice
{
	[NativeName("name")]
	internal string m_Name; //Field offset: 0x0
	[NativeName("depthCameraName")]
	internal string m_DepthCameraName; //Field offset: 0x8
	[NativeName("flags")]
	internal int m_Flags; //Field offset: 0x10
	[NativeName("kind")]
	internal WebCamKind m_Kind; //Field offset: 0x14
	[NativeName("resolutions")]
	internal Resolution[] m_Resolutions; //Field offset: 0x18

}

