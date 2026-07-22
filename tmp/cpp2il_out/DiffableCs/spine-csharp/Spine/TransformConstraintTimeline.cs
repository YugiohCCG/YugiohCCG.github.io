namespace Spine;

public class TransformConstraintTimeline : CurveTimeline
{
	public const int ENTRIES = 7; //Field offset: 0x0
	private const int ROTATE = 1; //Field offset: 0x0
	private const int X = 2; //Field offset: 0x0
	private const int Y = 3; //Field offset: 0x0
	private const int SCALEX = 4; //Field offset: 0x0
	private const int SCALEY = 5; //Field offset: 0x0
	private const int SHEARY = 6; //Field offset: 0x0
	private readonly int transformConstraintIndex; //Field offset: 0x28

	public virtual int FrameEntries
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int TransformConstraintIndex
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
	public TransformConstraintTimeline(int frameCount, int bezierCount, int transformConstraintIndex) { }

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
	public int get_TransformConstraintIndex() { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void SetFrame(int frame, float time, float mixRotate, float mixX, float mixY, float mixScaleX, float mixScaleY, float mixShearY) { }

}

