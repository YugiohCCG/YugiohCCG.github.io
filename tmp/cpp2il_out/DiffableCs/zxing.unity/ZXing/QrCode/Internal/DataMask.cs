namespace ZXing.QrCode.Internal;

internal abstract class DataMask
{
	private sealed class DataMask000 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask000() { }

		[CallerCount(Count = 0)]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask001 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask001() { }

		[CallerCount(Count = 0)]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask010 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask010() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask011 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask011() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask100 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask100() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask101 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask101() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask110 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask110() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private sealed class DataMask111 : DataMask
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public DataMask111() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal virtual bool isMasked(int i, int j) { }

	}

	private static readonly DataMask[] DATA_MASKS; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 35)]
	private static DataMask() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private DataMask() { }

	[CalledBy(Type = typeof(BitMatrixParser), Member = "readCodewords", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(BitMatrixParser), Member = "remask", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static DataMask forReference(int reference) { }

	internal abstract bool isMasked(int i, int j) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitMatrix), Member = "flip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void unmaskBitMatrix(BitMatrix bits, int dimension) { }

}

