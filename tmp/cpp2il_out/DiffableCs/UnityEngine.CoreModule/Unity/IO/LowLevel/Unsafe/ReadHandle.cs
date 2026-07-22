namespace Unity.IO.LowLevel.Unsafe;

public struct ReadHandle : IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	internal IntPtr ptr; //Field offset: 0x0
	internal int version; //Field offset: 0x8

	public JobHandle JobHandle
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Clear", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Wait", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "WaitAll", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "FileExists", ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 225
	}

	public ReadStatus Status
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "GetStatus", ReturnType = typeof(ReadStatus))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateRequestState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ReadHandle), Member = "Dispose", ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 183
	}

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateState", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public void Cancel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::CancelReadRequest")]
	private static void CancelInternal(ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void CancelInternal_Injected(in ReadHandle handle) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadHandle), Member = "get_Status", ReturnType = typeof(ReadStatus))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Wait", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "WaitAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "FileExists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "FileExists", ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public JobHandle get_JobHandle() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "GetStatus", ReturnType = typeof(ReadStatus))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateRequestState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadHandle), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public ReadStatus get_Status() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::GetJobHandle", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static JobHandle GetJobHandle(ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetJobHandle_Injected(in ReadHandle handle, out JobHandle ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::GetReadStatus", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static ReadStatus GetReadStatus(ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ReadStatus GetReadStatus_Injected(in ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::IsReadHandleValid", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static bool IsReadHandleValid(ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsReadHandleValid_Injected(in ReadHandle handle) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "Wait", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", Member = "GetStatus", ReturnType = typeof(ReadStatus))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "Cancel", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "WaitAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateRequestState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeReferenceVolume+DiskStreamingRequest", typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "UpdateState", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume+CellStreamingRequest", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 35)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsValid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("AsyncReadManagerManaged::ReleaseReadHandle", IsThreadSafe = True)]
	[ThreadAndSerializationSafe]
	private static void ReleaseReadHandle(ReadHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReleaseReadHandle_Injected(in ReadHandle handle) { }

}

