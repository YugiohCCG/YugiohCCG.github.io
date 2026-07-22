namespace UnityEngine.UIElements;

internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
{
	private static readonly string s_Description; //Field offset: 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	private BaseVisualElementPanel attachedPanel; //Field offset: 0x28
	internal RenderChain renderChain; //Field offset: 0x30
	private bool m_ForceGammaRendering; //Field offset: 0x38
	private uint m_VertexBudget; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <drawStats>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <breakBatches>k__BackingField; //Field offset: 0x41
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x42

	public bool breakBatches
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected private bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public bool drawStats
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override bool forceGammaRendering
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	public virtual ProfilerMarker profilerMarker
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 79
	}

	public override uint vertexBudget
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
		 set { } //Length: 16
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Utility), Member = "add_GraphicsResourcesRecreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static UIRRepaintUpdater() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseVisualTreeUpdater), Member = "add_panelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.UIElements.BaseVisualElementPanel>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public UIRRepaintUpdater() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "add_isFlatChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "add_atlasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "add_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "add_drawsInCamerasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void AttachToPanel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderChain), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override RenderChain CreateRenderChain() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "set_forceGammaRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "set_vertexBudget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelIsFlatChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelAtlasChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelDrawsInCamerasChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RenderChain), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DestroyRenderChain() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "OnPanelChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "remove_drawsInCamerasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "remove_isFlatChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "remove_atlasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "remove_hierarchyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private void DetachFromPanel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_breakBatches() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_disposed() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_drawStats() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_forceGammaRendering() { }

	[CallerCount(Count = 0)]
	public virtual ProfilerMarker get_profilerMarker() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override uint get_vertexBudget() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void InitRenderChain() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRenderDevice), Member = "PrepareForGfxDeviceRecreate", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIElementsUtility), Member = "GetPanelsIterator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Int32, UnityEngine.UIElements.Panel>))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRenderDevice), Member = "WrapUpGfxDeviceRecreate", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "FlushAllPendingDeviceDisposes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnPanelAtlasChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DetachFromPanel", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "AttachToPanel", ReturnType = typeof(void))]
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnPanelDrawsInCamerasChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private void OnPanelIsFlatChanged() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnDisableRenderingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "Render", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override void Render() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Reset() { }

	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "ResetAllElementsDataRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	public override void set_forceGammaRendering(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIRRepaintUpdater), Member = "DestroyRenderChain", ReturnType = typeof(void))]
	public override void set_vertexBudget(uint value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual void Update() { }

}

