namespace Spine;

public abstract class Timeline
{
	private readonly String[] propertyIds; //Field offset: 0x10
	internal readonly Single[] frames; //Field offset: 0x18

	public float Duration
	{
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 77
	}

	public int FrameCount
	{
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
		[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 51
	}

	public override int FrameEntries
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public Single[] Frames
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] PropertyIds
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public Timeline(int frameCount, String[] propertyIds) { }

	public abstract void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixBlend blend, MixDirection direction) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float get_Duration() { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public int get_FrameCount() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override int get_FrameEntries() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Single[] get_Frames() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public String[] get_PropertyIds() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static int Search(Single[] frames, float time) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static int Search(Single[] frames, float time, int step) { }

}

