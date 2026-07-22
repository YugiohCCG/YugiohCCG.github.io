namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression
{
	[CompilerGenerated]
	private readonly SymbolDocumentInfo <Document>k__BackingField; //Field offset: 0x10

	public SymbolDocumentInfo Document
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[ExcludeFromCodeCoverage]
	public override int EndLine
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	public override bool IsClear
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	public override int StartLine
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public SymbolDocumentInfo get_Document() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override int get_EndLine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsClear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContractUtils), Member = "get_Unreachable", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override int get_StartLine() { }

}

