namespace UnityEngine.Rendering.Universal;

internal struct PostProcessParams
{
	public Material blitMaterial; //Field offset: 0x0
	public GraphicsFormat requestColorFormat; //Field offset: 0x8

	[CalledBy(Type = typeof(UniversalRenderer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRendererData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static PostProcessParams Create() { }

}

