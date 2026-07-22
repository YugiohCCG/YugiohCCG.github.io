namespace Scenes.Battle;

public class CameraController : DraggableFrame
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public CameraView cv; //Field offset: 0x10
		public CameraController <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass15_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraController), Member = "UpdateForPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraView)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <Start>b__0() { }

	}

	private static readonly Dictionary<CameraView, ValueTuple`2<Vector3, Vector3>> DEF_CAMERAS; //Field offset: 0x0
	[SerializeField]
	private ValueSlider CamX; //Field offset: 0x98
	[SerializeField]
	private ValueSlider CamY; //Field offset: 0xA0
	[SerializeField]
	private ValueSlider CamZ; //Field offset: 0xA8
	[SerializeField]
	private ValueSlider CamOffsetX; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI Label; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI PresetsLabel; //Field offset: 0xC0
	[SerializeField]
	private Transform PresetsParent; //Field offset: 0xC8
	[SerializeField]
	private Button Confirm; //Field offset: 0xD0
	[SerializeField]
	private Button Cancel; //Field offset: 0xD8
	private ValueTuple<Vector3, Vector3> CameraCaching; //Field offset: 0xE0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static CameraController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DraggableFrame), Member = ".ctor", ReturnType = typeof(void))]
	public CameraController() { }

	[CalledBy(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone+<PrepareDuel>d__77", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DuelZone), Member = "get_IsDueling", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HandCards), Member = "RecalculateHandDisplay", ReturnType = typeof(void))]
	[Calls(Type = typeof(FieldSlot), Member = "UpdateHologramsState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Template), Member = "RefreshAllCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RefreshCardTemplateAction), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void CameraBootstrap() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DefineSliders(Vector3 pos, Vector3 rot) { }

	[CalledBy(Type = typeof(CameraController), Member = "OnCameraControlsClick", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "SetSlidersToCurrent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "Show", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ValueTuple<Vector3, Vector3> GetCurrentSetup() { }

	[CalledBy(Type = typeof(DuelField), Member = "ConfigureCamera", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(ValueTuple`2<Vector3, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_MainCamera", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static ValueTuple<Vector3, Vector3> GetOffsetFromDefault(CameraView view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueSlider), Member = "get_Value", ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private ValueTuple<Vector3, Vector3> GetSetup() { }

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Hide() { }

	[CalledBy(Type = typeof(Helper), Member = "LoadPrefs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Helper), Member = "UpdateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	public static void InitCameraDefaults() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraController), Member = "GetCurrentSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void OnCameraControlsClick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	private void OnCameraSettingChanged(ValueSlider slider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnCancel() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirm() { }

	[CalledBy(Type = typeof(CameraController), Member = "OnCameraSettingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueSlider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "OnConfirm", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "OnCancel", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ValueSlider), Member = "get_Value", ReturnType = typeof(float))]
	[Calls(Type = typeof(Helper), Member = "UpdateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraController), Member = "CameraBootstrap", ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetCameraToSliders(bool save) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetSlidersToCached() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraController), Member = "GetCurrentSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetSlidersToCurrent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraController), Member = "GetCurrentSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void Show() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueSlider), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueSlider), Member = "DefineMinMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraController), Member = "GetCurrentSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueSlider), Member = "AddOnValueChangedListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.Events.UnityAction`1<Scenes.General.ValueSlider>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "GetChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 7)]
	private void Start() { }

	[CalledBy(Type = typeof(<>c__DisplayClass15_0), Member = "<Start>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum", typeof(ValueTuple`2<Vector3, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueSlider), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateForPreset(CameraView view) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ValueSlider), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateLanguage() { }

}

