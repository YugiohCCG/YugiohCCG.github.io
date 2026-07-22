namespace UnityEngine.Rendering;

internal class DebugDisplaySettingsRenderGraph : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Render Graph", order = 10)]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{

		public virtual string PanelName
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 44
		}

		[CalledBy(Type = typeof(DebugDisplaySettingsRenderGraph), Member = "UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel", ReturnType = typeof(IDebugDisplaySettingsPanelDisposable))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderGraph), Member = "GetWidgetList", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Rendering.DebugUI+Widget>))]
		[Calls(Type = typeof(DebugDisplaySettingsPanel), Member = "AddWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		public SettingsPanel(DebugDisplaySettingsRenderGraph _) { }

		[CallerCount(Count = 0)]
		public virtual string get_PanelName() { }

	}


	public override bool AreAnySettingsActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RenderGraph), Member = "get_areAnySettingsActive", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 390
	}

	[CalledBy(Type = typeof(DebugDisplaySettingsUI), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugDisplaySettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraphDebugParams), Member = "Reset", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public DebugDisplaySettingsRenderGraph() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "get_areAnySettingsActive", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SettingsPanel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugDisplaySettingsRenderGraph)}, ReturnType = typeof(void))]
	private override IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel() { }

}

