namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
public static class NativeReferenceUnsafeUtility
{

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static T* GetUnsafePtr(NativeReference<T> reference) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static T* GetUnsafePtrWithoutChecks(NativeReference<T> reference) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	public static T* GetUnsafeReadOnlyPtr(NativeReference<T> reference) { }

}

