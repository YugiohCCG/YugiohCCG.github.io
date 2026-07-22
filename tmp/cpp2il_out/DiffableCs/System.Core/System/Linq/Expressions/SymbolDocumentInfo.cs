namespace System.Linq.Expressions;

public class SymbolDocumentInfo
{
	internal static readonly Guid DocumentType_Text; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; //Field offset: 0x10

	public string FileName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	private static SymbolDocumentInfo() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_FileName() { }

}

