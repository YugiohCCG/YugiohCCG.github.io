namespace UnityEngine.Rendering;

internal struct InstanceOcclusionTestSubviewSettings
{
	public int testCount; //Field offset: 0x0
	public int occluderSubviewIndices; //Field offset: 0x4
	public int occluderSubviewMask; //Field offset: 0x8
	public int cullingSplitIndices; //Field offset: 0xC
	public int cullingSplitMask; //Field offset: 0x10

	[CalledBy(Type = typeof(InstanceCuller), Member = "InstanceOcclusionTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(OcclusionCullingSettings&), typeof(System.ReadOnlySpan`1<UnityEngine.Rendering.SubviewOcclusionTest>), typeof(RenderersBatchersContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static InstanceOcclusionTestSubviewSettings FromSpan(ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests) { }

}

