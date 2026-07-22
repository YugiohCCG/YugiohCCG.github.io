namespace UnityEngine;

internal class AndroidJavaRunnableProxy : AndroidJavaProxy
{
	private AndroidJavaRunnable mRunnable; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AndroidJavaRunnableProxy(AndroidJavaRunnable runnable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AndroidJNISafe), Member = "GetArrayLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void run() { }

}

