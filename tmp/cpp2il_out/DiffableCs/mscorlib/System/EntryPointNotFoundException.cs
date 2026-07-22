namespace System;

public class EntryPointNotFoundException : TypeLoadException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public EntryPointNotFoundException() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public EntryPointNotFoundException(string message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) { }

}

