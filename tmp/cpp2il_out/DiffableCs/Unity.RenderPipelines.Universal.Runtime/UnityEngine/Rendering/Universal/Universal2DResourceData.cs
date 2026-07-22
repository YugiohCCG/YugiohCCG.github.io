namespace UnityEngine.Rendering.Universal;

internal class Universal2DResourceData : UniversalResourceDataBase
{
	private TextureHandle[][] _lightTextures; //Field offset: 0x18
	private TextureHandle[] _cameraNormalsTexture; //Field offset: 0x20
	private TextureHandle _normalsDepth; //Field offset: 0x28
	private TextureHandle[][] _shadowTextures; //Field offset: 0x38
	private TextureHandle _shadowDepth; //Field offset: 0x40
	private TextureHandle _upscaleTexture; //Field offset: 0x50
	private TextureHandle _cameraSortingLayerTexture; //Field offset: 0x60

	internal TextureHandle cameraSortingLayerTexture
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
		[DeduplicatedMethod]
		internal get { } //Length: 41
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal set { } //Length: 121
	}

	internal TextureHandle[][] lightTextures
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&)}, ReturnType = typeof(TextureHandle[][]))]
		internal get { } //Length: 12
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&), typeof(TextureHandle[][])}, ReturnType = typeof(void))]
		internal set { } //Length: 15
	}

	internal TextureHandle normalsDepth
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
		internal get { } //Length: 41
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		internal set { } //Length: 121
	}

	internal TextureHandle[] normalsTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[]&)}, ReturnType = typeof(TextureHandle[]))]
		internal get { } //Length: 12
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[]&), typeof(TextureHandle[])}, ReturnType = typeof(void))]
		internal set { } //Length: 15
	}

	internal TextureHandle shadowDepth
	{
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
		[DeduplicatedMethod]
		internal get { } //Length: 41
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal set { } //Length: 121
	}

	internal TextureHandle[][] shadowTextures
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&)}, ReturnType = typeof(TextureHandle[][]))]
		internal get { } //Length: 12
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&), typeof(TextureHandle[][])}, ReturnType = typeof(void))]
		internal set { } //Length: 15
	}

	internal TextureHandle upscaleTexture
	{
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
		[DeduplicatedMethod]
		internal get { } //Length: 41
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal set { } //Length: 121
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Universal2DResourceData() { }

	[CalledBy(Type = typeof(Universal2DResourceData), Member = "get_lightTextures", ReturnType = typeof(TextureHandle[][]))]
	[CalledBy(Type = typeof(Universal2DResourceData), Member = "get_shadowTextures", ReturnType = typeof(TextureHandle[][]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private TextureHandle[][] CheckAndGetTextureHandle(ref TextureHandle[][] handle) { }

	[CalledBy(Type = typeof(Universal2DResourceData), Member = "set_lightTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Universal2DResourceData), Member = "set_shadowTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void CheckAndSetTextureHandle(ref TextureHandle[][] handle, TextureHandle[][] newHandle) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[DeduplicatedMethod]
	internal TextureHandle get_cameraSortingLayerTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&)}, ReturnType = typeof(TextureHandle[][]))]
	internal TextureHandle[][] get_lightTextures() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	internal TextureHandle get_normalsDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[]&)}, ReturnType = typeof(TextureHandle[]))]
	internal TextureHandle[] get_normalsTexture() { }

	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[DeduplicatedMethod]
	internal TextureHandle get_shadowDepth() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&)}, ReturnType = typeof(TextureHandle[][]))]
	internal TextureHandle[][] get_shadowTextures() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndGetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle&)}, ReturnType = typeof(TextureHandle))]
	[DeduplicatedMethod]
	internal TextureHandle get_upscaleTexture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void set_cameraSortingLayerTexture(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&), typeof(TextureHandle[][])}, ReturnType = typeof(void))]
	internal void set_lightTextures(TextureHandle[][] value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	internal void set_normalsDepth(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalResourceDataBase), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[]&), typeof(TextureHandle[])}, ReturnType = typeof(void))]
	internal void set_normalsTexture(TextureHandle[] value) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void set_shadowDepth(TextureHandle value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Universal2DResourceData), Member = "CheckAndSetTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[][]&), typeof(TextureHandle[][])}, ReturnType = typeof(void))]
	internal void set_shadowTextures(TextureHandle[][] value) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal void set_upscaleTexture(TextureHandle value) { }

}

