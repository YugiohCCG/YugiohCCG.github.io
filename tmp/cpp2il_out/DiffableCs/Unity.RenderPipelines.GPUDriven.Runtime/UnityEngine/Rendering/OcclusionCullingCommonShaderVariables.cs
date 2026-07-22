namespace UnityEngine.Rendering;

[GenerateHLSL(PackingRules::Exact (0), True, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@ae070e0972dd\\Runtime\\GPUDriven\\OcclusionCullingCommonShaderVariables.cs", needAccessors = False, generateCBuffer = True)]
internal struct OcclusionCullingCommonShaderVariables
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_FacingDirWorldSpace>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_OccluderMipBounds>e__FixedBuffer
	{
		public uint FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_RadialDirWorldSpace>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_ViewOriginWorldSpace>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <_ViewProjMatrix>e__FixedBuffer
	{
		public float FixedElementField; //Field offset: 0x0

	}

	[FixedBuffer(typeof(uint), 32)]
	[HLSLArray(8, typeof(ShaderGenUInt4))]
	public <_OccluderMipBounds>e__FixedBuffer _OccluderMipBounds; //Field offset: 0x0
	[FixedBuffer(typeof(float), 96)]
	[HLSLArray(6, typeof(Matrix4x4))]
	public <_ViewProjMatrix>e__FixedBuffer _ViewProjMatrix; //Field offset: 0x80
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	public <_ViewOriginWorldSpace>e__FixedBuffer _ViewOriginWorldSpace; //Field offset: 0x200
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	public <_FacingDirWorldSpace>e__FixedBuffer _FacingDirWorldSpace; //Field offset: 0x260
	[FixedBuffer(typeof(float), 24)]
	[HLSLArray(6, typeof(Vector4))]
	public <_RadialDirWorldSpace>e__FixedBuffer _RadialDirWorldSpace; //Field offset: 0x2C0
	public Vector4 _DepthSizeInOccluderPixels; //Field offset: 0x320
	public Vector4 _OccluderDepthPyramidSize; //Field offset: 0x330
	public uint _OccluderMipLayoutSizeX; //Field offset: 0x340
	public uint _OccluderMipLayoutSizeY; //Field offset: 0x344
	public uint _OcclusionTestDebugFlags; //Field offset: 0x348
	public uint _OcclusionCullingCommonPad0; //Field offset: 0x34C
	public int _OcclusionTestCount; //Field offset: 0x350
	public int _OccluderSubviewIndices; //Field offset: 0x354
	public int _CullingSplitIndices; //Field offset: 0x358
	public int _CullingSplitMask; //Field offset: 0x35C

	[CalledBy(Type = typeof(OcclusionCullingCommon), Member = "PrepareCulling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeCommandBuffer), typeof(OccluderContext&), typeof(OcclusionCullingSettings&), typeof(InstanceOcclusionTestSubviewSettings&), typeof(OcclusionTestComputeShader&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	internal OcclusionCullingCommonShaderVariables(in OccluderContext occluderCtx, in InstanceOcclusionTestSubviewSettings subviewSettings, bool occlusionOverlayCountVisible, bool overrideOcclusionTestToAlwaysPass) { }

}

