namespace UnityEngine;

internal class AndroidJNISafe
{

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CallObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "hashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(IntPtr))]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetConstructorMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "NewProxyInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "CreateInvocationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(AndroidJavaProxy)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaProxy)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNISafe), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStaticStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(string))]
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStringMethodUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue*)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[CallerCount(Count = 127)]
	[Calls(Type = typeof(AndroidJNI), Member = "ExceptionClear", ReturnType = typeof(void))]
	[Calls(Type = typeof(AndroidJNI), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNI), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNI), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNI), Member = "CallStaticStringMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(jvalue[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJavaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public static void CheckException() { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "FromJavaArrayDeleteLocalRef", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "DeleteJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "DeleteJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteLocalRef(IntPtr localref) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(AndroidJNI), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr FindClass(string name) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "FromBooleanArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Boolean[]))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Boolean[] FromBooleanArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static Byte[] FromByteArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Char[] FromCharArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Double[] FromDoubleArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Single[] FromFloatArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Int32[] FromIntArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Int64[] FromLongArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static SByte[] FromSByteArray(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static Int16[] FromShortArray(IntPtr array) { }

	[CalledBy(Type = typeof(AndroidJavaRunnableProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static int GetArrayLength(IntPtr array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodIDFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	[CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetStaticFieldID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodIDFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(jvalue), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetStaticMethodID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"FieldType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "FieldType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetStaticStringField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNI), Member = "GetStringChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static string GetStringChars(IntPtr str) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[CalledBy(Type = typeof(AndroidReflection), Member = "GetConstructorMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Span`1<UnityEngine.jvalue>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AndroidJNI), Member = "NewStringFromStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr NewString(string chars) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ArrayType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "ArrayType")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void PushLocalFrame(int capacity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr ToBooleanArray(Boolean[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static IntPtr ToByteArray(Byte[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToCharArray(Char[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToDoubleArray(Double[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToFloatArray(Single[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToIntArray(Int32[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToLongArray(Int64[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToSByteArray(SByte[] array) { }

	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static IntPtr ToShortArray(Int16[] array) { }

}

