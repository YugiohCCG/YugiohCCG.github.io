namespace UnityEngine;

[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
internal sealed class UnhandledExceptionHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnhandledExceptionEventHandler <>9__0_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e) { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AppDomain), Member = "add_UnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnhandledExceptionEventHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void RegisterUECatcher() { }

}

