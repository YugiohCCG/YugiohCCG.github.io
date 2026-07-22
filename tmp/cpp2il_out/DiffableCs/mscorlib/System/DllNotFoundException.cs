namespace System;

public class DllNotFoundException : TypeLoadException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DllNotFoundException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public DllNotFoundException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected DllNotFoundException(SerializationInfo info, StreamingContext context) { }

}

