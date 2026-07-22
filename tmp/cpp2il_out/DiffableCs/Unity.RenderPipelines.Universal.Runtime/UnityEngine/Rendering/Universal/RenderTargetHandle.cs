namespace UnityEngine.Rendering.Universal;

[Obsolete("Deprecated in favor of RTHandle", True)]
public struct RenderTargetHandle
{
	public static readonly RenderTargetHandle CameraTarget; //Field offset: 0x0
	[CompilerGenerated]
	private int <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RenderTargetIdentifier <rtid>k__BackingField; //Field offset: 0x8

	public int id
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	private RenderTargetIdentifier rtid
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		private get { } //Length: 29
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 26
	}

	[CallerCount(Count = 0)]
	private static RenderTargetHandle() { }

	[CallerCount(Count = 0)]
	public RenderTargetHandle(RenderTargetIdentifier renderTargetIdentifier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RenderTargetHandle(RTHandle rtHandle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(RenderTargetHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderTargetHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle), typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderTargetHandle), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle), typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RenderTargetHandle), Member = "Identifier", ReturnType = typeof(RenderTargetIdentifier))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool Equals(RenderTargetHandle other) { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_id() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	private RenderTargetIdentifier get_rtid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static RenderTargetHandle GetCameraTarget(ref CameraData cameraData) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool HasInternalRenderTargetId() { }

	[CalledBy(Type = typeof(RenderTargetHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CubemapFace), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	public RenderTargetIdentifier Identifier() { }

	[CallerCount(Count = 0)]
	public void Init(RenderTargetIdentifier renderTargetIdentifier) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public void Init(string shaderProperty) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	public static bool op_Equality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetHandle), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetHandle)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_id(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_rtid(RenderTargetIdentifier value) { }

}

