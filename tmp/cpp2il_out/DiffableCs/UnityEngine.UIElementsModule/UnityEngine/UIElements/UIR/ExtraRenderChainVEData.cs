namespace UnityEngine.UIElements.UIR;

internal class ExtraRenderChainVEData : LinkedPoolItem<ExtraRenderChainVEData>
{
	public BasicNode<MeshHandle> extraMesh; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ExtraRenderChainVEData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	public void Reset() { }

}

