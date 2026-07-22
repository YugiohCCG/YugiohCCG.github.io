namespace Spine;

internal class Pool
{
	internal interface IPoolable
	{

		public void Reset() { }

	}

	public readonly int max; //Field offset: 0x0
	private readonly Stack<T> freeObjects; //Field offset: 0x0
	[CompilerGenerated]
	private int <Peak>k__BackingField; //Field offset: 0x0

	public int Count
	{
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 26
	}

	public private int Peak
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CalledBy(Type = typeof(AnimationState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationStateData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Triangulator), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Pool`1(int initialCapacity = 16, int max = 2147483647) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(EventQueue), Member = "Drain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Triangulator), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Int32>)}, ReturnType = typeof(Spine.ExposedList`1<Spine.ExposedList`1<System.Single>>))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public void Free(T obj) { }

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Peak() { }

	[CalledBy(Type = typeof(AnimationState), Member = "NewTrackEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Animation), typeof(bool), typeof(TrackEntry)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(Triangulator), Member = "Decompose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>), typeof(Spine.ExposedList`1<System.Int32>)}, ReturnType = typeof(Spine.ExposedList`1<Spine.ExposedList`1<System.Single>>))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public T Obtain() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	protected void Reset(T obj) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Peak(int value) { }

}

