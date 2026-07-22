namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyCommandList.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class HierarchyCommandList : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(HierarchyCommandList cmdList) { }

	}

	private IntPtr m_Ptr; //Field offset: 0x10
	private readonly bool m_IsOwner; //Field offset: 0x18

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private HierarchyCommandList(IntPtr nativePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	private static IntPtr CreateCommandList(IntPtr nativePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HierarchyCommandListBindings::Destroy", IsThreadSafe = True)]
	private static void Destroy(IntPtr nativePtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr) { }

}

