namespace UnityEngine.Rendering;

public class HableCurve
{
	private struct DirectParams
	{
		internal float x0; //Field offset: 0x0
		internal float y0; //Field offset: 0x4
		internal float x1; //Field offset: 0x8
		internal float y1; //Field offset: 0xC
		internal float W; //Field offset: 0x10
		internal float overshootX; //Field offset: 0x14
		internal float overshootY; //Field offset: 0x18
		internal float gamma; //Field offset: 0x1C

	}

	internal class Segment
	{
		public float offsetX; //Field offset: 0x10
		public float offsetY; //Field offset: 0x14
		public float scaleX; //Field offset: 0x18
		public float scaleY; //Field offset: 0x1C
		public float lnA; //Field offset: 0x20
		public float B; //Field offset: 0x24

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Segment() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public float Eval(float x) { }

	}

	internal class Uniforms
	{
		private HableCurve parent; //Field offset: 0x10

		public Vector4 curve
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 56
		}

		public Vector4 midSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 114
		}

		public Vector4 midSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 96
		}

		public Vector4 shoSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 114
		}

		public Vector4 shoSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 96
		}

		public Vector4 toeSegmentA
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 114
		}

		public Vector4 toeSegmentB
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 96
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal Uniforms(HableCurve parent) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public Vector4 get_curve() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_midSegmentA() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_midSegmentB() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_shoSegmentA() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_shoSegmentB() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_toeSegmentA() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public Vector4 get_toeSegmentB() { }

	}

	[CompilerGenerated]
	private float <whitePoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <inverseWhitePoint>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private float <x0>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <x1>k__BackingField; //Field offset: 0x1C
	public readonly Segment[] segments; //Field offset: 0x20
	public readonly Uniforms uniforms; //Field offset: 0x28

	public private float inverseWhitePoint
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	public private float whitePoint
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	public private float x0
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	public private float x1
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public HableCurve() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public float Eval(float x) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_inverseWhitePoint() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_whitePoint() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_x0() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_x1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HableCurve), Member = "InitSegments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DirectParams)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma) { }

	[CalledBy(Type = typeof(HableCurve), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void InitSegments(DirectParams srcParams) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_inverseWhitePoint(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_whitePoint(float value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_x0(float value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_x1(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m) { }

}

