namespace NGettext.Loaders;

public class MoAstPluralLoader : MoLoader
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public MoAstPluralLoader(string domain, string localeDir, MoFileParser parser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public MoAstPluralLoader(string filePath, MoFileParser parser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public MoAstPluralLoader(Stream moStream, MoFileParser parser) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public MoAstPluralLoader(string domain, string localeDir) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public MoAstPluralLoader(string filePath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AstTokenParser), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public MoAstPluralLoader(Stream moStream) { }

}

