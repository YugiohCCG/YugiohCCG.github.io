namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Fast (3), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct ZBinningJob : IJobFor
{
	public const int batchSize = 128; //Field offset: 0x0
	public const int headerLength = 2; //Field offset: 0x0
	[NativeDisableParallelForRestriction]
	public NativeArray<UInt32> bins; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<float2> minMaxZs; //Field offset: 0x10
	public float zBinScale; //Field offset: 0x20
	public float zBinOffset; //Field offset: 0x24
	public int binCount; //Field offset: 0x28
	public int wordsPerTile; //Field offset: 0x2C
	public int lightCount; //Field offset: 0x30
	public int reflectionProbeCount; //Field offset: 0x34
	public int batchCount; //Field offset: 0x38
	public int viewCount; //Field offset: 0x3C
	public bool isOrthographic; //Field offset: 0x40

	[CalledBy(Type = typeof(ZBinningJob), Member = "FillZBins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static ValueTuple<UInt32, UInt32> DecodeHeader(uint zBin) { }

	[CalledBy(Type = typeof(ZBinningJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ZBinningJob), Member = "FillZBins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private static uint EncodeHeader(uint min, uint max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ZBinningJob), Member = "EncodeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ZBinningJob), Member = "FillZBins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override void Execute(int jobIndex) { }

	[CalledBy(Type = typeof(ZBinningJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ZBinningJob), Member = "DecodeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(System.ValueTuple`2<System.UInt32, System.UInt32>))]
	[Calls(Type = typeof(ZBinningJob), Member = "EncodeHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset) { }

}

