namespace Spine;

[DebuggerDisplay("Count={Count}")]
public class ExposedList : IEnumerable<T>, IEnumerable
{
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private ExposedList<T> l; //Field offset: 0x0
		private int next; //Field offset: 0x0
		private int ver; //Field offset: 0x0
		private T current; //Field offset: 0x0

		public override T Current
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			[DeduplicatedMethod]
			private get { } //Length: 167
		}

		[CalledBy(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
		[CalledBy(Type = typeof(ExposedList`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(ExposedList`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal Enumerator(ExposedList<T> l) { }

		[CallerCount(Count = 66)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override T get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private void VerifyState() { }

	}

	private const int DefaultCapacity = 4; //Field offset: 0x0
	private static readonly T[] EmptyArray; //Field offset: 0x0
	public T[] Items; //Field offset: 0x0
	public int Count; //Field offset: 0x0
	private int version; //Field offset: 0x0

	public int Capacity
	{
		[CallerCount(Count = 36)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
		[CalledBy(Type = typeof(DeformTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 191
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static ExposedList`1() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal ExposedList`1(T[] data, int size) { }

	[CallerCount(Count = 1377)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ExposedList`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "AddEnumerable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public ExposedList`1(IEnumerable<T> collection) { }

	[CalledBy(Type = typeof(SkeletonClipping), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IkConstraint), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraintData), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathConstraint), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(VertexAttachment), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformConstraint), typeof(Skeleton)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "EnsureVertexCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public ExposedList`1(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Add(T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private void AddCollection(ICollection<T> collection) { }

	[CalledBy(Type = typeof(ExposedList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExposedList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[DeduplicatedMethod]
	private void AddEnumerable(IEnumerable<T> enumerable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void AddRange(ExposedList<T> list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "AddEnumerable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void AddRange(IEnumerable<T> collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int BinarySearch(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(bool), typeof(System.Collections.Generic.IComparer`1<System.Boolean>)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int BinarySearch(T item, IComparer<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(bool), typeof(System.Collections.Generic.IComparer`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void CheckCollection(IEnumerable<T> collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private void CheckIndex(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void CheckMatch(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private void CheckRange(int index, int count) { }

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear(bool clearArray = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Contains(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	public ExposedList<TOutput> ConvertAll(Converter<T, TOutput> converter) { }

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void CopyTo(T[] array, int arrayIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void CopyTo(int index, T[] array, int arrayIndex, int count) { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void CopyTo(T[] array) { }

	[CalledBy(Type = typeof(Triangulator), Member = "Triangulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(Spine.ExposedList`1<System.Int32>))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "UpdateMeshMultipleCanvasRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "EnsureMeshesCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonRendererInstruction", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Unity.SkeletonRendererInstruction"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void EnsureCapacity(int min) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Exists(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T Find(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public ExposedList<T> FindAll(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private ExposedList<T> FindAllList(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public int FindIndex(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public int FindIndex(int startIndex, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public T FindLast(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public int FindLastIndex(int startIndex, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public int FindLastIndex(Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public int FindLastIndex(int startIndex, int count, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public void ForEach(Action<T> action) { }

	[CallerCount(Count = 36)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Capacity() { }

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public Enumerator<T> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetIndex(int startIndex, int count, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private int GetLastIndex(int startIndex, int count, Predicate<T> match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ExposedList<T> GetRange(int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void GrowIfNeeded(int addedCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int IndexOf(T item, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public int IndexOf(T item, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int IndexOf(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void Insert(int index, T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void InsertCollection(int index, ICollection<T> collection) { }

	[CalledBy(Type = typeof(ExposedList`1), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	private void InsertEnumeration(int index, IEnumerable<T> enumerable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExposedList`1), Member = "InsertEnumeration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	public void InsertRange(int index, IEnumerable<T> collection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public int LastIndexOf(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public int LastIndexOf(T item, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public int LastIndexOf(T item, int index, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public T Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool Remove(T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public int RemoveAll(Predicate<T> match) { }

	[CalledBy(Type = typeof(SkeletonBounds), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Triangulator), Member = "Triangulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(Spine.ExposedList`1<System.Int32>))]
	[CalledBy(Type = typeof(Triangulator), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Int32>)}, ReturnType = typeof(Spine.ExposedList`1<Spine.ExposedList`1<System.Single>>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void RemoveRange(int index, int count) { }

	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyMixingFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry), typeof(Skeleton), typeof(MixBlend)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(AnimationState), Member = "ComputeHold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraint), Member = "ComputeWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathAttachment), typeof(int), typeof(bool)}, ReturnType = typeof(Single[]))]
	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Slot), typeof(ClippingAttachment)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SkeletonClipping), Member = "ClipTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[]), typeof(int), typeof(Int32[]), typeof(int), typeof(Single[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonClipping), Member = "Clip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Triangulator), Member = "Triangulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(Spine.ExposedList`1<System.Int32>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ExposedList<T> Resize(int newSize) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Reverse() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Reverse(int index, int count) { }

	[CalledBy(Type = typeof(DeformTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void set_Capacity(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void Shift(int start, int delta) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Sort(Comparison<T> comparison) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(System.Collections.Generic.IComparer`1<System.Boolean>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Sort(IComparer<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Boolean>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Boolean>))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(System.Collections.Generic.IComparer`1<System.Boolean>)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void Sort() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(int), typeof(System.Collections.Generic.IComparer`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Sort(int index, int count, IComparer<T> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<T>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(int)}, ReturnType = typeof(Vertices))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(VertexAttachment), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonPartsRenderer", Member = "RenderParts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.ExposedList`1<SubmeshInstruction>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshRendererBuffers", Member = "GetUpdatedSharedMaterialsArray", ReturnType = "UnityEngine.Material[]")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T[] ToArray() { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(SkeletonData), typeof(bool), typeof(bool)}, ReturnType = typeof(Skin))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.MeshGenerator", Member = "TrimExcess", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public void TrimExcess() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public bool TrueForAll(Predicate<T> match) { }

}

