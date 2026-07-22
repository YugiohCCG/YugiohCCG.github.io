namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class SortedSet : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public int index; //Field offset: 0x0
		public int count; //Field offset: 0x0
		public T[] array; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass52_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal bool <CopyTo>b__0(Node<T> node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public int index; //Field offset: 0x0
		public Object[] objects; //Field offset: 0x0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass53_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		internal bool <System.Collections.ICollection.CopyTo>b__0(Node<T> node) { }

	}

	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private static readonly Node<T> s_dummyNode; //Field offset: 0x0
		private SortedSet<T> _tree; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private Stack<Node<T>> _stack; //Field offset: 0x0
		private Node<T> _current; //Field offset: 0x0
		private bool _reverse; //Field offset: 0x0

		public override T Current
		{
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TKey")]
			[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 89
		}

		internal bool NotStartedOrEnded
		{
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			internal get { } //Length: 9
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			private get { } //Length: 164
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NodeColor)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static Enumerator() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(SortedSet`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		internal Enumerator(SortedSet<T> set) { }

		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SortedSet`1), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(SortedSet`1), Member = "Log2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerator), Member = "Initialize", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		internal Enumerator(SortedSet<T> set, bool reverse) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TKey")]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool get_NotStartedOrEnded() { }

		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private void Initialize() { }

		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
		[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 17)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CalledBy(Type = typeof(Enumerator), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Enumerator), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		internal void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	public sealed class Node
	{
		[CompilerGenerated]
		private T <Item>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node<T> <Left>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node<T> <Right>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private NodeColor <Color>k__BackingField; //Field offset: 0x0

		public NodeColor Color
		{
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public bool Is2Node
		{
			[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 180
		}

		public bool Is4Node
		{
			[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 152
		}

		public bool IsBlack
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public bool IsRed
		{
			[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public T Item
		{
			[CallerCount(Count = 17)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 11
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 18
		}

		public Node<T> Left
		{
			[CallerCount(Count = 12)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public Node<T> Right
		{
			[CallerCount(Count = 15)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		[CalledBy(Type = typeof(Enumerator), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public Node(T item, NodeColor color) { }

		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		public void ColorBlack() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public void ColorRed() { }

		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public NodeColor get_Color() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_Is2Node() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_Is4Node() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_IsBlack() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_IsRed() { }

		[CallerCount(Count = 17)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public T get_Item() { }

		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Node<T> get_Left() { }

		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public Node<T> get_Right() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public TreeRotation GetRotation(Node<T> current, Node<T> sibling) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public Node<T> GetSibling(Node<T> node) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool IsNonNullRed(Node<T> node) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public static bool IsNullOrBlack(Node<T> node) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Merge2Nodes() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "ReplaceChildOrRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "ReplaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public void ReplaceChild(Node<T> child, Node<T> newChild) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		public Node<T> Rotate(TreeRotation rotation) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public Node<T> RotateLeft() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public Node<T> RotateLeftRight() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "DoRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public Node<T> RotateRight() { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SortedSet`1), Member = "InsertionBalance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "Node<T>&", "System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		public Node<T> RotateRightLeft() { }

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Color(NodeColor value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Item(T value) { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Left(Node<T> value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_Right(Node<T> value) { }

		[CalledBy(Type = typeof(SortedSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public void Split4Node() { }

	}

	private Node<T> root; //Field offset: 0x0
	private IComparer<T> comparer; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int version; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private SerializationInfo siInfo; //Field offset: 0x0

	public override int Count
	{
		[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 34
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 107
	}

	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Byte, System.Object>>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Byte, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public SortedSet`1() { }

	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Byte, System.Object>>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Collections.Generic.KeyValuePair`2<System.Byte, System.Object>>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public SortedSet`1(IComparer<T> comparer) { }

	[CalledBy(Type = typeof(TreeSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected SortedSet`1(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Add(T item) { }

	[CalledBy(Type = typeof(TreeSet`1), Member = "AddIfNotPresent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Node), Member = "RotateRightLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "get_IsRed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "get_Is4Node", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "Split4Node", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "IsNonNullRed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "RotateLeftRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(NodeColor)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal override bool AddIfNotPresent(T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Contains(T item) { }

	[CalledBy(Type = typeof(SortedDictionary`2), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortedSet`1), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	public void CopyTo(T[] array, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void CopyTo(T[] array, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_Is2Node", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "GetSibling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "get_IsRed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "GetRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(TreeRotation))]
	[Calls(Type = typeof(Node), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TreeRotation)}, ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "Merge2Nodes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal override bool DoRemove(T item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal override Node<T> FindNode(T item) { }

	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedDictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedSet`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "RotateLeftRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRightLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateLeft", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "RotateRight", ReturnType = "System.Collections.Generic.SortedSet`1<T>+Node<T>")]
	[Calls(Type = typeof(Node), Member = "ColorRed", ReturnType = typeof(void))]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private void InsertionBalance(Node<T> current, ref Node<T> parent, Node<T> grandParent, Node<T> greatGrandParent) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal override bool IsWithinRange(T item) { }

	[CalledBy(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private static int Log2(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	protected override void OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool Remove(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void ReplaceChildOrRoot(Node<T> parent, Node<T> child, Node<T> newChild) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "ReplaceChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>+Node<T>", "System.Collections.Generic.SortedSet`1<T>+Node<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private void ReplaceNode(Node<T> match, Node<T> parentOfMatch, Node<T> successor, Node<T> parentOfSuccessor) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 36)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(object), typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedSet`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void UpdateVersion() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void VersionCheck() { }

}

