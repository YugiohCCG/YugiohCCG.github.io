namespace Spine;

public class Animation
{
	internal string name; //Field offset: 0x10
	internal ExposedList<Timeline> timelines; //Field offset: 0x18
	internal HashSet<String> timelineIds; //Field offset: 0x20
	internal float duration; //Field offset: 0x28

	public float Duration
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
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ExposedList<Timeline> Timelines
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Animation), Member = "SetTimelines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Timeline>)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animation), Member = "SetTimelines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Timeline>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Animation(string name, ExposedList<Timeline> timelines, float duration) { }

	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), "UnityEngine.AnimatorClipInfo", "UnityEngine.AnimatorStateInfo", typeof(int), typeof(float), typeof(MixBlend), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "ApplyInterruptionAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(bool), "UnityEngine.AnimatorClipInfo", "UnityEngine.AnimatorStateInfo", typeof(int), typeof(float), typeof(MixBlend), typeof(float), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonMecanim+MecanimTranslator", Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_Duration() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public ExposedList<Timeline> get_Timelines() { }

	[CalledBy(Type = typeof(AnimationState), Member = "ComputeHold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public bool HasTimeline(String[] propertyIds) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_Duration(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animation), Member = "SetTimelines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Timeline>)}, ReturnType = typeof(void))]
	public void set_Timelines(ExposedList<Timeline> value) { }

	[CalledBy(Type = typeof(Animation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Spine.ExposedList`1<Spine.Timeline>), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animation), Member = "set_Timelines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Spine.ExposedList`1<Spine.Timeline>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	public void SetTimelines(ExposedList<Timeline> timelines) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

