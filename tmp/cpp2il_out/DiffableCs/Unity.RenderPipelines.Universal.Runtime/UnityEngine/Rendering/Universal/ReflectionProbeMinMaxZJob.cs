namespace UnityEngine.Rendering.Universal;

[BurstCompile]
internal struct ReflectionProbeMinMaxZJob : IJobFor
{
	public Fixed2<float4x4> worldToViews; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; //Field offset: 0x80
	public NativeArray<float2> minMaxZs; //Field offset: 0x90

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisibleReflectionProbe), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int index) { }

}

