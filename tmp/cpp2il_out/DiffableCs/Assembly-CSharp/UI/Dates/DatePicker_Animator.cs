namespace UI.Dates;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasGroup))]
public class DatePicker_Animator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<DatePicker_Animation> <>9__11_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <Update>b__11_0(DatePicker_Animation a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public DatePicker_Animation_Property property; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <Animate>b__0(DatePicker_Animation a) { }

	}

	internal class DatePicker_Animation
	{
		public DatePicker_Animation_Property property; //Field offset: 0x10
		public float initialValue; //Field offset: 0x14
		public float desiredValue; //Field offset: 0x18
		public float startTime; //Field offset: 0x1C
		public float percentageComplete; //Field offset: 0x20
		public float duration; //Field offset: 0x24
		public Action onComplete; //Field offset: 0x28

		public float currentValue
		{
			[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 get { } //Length: 73
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DatePicker_Animation() { }

		[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public float get_currentValue() { }

	}

	internal enum DatePicker_Animation_Property
	{
		Alpha = 0,
		ScaleX = 1,
		ScaleY = 2,
	}

	protected List<DatePicker_Animation> animations; //Field offset: 0x20
	private CanvasGroup m_canvasGroup; //Field offset: 0x28
	private RectTransform m_rectTransform; //Field offset: 0x30
	public bool ResetWhenAnimationComplete; //Field offset: 0x38
	public float AnimationDuration; //Field offset: 0x3C

	protected CanvasGroup canvasGroup
	{
		[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	protected RectTransform rectTransform
	{
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public DatePicker_Animator() { }

	[CalledBy(Type = typeof(DatePicker), Member = "MonthChangedUpdateDisplay", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "Hide", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "HideInstantly", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void Animate(DatePicker_Animation_Property property, float desiredValue, float duration, Action onComplete = null) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected CanvasGroup get_canvasGroup() { }

	[CalledBy(Type = typeof(DatePicker_Animator), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "GetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	protected RectTransform get_rectTransform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(CanvasGroup), Member = "get_alpha", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	private float GetPropertyValue(DatePicker_Animation_Property property) { }

	[CalledBy(Type = typeof(DatePicker), Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Animation), typeof(AnimationType), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker), Member = "<MonthChangedUpdateDisplay>b__67_0", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void PlayAnimation(Animation animation, AnimationType animationType, Action onComplete = null) { }

	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Animate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float), typeof(float), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DatePicker_Animator), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetPropertyValue(DatePicker_Animation_Property property, float newValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(DatePicker_Animation), Member = "get_currentValue", ReturnType = typeof(float))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatePicker_Animation_Property), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_canvasGroup", ReturnType = typeof(CanvasGroup))]
	[Calls(Type = typeof(CanvasGroup), Member = "set_alpha", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DatePicker_Animator), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Transform), Member = "get_localScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update() { }

}

