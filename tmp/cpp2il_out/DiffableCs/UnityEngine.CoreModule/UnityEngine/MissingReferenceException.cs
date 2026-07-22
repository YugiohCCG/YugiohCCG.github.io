namespace UnityEngine;

public class MissingReferenceException : Exception
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public MissingReferenceException() { }

	[CalledBy(Type = typeof(MonoBehaviour), Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public MissingReferenceException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	protected MissingReferenceException(SerializationInfo info, StreamingContext context) { }

}

