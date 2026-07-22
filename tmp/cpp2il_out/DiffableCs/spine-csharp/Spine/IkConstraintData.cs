namespace Spine;

public class IkConstraintData : ConstraintData
{
	internal ExposedList<BoneData> bones; //Field offset: 0x20
	internal BoneData target; //Field offset: 0x28
	internal int bendDirection; //Field offset: 0x30
	internal bool compress; //Field offset: 0x34
	internal bool stretch; //Field offset: 0x35
	internal bool uniform; //Field offset: 0x36
	internal float mix; //Field offset: 0x38
	internal float softness; //Field offset: 0x3C

	public int BendDirection
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public ExposedList<BoneData> Bones
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Compress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float Mix
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Softness
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool Stretch
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public BoneData Target
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool Uniform
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 4
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public IkConstraintData(string name) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_BendDirection() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<BoneData> get_Bones() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Compress() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Mix() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Softness() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Stretch() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public BoneData get_Target() { }

	[CallerCount(Count = 0)]
	public bool get_Uniform() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_BendDirection(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Compress(bool value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_Mix(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Softness(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Stretch(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(BoneData value) { }

	[CallerCount(Count = 0)]
	public void set_Uniform(bool value) { }

}

