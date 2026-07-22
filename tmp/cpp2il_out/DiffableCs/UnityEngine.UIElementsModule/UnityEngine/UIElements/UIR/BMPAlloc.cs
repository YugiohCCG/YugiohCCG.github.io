namespace UnityEngine.UIElements.UIR;

internal struct BMPAlloc
{
	public static readonly BMPAlloc Invalid; //Field offset: 0x0
	public int page; //Field offset: 0x0
	public ushort pageLine; //Field offset: 0x4
	public byte bitIndex; //Field offset: 0x6
	public OwnedState ownedState; //Field offset: 0x7

	[CallerCount(Count = 0)]
	private static BMPAlloc() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Equals(BMPAlloc other) { }

	[CalledBy(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetClipRectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetOpacityValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

