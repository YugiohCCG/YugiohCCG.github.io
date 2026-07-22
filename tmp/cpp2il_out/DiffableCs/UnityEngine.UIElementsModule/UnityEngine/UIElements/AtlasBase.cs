namespace UnityEngine.UIElements;

internal abstract class AtlasBase
{
	internal TextureRegistry textureRegistry; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected AtlasBase() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void InvokeAssignedToPanel(IPanel panel) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnAssignedToPanel(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRemovedFromPanel(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderChain), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected static void RepaintTexturedElements(IPanel panel) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureRegistry), Member = "UpdateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	[CallerCount(Count = 0)]
	public override bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

