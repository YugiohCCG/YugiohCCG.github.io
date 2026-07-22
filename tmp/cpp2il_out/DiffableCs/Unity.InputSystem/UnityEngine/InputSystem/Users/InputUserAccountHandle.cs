namespace UnityEngine.InputSystem.Users;

public struct InputUserAccountHandle : IEquatable<InputUserAccountHandle>
{
	private string m_ApiName; //Field offset: 0x0
	private ulong m_Handle; //Field offset: 0x8

	public string apiName
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public ulong handle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(InputUser), Member = "QueryPairedPlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(Nullable`1<InputUserAccountHandle>&), typeof(String&), typeof(String&)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public InputUserAccountHandle(string apiName, ulong handle) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public override bool Equals(InputUserAccountHandle other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public string get_apiName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ulong get_handle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	public static bool op_Equality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	[CalledBy(Type = typeof(InputUser), Member = "UpdatePlatformUserAccount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputDevice)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool op_Inequality(InputUserAccountHandle left, InputUserAccountHandle right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

