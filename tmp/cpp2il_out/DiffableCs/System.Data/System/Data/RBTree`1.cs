namespace System.Data;

[DefaultMember("Item")]
internal abstract class RBTree : IEnumerable
{
	private struct Node
	{
		internal int _selfId; //Field offset: 0x0
		internal int _leftId; //Field offset: 0x0
		internal int _rightId; //Field offset: 0x0
		internal int _parentId; //Field offset: 0x0
		internal int _nextId; //Field offset: 0x0
		internal int _subTreeSize; //Field offset: 0x0
		internal K _keyOfNode; //Field offset: 0x0
		internal NodeColor<K> _nodeColor; //Field offset: 0x0

	}

	private enum NodeColor
	{
		red = 0,
		black = 1,
	}

	[IsReadOnly]
	private struct NodePath
	{
		internal readonly int _nodeID; //Field offset: 0x0
		internal readonly int _mainTreeNodeID; //Field offset: 0x0

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		internal NodePath(int nodeID, int mainTreeNodeID) { }

	}

	public struct RBTreeEnumerator : IEnumerator<K>, IDisposable, IEnumerator
	{
		private readonly RBTree<K> _tree; //Field offset: 0x0
		private readonly int _version; //Field offset: 0x0
		private int _index; //Field offset: 0x0
		private int _mainTreeNodeId; //Field offset: 0x0
		private K _current; //Field offset: 0x0

		public override K Current
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 94
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal RBTreeEnumerator(RBTree<K> tree) { }

		[CalledBy(Type = typeof(Index), Member = "GetEnumerator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.Data.RBTree`1+RBTreeEnumerator<System.Int32>))]
		[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RBTree`1), Member = "ComputeNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal RBTreeEnumerator(RBTree<K> tree, int position) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override K get_Current() { }

		[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataView), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRowView[]), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DataView), Member = "ResetRowViewCache", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Index), Member = "GetRows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Range)}, ReturnType = typeof(DataRow[]))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
		[Calls(Type = typeof(ExceptionBuilder), Member = "EnumeratorModified", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 11)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "EnumeratorModified", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	private sealed class TreePage
	{
		internal readonly Node<K>[] _slots; //Field offset: 0x0
		internal readonly Int32[] _slotMap; //Field offset: 0x0
		private int _inUseCount; //Field offset: 0x0
		private int _pageId; //Field offset: 0x0
		private int _nextFreeSlotLine; //Field offset: 0x0

		internal int InUseCount
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			internal set { } //Length: 4
		}

		internal int PageId
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal set { } //Length: 4
		}

		[CalledBy(Type = typeof(RBTree`1), Member = "AllocPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Data.RBTree`1<K>+TreePage<K>")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal TreePage(int size) { }

		[CalledBy(Type = typeof(TreePage), Member = "AllocSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(RBTree`1), Member = "MarkPageFull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>+TreePage<K>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RBTree`1), Member = "GetIntValueFromBitMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(TreePage), Member = "AllocSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>"}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal int AllocSlot(RBTree<K> tree) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal int get_InUseCount() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal int get_PageId() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal void set_InUseCount(int value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void set_PageId(int value) { }

	}

	private TreePage<K>[] _pageTable; //Field offset: 0x0
	private Int32[] _pageTableMap; //Field offset: 0x0
	private int _inUsePageCount; //Field offset: 0x0
	private int _nextFreePageLine; //Field offset: 0x0
	public int root; //Field offset: 0x0
	private int _version; //Field offset: 0x0
	private int _inUseNodeCount; //Field offset: 0x0
	private int _inUseSatelliteTreeCount; //Field offset: 0x0
	private readonly TreeAccessMethod _accessMethod; //Field offset: 0x0

	public int Count
	{
		[CalledBy(Type = typeof(DataRowCollection), Member = "get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public bool HasDuplicates
	{
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public K Item
	{
		[CalledBy(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Index), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 105
	}

	[CalledBy(Type = "System.Data.Index+IndexTree", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Index)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InitRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFilter)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RBTree`1(TreeAccessMethod accessMethod) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int Add(K item) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "InitTree", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TreePage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private TreePage<K> AllocPage(int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private NodeColor<K> color(int nodeId) { }

	protected abstract int CompareNode(K record1, K record2) { }

	protected abstract int CompareSateliteTreeNode(K record1, K record2) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByNodePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>+NodePath<K>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private int ComputeIndexByNode(int nodeId) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByNodePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>+NodePath<K>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private int ComputeNodeByIndex(int x_id, int index) { }

	[CalledBy(Type = typeof(RBTreeEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Data.RBTree`1<K>+NodePath<K>")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidOffsetLength", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public void CopyTo(K[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InvalidOffsetLength", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "ArgumentOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public void CopyTo(Array array, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void DecreaseSize(int nodeId) { }

	[CalledBy(Type = typeof(Index), Member = "DeleteRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = "RBDeleteX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public K DeleteByIndex(int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void FreeNode(int nodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void FreePage(TreePage<K> page) { }

	[CalledBy(Type = typeof(DataRowCollection), Member = "get_Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DataRowCollection), Member = "DiffInsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_HasDuplicates() { }

	[CalledBy(Type = typeof(Index), Member = "GetRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(DataRow))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public K get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override IEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(Index), Member = "ApplyChangeAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "GetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "RecordChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = "System.Data.RBTree`1<K>+NodePath<K>")]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexWithSatelliteByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int GetIndexByKey(K key) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexWithSatelliteByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public int GetIndexByNode(int node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexWithSatelliteByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	private int GetIndexByNodePath(NodePath<K> path) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexOfPageWithFreeSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexOfPageWithFreeSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	[CalledBy(Type = typeof(TreePage), Member = "AllocSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static int GetIntValueFromBitMap(uint bitMap) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "InsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RBTree`1), Member = "AllocPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Data.RBTree`1<K>+TreePage<K>")]
	[Calls(Type = typeof(TreePage), Member = "AllocSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private int GetNewNode(K key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "ComputeNodeByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "RowOutOfRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private NodePath<K> GetNodeByIndex(int userIndex) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "UpdateNodeKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K", "K"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RBTree`1), Member = "GetIndexByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	private NodePath<K> GetNodeByKey(K key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void IncreaseSize(int nodeId) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "GetIndexByNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public int IndexOf(int nodeId, K item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "AllocPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Data.RBTree`1<K>+TreePage<K>")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void InitTree() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int Insert(int position, K item) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int Insert(K item) { }

	[CalledBy(Type = typeof(Index), Member = "InitRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFilter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Index), Member = "InsertRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int InsertAt(int position, K item, bool append) { }

	[CalledBy(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyRecordInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public K Key(int nodeId) { }

	[CalledBy(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyRecordInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int Left(int nodeId) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "RBDeleteFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void MarkPageFree(TreePage<K> page) { }

	[CalledBy(Type = typeof(TreePage), Member = "AllocSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.RBTree`1<K>"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void MarkPageFull(TreePage<K> page) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int Minimum(int x_id) { }

	[CalledBy(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int Next(int nodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int Parent(int nodeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "RBDeleteX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int RBDelete(int z_id) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBDeleteX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "RightRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "LeftRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 56)]
	[DeduplicatedMethod]
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "DeleteByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "K")]
	[CalledBy(Type = typeof(RBTree`1), Member = "RBDelete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RBTree`1), Member = "RecomputeSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RBTree`1), Member = "RBDeleteFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 47)]
	[DeduplicatedMethod]
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "InsertAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "K", typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNewNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "RightRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RBTree`1), Member = "LeftRotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 84)]
	[DeduplicatedMethod]
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBDeleteX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void RecomputeSize(int nodeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RBTree`1), Member = "RBDeleteX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveAt(int position) { }

	[CalledBy(Type = typeof(Index), Member = "FindNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "FindNodeByKeyRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Index), Member = "IsKeyRecordInIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Index), Member = "GetUniqueKeyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Object[]>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniqueConstraint), Member = "CheckConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int Right(int nodeId) { }

	[CalledBy(Type = typeof(RBTree`1), Member = "RBInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RBTree`1), Member = "RBDeleteFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private int SearchSubTree(int root_id, K key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetColor(int nodeId, NodeColor<K> color) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetKey(int nodeId, K key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetLeft(int nodeId, int leftNodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetNext(int nodeId, int nextNodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetParent(int nodeId, int parentNodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetRight(int nodeId, int rightNodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private void SetSubTreeSize(int nodeId, int size) { }

	[CalledBy(Type = typeof(Index), Member = "GetRangeFromNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Range))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public int SubTreeSize(int nodeId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private int Successor(int x_id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExceptionBuilder), Member = "InternalRBTreeError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RBTreeError)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }

	[CalledBy(Type = typeof(Index), Member = "RecordStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DataViewRowState), typeof(DataViewRowState), typeof(int), typeof(DataViewRowState), typeof(DataViewRowState)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RBTree`1), Member = "GetNodeByKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"K"}, ReturnType = "System.Data.RBTree`1<K>+NodePath<K>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void UpdateNodeKey(K currentKey, K newKey) { }

}

