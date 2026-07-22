namespace UnityEngine;

public class AndroidJavaProxy
{
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; //Field offset: 0x0
	private static readonly IntPtr s_HashCodeMethodID; //Field offset: 0x8
	public readonly AndroidJavaClass javaInterface; //Field offset: 0x10
	internal IntPtr proxyObject; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static AndroidJavaProxy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AndroidJavaProxy(string javaInterface) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AndroidJavaProxy(AndroidJavaClass javaInterface) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool equals(AndroidJavaObject obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "AndroidJavaObjectDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaObject))]
	internal AndroidJavaObject GetProxyObject() { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "hashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetProxyObject", ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 6)]
	internal IntPtr GetRawProxy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticIntMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public override int hashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidReflection), Member = "CreateInvocationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 57)]
	public override AndroidJavaObject Invoke(string methodName, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "Unbox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	[CalledBy(Type = typeof(AndroidJavaRunnableProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetObjectArrayElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "AndroidJavaObjectDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaObject))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string toString() { }

}

