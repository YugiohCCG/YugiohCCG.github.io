namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/UIElementsRuntimeUtilityNative.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal static class UIElementsRuntimeUtilityNative
{
	internal static Action UpdatePanelsCallback; //Field offset: 0x0
	internal static Action<Boolean> RepaintPanelsCallback; //Field offset: 0x8
	internal static Action RenderOffscreenPanelsCallback; //Field offset: 0x10

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IPanel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RegisterPlayerloopCallback", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterPlayerloopCallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	public static void RenderOffscreenPanels() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIElementsRuntimeUtility), Member = "UnregisterPlayerloopCallback", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void UnregisterPlayerloopCallback() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	public static void UpdatePanels() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void VisualElementCreation() { }

}

