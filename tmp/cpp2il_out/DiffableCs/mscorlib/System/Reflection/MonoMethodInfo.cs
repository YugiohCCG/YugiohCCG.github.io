namespace System.Reflection;

internal struct MonoMethodInfo
{
	private Type parent; //Field offset: 0x0
	private Type ret; //Field offset: 0x8
	internal MethodAttributes attrs; //Field offset: 0x10
	internal MethodImplAttributes iattrs; //Field offset: 0x14
	private CallingConventions callconv; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int get_method_attributes(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static Type GetDeclaringType(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static Type GetReturnType(IntPtr handle) { }

}

