namespace System.Data;

internal sealed class LikeNode : BinaryNode
{
	private int _kind; //Field offset: 0x30
	private string _pattern; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	[CalledBy(Type = typeof(LikeNode), Member = "Eval", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DataRow), typeof(DataRowVersion)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ExprException), Member = "InvalidPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 10)]
	internal string AnalyzePattern(string pat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataStorage), Member = "IsObjectSqlNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ExpressionNode), Member = "get_FormatProvider", ReturnType = typeof(IFormatProvider))]
	[Calls(Type = typeof(SqlConvert), Member = "ChangeType2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StorageType), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(LikeNode), Member = "AnalyzePattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SqlString), Member = "get_Value", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DataTable), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DataTable), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(BinaryNode), Member = "SetTypeMismatchError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal virtual object Eval(DataRow row, DataRowVersion version) { }

}

