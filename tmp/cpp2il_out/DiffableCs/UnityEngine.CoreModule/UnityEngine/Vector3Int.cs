namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	private static readonly Vector3Int s_Zero; //Field offset: 0x0
	private static readonly Vector3Int s_One; //Field offset: 0xC
	private static readonly Vector3Int s_Up; //Field offset: 0x18
	private static readonly Vector3Int s_Down; //Field offset: 0x24
	private static readonly Vector3Int s_Left; //Field offset: 0x30
	private static readonly Vector3Int s_Right; //Field offset: 0x3C
	private static readonly Vector3Int s_Forward; //Field offset: 0x48
	private static readonly Vector3Int s_Back; //Field offset: 0x54
	private int m_X; //Field offset: 0x0
	private int m_Y; //Field offset: 0x4
	private int m_Z; //Field offset: 0x8

	public static Vector3Int one
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 75
	}

	public int x
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public int y
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int z
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static Vector3Int zero
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 74
	}

	[CallerCount(Count = 0)]
	private static Vector3Int() { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "K4os.Compression.LZ4.Streams.Internal.Stash", Member = "AsSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Span`1<Byte>")]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "K4os.Hash.xxHash.XXH32", Member = "DigestOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlySpan`1<Byte>"}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public Vector3Int(int x, int y, int z) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Vector3Int other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	public static Vector3Int get_one() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_x() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public int get_y() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public int get_z() { }

	[CallerCount(Count = 0)]
	public static Vector3Int get_zero() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "GetBakingHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BoundsInt), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) { }

	[CallerCount(Count = 0)]
	public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector3Int op_Division(Vector3Int a, int b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	[CallerCount(Count = 0)]
	public static Vector3 op_Implicit(Vector3Int v) { }

	[CallerCount(Count = 0)]
	public static Vector3Int op_Multiply(Vector3Int a, int b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_x(int value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_y(int value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_z(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

