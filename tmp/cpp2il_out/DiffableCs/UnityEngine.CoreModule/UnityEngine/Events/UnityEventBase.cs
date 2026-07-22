namespace UnityEngine.Events;

[UsedByNativeCode]
public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	private InvokableCallList m_Calls; //Field offset: 0x10
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	private PersistentCallGroup m_PersistentCalls; //Field offset: 0x18
	private bool m_CallsDirty; //Field offset: 0x20

	[CalledBy(Type = typeof(UnityEvent`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`4), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	protected UnityEventBase() { }

	[CalledBy(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal void AddCall(BaseInvokableCall call) { }

	[CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEventBase), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DirtyPersistentCalls() { }

	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(PersistentListenerMode), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 3)]
	internal MethodInfo FindMethod(PersistentCall call) { }

	[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetPersistentEventCount() { }

	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetPersistentMethodName(int index) { }

	[CalledBy(Type = "UI.Dates.DatePicker_HoldButton", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public object GetPersistentTarget(int index) { }

	[CalledBy(Type = typeof(UnityEvent), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`1), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`2), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(UnityEvent`4), Member = "FindMethod_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

	[CalledBy(Type = typeof(UnityEvent`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEvent`3), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T0", "T1", "T2"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal List<BaseInvokableCall> PrepareInvoke() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void RebuildPersistentCallsIfNeeded() { }

	[CalledBy(Type = "UI.Dates.DatePicker_InputField", Member = "ShowCalendar", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.HandCards", Member = "ToggleHandAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RealtimeSearch", Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Action), "TMPro.TMP_InputField"}, ReturnType = "Extensions.RealtimeSearch")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveAllListeners() { }

	[CalledBy(Type = typeof(UnityEvent`1), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvokableCallList), Member = "RemoveListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "DirtyPersistentCalls", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = "DirtyPersistentCalls", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

