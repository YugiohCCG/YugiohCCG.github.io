namespace UnityEngine.Android;

[NativeHeader("Modules/AndroidJNI/Public/AndroidApplication.bindings.h")]
[StaticAccessor("AndroidApplication", StaticAccessorType::DoubleColon (2))]
public static class AndroidApplication
{
	private static SynchronizationContext m_MainThreadSynchronizationContext; //Field offset: 0x0
	private static AndroidConfiguration m_CurrentConfiguration; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<AndroidConfiguration> onConfigurationChanged; //Field offset: 0x10

	internal static IntPtr UnityPlayerRaw
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[ThreadSafe]
		internal get { } //Length: 42
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static void AcquireMainThreadSynchronizationContext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static void DispatchConfigurationChanged(bool notifySubscribers) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	internal static IntPtr get_UnityPlayerRaw() { }

	[CallerCount(Count = 0)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static AndroidConfiguration GetCurrentConfiguration() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static void SetCurrentConfiguration(AndroidConfiguration config) { }

}

