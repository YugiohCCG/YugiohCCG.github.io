namespace System.Runtime.CompilerServices;

public abstract class CallSiteBinder
{
	private sealed class LambdaSignature
	{
		private static LambdaSignature<T> s_instance; //Field offset: 0x0
		internal readonly ReadOnlyCollection<ParameterExpression> Parameters; //Field offset: 0x0
		internal readonly LabelTarget ReturnLabel; //Field offset: 0x0

		internal static LambdaSignature<T> Instance
		{
			[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
			[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(LambdaSignature`1), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 12)]
			[DeduplicatedMethod]
			internal get { } //Length: 391
		}

		[CalledBy(Type = typeof(LambdaSignature`1), Member = "get_Instance", ReturnType = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
		[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TypeExtensions), Member = "GetReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(LabelTarget))]
		[Calls(Type = typeof(Error), Member = "FirstArgumentMustBeCallSite", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(Error), Member = "TypeParameterIsNotDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		[DeduplicatedMethod]
		private LambdaSignature`1() { }

		[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
		[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LambdaSignature`1), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 12)]
		[DeduplicatedMethod]
		internal static LambdaSignature<T> get_Instance() { }

	}

	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; //Field offset: 0x0
	internal Dictionary<Type, Object> Cache; //Field offset: 0x10

	public static LabelTarget UpdateLabel
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LabelTarget))]
	[CallsUnknownMethods(Count = 1)]
	private static CallSiteBinder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CallSiteBinder() { }

	public abstract Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LambdaSignature`1), Member = "get_Instance", ReturnType = "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>")]
	[Calls(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(CallSiteBinder), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[Calls(Type = typeof(RuleCache`1), Member = "AddRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "NoOrInvalidRuleProduced", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal T BindCore(CallSite<T> site, Object[] args) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override T BindDelegate(CallSite<T> site, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallSiteBinder), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[Calls(Type = typeof(RuleCache`1), Member = "AddRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void CacheTarget(T target) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static LabelTarget get_UpdateLabel() { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteBinder), Member = "CacheTarget", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSiteOps), Member = "GetRuleCache", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>"}, ReturnType = "System.Runtime.CompilerServices.RuleCache`1<T>")]
	[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuleCache`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal RuleCache<T> GetRuleCache() { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "BindCore", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSiteOps), Member = "Bind", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder), "System.Runtime.CompilerServices.CallSite`1<T>", typeof(Object[])}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(LabelExpression))]
	[Calls(Type = typeof(Expression), Member = "Condition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(PropertyInfo)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DefaultExpression))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_SetNotMatched", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(ReadOnlyCollectionBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlyCollectionBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static Expression<T> Stitch(Expression binding, LambdaSignature<T> signature) { }

}

