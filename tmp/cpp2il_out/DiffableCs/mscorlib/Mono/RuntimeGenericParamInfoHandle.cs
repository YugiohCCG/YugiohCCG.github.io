namespace Mono;

internal struct RuntimeGenericParamInfoHandle
{
	private GenericParamInfo* value; //Field offset: 0x0

	internal GenericParameterAttributes Attributes
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 26
	}

	internal Type[] Constraints
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "GetConstraints", ReturnType = typeof(Type[]))]
		internal get { } //Length: 7
	}

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal RuntimeGenericParamInfoHandle(IntPtr ptr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal GenericParameterAttributes get_Attributes() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "GetConstraints", ReturnType = typeof(Type[]))]
	internal Type[] get_Constraints() { }

	[CalledBy(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Constraints", ReturnType = typeof(Type[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 6)]
	private Type[] GetConstraints() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int GetConstraintsCount() { }

}

