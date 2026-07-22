namespace System;

internal static class NotImplemented
{

	internal static Exception ByDesign
	{
		[CalledBy(Type = typeof(Type), Member = "get_IsConstructedGenericType", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ParameterInfo), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(Module), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(Module), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Module), Member = "IsResource", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Module), Member = "get_ScopeName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Module), Member = "get_ModuleVersionId", ReturnType = typeof(Guid))]
		[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnParameter", ReturnType = typeof(ParameterInfo))]
		[CalledBy(Type = typeof(MethodBase), Member = "get_IsSecurityCritical", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MemberInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
		[CalledBy(Type = typeof(MemberInfo), Member = "get_Module", ReturnType = typeof(Module))]
		[CalledBy(Type = typeof(Type), Member = "GetEnumValues", ReturnType = typeof(Array))]
		[CalledBy(Type = typeof(Type), Member = "get_IsSZArray", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Module), Member = "get_Assembly", ReturnType = typeof(Assembly))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		internal get { } //Length: 68
	}

	[CalledBy(Type = typeof(Type), Member = "get_IsConstructedGenericType", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "get_Assembly", ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(Type), Member = "get_IsSZArray", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumValues", ReturnType = typeof(Array))]
	[CalledBy(Type = typeof(MemberInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(MemberInfo), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(MethodBase), Member = "get_IsSecurityCritical", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnParameter", ReturnType = typeof(ParameterInfo))]
	[CalledBy(Type = typeof(MethodInfo), Member = "get_ReturnType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Module), Member = "get_ScopeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Module), Member = "IsResource", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Module), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Module), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParameterInfo), Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Module), Member = "get_ModuleVersionId", ReturnType = typeof(Guid))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	internal static Exception get_ByDesign() { }

}

