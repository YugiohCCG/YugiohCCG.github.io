namespace System.Linq.Expressions;

internal static class CachedReflectionInfo
{
	private static MethodInfo s_CallSiteOps_SetNotMatched; //Field offset: 0x0
	private static MethodInfo s_CallSiteOps_CreateMatchmaker; //Field offset: 0x8
	private static MethodInfo s_CallSiteOps_GetMatch; //Field offset: 0x10
	private static MethodInfo s_CallSiteOps_ClearMatch; //Field offset: 0x18
	private static MethodInfo s_CallSiteOps_UpdateRules; //Field offset: 0x20
	private static MethodInfo s_CallSiteOps_GetRules; //Field offset: 0x28
	private static MethodInfo s_CallSiteOps_GetRuleCache; //Field offset: 0x30
	private static MethodInfo s_CallSiteOps_GetCachedRules; //Field offset: 0x38
	private static MethodInfo s_CallSiteOps_AddRule; //Field offset: 0x40
	private static MethodInfo s_CallSiteOps_MoveRule; //Field offset: 0x48
	private static MethodInfo s_CallSiteOps_Bind; //Field offset: 0x50
	private static MethodInfo s_String_op_Equality_String_String; //Field offset: 0x58
	private static MethodInfo s_Math_Pow_Double_Double; //Field offset: 0x60

	public static MethodInfo CallSiteOps_AddRule
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_Bind
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_ClearMatch
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_CreateMatchmaker
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_GetCachedRules
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_GetMatch
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_GetRuleCache
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_GetRules
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_MoveRule
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo CallSiteOps_SetNotMatched
	{
		[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 197
	}

	public static MethodInfo CallSiteOps_UpdateRules
	{
		[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 203
	}

	public static MethodInfo Math_Pow_Double_Double
	{
		[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
		[CalledBy(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
		[CalledBy(Type = typeof(Expression), Member = "PowerAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 11)]
		 get { } //Length: 464
	}

	public static MethodInfo String_op_Equality_String_String
	{
		[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
		[CallsUnknownMethods(Count = 11)]
		 get { } //Length: 453
	}

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_AddRule() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_Bind() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_ClearMatch() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_CreateMatchmaker() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_GetCachedRules() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_GetMatch() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_GetRuleCache() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_GetRules() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_MoveRule() { }

	[CalledBy(Type = typeof(CallSiteBinder), Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_SetNotMatched() { }

	[CalledBy(Type = typeof(CallSite`1), Member = "CreateCustomUpdateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 2)]
	public static MethodInfo get_CallSiteOps_UpdateRules() { }

	[CalledBy(Type = typeof(Expression), Member = "MakeBinary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionType), typeof(Expression), typeof(Expression), typeof(bool), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo)}, ReturnType = typeof(BinaryExpression))]
	[CalledBy(Type = typeof(Expression), Member = "PowerAssign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(Expression), typeof(MethodInfo), typeof(LambdaExpression)}, ReturnType = typeof(BinaryExpression))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 11)]
	public static MethodInfo get_Math_Pow_Double_Double() { }

	[CalledBy(Type = typeof(LightCompiler), Member = "CompileSwitchExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[CallsUnknownMethods(Count = 11)]
	public static MethodInfo get_String_op_Equality_String_String() { }

}

