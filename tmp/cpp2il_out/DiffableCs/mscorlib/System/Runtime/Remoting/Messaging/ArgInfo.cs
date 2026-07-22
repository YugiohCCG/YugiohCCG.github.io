namespace System.Runtime.Remoting.Messaging;

internal class ArgInfo
{
	private Int32[] _paramMap; //Field offset: 0x10
	private int _inoutArgCount; //Field offset: 0x18
	private MethodBase _method; //Field offset: 0x20

	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public ArgInfo(MethodBase method, ArgInfoType type) { }

	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public Object[] GetInOutArgs(Object[] args) { }

}

