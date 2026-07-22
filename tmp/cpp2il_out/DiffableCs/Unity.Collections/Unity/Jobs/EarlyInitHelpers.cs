namespace Unity.Jobs;

public class EarlyInitHelpers
{
	internal sealed class EarlyInitFunction : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public EarlyInitFunction(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	private static List<EarlyInitFunction> s_PendingDelegates; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EarlyInitHelpers), Member = "FlushEarlyInits", ReturnType = typeof(void))]
	private static EarlyInitHelpers() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public EarlyInitHelpers() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void AddEarlyInitFunction(EarlyInitFunction func) { }

	[CalledBy(Type = typeof(EarlyInitHelpers), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void FlushEarlyInits() { }

	[CalledBy(Type = typeof(__JobReflectionRegistrationOutput__1652832624114795843), Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CalledBy(Type = "__JobReflectionRegistrationOutput__15867191014387474753", Member = "CreateJobReflectionData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	public static void JobReflectionDataCreationFailed(Exception ex) { }

}

