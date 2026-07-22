namespace ZXing.Common;

public sealed class PerspectiveTransform
{
	private float a11; //Field offset: 0x10
	private float a12; //Field offset: 0x14
	private float a13; //Field offset: 0x18
	private float a21; //Field offset: 0x1C
	private float a22; //Field offset: 0x20
	private float a23; //Field offset: 0x24
	private float a31; //Field offset: 0x28
	private float a32; //Field offset: 0x2C
	private float a33; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private PerspectiveTransform(float a11, float a21, float a31, float a12, float a22, float a32, float a13, float a23, float a33) { }

	[CalledBy(Type = typeof(DefaultGridSampler), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PerspectiveTransform), Member = "quadrilateralToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CalledBy(Type = typeof(PerspectiveTransform), Member = "quadrilateralToSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal PerspectiveTransform buildAdjoint() { }

	[CalledBy(Type = typeof(Detector), Member = "createTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(PerspectiveTransform))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PerspectiveTransform), Member = "squareToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "buildAdjoint", ReturnType = typeof(PerspectiveTransform))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "times", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PerspectiveTransform)}, ReturnType = typeof(PerspectiveTransform))]
	[CallsUnknownMethods(Count = 1)]
	public static PerspectiveTransform quadrilateralToQuadrilateral(float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3, float x0p, float y0p, float x1p, float y1p, float x2p, float y2p, float x3p, float y3p) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PerspectiveTransform), Member = "squareToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[Calls(Type = typeof(PerspectiveTransform), Member = "buildAdjoint", ReturnType = typeof(PerspectiveTransform))]
	[CallsUnknownMethods(Count = 1)]
	public static PerspectiveTransform quadrilateralToSquare(float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3) { }

	[CalledBy(Type = typeof(DefaultGridSampler), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PerspectiveTransform), Member = "quadrilateralToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CalledBy(Type = typeof(PerspectiveTransform), Member = "quadrilateralToSquare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static PerspectiveTransform squareToQuadrilateral(float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3) { }

	[CalledBy(Type = typeof(DefaultGridSampler), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(BitMatrix))]
	[CalledBy(Type = typeof(PerspectiveTransform), Member = "quadrilateralToQuadrilateral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(PerspectiveTransform))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal PerspectiveTransform times(PerspectiveTransform other) { }

	[CalledBy(Type = typeof(DefaultGridSampler), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(int), typeof(int), typeof(PerspectiveTransform)}, ReturnType = typeof(BitMatrix))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void transformPoints(Single[] points) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void transformPoints(Single[] xValues, Single[] yValues) { }

}

