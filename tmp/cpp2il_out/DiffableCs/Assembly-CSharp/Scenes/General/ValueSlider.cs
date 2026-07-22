namespace Scenes.General;

public class ValueSlider : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public UnityAction<ValueSlider> call; //Field offset: 0x10
		public ValueSlider <>4__this; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass4_0() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <AddOnValueChangedListener>b__0(float x) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void <AddOnValueChangedListener>b__1(string x) { }

	}

	[SerializeField]
	private Slider Slide; //Field offset: 0x20
	[SerializeField]
	private TMP_InputField Input; //Field offset: 0x28
	[SerializeField]
	private TextMeshProUGUI Label; //Field offset: 0x30

	public string Name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CalledBy(Type = typeof(CameraController), Member = "UpdateLanguage", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public float Value
	{
		[CalledBy(Type = typeof(CameraController), Member = "GetSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
		[CalledBy(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 39
		[CalledBy(Type = typeof(CameraController), Member = "UpdateForPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraView)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "SetSlidersToCurrent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "SetSlidersToCached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "DefineSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CameraController), Member = "OnCancel", ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 266
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ValueSlider() { }

	[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void AddOnValueChangedListener(UnityAction<ValueSlider> call) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake() { }

	[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Slider), Member = "set_minValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Slider), Member = "set_maxValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DefineMinMax(float min, float max) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string get_Name() { }

	[CalledBy(Type = typeof(CameraController), Member = "GetSetup", ReturnType = typeof(System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(CameraController), Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float get_Value() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void OnInputChanged(string val) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_InputField), Member = "SetTextWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void OnSlideChanged(float val) { }

	[CalledBy(Type = typeof(CameraController), Member = "UpdateLanguage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void set_Name(string value) { }

	[CalledBy(Type = typeof(CameraController), Member = "UpdateForPreset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "SetSlidersToCurrent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "SetSlidersToCached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "DefineSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraController), Member = "OnCancel", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void set_Value(float value) { }

}

