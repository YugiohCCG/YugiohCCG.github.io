namespace UnityEngine.Assertions;

internal class AssertionMessageUtil
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	public static string BooleanFailureMessage(bool expected) { }

	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string), "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	[ContainsInvalidInstructions]
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public static string GetMessage(string failureMessage) { }

	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssertionMessageUtil), Member = "BooleanFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 26)]
	public static string GetMessage(string failureMessage, string expected) { }

	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 10)]
	public static string NullFailureMessage(object value, bool expectNull) { }

}

