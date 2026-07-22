namespace TMPro;

public class TMP_UpdateManager
{
	private static TMP_UpdateManager s_Instance; //Field offset: 0x0
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; //Field offset: 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; //Field offset: 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; //Field offset: 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; //Field offset: 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; //Field offset: 0x28
	private readonly HashSet<Int32> m_LayoutQueueLookup; //Field offset: 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; //Field offset: 0x18
	private readonly HashSet<Int32> m_GraphicQueueLookup; //Field offset: 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; //Field offset: 0x28
	private readonly HashSet<Int32> m_InternalUpdateLookup; //Field offset: 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; //Field offset: 0x38
	private readonly HashSet<Int32> m_CullingUpdateLookup; //Field offset: 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; //Field offset: 0x48

	private static TMP_UpdateManager instance
	{
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForCullingUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "set_autoSizeTextContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetVerticesDirty", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(TMP_UpdateManager), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 219
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static TMP_UpdateManager() { }

	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Canvas), Member = "add_willRenderCanvases", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WillRenderCanvases)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private TMP_UpdateManager() { }

	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "OnCameraPreCull", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private void DoRebuilds() { }

	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForLayoutRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "RegisterTextElementForCullingUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextObjectForUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_UpdateManager), Member = "UnRegisterTextElementForRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_autoSizeTextContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetVerticesDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static TMP_UpdateManager get_instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "DoRebuilds", ReturnType = typeof(void))]
	private void OnCameraPreCull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "set_isTextObjectScaleStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	[CalledBy(Type = typeof(TMP_Text), Member = "set_isTextObjectScaleStatic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TMP_UpdateManager), Member = "get_instance", ReturnType = typeof(TMP_UpdateManager))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

