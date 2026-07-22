namespace System.Collections;

[DefaultMember("Item")]
public sealed class BitArray : ICollection, IEnumerable, ICloneable
{
	private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
	{
		private BitArray bitarray; //Field offset: 0x10
		private int index; //Field offset: 0x18
		private int version; //Field offset: 0x1C
		private bool currentElement; //Field offset: 0x20

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 10)]
			 get { } //Length: 272
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal BitArrayEnumeratorSimple(BitArray bitarray) { }

		[CallerCount(Count = 113)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public override void Reset() { }

	}

	private Int32[] m_array; //Field offset: 0x10
	private int m_length; //Field offset: 0x18
	private int _version; //Field offset: 0x1C
	private object _syncRoot; //Field offset: 0x20

	public override int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool Item
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "UpdateDebugData", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "ComputeFragmentationRate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Data.DataTable", Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataTable", Member = "ConvertToRowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = "System.Data.DataRowState")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		 get { } //Length: 8
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "ReserveChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "RemoveBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+CellIndexInfo"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Data.DataTable", Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 277
	}

	public int Length
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "System.Data.Common.DataStorage", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 408
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 104
	}

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.DataStorage", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public BitArray(int length) { }

	[CalledBy(Type = "System.Data.DataTable", Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public BitArray(int length, bool defaultValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public BitArray(BitArray bits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 36)]
	[ContainsUnimplementedInstructions]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 68)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public bool Get(int index) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSynchronized() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "UpdateDebugData", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "ComputeFragmentationRate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.DataTable", Member = "DeserializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "ConvertToRowState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitArray), typeof(int)}, ReturnType = "System.Data.DataRowState")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BitArray), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	public bool get_Item(int index) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static int GetArrayLength(int n, int div) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override IEnumerator GetEnumerator() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public BitArray Or(BitArray value) { }

	[CallerCount(Count = 63)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void Set(int index, bool value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "ReserveChunks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "RemoveBricks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+CellIndexInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "SerializeTableData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public void set_Item(int index, bool value) { }

	[CalledBy(Type = "System.Data.Common.DataStorage", Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void set_Length(int value) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeTextureMemoryBudget"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeBrickIndex", Member = "FindSlotsForEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"IndirectionEntryUpdateInfo[]&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetAll(bool value) { }

}

