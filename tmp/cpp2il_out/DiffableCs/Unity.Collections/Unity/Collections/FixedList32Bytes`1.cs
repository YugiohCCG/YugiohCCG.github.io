namespace Unity.Collections;

[DebuggerTypeProxy(typeof(FixedList32BytesDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
public struct FixedList32Bytes : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes`1<T>>, IComparable<FixedList32Bytes`1<T>>, IEquatable<FixedList64Bytes`1<T>>, IComparable<FixedList64Bytes`1<T>>, IEquatable<FixedList128Bytes`1<T>>, IComparable<FixedList128Bytes`1<T>>, IEquatable<FixedList512Bytes`1<T>>, IComparable<FixedList512Bytes`1<T>>, IEquatable<FixedList4096Bytes`1<T>>, IComparable<FixedList4096Bytes`1<T>>
{
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private FixedList32Bytes<T> m_List; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override T Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 68
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			private get { } //Length: 160
		}

		[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "GetEnumerator", ReturnType = "Unity.Collections.FixedList32Bytes`1<T>+Enumerator<T>")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator(ref FixedList32Bytes<T>& list) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[SerializeField]
	internal FixedBytes32Align8 data; //Field offset: 0x0

	internal Byte* buffer
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 5
	}

	internal Byte* Buffer
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 91
	}

	public override int Capacity
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 103
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 54
	}

	public override bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 72
	}

	public override T Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 143
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 151
	}

	internal ushort length
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[IsReadOnly]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CreateProperty]
	public override int Length
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 36
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 47
	}

	internal int LengthInBytes
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 100
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedList32Bytes`1(in FixedList64Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList4096Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedList32Bytes`1(in FixedList4096Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList128Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedList32Bytes`1(in FixedList128Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList512Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedList32Bytes`1(in FixedList512Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void Add(in T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void AddNoResize(in T item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void AddRange(Void* ptr, int length) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public void AddRangeNoResize(Void* ptr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpyReplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public void AddReplicate(in T value, int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override int CompareTo(FixedList32Bytes<T> other) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override int CompareTo(FixedList128Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override int CompareTo(FixedList4096Bytes<T> other) { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override int CompareTo(FixedList64Bytes<T> other) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	public override int CompareTo(FixedList512Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override T ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FixedList4096Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FixedList128Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 38)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FixedList64Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FixedList512Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(FixedList32Bytes<T> other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal Byte* get_buffer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal Byte* get_Buffer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Capacity() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private IEnumerable<T> get_Elements() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override bool get_IsEmpty() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override T get_Item(int index) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[IsReadOnly]
	internal ushort get_length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal int get_LengthInBytes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList32Bytes`1<T>&"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "Hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList512Bytes`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList512Bytes`1<T>&"}, ReturnType = "Unity.Collections.FixedList32Bytes`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	internal int Initialize(in FixedList512Bytes<T>& other) { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList128Bytes`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList128Bytes`1<T>&"}, ReturnType = "Unity.Collections.FixedList32Bytes`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	internal int Initialize(in FixedList128Bytes<T>& other) { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = "Unity.Collections.FixedList32Bytes`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	internal int Initialize(in FixedList64Bytes<T>& other) { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList4096Bytes`1<T>&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList4096Bytes`1<T>&"}, ReturnType = "Unity.Collections.FixedList32Bytes`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	internal int Initialize(in FixedList4096Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Insert(int index, in T item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void InsertRange(int index, int count) { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[CalledBy(Type = typeof(FixedList32Bytes`1), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList32Bytes`1<T>&", "Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(in FixedList32Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList512Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static FixedList32Bytes<T> op_Implicit(in FixedList512Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList128Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static FixedList32Bytes<T> op_Implicit(in FixedList128Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static FixedList32Bytes<T> op_Implicit(in FixedList64Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList4096Bytes`1<T>&"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static FixedList32Bytes<T> op_Implicit(in FixedList4096Bytes<T>& other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList512Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FixedList32Bytes`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.FixedList32Bytes`1<T>&", "Unity.Collections.FixedList64Bytes`1<T>&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList64Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList4096Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList32Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Inequality(in FixedList32Bytes<T>& a, in FixedList128Bytes<T>& b) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveAtSwapBack(int index) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	public void RemoveRange(int index, int count) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	public void RemoveRangeSwapBack(int index, int count) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void set_Item(int index, T value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_length(ushort value) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionHelper), Member = "CreateNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle), typeof(NativeArrayOptions)}, ReturnType = typeof(Unity.Collections.NativeArray`1<System.Byte>))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public NativeArray<T> ToNativeArray(AllocatorHandle allocator) { }

}

