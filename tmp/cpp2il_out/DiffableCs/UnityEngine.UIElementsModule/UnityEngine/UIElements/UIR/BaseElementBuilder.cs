namespace UnityEngine.UIElements.UIR;

internal abstract class BaseElementBuilder
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected BaseElementBuilder() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_areAncestorsAndSelfDisplayed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(VisualElement), Member = "get_subRenderTargetMode", ReturnType = typeof(RenderTargetMode))]
	[Calls(Type = typeof(VisualElement), Member = "get_defaultMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_visible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseElementBuilder), Member = "PushVisualElementClipping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void Build(MeshGenerationContext mgc) { }

	protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "InvokeGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsUnknownMethods(Count = 3)]
	private static void PopVisualElementClipping(MeshGenerationContext mgc) { }

	[CalledBy(Type = typeof(BaseElementBuilder), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void PushVisualElementClipping(MeshGenerationContext mgc) { }

	public abstract bool RequiresStencilMask(VisualElement ve) { }

	public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }

}

