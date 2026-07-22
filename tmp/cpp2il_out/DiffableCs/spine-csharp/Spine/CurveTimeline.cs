namespace Spine;

public abstract class CurveTimeline : Timeline
{
	public const int LINEAR = 0; //Field offset: 0x0
	public const int STEPPED = 1; //Field offset: 0x0
	public const int BEZIER = 2; //Field offset: 0x0
	public const int BEZIER_SIZE = 18; //Field offset: 0x0
	internal Single[] curves; //Field offset: 0x20

	[CalledBy(Type = typeof(CurveTimeline1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CurveTimeline2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBATimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBA2Timeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB2Timeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeformTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(VertexAttachment)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraintTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraintTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintMixTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public CurveTimeline(int frameCount, int bezierCount, String[] propertyIds) { }

	[CalledBy(Type = typeof(CurveTimeline1), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TranslateTimeline), Member = "GetCurveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Single&), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBATimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGBA2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RGB2Timeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IkConstraintTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransformConstraintTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PathConstraintMixTimeline), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skeleton), typeof(float), typeof(float), typeof(Spine.ExposedList`1<Spine.Event>), typeof(float), typeof(MixBlend), typeof(MixDirection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 38)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetBezierValue(float time, int frameIndex, int valueOffset, int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public float GetCurveType(int frame) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "SetBezier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void SetBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetLinear(int frame) { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonInput), typeof(SkeletonData)}, ReturnType = typeof(Animation))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline1), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadCurve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CurveTimeline), typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	public void SetStepped(int frame) { }

	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, System.Object>), typeof(string), typeof(SkeletonData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enumerator<Object>&), typeof(CurveTimeline1), typeof(float), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enumerator<Object>&), typeof(CurveTimeline2), typeof(string), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Timeline))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void Shrink(int bezierCount) { }

}

