namespace UnityEngine.UIElements;

internal struct ColorPage
{
	public bool isValid; //Field offset: 0x0
	public Color32 pageAndID; //Field offset: 0x4

	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ColorAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[CallsUnknownMethods(Count = 1)]
	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	[CalledBy(Type = typeof(BorderParams), Member = "ToNativeParams", ReturnType = typeof(NativeBorderParams))]
	[CalledBy(Type = typeof(RectangleParams), Member = "ToNativeParams", ReturnType = typeof(NativeRectParams))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public NativeColorPage ToNativeColorPage() { }

}

