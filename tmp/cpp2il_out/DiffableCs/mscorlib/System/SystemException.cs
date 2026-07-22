namespace System;

public class SystemException : Exception
{

	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSyntaxException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.InternalException", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public SystemException() { }

	[CallerCount(Count = 233)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public SystemException(string message) { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	public SystemException(string message, Exception innerException) { }

	[CallerCount(Count = 64)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected SystemException(SerializationInfo info, StreamingContext context) { }

}

