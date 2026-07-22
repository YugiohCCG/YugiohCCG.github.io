namespace UnityEngine.Android;

[NativeAsStruct]
[NativeType(Header = "Modules/AndroidJNI/Public/AndroidConfiguration.bindings.h")]
[RequiredByNativeCode]
public sealed class AndroidConfiguration
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <colorMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <densityDpi>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <fontScale>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <fontWeightAdjustment>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidKeyboard <keyboard>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidKeyboardHidden <keyboardHidden>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <mobileCountryCode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <mobileNetworkCode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidNavigation <navigation>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidNavigationHidden <navigationHidden>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidOrientation <orientation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <screenHeightDp>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <screenWidthDp>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <smallestScreenWidthDp>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <screenLayout>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private AndroidTouchScreen <touchScreen>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <uiMode>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <primaryLocaleCountry>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <primaryLocaleLanguage>k__BackingField; //Field offset: 0x60

	private int colorMode
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	public AndroidColorModeHdr colorModeHdr
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public AndroidColorModeWideColorGamut colorModeWideColorGamut
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public int densityDpi
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public float fontScale
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int fontWeightAdjustment
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidHardwareKeyboardHidden hardKeyboardHidden
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidKeyboard keyboard
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidKeyboardHidden keyboardHidden
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidLocale[] locales
	{
		[CalledBy(Type = typeof(AndroidConfiguration), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 290
	}

	public int mobileCountryCode
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int mobileNetworkCode
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidNavigation navigation
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidNavigationHidden navigationHidden
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidOrientation orientation
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private string primaryLocaleCountry
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private string primaryLocaleLanguage
	{
		[CallerCount(Count = 84)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	public int screenHeightDp
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private int screenLayout
	{
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	public AndroidScreenLayoutDirection screenLayoutDirection
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public AndroidScreenLayoutLong screenLayoutLong
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public AndroidScreenLayoutRound screenLayoutRound
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
	}

	public AndroidScreenLayoutSize screenLayoutSize
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public int screenWidthDp
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int smallestScreenWidthDp
	{
		[CallerCount(Count = 26)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public AndroidTouchScreen touchScreen
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private int uiMode
	{
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	public AndroidUIModeNight uiModeNight
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public AndroidUIModeType uiModeType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int get_colorMode() { }

	[CallerCount(Count = 0)]
	public AndroidColorModeHdr get_colorModeHdr() { }

	[CallerCount(Count = 0)]
	public AndroidColorModeWideColorGamut get_colorModeWideColorGamut() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_densityDpi() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public float get_fontScale() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_fontWeightAdjustment() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidHardwareKeyboardHidden get_hardKeyboardHidden() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidKeyboard get_keyboard() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidKeyboardHidden get_keyboardHidden() { }

	[CalledBy(Type = typeof(AndroidConfiguration), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public AndroidLocale[] get_locales() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_mobileCountryCode() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_mobileNetworkCode() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidNavigation get_navigation() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidNavigationHidden get_navigationHidden() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidOrientation get_orientation() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private string get_primaryLocaleCountry() { }

	[CallerCount(Count = 84)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private string get_primaryLocaleLanguage() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_screenHeightDp() { }

	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int get_screenLayout() { }

	[CallerCount(Count = 0)]
	public AndroidScreenLayoutDirection get_screenLayoutDirection() { }

	[CallerCount(Count = 0)]
	public AndroidScreenLayoutLong get_screenLayoutLong() { }

	[CallerCount(Count = 0)]
	public AndroidScreenLayoutRound get_screenLayoutRound() { }

	[CallerCount(Count = 0)]
	public AndroidScreenLayoutSize get_screenLayoutSize() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_screenWidthDp() { }

	[CallerCount(Count = 26)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_smallestScreenWidthDp() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AndroidTouchScreen get_touchScreen() { }

	[CallerCount(Count = 14)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private int get_uiMode() { }

	[CallerCount(Count = 0)]
	public AndroidUIModeNight get_uiModeNight() { }

	[CallerCount(Count = 0)]
	public AndroidUIModeType get_uiModeType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(AndroidConfiguration), Member = "get_locales", ReturnType = typeof(AndroidLocale[]))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Preserve]
	public virtual string ToString() { }

}

