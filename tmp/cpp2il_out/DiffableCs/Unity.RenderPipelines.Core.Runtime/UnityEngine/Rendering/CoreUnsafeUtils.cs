namespace UnityEngine.Rendering;

[Extension]
public static class CoreUnsafeUtils
{
	public struct DefaultKeyGetter : IKeyGetter<T, T>
	{

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		public override T Get(ref T v) { }

	}

	internal struct FixedBufferStringQueue
	{
		private Byte* m_ReadCursor; //Field offset: 0x0
		private Byte* m_WriteCursor; //Field offset: 0x8
		private readonly Byte* m_BufferEnd; //Field offset: 0x10
		private readonly Byte* m_BufferStart; //Field offset: 0x18
		private readonly int m_BufferLength; //Field offset: 0x20
		[CompilerGenerated]
		private int <Count>k__BackingField; //Field offset: 0x24

		public private int Count
		{
			[CallerCount(Count = 9)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		public FixedBufferStringQueue(Byte* ptr, int length) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		public void Clear() { }

		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_Count() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Count(int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		public bool TryPop(out string v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsUnknownMethods(Count = 1)]
		public bool TryPush(string v) { }

	}

	internal interface IKeyGetter
	{

		public TKey Get(ref TValue v) { }

	}

	public struct UintKeyGetter : IKeyGetter<UInt32, UInt32>
	{

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public override uint Get(ref uint v) { }

	}

	public struct UlongKeyGetter : IKeyGetter<UInt64, UInt64>
	{

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override ulong Get(ref ulong v) { }

	}


	[CallerCount(Count = 0)]
	private static void CalculateRadixParams(int radixBits, out int bitStates) { }

	[CallerCount(Count = 0)]
	private static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, UInt32* supportArray, out UInt32* bucketIndices, out UInt32* bucketSizes, out UInt32* bucketPrefix, out UInt32* arrayOutput) { }

	[CallerCount(Count = 0)]
	private static int CalculateRadixSupportSize(int bitStates, int arrayLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "CombineHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(Hash128*)}, ReturnType = typeof(void))]
	public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "CombineHashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hash128*), typeof(Hash128*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(HashUtilities), Member = "AppendHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128&), typeof(Hash128&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void CombineHashes(int count, Void* hashes, Hash128* outHash) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "CompareHashes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TOldValue", "TOldGetter", "TNewValue", "TNewGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(int), typeof(Void*), typeof(Int32*), typeof(Int32*), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, Int32* addIndices, Int32* removeIndices, out int addCount, out int remCount) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "CompareHashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Hash128*), typeof(int), typeof(Hash128*), typeof(Int32*), typeof(Int32*), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Hash128), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static int CompareHashes(int oldHashCount, Void* oldHashes, int newHashCount, Void* newHashes, Int32* addIndices, Int32* removeIndices, out int addCount, out int remCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void CopyTo(List<T> list, Void* dest, int count) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "HaveDuplicates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static void CopyTo(T[] list, Void* dest, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "CopyTo", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public static bool HaveDuplicates(Int32[] arr) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static int IndexOf(Void* data, int count, T v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void InsertionSort(NativeArray<UInt32> arr, int sortSize) { }

	[CallerCount(Count = 0)]
	private static void InsertionSort(UInt32* arr, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public static void InsertionSort(UInt32[] arr, int sortSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "MergeSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void MergeSort(NativeArray<UInt32> arr, int sortSize, ref NativeArray<UInt32>& supportArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "MergeSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void MergeSort(UInt32[] arr, int sortSize, ref UInt32[] supportArray) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "MergeSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "MergeSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>), typeof(int), typeof(NativeArray`1<UInt32>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private static void MergeSort(UInt32* array, UInt32* support, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int Partition(Void* data, int left, int right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(UintKeyGetter)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void QuickSort(UInt32[] arr, int left, int right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(UlongKeyGetter)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void QuickSort(UInt64[] arr, int left, int right) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "HaveDuplicates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ListBufferExtensions), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListBuffer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TKey", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void QuickSort(int count, Void* data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static void QuickSort(int count, Void* data) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TKey", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "QuickSort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TKey", "TGetter"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void QuickSort(Void* data, int left, int right) { }

	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "RadixSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(UInt32[]&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CoreUnsafeUtils), Member = "RadixSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt32>), typeof(int), typeof(NativeArray`1<UInt32>&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static void RadixSort(UInt32* array, UInt32* support, int radixBits, int bitStates, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayExtensions), Member = "ResizeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "RadixSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void RadixSort(NativeArray<UInt32> array, int sortSize, ref NativeArray<UInt32>& supportArray, int radixBits = 8) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CoreUnsafeUtils), Member = "RadixSort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32*), typeof(UInt32*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void RadixSort(UInt32[] arr, int sortSize, ref UInt32[] supportArray, int radixBits = 8) { }

}

