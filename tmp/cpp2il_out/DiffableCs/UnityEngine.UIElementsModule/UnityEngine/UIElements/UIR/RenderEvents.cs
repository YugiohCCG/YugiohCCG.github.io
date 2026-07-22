namespace UnityEngine.UIElements.UIR;

internal static class RenderEvents
{
	private static readonly ProfilerMarker k_NudgeVerticesMarker; //Field offset: 0x0
	private static readonly float VisibilityTreshold; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static RenderEvents() { }

	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "InitColorIDs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTransform", ReturnType = typeof(BMPAlloc))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "EnsureFits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChainVEData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderEvents), Member = "UpdateLocalFlipsWinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildrenReordered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "UIEOnRenderHintsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RenderChain), Member = "ResetTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandManipulator), Member = "ResetCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "ClearDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnChildRemoving", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "ProcessOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocClipRect", ReturnType = typeof(BMPAlloc))]
	[Calls(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderChainVEData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "ProcessOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocOpacity", ReturnType = typeof(BMPAlloc))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetOpacityValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "ProcessOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VisualElement), Member = "EnsureWorldTransformAndClipUpToDate", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "UIEOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "UpdateZeroScaling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "UpdateLocalFlipsWinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetClipRectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "ShouldClip", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClipMinusGroup", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldClip", ReturnType = typeof(Rect))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = "get_childCount", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(VisualElement), Member = "MultiplyMatrix34", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Matrix4x4&), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocColor", ReturnType = typeof(BMPAlloc))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Texture2D>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&), typeof(List`1<Single>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool NeedsColorID(VisualElement ve) { }

	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Texture2D>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&), typeof(List`1<Single>&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[ContainsUnimplementedInstructions]
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool NeedsTransformID(VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRUtility), Member = "GetVerticesTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RenderEvents), Member = "PrepareNudgeVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(UIRenderDevice), typeof(MeshHandle), typeof(IntPtr&), typeof(IntPtr&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobManager), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NudgeJobData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderChain), Member = "GetOrAddExtraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(ExtraRenderChainVEData))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "ProcessOnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = "UnityEngine.UIElements.UIR.RenderChain+DepthOrderedDirtyTracking", Member = "RegisterDirty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderDataDirtyTypes), typeof(RenderDataDirtyTypeClasses)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "InitColorIDs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(RenderChain), typeof(UIRenderDevice)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.Vertex>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
	[Calls(Type = typeof(UIRenderDevice), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(NativeSlice`1<Vertex>&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderEvents), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(float), typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	[CalledBy(Type = typeof(RenderChain), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(int), typeof(bool)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain+VisualChangesProcessor", Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "OnColorChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(uint), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextUtilities), Member = "IsFontAssigned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextCoreSettingsForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(bool)}, ReturnType = typeof(TextCoreSettings))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(BMPAlloc))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(VisualElement), Member = "get_playModeTintColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChain), typeof(VisualElement), typeof(VisualElement), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hierarchy), Member = "get_parent", ReturnType = typeof(VisualElement))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void UpdateZeroScaling(VisualElement ve) { }

}

