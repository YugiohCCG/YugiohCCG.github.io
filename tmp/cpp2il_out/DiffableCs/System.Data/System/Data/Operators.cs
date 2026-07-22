namespace System.Data;

internal sealed class Operators
{
	private static readonly Int32[] s_priority; //Field offset: 0x0
	private static readonly String[] s_looks; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 44)]
	private static Operators() { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsArithmetical(int op) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CalledBy(Type = typeof(BinaryNode), Member = "ResultSqlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static bool IsLogical(int op) { }

	[CalledBy(Type = typeof(BinaryNode), Member = "ResultType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StorageType), typeof(StorageType), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(StorageType))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static bool IsRelational(int op) { }

	[CalledBy(Type = typeof(ExpressionParser), Member = "Parse", ReturnType = typeof(ExpressionNode))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static int Priority(int op) { }

	[CalledBy(Type = typeof(ExprException), Member = "MissingOperand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperatorInfo)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "TypeMismatchInBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "AmbiguousBinop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ExprException), Member = "UnsupportedOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal static string ToString(int op) { }

}

