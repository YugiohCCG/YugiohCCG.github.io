namespace System.Numerics;

[DefaultMember("Item")]
[Intrinsic]
public struct Vector : IEquatable<Vector`1<T>>, IFormattable
{
	private struct VectorSizeHelper
	{
		internal Vector<T> _placeholder; //Field offset: 0x0
		internal byte _byte; //Field offset: 0x0

	}

	private static readonly int s_count; //Field offset: 0x0
	private static readonly Vector<T> s_zero; //Field offset: 0x0
	private static readonly Vector<T> s_one; //Field offset: 0x0
	private static readonly Vector<T> s_allOnes; //Field offset: 0x0
	private Register register; //Field offset: 0x0

	public static int Count
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[Intrinsic]
		 get { } //Length: 151
	}

	public T Item
	{
		[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Vector`1), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Vector`1), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = "System.Numerics.Vector`1<T>")]
		[CalledBy(Type = "Unity.Burst.Unsafe", Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), "T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 94)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 60)]
		[DeduplicatedMethod]
		[Intrinsic]
		 get { } //Length: 2654
	}

	public static Vector<T> Zero
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[Intrinsic]
		 get { } //Length: 159
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "InitializeCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Vector`1), Member = "GetOneValue", ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector`1), Member = "GetAllBitsSetValue", ReturnType = "T")]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	private static Vector`1() { }

	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Vector`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 238)]
	[DeduplicatedMethod]
	[Intrinsic]
	public Vector`1(T value) { }

	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	internal Vector`1(Void* dataPointer) { }

	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = "System.Numerics.Vector`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 62)]
	[DeduplicatedMethod]
	internal Vector`1(Void* dataPointer, int offset) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private Vector`1(ref Register existingRegister) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 194)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Intrinsic]
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[CalledBy(Type = typeof(SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(int), typeof(Char&), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Vector`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Vector`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector`1), Member = "ScalarEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 22)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Intrinsic]
	public override bool Equals(Vector<T> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static int get_Count() { }

	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Vector`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Vector`1), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = "System.Numerics.Vector`1<T>")]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 94)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 60)]
	[DeduplicatedMethod]
	[Intrinsic]
	public T get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static Vector<T> get_Zero() { }

	[CalledBy(Type = typeof(Vector`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 53)]
	[DeduplicatedMethod]
	private static T GetAllBitsSetValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(short), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(sbyte), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 136)]
	[CallsUnknownMethods(Count = 132)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(Vector`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 53)]
	[DeduplicatedMethod]
	private static T GetOneValue() { }

	[CalledBy(Type = typeof(Vector`1), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	private static int InitializeCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }

	[CalledBy(Type = typeof(__DTString), Member = "get_Length", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "LocateFirstFoundChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Numerics.Vector`1<System.UInt16>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpanHelpers), Member = "LocateLastFoundChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Numerics.Vector`1<System.UInt16>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Vector), Member = "AsVectorUInt64", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(System.Numerics.Vector`1<System.UInt64>))]
	[CallerCount(Count = 5)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	[Intrinsic]
	public static Vector<UInt64> op_Explicit(Vector<T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }

	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Vector`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.Vector`1<T>", "System.Numerics.Vector`1<T>"}, ReturnType = "System.Numerics.Vector`1<T>")]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Void*", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.Unsafe", Member = "WriteUnaligned", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 63)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool ScalarEquals(T left, T right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Vector`1), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(Vector`1), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Vector`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

