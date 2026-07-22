namespace DG.Tweening.Core;

public class DOTweenSettings : ScriptableObject
{
	internal class ModulesSetup
	{
		public bool showPanel; //Field offset: 0x10
		public bool audioEnabled; //Field offset: 0x11
		public bool physicsEnabled; //Field offset: 0x12
		public bool physics2DEnabled; //Field offset: 0x13
		public bool spriteEnabled; //Field offset: 0x14
		public bool uiEnabled; //Field offset: 0x15
		public bool textMeshProEnabled; //Field offset: 0x16
		public bool tk2DEnabled; //Field offset: 0x17
		public bool deAudioEnabled; //Field offset: 0x18
		public bool deUnityExtendedEnabled; //Field offset: 0x19
		public bool epoOutlineEnabled; //Field offset: 0x1A

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ModulesSetup() { }

	}

	internal class SafeModeOptions
	{
		public SafeModeLogBehaviour logBehaviour; //Field offset: 0x10
		public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; //Field offset: 0x14

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SafeModeOptions() { }

	}

	internal enum SettingsLocation
	{
		AssetsDirectory = 0,
		DOTweenDirectory = 1,
		DemigiantDirectory = 2,
	}

	public const string AssetName = "DOTweenSettings"; //Field offset: 0x0
	public const string AssetFullFilename = "DOTweenSettings.asset"; //Field offset: 0x0
	public bool useSafeMode; //Field offset: 0x18
	public SafeModeOptions safeModeOptions; //Field offset: 0x20
	public float timeScale; //Field offset: 0x28
	public bool useSmoothDeltaTime; //Field offset: 0x2C
	public float maxSmoothUnscaledTime; //Field offset: 0x30
	public RewindCallbackMode rewindCallbackMode; //Field offset: 0x34
	public bool showUnityEditorReport; //Field offset: 0x38
	public LogBehaviour logBehaviour; //Field offset: 0x3C
	public bool drawGizmos; //Field offset: 0x40
	public bool defaultRecyclable; //Field offset: 0x41
	public AutoPlay defaultAutoPlay; //Field offset: 0x44
	public UpdateType defaultUpdateType; //Field offset: 0x48
	public bool defaultTimeScaleIndependent; //Field offset: 0x4C
	public Ease defaultEaseType; //Field offset: 0x50
	public float defaultEaseOvershootOrAmplitude; //Field offset: 0x54
	public float defaultEasePeriod; //Field offset: 0x58
	public bool defaultAutoKill; //Field offset: 0x5C
	public LoopType defaultLoopType; //Field offset: 0x60
	public bool debugMode; //Field offset: 0x64
	public bool debugStoreTargetId; //Field offset: 0x65
	public bool showPreviewPanel; //Field offset: 0x66
	public SettingsLocation storeSettingsLocation; //Field offset: 0x68
	public ModulesSetup modules; //Field offset: 0x70
	public bool createASMDEF; //Field offset: 0x78
	public bool showPlayingTweens; //Field offset: 0x79
	public bool showPausedTweens; //Field offset: 0x7A

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public DOTweenSettings() { }

}

