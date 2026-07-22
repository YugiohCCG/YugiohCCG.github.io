namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[UsedByNativeCode]
public class Sampler
{
	internal static Sampler s_InvalidSampler; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool isValid
	{
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static Sampler() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Sampler() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal Sampler(IntPtr ptr) { }

	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isValid() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProfilingSampler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintManager+Profiling", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ProfilerRecorderHandle), Member = "get_Valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ProfilerRecorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle), typeof(int), typeof(ProfilerRecorderOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerRecorderHandle), Member = "GetDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilerRecorderHandle)}, ReturnType = typeof(ProfilerRecorderDescription))]
	[CallsDeduplicatedMethods(Count = 3)]
	public Recorder GetRecorder() { }

}

