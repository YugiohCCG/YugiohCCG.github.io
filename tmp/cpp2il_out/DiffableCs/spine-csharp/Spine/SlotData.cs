namespace Spine;

public class SlotData
{
	internal int index; //Field offset: 0x10
	internal string name; //Field offset: 0x18
	internal BoneData boneData; //Field offset: 0x20
	internal float r; //Field offset: 0x28
	internal float g; //Field offset: 0x2C
	internal float b; //Field offset: 0x30
	internal float a; //Field offset: 0x34
	internal float r2; //Field offset: 0x38
	internal float g2; //Field offset: 0x3C
	internal float b2; //Field offset: 0x40
	internal bool hasSecondColor; //Field offset: 0x44
	internal string attachmentName; //Field offset: 0x48
	internal BlendMode blendMode; //Field offset: 0x50

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public string AttachmentName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float B
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float B2
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public BlendMode BlendMode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public BoneData BoneData
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float G
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float G2
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public bool HasSecondColor
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int Index
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string Name
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float R
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float R2
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public SlotData(int index, string name, BoneData boneData) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_AttachmentName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_B2() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public BlendMode get_BlendMode() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public BoneData get_BoneData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G2() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_HasSecondColor() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_R() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R2() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_A(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AttachmentName(string value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B2(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_BlendMode(BlendMode value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_G(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G2(float value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_HasSecondColor(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_R(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_R2(float value) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

