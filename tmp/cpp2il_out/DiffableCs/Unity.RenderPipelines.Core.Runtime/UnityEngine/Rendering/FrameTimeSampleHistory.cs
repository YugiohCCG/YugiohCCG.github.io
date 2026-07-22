namespace UnityEngine.Rendering;

internal class FrameTimeSampleHistory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_0(float value, float other) { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_1(float value, float other) { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_2(float value, float other) { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_3(float value, float other) { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_4(float value, float other) { }

		[CallerCount(Count = 0)]
		internal float <.cctor>b__15_5(float value, float other) { }

	}

	private static Func<Single, Single, Single> s_SampleValueAdd; //Field offset: 0x0
	private static Func<Single, Single, Single> s_SampleValueMin; //Field offset: 0x8
	private static Func<Single, Single, Single> s_SampleValueMax; //Field offset: 0x10
	private static Func<Single, Single, Single> s_SampleValueCountValid; //Field offset: 0x18
	private static Func<Single, Single, Single> s_SampleValueEnsureValid; //Field offset: 0x20
	private static Func<Single, Single, Single> s_SampleValueDivide; //Field offset: 0x28
	private List<FrameTimeSample> m_Samples; //Field offset: 0x10
	internal FrameTimeSample SampleAverage; //Field offset: 0x18
	internal FrameTimeSample SampleMin; //Field offset: 0x30
	internal FrameTimeSample SampleMax; //Field offset: 0x48

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Func`3<System.Single, System.Single, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static FrameTimeSampleHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public FrameTimeSampleHistory(int initialCapacity) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <ComputeAggregateValues>g__ForEachSampleMember|12_0(ref FrameTimeSample aggregate, FrameTimeSample sample, Func<Single, Single, Single> func) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void Add(FrameTimeSample sample) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal void Clear() { }

	[CalledBy(Type = typeof(DebugFrameTiming), Member = "UpdateFrameTiming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 42)]
	[CallsUnknownMethods(Count = 1)]
	internal void ComputeAggregateValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void DiscardOldSamples(int sampleHistorySize) { }

}

