namespace Spine;

public class BoneData
{
	internal int index; //Field offset: 0x10
	internal string name; //Field offset: 0x18
	internal BoneData parent; //Field offset: 0x20
	internal float length; //Field offset: 0x28
	internal float x; //Field offset: 0x2C
	internal float y; //Field offset: 0x30
	internal float rotation; //Field offset: 0x34
	internal float scaleX; //Field offset: 0x38
	internal float scaleY; //Field offset: 0x3C
	internal float shearX; //Field offset: 0x40
	internal float shearY; //Field offset: 0x44
	internal TransformMode transformMode; //Field offset: 0x48
	internal bool skinRequired; //Field offset: 0x4C

	public int Index
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public float Length
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public string Name
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public BoneData Parent
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float Rotation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ScaleX
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ScaleY
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ShearX
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float ShearY
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
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

	public TransformMode TransformMode
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public BoneData(int index, string name, BoneData parent) { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public int get_Index() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_Length() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public BoneData get_Parent() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Rotation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ScaleX() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_ScaleY() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_ShearX() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_ShearY() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_SkinRequired() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public TransformMode get_TransformMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Length(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Rotation(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_ScaleX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ScaleY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ShearX(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ShearY(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_SkinRequired(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_TransformMode(TransformMode value) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

