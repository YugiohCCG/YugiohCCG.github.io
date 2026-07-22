namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("Runtime/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[UsedByNativeCode]
public sealed class Profiler
{

	[CalledBy(Type = "UnityEngine.Rendering.RenderGraphModule.TexturePool", Member = "GetResourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RTHandle&"}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
	public static long GetRuntimeMemorySizeLong(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long GetRuntimeMemorySizeLong_Injected(IntPtr o) { }

}

