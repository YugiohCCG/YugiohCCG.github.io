namespace Unity.IO.LowLevel.Unsafe;

[IsReadOnly]
public struct FileHandle
{
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr fileCommandPtr; //Field offset: 0x0
	internal readonly int version; //Field offset: 0x8

	public JobHandle JobHandle
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "CloseFile", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 205
	}

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "CloseFile", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public JobHandle Close(JobHandle dependency = null) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "CloseFile", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public JobHandle get_JobHandle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::GetJobFenceFromManagedHandle")]
	private static JobHandle GetJobHandle_Internal(in FileHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetJobHandle_Internal_Injected(in FileHandle handle, out JobHandle ret) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("AsyncReadManagerManaged::IsFileHandleValid")]
	private static bool IsFileHandleValid(in FileHandle handle) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool IsValid() { }

}

