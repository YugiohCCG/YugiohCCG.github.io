namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
{
	private BaseRuntimePanel m_Panel; //Field offset: 0x28

	public virtual Camera eventCamera
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override IPanel panel
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 367
	}

	public virtual int renderOrderPriority
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 118
	}

	private GameObject selectableGameObject
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 18
	}

	public virtual int sortOrderPriority
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 102
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PanelRaycaster() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Camera get_eventCamera() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override IPanel get_panel() { }

	[CallerCount(Count = 0)]
	public virtual int get_renderOrderPriority() { }

	[CallerCount(Count = 0)]
	private GameObject get_selectableGameObject() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_sortOrderPriority() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPanelDestroyed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MultipleDisplayUtilities), Member = "GetRelativeMousePositionForRaycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PointerCaptureHelper), Member = "GetCapturingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(int)}, ReturnType = typeof(IEventHandler))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.UIElements.PointerDeviceState", Member = "GetPlayerPanelWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IPanel))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "ScreenToPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2&), typeof(Vector2&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RegisterCallbacks() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "add_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_panel(IPanel value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "remove_destroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UnregisterCallbacks() { }

}

