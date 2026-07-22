namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x0

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public UnityEvent`1() { }

	[CallerCount(Count = 95)]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T1>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEventBase), Member = "AddCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseInvokableCall)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void AddListener(UnityAction<T0> call) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T1>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public void Invoke(T0 arg0) { }

	[CalledBy(Type = "PooledScrollList.Controller.PooledScrollRectBase", Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "ClearTooltip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "UnregisterConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerConnection), Member = "UnregisterDisconnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "UnregisterManagedCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(UnityEngine.Events.UnityAction`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_verticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Scrollbar"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "set_horizontalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Scrollbar"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "set_verticalScrollbar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Scrollbar"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void RemoveListener(UnityAction<T0> call) { }

}

