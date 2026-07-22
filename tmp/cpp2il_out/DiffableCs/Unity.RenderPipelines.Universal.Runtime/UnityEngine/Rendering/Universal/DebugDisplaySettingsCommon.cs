namespace UnityEngine.Rendering.Universal;

internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Frequently Used", order = -1)]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			public Foldout foldout; //Field offset: 0x10

			[CallerCount(Count = 2180)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			public <>c__DisplayClass3_0() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
			[Calls(Type = typeof(DebugManager), Member = "PanelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[Calls(Type = typeof(DebugManager), Member = "RequestEditorWindowPanelIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			internal void <.ctor>b__0() { }

		}

		private const string k_GoToSectionString = "Go to Section..."; //Field offset: 0x0

		public virtual Flags Flags
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 6
		}

		[CalledBy(Type = typeof(DebugDisplaySettingsCommon), Member = "CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(RuntimeDebugShadersMessageBox), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
		[Calls(Type = typeof(DebugManager), Member = "GetItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags)}, ReturnType = typeof(Widget[]))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		public SettingsPanel() { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public virtual Flags get_Flags() { }

	}


	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugDisplaySettingsCommon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", ReturnType = typeof(void))]
	public override IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_AreAnySettingsActive() { }

}

