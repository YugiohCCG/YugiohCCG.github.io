namespace Spine;

public class SkeletonData
{
	internal string name; //Field offset: 0x10
	internal ExposedList<BoneData> bones; //Field offset: 0x18
	internal ExposedList<SlotData> slots; //Field offset: 0x20
	internal ExposedList<Skin> skins; //Field offset: 0x28
	internal Skin defaultSkin; //Field offset: 0x30
	internal ExposedList<EventData> events; //Field offset: 0x38
	internal ExposedList<Animation> animations; //Field offset: 0x40
	internal ExposedList<IkConstraintData> ikConstraints; //Field offset: 0x48
	internal ExposedList<TransformConstraintData> transformConstraints; //Field offset: 0x50
	internal ExposedList<PathConstraintData> pathConstraints; //Field offset: 0x58
	internal float x; //Field offset: 0x60
	internal float y; //Field offset: 0x64
	internal float width; //Field offset: 0x68
	internal float height; //Field offset: 0x6C
	internal string version; //Field offset: 0x70
	internal string hash; //Field offset: 0x78
	internal float fps; //Field offset: 0x80
	internal string imagesPath; //Field offset: 0x88
	internal string audioPath; //Field offset: 0x90

	public ExposedList<Animation> Animations
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string AudioPath
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public ExposedList<BoneData> Bones
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Skin DefaultSkin
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public ExposedList<EventData> Events
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Fps
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 9
	}

	public string Hash
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Height
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public ExposedList<IkConstraintData> IkConstraints
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string ImagesPath
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public ExposedList<PathConstraintData> PathConstraints
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public ExposedList<Skin> Skins
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public ExposedList<SlotData> Slots
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<TransformConstraintData> TransformConstraints
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string Version
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public float Width
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float X
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float Y
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public SkeletonData() { }

	[CalledBy(Type = typeof(AnimationState), Member = "SetAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationState), Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(bool), typeof(float)}, ReturnType = typeof(TrackEntry))]
	[CalledBy(Type = typeof(AnimationStateData), Member = "SetMix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AnimationReferenceAsset", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "set_AnimationName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonAnimation", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonGraphic", Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Animation FindAnimation(string animationName) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = "Spine.Unity.SpineBone", Member = "GetBoneData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.Unity.SkeletonDataAsset"}, ReturnType = typeof(BoneData))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BoneData FindBone(string boneName) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.EventDataReferenceAsset", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public EventData FindEvent(string eventDataName) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IkConstraintData FindIkConstraint(string constraintName) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public PathConstraintData FindPathConstraint(string constraintName) { }

	[CalledBy(Type = typeof(Skeleton), Member = "SetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.SkeletonUtility", Member = "AddBoundingBoxGameObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(string), typeof(string), typeof(string), "UnityEngine.Transform", typeof(bool)}, ReturnType = "UnityEngine.PolygonCollider2D")]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.Unity.SkeletonDataAsset"}, ReturnType = typeof(Attachment))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ExposedList`1), Member = "GetEnumerator", ReturnType = "Spine.ExposedList`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Spine.ExposedList`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public Skin FindSkin(string skinName) { }

	[CalledBy(Type = typeof(Skeleton), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(Skin), typeof(int), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
	[CalledBy(Type = "Spine.Unity.SpineAttachment", Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Spine.Unity.SkeletonDataAsset"}, ReturnType = typeof(Attachment))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SlotData FindSlot(string slotName) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(SkeletonData))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public TransformConstraintData FindTransformConstraint(string constraintName) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<Animation> get_Animations() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public string get_AudioPath() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<BoneData> get_Bones() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public Skin get_DefaultSkin() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public ExposedList<EventData> get_Events() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Fps() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_Hash() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Height() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ExposedList<IkConstraintData> get_IkConstraints() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_ImagesPath() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public ExposedList<PathConstraintData> get_PathConstraints() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public ExposedList<Skin> get_Skins() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ExposedList<SlotData> get_Slots() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public ExposedList<TransformConstraintData> get_TransformConstraints() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public string get_Version() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Width() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_X() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_Y() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Animations(ExposedList<Animation> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_AudioPath(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_DefaultSkin(Skin value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Events(ExposedList<EventData> value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Fps(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Hash(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Height(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_IkConstraints(ExposedList<IkConstraintData> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ImagesPath(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_PathConstraints(ExposedList<PathConstraintData> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Skins(ExposedList<Skin> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_TransformConstraints(ExposedList<TransformConstraintData> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Version(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Width(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_X(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Y(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

