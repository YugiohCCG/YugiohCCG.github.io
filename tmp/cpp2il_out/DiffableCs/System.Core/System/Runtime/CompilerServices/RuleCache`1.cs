namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public class RuleCache
{
	private T[] _rules; //Field offset: 0x0
	private readonly object _cacheLock; //Field offset: 0x0

	[CalledBy(Type = typeof(CallSiteBinder), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal RuleCache`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "AddLast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private static T[] AddOrInsert(T[] rules, T item) { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "CacheTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionExtensions), Member = "AddLast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	internal void AddRule(T newRule) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal T[] GetRules() { }

	[CalledBy(Type = typeof(CallSiteOps), Member = "MoveRule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.RuleCache`1<T>", "T", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	[DeduplicatedMethod]
	internal void MoveRule(T rule, int i) { }

}

