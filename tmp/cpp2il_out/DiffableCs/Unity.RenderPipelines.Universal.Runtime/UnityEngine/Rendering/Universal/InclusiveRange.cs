namespace UnityEngine.Rendering.Universal;

internal struct InclusiveRange
{
	public short start; //Field offset: 0x0
	public short end; //Field offset: 0x2

	public static InclusiveRange empty
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 13
	}

	public bool isEmpty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InclusiveRange(short startEnd) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public InclusiveRange(short start, short end) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	public void Clamp(short min, short max) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Contains(short index) { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "ExpandRangeOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InclusiveRange&), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	public void Expand(short index) { }

	[CallerCount(Count = 0)]
	public static InclusiveRange get_empty() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_isEmpty() { }

	[CalledBy(Type = typeof(TilingJob), Member = "TileLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "TileLightOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TilingJob), Member = "TileReflectionProbe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
	public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

