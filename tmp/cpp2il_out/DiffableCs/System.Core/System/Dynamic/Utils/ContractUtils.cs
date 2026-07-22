namespace System.Dynamic.Utils;

internal static class ContractUtils
{

	[ExcludeFromCodeCoverage]
	public static Exception Unreachable
	{
		[CallerCount(Count = 79)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		 get { } //Length: 88
	}

	[CallerCount(Count = 79)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static Exception get_Unreachable() { }

	[CalledBy(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContractUtils), Member = "RequiresNotNullItems", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionUtils), Member = "RequiresCanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	private static string GetParamName(string paramName, int index) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeCatchBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterExpression), typeof(Expression), typeof(Expression)}, ReturnType = typeof(CatchBlock))]
	[CalledBy(Type = typeof(BinaryOperationBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(ConvertBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DeleteMemberBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Error), Member = "InvalidArgumentValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public static void Requires(bool precondition, string paramName) { }

	[CalledBy(Type = "System.Dynamic.ExpandoObject+KeyCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpandoObject), Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyValuePair`2<String, Object>[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void RequiresArrayRange(IList<T> array, int offset, int count, string offsetName, string countName) { }

	[CallerCount(Count = 130)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void RequiresNotNull(object value, string paramName) { }

	[CalledBy(Type = typeof(Expression), Member = "BlockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression>)}, ReturnType = typeof(BlockExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContractUtils), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void RequiresNotNull(object value, string paramName, int index) { }

	[CalledBy(Type = typeof(Expression), Member = "MakeTry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(Expression), typeof(Expression), typeof(System.Collections.Generic.IEnumerable`1<System.Linq.Expressions.CatchBlock>)}, ReturnType = typeof(TryExpression))]
	[CalledBy(Type = typeof(CreateInstanceBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(DeleteIndexBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(GetIndexBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(InvokeBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(InvokeMemberBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CalledBy(Type = typeof(SetIndexBinder), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicMetaObject), typeof(DynamicMetaObject[])}, ReturnType = typeof(DynamicMetaObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ContractUtils), Member = "RequiresNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ContractUtils), Member = "GetParamName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void RequiresNotNullItems(IList<T> array, string arrayName) { }

}

