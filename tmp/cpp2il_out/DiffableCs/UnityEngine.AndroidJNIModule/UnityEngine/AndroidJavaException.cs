namespace UnityEngine;

public sealed class AndroidJavaException : Exception
{
	private string mJavaStackTrace; //Field offset: 0x90

	public virtual string StackTrace
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 39
	}

	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal AndroidJavaException(string message, string javaStackTrace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_StackTrace", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string get_StackTrace() { }

}

