namespace Unity.Jobs;

[Extension]
public static class IJobFilterExtensions
{
	public struct JobFilterProducer
	{
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 4)]
			[DeduplicatedMethod]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			public override IAsyncResult BeginInvoke(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void EndInvoke(ref JobWrapper<T> jobWrapper, ref JobRanges ranges, IAsyncResult result) { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public override void Invoke(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		internal struct JobWrapper
		{
			[NativeDisableParallelForRestriction]
			public NativeList<Int32> outputIndices; //Field offset: 0x0
			public int appendCount; //Field offset: 0x0
			public T JobData; //Field offset: 0x0

		}

		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private static JobFilterProducer`1() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 11)]
		[DeduplicatedMethod]
		public static void Execute(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeList`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 25)]
		[DeduplicatedMethod]
		public static void ExecuteAppend(ref JobWrapper<T> jobWrapper, IntPtr bufferRangePatchData) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NativeList`1), Member = "ResizeUninitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		public static void ExecuteFilter(ref JobWrapper<T> jobWrapper, IntPtr bufferRangePatchData) { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(JobsUtility), Member = "CreateJobReflectionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(object)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 16)]
		[DeduplicatedMethod]
		internal static void Initialize() { }

	}


	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static void EarlyJobInit() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static IntPtr GetReflectionData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunAppend(T jobData, NativeList<Int32> indices, int arrayLength) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunAppendByRef(ref T jobData, NativeList<Int32> indices, int arrayLength) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunFilter(T jobData, NativeList<Int32> indices) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static void RunFilterByRef(ref T jobData, NativeList<Int32> indices) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleAppend(T jobData, NativeList<Int32> indices, int arrayLength, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleAppendByRef(ref T jobData, NativeList<Int32> indices, int arrayLength, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleFilter(T jobData, NativeList<Int32> indices, JobHandle dependsOn = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobScheduleParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(IntPtr), typeof(JobHandle), typeof(ScheduleMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JobsUtility), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobScheduleParameters&)}, ReturnType = typeof(JobHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	[Extension]
	public static JobHandle ScheduleFilterByRef(ref T jobData, NativeList<Int32> indices, JobHandle dependsOn = null) { }

}

