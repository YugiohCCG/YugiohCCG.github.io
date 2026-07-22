namespace System.Reflection;

public sealed class MissingMetadataException : TypeAccessException
{

	[CalledBy(Type = typeof(ReflectionExecutionDomainCallbacks), Member = "CreateMissingMetadataException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeAccessException), Member = ".ctor", ReturnType = typeof(void))]
	public MissingMetadataException() { }

}

