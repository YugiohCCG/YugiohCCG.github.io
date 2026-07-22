namespace UnityEngine.UIElements;

internal struct TextureId
{
	public static readonly TextureId invalid; //Field offset: 0x0
	private readonly int m_Index; //Field offset: 0x0

	public int index
	{
		[CalledBy(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	private static TextureId() { }

	[CallerCount(Count = 0)]
	public TextureId(int index) { }

	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextureSlotManager), Member = "SetGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TextureId), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public float ConvertToGpu() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(TextureSlotManager), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	public int get_index() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(TextureId left, TextureId right) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(TextureId left, TextureId right) { }

}

