namespace System.Data;

internal sealed class ConstNode : ExpressionNode
{
	internal readonly object _val; //Field offset: 0x18

	[CalledBy(Type = typeof(FunctionNode), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(System.Collections.Generic.List`1<System.Data.DataColumn>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	internal ConstNode(DataTable table, ValueType type, object constant) { }

	[CalledBy(Type = typeof(FunctionNode), Member = "Optimize", ReturnType = typeof(ExpressionNode))]
	[CalledBy(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnaryNode), Member = "Optimize", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstNode), Member = "SmallestNumeric", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ConstNode), Member = "SmallestDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal ConstNode(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void Bind(DataTable table, List<DataColumn> list) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal virtual object Eval() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object Eval(Int32[] recordNos) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasLocalAggregate() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal virtual bool HasRemoteAggregate() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool IsConstant() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	internal virtual bool IsTableConstant() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	internal virtual ExpressionNode Optimize() { }

	[CalledBy(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private object SmallestDecimal(object constant) { }

	[CalledBy(Type = typeof(ConstNode), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataTable), typeof(ValueType), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(ExceptionBuilder), Member = "TraceExceptionWithoutRethrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private object SmallestNumeric(object constant) { }

}

