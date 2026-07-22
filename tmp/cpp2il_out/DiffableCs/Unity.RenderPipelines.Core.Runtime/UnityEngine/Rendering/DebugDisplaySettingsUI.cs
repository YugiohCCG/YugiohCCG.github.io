namespace UnityEngine.Rendering;

public class DebugDisplaySettingsUI : IDebugData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DebugManager debugManager; //Field offset: 0x10
		public List<IDebugDisplaySettingsPanelDisposable> panels; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass3_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		internal void <RegisterDebug>b__0(IDebugDisplaySettingsData data) { }

	}

	private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels; //Field offset: 0x10
	private IDebugDisplaySettings m_Settings; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugDisplaySettingsUI() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Action GetReset() { }

	[CalledBy(Type = typeof(DebugDisplaySettingsUI), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(DebugDisplaySettingsRenderGraph), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void RegisterDebug(IDebugDisplaySettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugDisplaySettingsUI), Member = "UnregisterDebug", ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugDisplaySettingsUI), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugDisplaySettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[CallsUnknownMethods(Count = 2)]
	private void Reset() { }

	[CalledBy(Type = typeof(DebugDisplaySettingsUI), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DebugManager), Member = "get_instance", ReturnType = typeof(DebugManager))]
	[Calls(Type = typeof(DebugManager), Member = "GetPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(bool)}, ReturnType = typeof(Panel))]
	[Calls(Type = typeof(ObservableList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	public void UnregisterDebug() { }

}

