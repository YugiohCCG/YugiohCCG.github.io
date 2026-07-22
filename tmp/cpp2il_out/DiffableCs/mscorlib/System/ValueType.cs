namespace System;

[ComVisible(True)]
public abstract class ValueType
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ValueType() { }

	[CalledBy(Type = typeof(Enum), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueType), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static bool DefaultEquals(object o1, object o2) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool InternalEquals(object o1, object o2, out Object[] fields) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static int InternalGetHashCode(object o, out Object[] fields) { }

	[CalledBy(Type = typeof(Nullable`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`2), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`2), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlScheme+DeviceRequirement", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControlScheme", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Users.InputUserAccountHandle", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

