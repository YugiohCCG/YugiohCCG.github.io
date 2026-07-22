namespace System;

internal class ReflectionOnlyType : RuntimeType
{

	public virtual RuntimeTypeHandle TypeHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 95
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = ".ctor", ReturnType = typeof(void))]
	private ReflectionOnlyType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

}

