namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility
{
	[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	public sealed class LayoutCache
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private int <id>k__BackingField; //Field offset: 0x10
		public GUILayoutGroup topLevel; //Field offset: 0x18
		internal GenericStack layoutGroups; //Field offset: 0x20
		internal GUILayoutGroup windows; //Field offset: 0x28

		private int id
		{
			[CallerCount(Count = 7)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "get_cache", ReturnType = typeof(LayoutCache))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GenericStack), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public LayoutCache(int instanceID = -1) { }

		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 10)]
		public void ResetCursor() { }

		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private void set_id(int value) { }

	}

	private static readonly Dictionary<Int32, LayoutCache> s_StoredLayouts; //Field offset: 0x0
	private static readonly Dictionary<Int32, LayoutCache> s_StoredWindows; //Field offset: 0x8
	internal static LayoutCache current; //Field offset: 0x10
	internal static readonly Rect kDummyRect; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LayoutCache), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static GUILayoutUtility() { }

	[CalledBy(Type = typeof(GUIUtility), Member = "BeginGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	internal static void Begin(int instanceID) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainer(LayoutCache cache) { }

	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Rect Internal_GetWindowRect(int windowID) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_MoveWindow_Injected(int windowID, in Rect r) { }

	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal static void Layout() { }

	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void LayoutFromContainer(float w, float h) { }

	[CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal static void LayoutFromEditorWindow() { }

	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUILayoutGroup)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WindowFunction), typeof(int), typeof(int), typeof(GUISkin), typeof(int), typeof(float), typeof(float), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LayoutCache), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static LayoutCache SelectIDList(int instanceID, bool isWindow) { }

}

