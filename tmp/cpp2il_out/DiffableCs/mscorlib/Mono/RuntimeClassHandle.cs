namespace Mono;

internal struct RuntimeClassHandle
{
	private MonoClass* value; //Field offset: 0x0

	internal MonoClass* Value
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal RuntimeClassHandle(MonoClass* value) { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal RuntimeClassHandle(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal MonoClass* get_Value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	internal static IntPtr GetTypeFromClass(MonoClass* klass) { }

	[CalledBy(Type = typeof(TransparentProxy), Member = "GetProxyType", ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	internal RuntimeTypeHandle GetTypeHandle() { }

}

