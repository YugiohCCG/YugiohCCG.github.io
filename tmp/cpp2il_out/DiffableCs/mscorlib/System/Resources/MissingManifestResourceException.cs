namespace System.Resources;

public class MissingManifestResourceException : SystemException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public MissingManifestResourceException() { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MissingManifestResourceException(SerializationInfo info, StreamingContext context) { }

}

