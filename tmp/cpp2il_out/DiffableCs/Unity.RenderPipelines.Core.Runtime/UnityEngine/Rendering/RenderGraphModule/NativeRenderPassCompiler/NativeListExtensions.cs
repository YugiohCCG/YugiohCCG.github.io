namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Extension]
internal static class NativeListExtensions
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	internal static int LastIndex(ref NativeList<T>& list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	internal static ReadOnlySpan<T> MakeReadOnlySpan(ref NativeList<T>& list, int first, int numElements) { }

}

