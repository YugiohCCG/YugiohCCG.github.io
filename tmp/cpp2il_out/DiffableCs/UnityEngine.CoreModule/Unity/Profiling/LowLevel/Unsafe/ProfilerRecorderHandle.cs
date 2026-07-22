namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerRecorderHandle
{
	internal readonly ulong handle; //Field offset: 0x0

	public bool Valid
	{
		[CalledBy(Type = typeof(Recorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 17
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal ProfilerRecorderHandle(ulong handle) { }

	[CalledBy(Type = typeof(Recorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_Valid() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, Byte* name, int nameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetByName__Unmanaged_Injected(in ProfilerCategory category, Byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	[CalledBy(Type = typeof(Recorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Sampler), Member = "GetRecorder", ReturnType = typeof(Recorder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetDescriptionInternal_Injected(in ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret) { }

}

