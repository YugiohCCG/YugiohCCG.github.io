namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x28

	[CalledBy(Type = "UnityEngine.UI.Button+ButtonClickedEvent", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Button", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[RequiredByNativeCode]
	public UnityEvent() { }

	[CallerCount(Count = 162)]
	[Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AddListener(UnityAction call) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall), Member = "add_Delegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	[CalledBy(Type = "HostSettings", Member = "ShowHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Button", Member = "Press", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void Invoke() { }

}

