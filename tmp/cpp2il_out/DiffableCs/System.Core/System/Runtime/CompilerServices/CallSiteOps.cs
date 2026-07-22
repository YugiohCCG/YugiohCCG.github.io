namespace System.Runtime.CompilerServices;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState::Never (1))]
public static class CallSiteOps
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallSite`1), Member = "AddRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void AddRule(CallSite<T> site, T rule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1", Member = "get_Instance", ReturnType = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>")]
	[Calls(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(CallSiteBinder), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[Calls(Type = typeof(RuleCache`1), Member = "AddRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "NoOrInvalidRuleProduced", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T Bind(CallSiteBinder binder, CallSite<T> site, Object[] args) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void ClearMatch(CallSite site) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallSite`1), Member = "CreateMatchMaker", ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static CallSite<T> CreateMatchmaker(CallSite<T> site) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetCachedRules(RuleCache<T> cache) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool GetMatch(CallSite site) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallSiteBinder), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static RuleCache<T> GetRuleCache(CallSite<T> site) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static T[] GetRules(CallSite<T> site) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuleCache`1), Member = "MoveRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void MoveRule(RuleCache<T> cache, T rule, int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static bool SetNotMatched(CallSite site) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallSite`1), Member = "MoveRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("do not use this method", True)]
	public static void UpdateRules(CallSite<T> this, int matched) { }

}

