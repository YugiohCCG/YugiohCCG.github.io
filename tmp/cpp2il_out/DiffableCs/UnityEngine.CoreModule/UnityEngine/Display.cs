namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display
{
	internal sealed class DisplaysUpdatedDelegate : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public DisplaysUpdatedDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	public static Display[] displays; //Field offset: 0x0
	private static Display _mainDisplay; //Field offset: 0x8
	private static int m_ActiveEditorGameViewTarget; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static DisplaysUpdatedDelegate onDisplaysUpdated; //Field offset: 0x18
	internal IntPtr nativeDisplay; //Field offset: 0x10

	public static Display main
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 21)]
		 get { } //Length: 79
	}

	public int renderingHeight
	{
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 127
	}

	public int renderingWidth
	{
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 127
	}

	public bool requiresSrgbBlitToBackbuffer
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 104
	}

	public int systemHeight
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 127
	}

	public int systemWidth
	{
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 127
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static Display() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal Display() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Display(IntPtr nativeDisplay) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void FireDisplaysUpdated() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 21)]
	public static Display get_main() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public int get_renderingHeight() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public int get_renderingWidth() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_requiresSrgbBlitToBackbuffer() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputAction+CallbackContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsUnknownMethods(Count = 2)]
	public int get_systemHeight() { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public int get_systemWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[RequiredByNativeCode]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("UnityDisplayManager_RequiresSRGBBlitToBackbuffer")]
	private static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay) { }

}

