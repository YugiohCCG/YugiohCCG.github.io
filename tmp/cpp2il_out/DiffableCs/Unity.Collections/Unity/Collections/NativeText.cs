namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility]
[NativeContainer]
public struct NativeText : INativeList<Byte>, IIndexable<Byte>, INativeDisposable, IDisposable, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	internal struct Enumerator : IEnumerator<Rune>, IEnumerator, IDisposable
	{
		private ReadOnly target; //Field offset: 0x0
		private int offset; //Field offset: 0x8
		private Rune current; //Field offset: 0xC

		public override Rune Current
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 67
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Enumerator(NativeText source) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Enumerator(ReadOnly source) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override Rune get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unicode), Member = "Utf8ToUcs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rune&), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : INativeList<Byte>, IIndexable<Byte>, IUTF8Bytes, IComparable<String>, IEquatable<String>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeText* m_Data; //Field offset: 0x0

		public override int Capacity
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 77
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override bool IsEmpty
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(UnsafeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 19
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override byte Item
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 62
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public override int Length
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 157
			[CallerCount(Count = 13327)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		[CreateProperty]
		[EditorBrowsable(EditorBrowsableState::Never (1))]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		public string Value
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
			[DeduplicatedMethod]
			 get { } //Length: 88
		}

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal ReadOnly(UnsafeText* text) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		internal static void CheckNull(Void* dataPtr) { }

		[CallerCount(Count = 13327)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[DeduplicatedMethod]
		[IsReadOnly]
		private void CheckRead() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Clear() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(FixedString128Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(FixedString32Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(FixedString4096Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(NativeText other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(FixedString512Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
		public override int CompareTo(FixedString64Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText), typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(UnsafeText&)}, ReturnType = typeof(int))]
		public int CompareTo(ReadOnly other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeText), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public override int CompareTo(string other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public override byte ElementAt(int index) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
		public override bool Equals(FixedString32Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
		public override bool Equals(NativeText other) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText), typeof(UnsafeText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeText&), typeof(UnsafeText&)}, ReturnType = typeof(bool))]
		public bool Equals(ReadOnly other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeText), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ExcludeFromBurstCompatTesting("Takes managed string")]
		public override bool Equals(string other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnsafeText), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 11)]
		[ContainsUnimplementedInstructions]
		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public virtual bool Equals(object other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
		public override bool Equals(FixedString128Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
		public override bool Equals(FixedString512Bytes other) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
		public override bool Equals(FixedString4096Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
		public override bool Equals(FixedString64Bytes other) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		[Conditional("UNITY_DOTS_DEBUG")]
		private void ErrorWrite() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override int get_Capacity() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override bool get_IsEmpty() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override byte get_Item(int index) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		public override int get_Length() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		public string get_Value() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Enumerator GetEnumerator() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "ComputeHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		public override Byte* GetUnsafePtr() { }

		[CalledBy(Type = typeof(ReadOnly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool op_Equality(in ReadOnly a, in FixedString64Bytes b) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool op_Equality(in ReadOnly a, in FixedString4096Bytes b) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool op_Equality(in ReadOnly a, in FixedString512Bytes b) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool op_Equality(in ReadOnly a, in FixedString32Bytes b) { }

		[CalledBy(Type = typeof(ReadOnly), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ReadOnly), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		public static bool op_Equality(in ReadOnly a, in FixedString128Bytes b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(in ReadOnly a, in FixedString128Bytes b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(in ReadOnly a, in FixedString512Bytes b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(in ReadOnly a, in FixedString64Bytes b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(in ReadOnly a, in FixedString4096Bytes b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
		public static bool op_Inequality(in ReadOnly a, in FixedString32Bytes b) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void set_Capacity(int value) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public void set_IsEmpty(bool value) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void set_Item(int index, byte value) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void set_Length(int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		[ExcludeFromBurstCompatTesting("Returns managed string")]
		public virtual string ToString() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	}

	public const int MaxCapacity = 2147483646; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeText* m_Data; //Field offset: 0x0

	public override int Capacity
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 77
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 99
	}

	public bool IsCreated
	{
		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 19
	}

	public override byte Item
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 62
		[CallerCount(Count = 0)]
		 set { } //Length: 75
	}

	public override int Length
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 157
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 11
	}

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 88
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public NativeText(string source, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public NativeText(in FixedString4096Bytes source, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(in FixedString512Bytes source, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public NativeText(in FixedString512Bytes source, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(in FixedString128Bytes source, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public NativeText(in FixedString128Bytes source, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(in FixedString64Bytes source, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(in FixedString4096Bytes source, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public NativeText(in FixedString64Bytes source, AllocatorHandle allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public NativeText(in FixedString32Bytes source, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(Allocator allocator) { }

	[CalledBy(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int), typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ToLowerAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle), typeof(System.ReadOnlySpan`1<Unity.Collections.Unicode+Rune>)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "TrimStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(int), typeof(int)}, ReturnType = typeof(NativeText))]
	[CalledBy(Type = typeof(FixedStringMethods), Member = "ToUpperAscii", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(AllocatorHandle)}, ReturnType = typeof(NativeText))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(UnsafeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	public NativeText(int capacity, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(int capacity, Allocator allocator) { }

	[CalledBy(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(Unicode), Member = "Utf16ToUtf8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(Int32&), typeof(int)}, ReturnType = typeof(ConversionError))]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long), typeof(long), typeof(AllocatorHandle), typeof(long), typeof(int)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public NativeText(string source, AllocatorHandle allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeText), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes&), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public NativeText(in FixedString32Bytes source, Allocator allocator) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public void Add(in byte value) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public ReadOnly AsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void CheckIndexInRange(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	internal static void CheckNull(Void* dataPtr) { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckRead() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	private void CheckWrite() { }

	[CallerCount(Count = 13327)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[DeduplicatedMethod]
	[IsReadOnly]
	private void CheckWriteAndBumpSecondaryVersion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString64Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString512Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(FixedString32Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(int))]
	public override int CompareTo(NativeText other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public override int CompareTo(string other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "CompareTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText), typeof(ReadOnly)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(ReadOnly&)}, ReturnType = typeof(int))]
	public int CompareTo(ReadOnly other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IJobExtensions), Member = "Schedule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextDisposeJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextDisposeJob), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[CallerCount(Count = 0)]
	public override byte ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadOnly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object other) { }

	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString4096Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
	public override bool Equals(NativeText other) { }

	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromBurstCompatTesting("Takes managed string")]
	public override bool Equals(string other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString512Bytes other) { }

	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FixedStringMethods), Member = "Equals", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T2&"}, ReturnType = typeof(bool))]
	public bool Equals(ReadOnly other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString128Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString32Bytes other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	public override bool Equals(FixedString64Bytes other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Capacity() { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public bool get_IsCreated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override byte get_Item(int index) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Length() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Enumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ComputeHashCode", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	public override Byte* GetUnsafePtr() { }

	[CalledBy(Type = typeof(NativeText), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString4096Bytes)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in NativeText a, in FixedString4096Bytes b) { }

	[CalledBy(Type = typeof(NativeText), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString64Bytes)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in NativeText a, in FixedString64Bytes b) { }

	[CalledBy(Type = typeof(NativeText), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString512Bytes)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in NativeText a, in FixedString512Bytes b) { }

	[CalledBy(Type = typeof(NativeText), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString32Bytes)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in NativeText a, in FixedString32Bytes b) { }

	[CalledBy(Type = typeof(NativeText), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixedString128Bytes)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeText), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF8ArrayUnsafeUtility), Member = "EqualsUTF8Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Byte*), typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public static bool op_Equality(in NativeText a, in FixedString128Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString512Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in NativeText a, in FixedString512Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString4096Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in NativeText a, in FixedString4096Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString32Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in NativeText a, in FixedString32Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString128Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in NativeText a, in FixedString128Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeText), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeText&), typeof(FixedString64Bytes&)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(in NativeText a, in FixedString64Bytes b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.LowLevel.Unsafe.UnsafeList`1<System.Byte>), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	public override void set_Item(int index, byte value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	private void ThrowCopyError(CopyError error, string source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedStringMethods), Member = "ConvertToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed string")]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeText), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public override bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

}

