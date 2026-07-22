namespace System.Linq.Expressions;

internal sealed class ByRefParameterExpression : TypedParameterExpression
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedParameterExpression), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	internal ByRefParameterExpression(Type type, string name) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool GetIsByRef() { }

}

