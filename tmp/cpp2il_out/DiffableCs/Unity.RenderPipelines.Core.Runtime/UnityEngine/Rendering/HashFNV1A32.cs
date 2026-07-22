namespace UnityEngine.Rendering;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct HashFNV1A32
{
	private const uint k_Prime = 16777619; //Field offset: 0x0
	private const uint k_OffsetBasis = 2166136261; //Field offset: 0x0
	private uint m_Hash; //Field offset: 0x0

	public int value
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Append(in int input) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Append(in uint input) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void Append(in bool input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public void Append(in float input) { }

	[CallerCount(Count = 0)]
	public void Append(in double input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public void Append(in Vector2 input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public void Append(in Vector3 input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public void Append(in Vector4 input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void Append(T input) { }

	[CalledBy(Type = typeof(XRSRPSettings), Member = "set_occlusionMeshScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphPass), Member = "ComputeTextureHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashFNV1A32&), typeof(ResourceHandle&), typeof(RenderGraphResourceRegistry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void Append(Delegate del) { }

	[CalledBy(Type = typeof(BufferDesc), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BufferResource), Member = "GetDescHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextureDesc), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	public static HashFNV1A32 Create() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetFuncHashCode(Delegate del) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

