namespace Spine;

public class Slot
{
	internal SlotData data; //Field offset: 0x10
	internal Bone bone; //Field offset: 0x18
	internal float r; //Field offset: 0x20
	internal float g; //Field offset: 0x24
	internal float b; //Field offset: 0x28
	internal float a; //Field offset: 0x2C
	internal float r2; //Field offset: 0x30
	internal float g2; //Field offset: 0x34
	internal float b2; //Field offset: 0x38
	internal bool hasSecondColor; //Field offset: 0x3C
	internal Attachment attachment; //Field offset: 0x40
	internal float attachmentTime; //Field offset: 0x48
	internal ExposedList<Single> deform; //Field offset: 0x50
	internal int attachmentState; //Field offset: 0x58

	public float A
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Attachment Attachment
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(AttachmentTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttachmentTimeline), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(AnimationState), Member = "ApplyAttachmentTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentTimeline), typeof(Skeleton), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AnimationState), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Skeleton), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Skin), Member = "AttachAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Skin)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SlotData), typeof(Bone)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Slot), Member = "SetToSetupPose", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 366
	}

	public float AttachmentTime
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 42
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 46
	}

	public float B
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float B2
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Bone Bone
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public SlotData Data
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Single> Deform
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		 set { } //Length: 138
	}

	public float G
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 26
	}

	public float R
	{
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Skeleton Skeleton
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CalledBy(Type = typeof(Skeleton), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public Slot(SlotData data, Bone bone) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spine.ExposedList`1<System.Single>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public Slot(Slot slot, Bone bone) { }

	[CalledBy(Type = typeof(RGBATimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AlphaTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBA2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void ClampColor() { }

	[CalledBy(Type = typeof(RGBA2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void ClampSecondColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_A() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Attachment get_Attachment() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float get_AttachmentTime() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_B() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_B2() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Bone get_Bone() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public SlotData get_Data() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public ExposedList<Single> get_Deform() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_G2() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_HasSecondColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_R2() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Skeleton get_Skeleton() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_A(float value) { }

	[CalledBy(Type = typeof(AttachmentTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AttachmentTimeline), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyAttachmentTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttachmentTimeline), typeof(Skeleton), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Slot), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skin), Member = "AttachAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(Skin)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SlotData), typeof(Bone)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slot), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_Attachment(Attachment value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_AttachmentTime(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_B(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_B2(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void set_Deform(ExposedList<Single> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_G2(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_HasSecondColor(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_R(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_R2(float value) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SetToSetupPose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Skeleton), Member = "SetSlotsToSetupPose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[Calls(Type = typeof(Slot), Member = "set_Attachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attachment)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExposedList`1), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetToSetupPose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

