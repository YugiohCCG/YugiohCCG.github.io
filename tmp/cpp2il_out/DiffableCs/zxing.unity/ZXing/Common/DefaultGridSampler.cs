namespace ZXing.Common;

public sealed class DefaultGridSampler : GridSampler
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public DefaultGridSampler() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerspectiveTransform), Member = "squareToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "buildAdjoint", ReturnType = typeof(PerspectiveTransform))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "times", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerspectiveTransform)}, ReturnType = typeof(PerspectiveTransform))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual BitMatrix sampleGrid(BitMatrix image, int dimensionX, int dimensionY, float p1ToX, float p1ToY, float p2ToX, float p2ToY, float p3ToX, float p3ToY, float p4ToX, float p4ToY, float p1FromX, float p1FromY, float p2FromX, float p2FromY, float p3FromX, float p3FromY, float p4FromX, float p4FromY) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "transformPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GridSampler), Member = "checkAndNudgePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(Single[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BitMatrix), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public virtual BitMatrix sampleGrid(BitMatrix image, int dimensionX, int dimensionY, PerspectiveTransform transform) { }

}

