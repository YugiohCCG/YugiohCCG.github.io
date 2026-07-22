namespace UnityEngine;

[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	[NativeProperty("Alpha", False, TargetType::Function (0))]
	public float alpha
	{
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property"}, ReturnType = typeof(float))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass0_0", Member = "<DOFade>b__0", ReturnType = typeof(float))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Hide", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Hide", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UI.Dates.DatePicker", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.Animation", "UI.Dates.AnimationType", typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass0_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[NativeProperty("BlocksRaycasts", False, TargetType::Function (0))]
	public bool blocksRaycasts
	{
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 118
	}

	[NativeProperty("IgnoreParentGroups", False, TargetType::Function (0))]
	public bool ignoreParentGroups
	{
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[NativeProperty("Interactable", False, TargetType::Function (0))]
	public bool interactable
	{
		[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public CanvasGroup() { }

	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property"}, ReturnType = typeof(float))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass0_0", Member = "<DOFade>b__0", ReturnType = typeof(float))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Hide", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Hide", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_alpha() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public bool get_blocksRaycasts() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_ignoreParentGroups() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "ParentGroupAllowsInteraction", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_interactable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.Animation", "UI.Dates.AnimationType", typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UI.Dates.DatePicker_Animator", Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UI.Dates.DatePicker_Animator+DatePicker_Animation_Property", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleUI+<>c__DisplayClass0_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetAlpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_alpha(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_ignoreParentGroups(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }

}

