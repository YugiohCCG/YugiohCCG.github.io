namespace UnityEngine.Events;

internal class CachedInvokableCall : InvokableCall<T>
{
	private readonly T m_Arg1; //Field offset: 0x0

	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public CachedInvokableCall`1(object target, MethodInfo theFunction, T argument) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Invoke(Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvokableCall`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void Invoke(T arg0) { }

}

