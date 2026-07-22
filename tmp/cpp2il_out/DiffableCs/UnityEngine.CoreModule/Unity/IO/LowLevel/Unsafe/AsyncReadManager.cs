namespace Unity.IO.LowLevel.Unsafe;

[NativeHeader("Runtime/File/AsyncReadManagerManagedApi.h")]
public static class AsyncReadManager
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::ScheduleCloseRequest", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	internal static JobHandle CloseFileAsync(in FileHandle fileHandle, JobHandle dependency) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CloseFileAsync_Injected(in FileHandle fileHandle, in JobHandle dependency, out JobHandle ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "FileExists", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncReadManager), Member = "GetFileInfoInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Void*)}, ReturnType = typeof(ReadHandle))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static ReadHandle GetFileInfo(string filename, FileInfoResult* result) { }

	[CalledBy(Type = typeof(AsyncReadManager), Member = "GetFileInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileInfoResult*)}, ReturnType = typeof(ReadHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AsyncReadManagerManaged::GetFileInfo", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static ReadHandle GetFileInfoInternal(string filename, Void* cmd) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetFileInfoInternal_Injected(ref ManagedSpanWrapper filename, Void* cmd, out ReadHandle ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "OpenFile", ReturnType = typeof(FileHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncReadManager), Member = "OpenFileAsync_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileHandle))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static FileHandle OpenFileAsync(string fileName) { }

	[CalledBy(Type = typeof(AsyncReadManager), Member = "OpenFileAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("AsyncReadManagerManaged::ScheduleOpenRequest", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static FileHandle OpenFileAsync_Internal(string fileName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void OpenFileAsync_Internal_Injected(ref ManagedSpanWrapper fileName, out FileHandle ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "RunCommands", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileHandle)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public static ReadHandle Read(in FileHandle fileHandle, ReadCommandArray readCmdArray) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::ReadWithHandles_NativeCopy", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static ReadHandle ReadWithHandlesInternal_NativeCopy(in FileHandle fileHandle, Void* readCmdArray) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReadWithHandlesInternal_NativeCopy_Injected(in FileHandle fileHandle, Void* readCmdArray, out ReadHandle ret) { }

}

