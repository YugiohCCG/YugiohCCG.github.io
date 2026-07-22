namespace UnityEngine.UIElements;

internal class UITKTextJobSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal ManagedJobData <.cctor>b__25_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal void <.cctor>b__25_1(ManagedJobData inst) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal List<Material> <.cctor>b__25_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__25_3(List<Material> list) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal List<GlyphRenderMode> <.cctor>b__25_4() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__25_5(List<GlyphRenderMode> list) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal List<NativeSlice`1<Vertex>> <.cctor>b__25_6() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__25_7(List<NativeSlice`1<Vertex>> list) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal List<NativeSlice`1<UInt16>> <.cctor>b__25_8() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <.cctor>b__25_9(List<NativeSlice`1<UInt16>> list) { }

	}

	private struct GenerateTextJobData : IJobParallelFor
	{
		public GCHandle managedJobDataHandle; //Field offset: 0x0
		[ReadOnly]
		public TempMeshAllocator alloc; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UITKTextHandle), Member = "UpdateMesh", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
		[Calls(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UITKTextHandle), Member = "HandleATag", ReturnType = typeof(void))]
		[Calls(Type = typeof(UITKTextHandle), Member = "HandleLinkTag", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public override void Execute(int index) { }

	}

	private class ManagedJobData
	{
		public TextElement visualElement; //Field offset: 0x10
		public MeshGenerationNode node; //Field offset: 0x18
		public List<Material> materials; //Field offset: 0x20
		public List<GlyphRenderMode> renderModes; //Field offset: 0x28
		public List<NativeSlice`1<Vertex>> vertices; //Field offset: 0x30
		public List<NativeSlice`1<UInt16>> indices; //Field offset: 0x38
		public bool prepareSuccess; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ManagedJobData() { }

		[CalledBy(Type = typeof(UITKTextJobSystem), Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		public void Release() { }

	}

	private struct PrepareTextJobData : IJobParallelFor
	{
		public GCHandle managedJobDataHandle; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PrepareFontAsset", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public override void Execute(int index) { }

	}

	private static readonly ProfilerMarker k_ExecuteMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_UpdateMainThreadMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_PrepareMainThreadMarker; //Field offset: 0x10
	private static readonly ProfilerMarker k_PrepareJobifiedMarker; //Field offset: 0x18
	private static ObjectPool<ManagedJobData> s_JobDataPool; //Field offset: 0x20
	private static ObjectPool<List`1<Material>> s_MaterialsPool; //Field offset: 0x28
	private static ObjectPool<List`1<GlyphRenderMode>> s_RenderModesPool; //Field offset: 0x30
	private static ObjectPool<List`1<NativeSlice`1<Vertex>>> s_VerticesPool; //Field offset: 0x38
	private static ObjectPool<List`1<NativeSlice`1<UInt16>>> s_IndicesPool; //Field offset: 0x40
	private GCHandle textJobDatasHandle; //Field offset: 0x10
	private List<ManagedJobData> textJobDatas; //Field offset: 0x18
	private bool hasPendingTextWork; //Field offset: 0x20
	internal MeshGenerationCallback m_PrepareTextJobifiedCallback; //Field offset: 0x28
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback; //Field offset: 0x30
	internal MeshGenerationCallback m_AddDrawEntriesCallback; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	private static UITKTextJobSystem() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public UITKTextJobSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventHandler), Member = "HandleLinkAndATagCallbacks", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextElement), Member = "OnGenerateTextOver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobData), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private void AddDrawEntries(MeshGenerationContext mgc, object _) { }

	[CalledBy(Type = typeof(GenerateTextJobData), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_contentRect", ReturnType = typeof(Rect))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_textInfo", ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = typeof(RenderEvents), Member = "NeedsColorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderEvents), Member = "NeedsTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static void ConvertMeshInfoToUIRVertex(MeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Material>& materials, ref List<NativeSlice`1<Vertex>>& verticesArray, ref List<NativeSlice`1<UInt16>>& indicesArray, ref List<GlyphRenderMode>& renderModes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenerateTextJobData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GenerateTextJobData), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "GetTempMeshAllocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateFontAssetsInUpdateQueue", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "PrepareFontAsset", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSettings), Member = "get_lineBreakingRules", ReturnType = typeof(UnicodeLineBreakingRules))]
	[Calls(Type = typeof(PanelTextSettings), Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void GenerateTextJobified(MeshGenerationContext mgc, object _) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static void OnGetManagedJob(ManagedJobData managedJobData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "InitThreadArrays", ReturnType = typeof(void))]
	[Calls(Type = typeof(PanelTextSettings), Member = "InitializeDefaultPanelTextSettingsIfNull", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrepareTextJobData)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrepareTextJobData), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void PrepareTextJobified(MeshGenerationContext mgc, object _) { }

}

