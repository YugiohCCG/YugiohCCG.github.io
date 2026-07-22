namespace UnityEngine.Rendering;

public class DebugDisplaySettingsHDROutput
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public HDROutputSettings d; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass1_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_active", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal object <CreateHDROuputDisplayTable>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		internal object <CreateHDROuputDisplayTable>b__1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_displayColorGamut", ReturnType = typeof(ColorGamut))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_graphicsFormat", ReturnType = typeof(GraphicsFormat))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__3() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_automaticHDRTonemapping", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__4() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_paperWhiteNits", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__5() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_minToneMapLuminance", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__6() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxToneMapLuminance", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__7() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_maxFullFrameToneMapLuminance", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__8() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_available", ReturnType = typeof(bool))]
		[Calls(Type = typeof(HDROutputSettings), Member = "get_HDRModeChangeRequested", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		internal object <CreateHDROuputDisplayTable>b__9() { }

	}

	private static class Strings
	{
		public static readonly string hdrOutputAPI; //Field offset: 0x0
		public static readonly string displayName; //Field offset: 0x8
		public static readonly string displayMain; //Field offset: 0x10
		public static readonly string hdrActive; //Field offset: 0x18
		public static readonly string hdrAvailable; //Field offset: 0x20
		public static readonly string gamut; //Field offset: 0x28
		public static readonly string format; //Field offset: 0x30
		public static readonly string autoHdrTonemapping; //Field offset: 0x38
		public static readonly string paperWhite; //Field offset: 0x40
		public static readonly string minLuminance; //Field offset: 0x48
		public static readonly string maxLuminance; //Field offset: 0x50
		public static readonly string maxFullFrameLuminance; //Field offset: 0x58
		public static readonly string modeChangeRequested; //Field offset: 0x60
		public static readonly string notAvailable; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 14)]
		private static Strings() { }

	}


	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DebugDisplaySettingsHDROutput() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Table), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Row), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(HDROutputSettings), Member = "get_main", ReturnType = typeof(HDROutputSettings))]
	[Calls(Type = typeof(Value), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObservableList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 34)]
	public static Table CreateHDROuputDisplayTable() { }

}

