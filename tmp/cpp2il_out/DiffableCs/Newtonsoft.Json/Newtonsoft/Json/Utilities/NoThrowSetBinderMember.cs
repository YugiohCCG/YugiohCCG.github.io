namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class NoThrowSetBinderMember : SetMemberBinder
{
	private readonly SetMemberBinder _innerBinder; //Field offset: 0x28

	[CalledBy(Type = typeof(JsonDynamicContract), Member = "CreateCallSiteSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite, System.Object, System.Object, System.Object>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SetMemberBinder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public NoThrowSetBinderMember(SetMemberBinder innerBinder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicMetaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(BindingRestrictions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public virtual DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

