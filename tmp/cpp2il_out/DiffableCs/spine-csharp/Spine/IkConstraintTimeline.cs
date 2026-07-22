namespace Spine;

public class IkConstraintTimeline : CurveTimeline
{
	public const int ENTRIES = 6; //Field offset: 0x0
	private const int MIX = 1; //Field offset: 0x0
	private const int SOFTNESS = 2; //Field offset: 0x0
	private const int BEND_DIRECTION = 3; //Field offset: 0x0
	private const int COMPRESS = 4; //Field offset: 0x0
	private const int STRETCH = 5; //Field offset: 0x0
	private readonly int ikConstraintIndex; //Field offset: 0x28

	public virtual int FrameEntries
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int IkConstraintIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CurveTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public IkConstraintTimeline(int frameCount, int bezierCount, int ikConstraintIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CurveTimeline), Member = "GetBezierValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_FrameEntries() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_IkConstraintIndex() { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFrame(int frame, float time, float mix, float softness, int bendDirection, bool compress, bool stretch) { }

}

