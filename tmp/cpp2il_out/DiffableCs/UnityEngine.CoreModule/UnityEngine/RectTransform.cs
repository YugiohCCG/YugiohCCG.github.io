namespace UnityEngine;

[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform
{
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal sealed class ReapplyDrivenProperties : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ReapplyDrivenProperties(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(RectTransform driven) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ReapplyDrivenProperties reapplyDrivenProperties; //Field offset: 0x0

	public static event ReapplyDrivenProperties reapplyDrivenProperties
	{
		[CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 180
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public Vector2 anchoredPosition
	{
		[CallerCount(Count = 86)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CallerCount(Count = 147)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 129
	}

	public Vector3 anchoredPosition3D
	{
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass16_0", Member = "<DOAnchorPos3D>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass17_0", Member = "<DOAnchorPos3DX>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass18_0", Member = "<DOAnchorPos3DY>b__0", ReturnType = typeof(Vector3))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass19_0", Member = "<DOAnchorPos3DZ>b__0", ReturnType = typeof(Vector3))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 313
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Tables.TableRow", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass16_0", Member = "<DOAnchorPos3D>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass17_0", Member = "<DOAnchorPos3DX>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass18_0", Member = "<DOAnchorPos3DY>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass19_0", Member = "<DOAnchorPos3DZ>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 379
	}

	public Vector2 anchorMax
	{
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass20_0", Member = "<DOAnchorMax>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CallerCount(Count = 78)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 129
	}

	public Vector2 anchorMin
	{
		[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "SetNativeSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass21_0", Member = "<DOAnchorMin>b__0", ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CallerCount(Count = 89)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 129
	}

	public Vector2 offsetMax
	{
		[CalledBy(Type = "Extensions.General", Member = "SetRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "SetTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 451
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateTextArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "Extensions.General", Member = "SetRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "SetTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 17)]
		 set { } //Length: 1033
	}

	public Vector2 offsetMin
	{
		[CalledBy(Type = "Extensions.General", Member = "SetLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "SetBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 411
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateTextArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
		[CalledBy(Type = "Extensions.General", Member = "SetLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "SetBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 17)]
		 set { } //Length: 1043
	}

	public Vector2 pivot
	{
		[CallerCount(Count = 47)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CallerCount(Count = 39)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 129
	}

	public Rect rect
	{
		[CallerCount(Count = 140)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 143
	}

	public bool sendChildDimensionsChange
	{
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 135
	}

	public Vector2 sizeDelta
	{
		[CallerCount(Count = 109)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CallerCount(Count = 140)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 129
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RectTransform() { }

	[CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[CallerCount(Count = 86)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_anchoredPosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass16_0", Member = "<DOAnchorPos3D>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass17_0", Member = "<DOAnchorPos3DX>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass18_0", Member = "<DOAnchorPos3DY>b__0", ReturnType = typeof(Vector3))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass19_0", Member = "<DOAnchorPos3DZ>b__0", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Vector3 get_anchoredPosition3D() { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass20_0", Member = "<DOAnchorMax>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_anchorMax() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass21_0", Member = "<DOAnchorMin>b__0", ReturnType = typeof(Vector2))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "GetSizeDeltaToProduceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.RawImage", Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_anchorMin() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "Extensions.General", Member = "SetRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "SetTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public Vector2 get_offsetMax() { }

	[CalledBy(Type = "Extensions.General", Member = "SetLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "SetBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public Vector2 get_offsetMin() { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_pivot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_rect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[CallerCount(Count = 109)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector2 get_sizeDelta() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GetTextContainerLocalCorners", ReturnType = "UnityEngine.Vector3[]")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetTextContainerLocalCorners", ReturnType = "UnityEngine.Vector3[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private Vector2 GetParentSize() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "RayIntersectsRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Ray), typeof(Vector3&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_TextUtilities", Member = "IsIntersectingRectTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.RectangularVertexClipper", Member = "GetCanvasRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), "UnityEngine.Canvas"}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "GetBounds", ReturnType = typeof(Bounds))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	[CallerCount(Count = 147)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_anchoredPosition(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_anchoredPosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "UI.Tables.TableLayout", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UI.Tables.TableLayoutUtilities", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Tables.TableRow", Member = "UpdateLayout", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "FixInstanceTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(RectTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Instantiation", Member = "InstantiatePrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(Transform)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass16_0", Member = "<DOAnchorPos3D>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass17_0", Member = "<DOAnchorPos3DX>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass18_0", Member = "<DOAnchorPos3DY>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass19_0", Member = "<DOAnchorPos3DZ>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public void set_anchoredPosition3D(Vector3 value) { }

	[CallerCount(Count = 78)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_anchorMax(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_anchorMax_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_anchorMin(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_anchorMin_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateTextArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "Extensions.General", Member = "SetRight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "SetTop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public void set_offsetMax(Vector2 value) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_ContentLayout", Member = "SetBorderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateTextArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreatePlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "UI.Dates.DatePicker_TextMeshProUtilities", Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform)}, ReturnType = typeof(RectTransform))]
	[CalledBy(Type = "Extensions.General", Member = "SetLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "SetBottom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "TMPro.TMP_DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateToggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.DefaultControls+Resources"}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 17)]
	public void set_offsetMin(Vector2 value) { }

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_pivot(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_pivot_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sendChildDimensionsChange(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sendChildDimensionsChange_Injected(IntPtr _unity_self, bool value) { }

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_sizeDelta(Vector2 value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_sizeDelta_Injected(IntPtr _unity_self, in Vector2 value) { }

	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsUsingTemplate>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Tables.Examples.DynamicRowsExampleController+<AddRowsWithoutTemplate>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "_UpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker", Member = "SetPositionAdjacentToInputFieldContainer", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "UpdateRect", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ContentSizeFitter", Member = "HandleSelfFittingAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ContentSizeFitter", Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ContentSizeFitter", Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 30)]
	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

}

