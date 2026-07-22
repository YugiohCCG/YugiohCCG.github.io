namespace Spine;

public class TranslateTimeline : CurveTimeline2, IBoneTimeline
{
	private readonly int boneIndex; //Field offset: 0x28

	public override int BoneIndex
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
	[Calls(Type = typeof(CurveTimeline2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	public TranslateTimeline(int frameCount, int bezierCount, int boneIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TranslateTimeline), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override int get_BoneIndex() { }

	[CalledBy(Type = typeof(TranslateTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AnimationTools.TimelineExtensions", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CurveTimeline), Member = "GetBezierValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void GetCurveValue(out float x, out float y, float time) { }

}

