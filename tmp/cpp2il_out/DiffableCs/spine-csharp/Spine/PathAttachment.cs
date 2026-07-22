namespace Spine;

public class PathAttachment : VertexAttachment
{
	internal Single[] lengths; //Field offset: 0x40
	internal bool closed; //Field offset: 0x48
	internal bool constantSpeed; //Field offset: 0x49

	public bool Closed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool ConstantSpeed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Single[] Lengths
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "NewPathAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(PathAttachment))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public PathAttachment(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Attachment Copy() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Closed() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_ConstantSpeed() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Single[] get_Lengths() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Closed(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ConstantSpeed(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Lengths(Single[] value) { }

}

