namespace System.Runtime.CompilerServices;

public class CallSite : CallSite
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Converter<ParameterInfo, ParameterExpression> <>9__20_0; //Field offset: 0x0
		public static Converter<ParameterExpression, Expression> <>9__20_1; //Field offset: 0x0
		public static Converter<ParameterInfo, ParameterExpression> <>9__21_0; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ParameterExpression <CreateCustomNoMatchDelegate>b__21_0(ParameterInfo p) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Expression), Member = "Parameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ParameterExpression <CreateCustomUpdateDelegate>b__20_0(ParameterInfo p) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CallSite`1), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(Expression))]
		[DeduplicatedMethod]
		internal Expression <CreateCustomUpdateDelegate>b__20_1(ParameterExpression p) { }

	}

	private static T s_cachedUpdate; //Field offset: 0x0
	private static T s_cachedNoMatch; //Field offset: 0x0
	public T Target; //Field offset: 0x0
	internal T[] Rules; //Field offset: 0x0

	public T Update
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 108
	}

	[CalledBy(Type = typeof(CallSite`1), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private CallSite`1(CallSiteBinder binder) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private CallSite`1() { }

	[CalledBy(Type = typeof(CallSiteOps), Member = "AddRule", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal void AddRule(T newRule) { }

	[CalledBy(Type = typeof(<>c), Member = "<CreateCustomUpdateDelegate>b__20_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterExpression)}, ReturnType = typeof(Expression))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeUtils), Member = "AreReferenceAssignable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static Expression Convert(Expression arg, Type type) { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDynamicContract", Member = "CreateCallSiteGetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<Func`3<CallSite, Object, Object>>")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDynamicContract", Member = "CreateCallSiteSetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<Func`4<CallSite, Object, Object, Object>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallSite`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Error), Member = "TypeMustBeDerivedFromSystemDelegate", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static CallSite<T> Create(CallSiteBinder binder) { }

	[CalledBy(Type = typeof(CallSite`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSite`1), Member = "GetUpdateDelegate", ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "GetUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "MakeUpdateDelegate", ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DefaultExpression))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(Array), Member = "ConvertAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInput", "TOutput"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInput[]", "System.Converter`2<TInput, TOutput>"}, ReturnType = "TOutput[]")]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }

	[CalledBy(Type = typeof(CallSite`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallSiteBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallSite`1), Member = "GetUpdateDelegate", ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "GetUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[CalledBy(Type = typeof(CallSite`1), Member = "MakeUpdateDelegate", ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Expression), Member = "ArrayAccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(IndexExpression))]
	[Calls(Type = typeof(Expression), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(LabelTarget), typeof(LabelTarget)}, ReturnType = typeof(LoopExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Utils), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "Constant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(ConstantExpression))]
	[Calls(Type = typeof(Expression), Member = "NotEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_GetRuleCache", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_GetRules", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "PreIncrementAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "ArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_GetCachedRules", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_MoveRule", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Break", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(GotoExpression))]
	[Calls(Type = typeof(Expression), Member = "TryFinally", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(TryExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "NewArrayInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(NewArrayExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_Bind", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression), Member = "Default", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(DefaultExpression))]
	[Calls(Type = typeof(ArrayBuilderExtensions), Member = "ToReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ArrayBuilder`1<T>"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(LabelExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_AddRule", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Equal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "IfThen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(ConditionalExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_CreateMatchmaker", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArrayBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[Calls(Type = typeof(Array), Member = "ConvertAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInput", "TOutput"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInput[]", "System.Converter`2<TInput, TOutput>"}, ReturnType = "TOutput[]")]
	[Calls(Type = typeof(Expression), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(LabelTarget))]
	[Calls(Type = typeof(CollectionExtensions), Member = "RemoveFirst", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Expression), Member = "Variable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ParameterExpression))]
	[Calls(Type = typeof(Expression), Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Type)}, ReturnType = typeof(UnaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Assign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BinaryExpression))]
	[Calls(Type = typeof(Expression), Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string)}, ReturnType = typeof(MemberExpression))]
	[Calls(Type = typeof(Expression`1), Member = "Compile", ReturnType = "TDelegate")]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_GetMatch", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_ClearMatch", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(TrueReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Expression), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(InvocationExpression))]
	[Calls(Type = typeof(CachedReflectionInfo), Member = "get_CallSiteOps_UpdateRules", ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Expression), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(Expression), typeof(Expression)}, ReturnType = typeof(MethodCallExpression))]
	[Calls(Type = typeof(Expression), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget), typeof(Expression)}, ReturnType = typeof(GotoExpression))]
	[Calls(Type = typeof(Expression), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelTarget)}, ReturnType = typeof(GotoExpression))]
	[Calls(Type = typeof(Expression), Member = "Block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression)}, ReturnType = typeof(BlockExpression))]
	[Calls(Type = typeof(Expression), Member = "Lambda", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = "System.Linq.Expressions.Expression`1<TDelegate>")]
	[Calls(Type = typeof(Expression), Member = "Label", ReturnType = typeof(LabelTarget))]
	[CallsDeduplicatedMethods(Count = 37)]
	[CallsUnknownMethods(Count = 24)]
	[DeduplicatedMethod]
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }

	[CalledBy(Type = typeof(CallSiteOps), Member = "CreateMatchmaker", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>"}, ReturnType = "System.Runtime.CompilerServices.CallSite`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal CallSite<T> CreateMatchMaker() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public T get_Update() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private T GetUpdateDelegate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private T GetUpdateDelegate(ref T addr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeUtils), Member = "GetInvokeMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomNoMatchDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[Calls(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal T MakeUpdateDelegate() { }

	[CalledBy(Type = typeof(CallSiteOps), Member = "UpdateRules", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Runtime.CompilerServices.CallSite`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void MoveRule(int i) { }

}

