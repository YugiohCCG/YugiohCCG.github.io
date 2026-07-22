namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/GPUFence.h")]
[UsedByNativeCode]
public struct GraphicsFence
{
	internal IntPtr m_Ptr; //Field offset: 0x0
	internal int m_Version; //Field offset: 0x8
	internal GraphicsFenceType m_FenceType; //Field offset: 0xC

	[CallerCount(Count = 0)]
	private int GetPlatformNotSupportedVersion() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("GPUFenceInternals::GetVersionNumber")]
	[NativeThrows]
	private static int GetVersionNumber(IntPtr fencePtr) { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "CreateAsyncGraphicsFence", ReturnType = typeof(GraphicsFence))]
	[CalledBy(Type = typeof(CommandBuffer), Member = "CreateGraphicsFence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFenceType), typeof(SynchronisationStageFlags)}, ReturnType = typeof(GraphicsFence))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	internal void InitPostAllocation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsFencePending() { }

	[CalledBy(Type = typeof(CommandBuffer), Member = "WaitOnAsyncGraphicsFence", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFence), typeof(SynchronisationStageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal void Validate() { }

}

