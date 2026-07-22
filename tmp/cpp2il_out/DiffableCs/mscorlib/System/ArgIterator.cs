namespace System;

public struct ArgIterator
{
	private IntPtr sig; //Field offset: 0x0
	private IntPtr args; //Field offset: 0x8
	private int next_arg; //Field offset: 0x10
	private int num_args; //Field offset: 0x14

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

