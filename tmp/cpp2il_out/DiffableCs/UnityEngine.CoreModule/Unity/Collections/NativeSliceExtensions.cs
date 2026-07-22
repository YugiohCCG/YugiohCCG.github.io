namespace Unity.Collections;

[Extension]
public static class NativeSliceExtensions
{

	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobMerger", Member = "MergeAndReset", ReturnType = typeof(JobHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.Painter2D", Member = "ScheduleJobs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendUpdates", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendFullRange", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.Page+DataSet`1", Member = "SendPartialRanges", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.JobManager", Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativeList`1", Member = "GetSlice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.NativePagedList`1", Member = "GetPages", ReturnType = "System.Collections.Generic.List`1<NativeSlice`1<T>>")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.OpacityIdAccelerator", Member = "CompleteJobs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChain", Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NativeSlice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static NativeSlice<T> Slice(NativeArray<T> thisArray, int start, int length) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry", "UnityEngine.UIElements.TextureId"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "DrawReverseMask", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UnsafeMeshGenerationNode", "NativeRectParams&", typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NativeSlice`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static NativeSlice<T> Slice(NativeSlice<T> thisSlice, int start, int length) { }

}

