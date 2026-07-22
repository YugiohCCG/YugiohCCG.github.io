namespace Spine;

public class AttachmentTimeline : Timeline, ISlotTimeline
{
	private readonly int slotIndex; //Field offset: 0x20
	private readonly String[] attachmentNames; //Field offset: 0x28

	public String[] AttachmentNames
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override int SlotIndex
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public AttachmentTimeline(int frameCount, int slotIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public String[] get_AttachmentNames() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_SlotIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetFrame(int frame, float time, string attachmentName) { }

}

