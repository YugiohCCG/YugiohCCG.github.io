namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x0

	[CallerCount(Count = 57)]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public UnityEvent`3() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendOnTextSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendOnEndTextSelection", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEventBase), Member = "PrepareInvoke", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Events.BaseInvokableCall>))]
	[Calls(Type = typeof(InvokableCall`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

