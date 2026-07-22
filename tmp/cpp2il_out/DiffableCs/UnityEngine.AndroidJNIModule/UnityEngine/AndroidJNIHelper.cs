namespace UnityEngine;

[NativeConditional("PLATFORM_ANDROID")]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType::DoubleColon (2))]
[UsedByNativeCode]
public static class AndroidJNIHelper
{

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 4)]
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	public static IntPtr Box(int value) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public static IntPtr Box(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static ArrayType ConvertFromJNIArray(IntPtr array) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static void CreateJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void DeleteJNIArgArray(Object[] args, Span<jvalue> jniArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	public static IntPtr GetConstructorID(IntPtr jclass, Object[] args) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, bool isStatic) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, Object[] args, bool isStatic) { }

}

