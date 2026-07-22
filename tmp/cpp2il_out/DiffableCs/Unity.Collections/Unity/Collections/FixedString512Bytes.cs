namespace Unity.Collections;

[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
public struct FixedString512Bytes : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	internal struct Enumerator : IEnumerator
	{
		private FixedString512Bytes target; //Field offset: 0x0
		private int offset; //Field offset: 0x200
		private Rune current; //Field offset: 0x204

		public Rune Current
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 7
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 70
		}

		[CallerCount(Count = 0)]
		public Enumerator(FixedString512Bytes other) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void Dispose() { }

		[CallerCount(Count = 0)]
		public Rune get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal const ushort utf8MaxLengthInBytes = 509; //Field offset: 0x0
	[SerializeField]
	internal ushort utf8LengthInBytes; //Field offset: 0x0
	[SerializeField]
	internal FixedBytes510 bytes; //Field offset: 0x2

	public override int Capacity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 6
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override byte Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public override int Length
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 12
	}

	public static int UTF8MaxLengthInBytes
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 57
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes(in FixedString64Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes(in FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes(in FixedString32Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public FixedString512Bytes(in UnsafeText other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public FixedString512Bytes(ReadOnly other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes(in FixedString512Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(Rune), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	public FixedString512Bytes(Rune rune, int count = 1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(CopyError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public FixedString512Bytes(string source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	public FixedString512Bytes(in FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Add(in byte value) { }

	[CallerCount(Count = 0)]
	public FixedList512Bytes<Byte>& AsFixedList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckCapacityInRange(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckCopyError(CopyError error, string source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private static void CheckFormatError(FormatError error) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[IsReadOnly]
	private void CheckIndexInRange(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckLengthInRange(int length) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public override int CompareTo(string other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString64Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString512Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString32Bytes other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override byte ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString32Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString64Bytes other) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString512Bytes other) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "StrCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public override bool Equals(string other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Capacity() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override byte get_Item(int index) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Length() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int get_UTF8MaxLengthInBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	public Enumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ComputeHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override Byte* GetUnsafePtr() { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	internal FormatError Initialize(in FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(CopyError))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	internal CopyError Initialize(string source) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	internal FormatError Initialize(in FixedString512Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(Rune), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	internal FormatError Initialize(Rune rune, int count = 1) { }

	[CalledBy(Type = typeof(FixedString64Bytes), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&)}, ReturnType = typeof(FixedString512Bytes))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	internal FormatError Initialize(in FixedString64Bytes other) { }

	[CalledBy(Type = typeof(FixedString32Bytes), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&)}, ReturnType = typeof(FixedString512Bytes))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	internal FormatError Initialize(in FixedString32Bytes other) { }

	[CalledBy(Type = typeof(FixedString128Bytes), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&)}, ReturnType = typeof(FixedString512Bytes))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 2)]
	internal FormatError Initialize(in FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 1)]
	internal FormatError Initialize(Byte* srcBytes, int srcLength) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(CopyError))]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static bool op_Equality(in FixedString512Bytes a, string b) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedString512Bytes), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(CopyError))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static FixedString512Bytes op_Implicit(string b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "AppendUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Int32&), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(FormatError))]
	[CallsUnknownMethods(Count = 5)]
	public static FixedString4096Bytes op_Implicit(in FixedString512Bytes fs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString4096Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString128Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CopyFromTruncated", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(string)}, ReturnType = typeof(CopyError))]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public static bool op_Inequality(in FixedString512Bytes a, string b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString512Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString32Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedString512Bytes), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in FixedString512Bytes a, in FixedString64Bytes b) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void set_Item(int index, byte value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

