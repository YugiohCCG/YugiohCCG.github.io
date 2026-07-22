namespace Spine;

public abstract class CurveTimeline2 : CurveTimeline
{
	public const int ENTRIES = 3; //Field offset: 0x0
	internal const int VALUE1 = 1; //Field offset: 0x0
	internal const int VALUE2 = 2; //Field offset: 0x0

	public virtual int FrameEntries
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CalledBy(Type = typeof(TranslateTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShearTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CurveTimeline), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public CurveTimeline2(int frameCount, int bezierCount, string propertyId1, string propertyId2) { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual int get_FrameEntries() { }

	[CalledBy(Type = typeof(SkeletonBinary), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SkeletonInput), typeof(CurveTimeline2), typeof(float)}, ReturnType = typeof(Timeline))]
	[CalledBy(Type = typeof(SkeletonJson), Member = "ReadTimeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enumerator<Object>&), typeof(CurveTimeline2), typeof(string), typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(Timeline))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFrame(int frame, float time, float value1, float value2) { }

}

