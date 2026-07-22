namespace NGettext.Loaders;

public class CatalogLoadingException : Exception
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	public CatalogLoadingException() { }

	[CalledBy(Type = typeof(MoFileParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(MoFile))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public CatalogLoadingException(string message) { }

	[CalledBy(Type = typeof(MoFileParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(MoFile))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public CatalogLoadingException(string message, Exception innerException) { }

}

