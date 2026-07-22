namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Fast (3), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct TileRangeExpansionJob : IJobFor
{
	[ReadOnly]
	public NativeArray<InclusiveRange> tileRanges; //Field offset: 0x0
	[NativeDisableParallelForRestriction]
	public NativeArray<UInt32> tileMasks; //Field offset: 0x10
	public int rangesPerItem; //Field offset: 0x20
	public int itemsPerTile; //Field offset: 0x24
	public int wordsPerTile; //Field offset: 0x28
	public int2 tileResolution; //Field offset: 0x2C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.Rendering.Universal.InclusiveRange>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public override void Execute(int jobIndex) { }

}

