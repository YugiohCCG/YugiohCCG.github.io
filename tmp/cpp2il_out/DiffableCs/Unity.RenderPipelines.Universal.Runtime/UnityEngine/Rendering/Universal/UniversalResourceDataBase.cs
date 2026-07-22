namespace UnityEngine.Rendering.Universal;

public abstract class UniversalResourceDataBase : ContextItem
{
	public enum ActiveID
	{
		Camera = 0,
		BackBuffer = 1,
	}

	[CompilerGenerated]
	private bool <isAccessible>k__BackingField; //Field offset: 0x10

	internal bool isAccessible
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 370
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected UniversalResourceDataBase() { }

	[CallerCount(Count = 28)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected TextureHandle CheckAndGetTextureHandle(ref TextureHandle handle) { }

	[CalledBy(Type = typeof(Universal2DResourceData), Member = "get_normalsTexture", ReturnType = typeof(TextureHandle[]))]
	[CalledBy(Type = typeof(UniversalResourceData), Member = "get_gBuffer", ReturnType = typeof(TextureHandle[]))]
	[CalledBy(Type = typeof(UniversalResourceData), Member = "get_dBuffer", ReturnType = typeof(TextureHandle[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected TextureHandle[] CheckAndGetTextureHandle(ref TextureHandle[] handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void CheckAndSetTextureHandle(ref TextureHandle handle, TextureHandle newHandle) { }

	[CalledBy(Type = typeof(Universal2DResourceData), Member = "set_normalsTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalResourceData), Member = "set_gBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalResourceData), Member = "set_dBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected void CheckAndSetTextureHandle(ref TextureHandle[] handle, TextureHandle[] newHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected bool CheckAndWarnAboutAccessibility() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	internal void EndFrame() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal bool get_isAccessible() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal void InitFrame() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_isAccessible(bool value) { }

}

