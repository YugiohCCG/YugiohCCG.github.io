namespace UnityEngine.Rendering;

internal struct RenderersParameters
{
	[Flags]
	internal enum Flags
	{
		None = 0,
		UseBoundingSphereParameter = 1,
	}

	internal struct ParamInfo
	{
		public int index; //Field offset: 0x0
		public int gpuAddress; //Field offset: 0x4
		public int uintOffset; //Field offset: 0x8

		public bool valid
		{
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_valid() { }

	}

	internal static class ParamNames
	{
		public static readonly int _BaseColor; //Field offset: 0x0
		public static readonly int unity_SpecCube0_HDR; //Field offset: 0x4
		public static readonly int unity_SHCoefficients; //Field offset: 0x8
		public static readonly int unity_LightmapST; //Field offset: 0xC
		public static readonly int unity_ObjectToWorld; //Field offset: 0x10
		public static readonly int unity_WorldToObject; //Field offset: 0x14
		public static readonly int unity_MatrixPreviousM; //Field offset: 0x18
		public static readonly int unity_MatrixPreviousMI; //Field offset: 0x1C
		public static readonly int unity_WorldBoundingSphere; //Field offset: 0x20
		public static readonly Int32[] DOTS_ST_WindParams; //Field offset: 0x28
		public static readonly Int32[] DOTS_ST_WindHistoryParams; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 4)]
		private static ParamNames() { }

	}

	private static int s_uintSize; //Field offset: 0x0
	public ParamInfo lightmapScale; //Field offset: 0x0
	public ParamInfo localToWorld; //Field offset: 0xC
	public ParamInfo worldToLocal; //Field offset: 0x18
	public ParamInfo matrixPreviousM; //Field offset: 0x24
	public ParamInfo matrixPreviousMI; //Field offset: 0x30
	public ParamInfo shCoefficients; //Field offset: 0x3C
	public ParamInfo boundingSphere; //Field offset: 0x48
	public ParamInfo[] windParams; //Field offset: 0x58
	public ParamInfo[] windHistoryParams; //Field offset: 0x60

	[CallerCount(Count = 0)]
	private static RenderersParameters() { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderersBatchersContext), Member = "GrowInstanceBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "GetGpuAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "GetPropertyIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public RenderersParameters(in GPUInstanceDataBuffer instanceDataBuffer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "GetGpuAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GPUInstanceDataBuffer), Member = "GetPropertyIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static ParamInfo <.ctor>g__GetParamInfo|14_0(in GPUInstanceDataBuffer instanceDataBuffer, int paramNameIdx, bool assertOnFail = true) { }

	[CalledBy(Type = typeof(RenderersBatchersContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderersBatchersContextDesc&), "UnityEngine.Rendering.GPUDrivenProcessor", typeof(GPUResidentDrawerResources)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SHCoefficients)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool), typeof(InstanceType), typeof(InstanceComponentGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceNumInfo&)}, ReturnType = typeof(GPUInstanceDataBuffer))]
	[Calls(Type = typeof(GPUInstanceDataBufferBuilder), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static GPUInstanceDataBuffer CreateInstanceDataBuffer(Flags flags, in InstanceNumInfo instanceNumInfo) { }

}

