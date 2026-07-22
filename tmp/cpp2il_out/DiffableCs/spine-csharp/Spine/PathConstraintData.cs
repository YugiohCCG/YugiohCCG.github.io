namespace Spine;

public class PathConstraintData : ConstraintData
{
	internal ExposedList<BoneData> bones; //Field offset: 0x20
	internal SlotData target; //Field offset: 0x28
	internal PositionMode positionMode; //Field offset: 0x30
	internal SpacingMode spacingMode; //Field offset: 0x34
	internal RotateMode rotateMode; //Field offset: 0x38
	internal float offsetRotation; //Field offset: 0x3C
	internal float position; //Field offset: 0x40
	internal float spacing; //Field offset: 0x44
	internal float mixRotate; //Field offset: 0x48
	internal float mixX; //Field offset: 0x4C
	internal float mixY; //Field offset: 0x50

	public ExposedList<BoneData> Bones
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float MixX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float OffsetRotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Position
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public PositionMode PositionMode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float RotateMix
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public RotateMode RotateMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float Spacing
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public SpacingMode SpacingMode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public SlotData Target
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public PathConstraintData(string name) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<BoneData> get_Bones() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetRotation() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_Position() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public PositionMode get_PositionMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_RotateMix() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public RotateMode get_RotateMode() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_Spacing() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public SpacingMode get_SpacingMode() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public SlotData get_Target() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetRotation(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Position(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_PositionMode(PositionMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RotateMix(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_RotateMode(RotateMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Spacing(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_SpacingMode(SpacingMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(SlotData value) { }

}

