namespace UnityEngine.Rendering.Universal;

[BurstCompile]
internal struct LightMinMaxZJob : IJobFor
{
	public Fixed2<float4x4> worldToViews; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<VisibleLight> lights; //Field offset: 0x80
	public NativeArray<float2> minMaxZs; //Field offset: 0x90

	[CalledBy(Type = "Unity.Jobs.IJobForExtensions+ForJobStruct`1", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(IntPtr), typeof(IntPtr), typeof(JobRanges&), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisibleLight), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(float4x4), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(float4x4))]
	[Calls(Type = typeof(VisibleLight), Member = "get_range", ReturnType = typeof(float))]
	[Calls(Type = typeof(VisibleLight), Member = "get_spotAngle", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public override void Execute(int index) { }

}

