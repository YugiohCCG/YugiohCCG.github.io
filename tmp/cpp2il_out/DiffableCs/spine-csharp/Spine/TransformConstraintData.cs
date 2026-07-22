namespace Spine;

public class TransformConstraintData : ConstraintData
{
	internal ExposedList<BoneData> bones; //Field offset: 0x20
	internal BoneData target; //Field offset: 0x28
	internal float mixRotate; //Field offset: 0x30
	internal float mixX; //Field offset: 0x34
	internal float mixY; //Field offset: 0x38
	internal float mixScaleX; //Field offset: 0x3C
	internal float mixScaleY; //Field offset: 0x40
	internal float mixShearY; //Field offset: 0x44
	internal float offsetRotation; //Field offset: 0x48
	internal float offsetX; //Field offset: 0x4C
	internal float offsetY; //Field offset: 0x50
	internal float offsetScaleX; //Field offset: 0x54
	internal float offsetScaleY; //Field offset: 0x58
	internal float offsetShearY; //Field offset: 0x5C
	internal bool relative; //Field offset: 0x60
	internal bool local; //Field offset: 0x61

	public ExposedList<BoneData> Bones
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Local
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float MixRotate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixScaleY
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float MixShearY
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
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
		[CallerCount(Count = 3)]
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

	public float OffsetScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float OffsetScaleY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float OffsetShearY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float OffsetX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float OffsetY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool Relative
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

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConstraintData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TransformConstraintData(string name) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<BoneData> get_Bones() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Local() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixRotate() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixScaleX() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_MixScaleY() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_MixShearY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_MixY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetRotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetScaleX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetScaleY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetShearY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_OffsetY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Relative() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public BoneData get_Target() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Local(bool value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_MixRotate(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixShearY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_MixX(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_MixY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetRotation(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_OffsetScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetShearY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_OffsetY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Relative(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Target(BoneData value) { }

}

