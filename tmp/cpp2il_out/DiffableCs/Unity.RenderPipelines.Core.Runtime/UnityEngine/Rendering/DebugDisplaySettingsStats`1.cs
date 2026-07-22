namespace UnityEngine.Rendering;

public class DebugDisplaySettingsStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Display Stats", order = -2147483648)]
	private class StatsPanel : DebugDisplaySettingsPanel
	{
		private readonly DebugDisplaySettingsStats<TProfileId> m_Data; //Field offset: 0x0

		public virtual Flags Flags
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CalledBy(Type = typeof(DebugDisplaySettingsStats`1), Member = "CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		public StatsPanel(DebugDisplaySettingsStats<TProfileId> displaySettingsStats) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public virtual void Dispose() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual Flags get_Flags() { }

	}

	[CompilerGenerated]
	private readonly DebugDisplayStats<TProfileId> <debugDisplayStats>k__BackingField; //Field offset: 0x0

	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public DebugDisplayStats<TProfileId> debugDisplayStats
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugDisplaySettingsStats`1(DebugDisplayStats<TProfileId> debugDisplayStats) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugDisplaySettingsStats`1<TProfileId>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DebugDisplayStats<TProfileId> get_debugDisplayStats() { }

}

