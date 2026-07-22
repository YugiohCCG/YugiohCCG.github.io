namespace UnityEngine;

public class AndroidJavaClass : AndroidJavaObject
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void _AndroidJavaClass(string className) { }

	[CalledBy(Type = "Plugins.OmegaAndroidPlugin", Member = "get_API_Level", ReturnType = typeof(int))]
	[CalledBy(Type = "Plugins.OmegaAndroidPlugin", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaRunnableProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "UnboxArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaRunnable)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public AndroidJavaClass(string className) { }

	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ReturnType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Object[])}, ReturnType = "ReturnType")]
	[CalledBy(Type = typeof(AndroidJavaObject), Member = "AndroidJavaClassDeleteLocalRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AndroidJavaClass))]
	[CalledBy(Type = typeof(_AndroidJNIHelper), Member = "Unbox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AndroidJavaObject)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	internal AndroidJavaClass(IntPtr jclass) { }

}

