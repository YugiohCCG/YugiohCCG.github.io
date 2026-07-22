namespace ZXing.Datamatrix.Internal;

public sealed class Detector
{
	private sealed class ResultPointsAndTransitions
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private ResultPoint <From>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private ResultPoint <To>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <Transitions>k__BackingField; //Field offset: 0x20

		public private ResultPoint From
		{
			[CallerCount(Count = 106)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public private ResultPoint To
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 9)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 13
		}

		public private int Transitions
		{
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 2)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ResultPointsAndTransitions(ResultPoint from, ResultPoint to, int transitions) { }

		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public ResultPoint get_From() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public ResultPoint get_To() { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public int get_Transitions() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_From(ResultPoint value) { }

		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_To(ResultPoint value) { }

		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_Transitions(int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 22)]
		public virtual string ToString() { }

	}

	private sealed class ResultPointsAndTransitionsComparator : IComparer<ResultPointsAndTransitions>
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ResultPointsAndTransitionsComparator() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override int Compare(ResultPointsAndTransitions o1, ResultPointsAndTransitions o2) { }

	}

	private readonly BitMatrix image; //Field offset: 0x10
	private readonly WhiteRectangleDetector rectangleDetector; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix)}, ReturnType = typeof(WhiteRectangleDetector))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Detector(BitMatrix image) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Detector), Member = "isValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Detector), Member = "transitionsBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(ResultPointsAndTransitions))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	private ResultPoint correctTopRight(ResultPoint bottomLeft, ResultPoint bottomRight, ResultPoint topLeft, ResultPoint topRight, int dimension) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ResultPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Detector), Member = "isValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Detector), Member = "transitionsBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(ResultPointsAndTransitions))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	private ResultPoint correctTopRightRectangular(ResultPoint bottomLeft, ResultPoint bottomRight, ResultPoint topLeft, ResultPoint topRight, int dimensionTop, int dimensionRight) { }

	[CalledBy(Type = typeof(DataMatrixReader), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryBitmap), typeof(System.Collections.Generic.IDictionary`2<ZXing.DecodeHintType, System.Object>)}, ReturnType = typeof(Result))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Detector), Member = "sampleGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitMatrix), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(Detector), Member = "correctTopRightRectangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Detector), Member = "correctTopRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ResultPoint), Member = "orderBestPatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Detector), Member = "increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<ZXing.ResultPoint, System.Int32>), typeof(ResultPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Detector), Member = "transitionsBetween", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(ResultPointsAndTransitions))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WhiteRectangleDetector), Member = "detect", ReturnType = typeof(ResultPoint[]))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 35)]
	public DetectorResult detect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResultPoint), Member = "distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MathUtils), Member = "round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	private static int distance(ResultPoint a, ResultPoint b) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void increment(IDictionary<ResultPoint, Int32> table, ResultPoint key) { }

	[CalledBy(Type = typeof(Detector), Member = "correctTopRightRectangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool isValid(ResultPoint p) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	private static BitMatrix sampleGrid(BitMatrix image, ResultPoint topLeft, ResultPoint bottomLeft, ResultPoint bottomRight, ResultPoint topRight, int dimensionX, int dimensionY) { }

	[CalledBy(Type = typeof(Detector), Member = "detect", ReturnType = typeof(DetectorResult))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRightRectangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CalledBy(Type = typeof(Detector), Member = "correctTopRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(ResultPoint), typeof(int)}, ReturnType = typeof(ResultPoint))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(BitMatrix), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private ResultPointsAndTransitions transitionsBetween(ResultPoint from, ResultPoint to) { }

}

