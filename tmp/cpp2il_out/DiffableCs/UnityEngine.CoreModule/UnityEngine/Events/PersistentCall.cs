namespace UnityEngine.Events;

internal class PersistentCall : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("instance")]
	[SerializeField]
	private object m_Target; //Field offset: 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; //Field offset: 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; //Field offset: 0x20
	[FormerlySerializedAs("mode")]
	[SerializeField]
	private PersistentListenerMode m_Mode; //Field offset: 0x28
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	private ArgumentCache m_Arguments; //Field offset: 0x30
	[FormerlySerializedAs("enabled")]
	[FormerlySerializedAs("m_Enabled")]
	[SerializeField]
	private UnityEventCallState m_CallState; //Field offset: 0x38

	public ArgumentCache arguments
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string methodName
	{
		[CallerCount(Count = 71)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public PersistentListenerMode mode
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public object target
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string targetAssemblyTypeName
	{
		[CalledBy(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 186
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public PersistentCall() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public ArgumentCache get_arguments() { }

	[CallerCount(Count = 71)]
	[DeduplicatedMethod]
	public string get_methodName() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public PersistentListenerMode get_mode() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public object get_target() { }

	[CalledBy(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string get_targetAssemblyTypeName() { }

	[CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEventBase)}, ReturnType = typeof(BaseInvokableCall))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	[ContainsUnimplementedInstructions]
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	[CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InvokableCallList), typeof(UnityEventBase)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PersistentCall)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PersistentCall), Member = "GetObjectCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(ArgumentCache)}, ReturnType = typeof(BaseInvokableCall))]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.Events.CachedInvokableCall`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CachedInvokableCall`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(MethodInfo), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnAfterDeserialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnBeforeSerialize() { }

}

