namespace Spine;

public class ClippingAttachment : VertexAttachment
{
	internal SlotData endSlot; //Field offset: 0x40

	public SlotData EndSlot
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "NewClippingAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(ClippingAttachment))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public ClippingAttachment(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Attachment Copy() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SlotData get_EndSlot() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_EndSlot(SlotData value) { }

}

