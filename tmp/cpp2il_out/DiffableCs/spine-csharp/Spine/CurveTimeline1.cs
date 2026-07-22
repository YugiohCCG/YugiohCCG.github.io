namespace Spine;

public abstract class CurveTimeline1 : CurveTimeline
{
	public const int ENTRIES = 2; //Field offset: 0x0
	internal const int VALUE = 1; //Field offset: 0x0

	public virtual int FrameEntries
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(RotateTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TranslateXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TranslateYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearXTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearYTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AlphaTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintPositionTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintSpacingTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CurveTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public CurveTimeline1(int frameCount, int bezierCount, string propertyId) { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public virtual int get_FrameEntries() { }

	[CalledBy(Type = typeof(RotateTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TranslateXTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TranslateYTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleXTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleYTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearXTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearYTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AlphaTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintPositionTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintSpacingTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimationState), Member = "ApplyRotateTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RotateTimeline), typeof(Skeleton), typeof(float), typeof(float), typeof(MixBlend), typeof(Single[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AnimationTools.TimelineExtensions", Member = "Evaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TranslateXTimeline), typeof(TranslateYTimeline), typeof(float), typeof(SkeletonData)}, ReturnType = "UnityEngine.Vector2")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CurveTimeline), Member = "GetBezierValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public float GetCurveValue(float time) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enumerator<Object>&), typeof(CurveTimeline1), typeof(float), typeof(float)}, ReturnType = typeof(Timeline))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFrame(int frame, float time, float value) { }

}

