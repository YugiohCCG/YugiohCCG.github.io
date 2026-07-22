namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints; //Field offset: 0x0
	internal GlobalJavaObjectRef m_jobject; //Field offset: 0x10
	internal GlobalJavaObjectRef m_jclass; //Field offset: 0x18

	[CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsInvalidInstructions]
	private void _AndroidJavaObject(string className, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "NewObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void _AndroidJavaObject(IntPtr constructorID, Object[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallBooleanMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallSByteMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallShortMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallLongMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallFloatMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallDoubleMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallCharMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNI), Member = "PopLocalFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidReflection), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNI), Member = "PushLocalFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallIntMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 53)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected ReturnType _Call(IntPtr methodID, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	protected ReturnType _Call(string methodName, Object[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallVoidMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	protected void _Call(IntPtr methodID, Object[] args) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void _Call(string methodName, Object[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticBooleanMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticSByteMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticShortMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticLongMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticFloatMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticDoubleMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticCharMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNI), Member = "PopLocalFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidReflection), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNI), Member = "PushLocalFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticIntMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 49)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected ReturnType _CallStatic(IntPtr methodID, Object[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ReturnType _CallStatic(string methodName, Object[] args) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IntPtr _GetRawClass() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected IntPtr _GetRawObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticDoubleField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticIntField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticBooleanField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticSByteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticShortField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticLongField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticFloatField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticCharField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticStringField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "AndroidJavaClassDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaClass))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "AndroidJavaObjectDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaObject))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "FromJavaArrayDeleteLocalRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ReturnType")]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticObjectField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidReflection), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 44)]
	[DeduplicatedMethod]
	protected FieldType _GetStatic(IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNIHelper), Member = "GetFieldID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	protected FieldType _GetStatic(string fieldName) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public AndroidJavaObject(string className, Object[] args) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "AndroidJavaObjectDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetObjectClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public AndroidJavaObject(IntPtr jobject) { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal AndroidJavaObject() { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetProxyObject", ReturnType = typeof(AndroidJavaObject))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "UnboxArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Unbox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(Object[]), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public ReturnType Call(string methodName, Object[] args) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Call(string methodName, Object[] args) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "UnboxArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReturnType CallStatic(string methodName, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	protected void DebugPrint(string msg) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(AndroidJavaObject[])}, ReturnType = typeof(AndroidJavaObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static ReturnType FromJavaArray(IntPtr jobject) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	internal static ReturnType FromJavaArrayDeleteLocalRef(IntPtr jobject) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IntPtr GetRawClass() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public IntPtr GetRawObject() { }

	[CalledBy(Type = "Plugins.OmegaAndroidPlugin", Member = "get_API_Level", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "FieldType")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FieldType GetStatic(string fieldName) { }

}

