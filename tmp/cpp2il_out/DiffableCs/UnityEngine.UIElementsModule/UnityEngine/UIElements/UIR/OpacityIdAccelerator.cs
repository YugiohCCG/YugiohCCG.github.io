namespace UnityEngine.UIElements.UIR;

internal class OpacityIdAccelerator : IDisposable
{
	private struct OpacityIdUpdateJob : IJobParallelFor
	{
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> oldVerts; //Field offset: 0x0
		[NativeDisableContainerSafetyRestriction]
		public NativeSlice<Vertex> newVerts; //Field offset: 0x10
		public Color32 opacityData; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vertex))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
		public override void Execute(int i) { }

	}

	private NativeArray<JobHandle> m_Jobs; //Field offset: 0x10
	private int m_NextJobIndex; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x24

	protected private bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public OpacityIdAccelerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "Complete", ReturnType = typeof(void))]
	public void CompleteJobs() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpacityIdUpdateJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpacityIdUpdateJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "CombineDependencies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<Unity.Jobs.JobHandle>)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(JobHandle), Member = "ScheduleBatchedJobs", ReturnType = typeof(void))]
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected bool get_disposed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

}

