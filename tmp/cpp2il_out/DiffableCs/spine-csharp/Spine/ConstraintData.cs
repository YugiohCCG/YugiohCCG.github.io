namespace Spine;

public abstract class ConstraintData
{
	internal readonly string name; //Field offset: 0x10
	internal int order; //Field offset: 0x18
	internal bool skinRequired; //Field offset: 0x1C

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Order
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool SkinRequired
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(TransformConstraintData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public ConstraintData(string name) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_Order() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_SkinRequired() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_Order(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_SkinRequired(bool value) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

