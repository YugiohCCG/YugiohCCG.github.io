namespace TMPro;

internal struct ColorTween : ITweenValue
{
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public ColorTweenCallback() { }

	}

	internal enum ColorTweenMode
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	private ColorTweenCallback m_Target; //Field offset: 0x0
	private Color m_StartColor; //Field offset: 0x8
	private Color m_TargetColor; //Field offset: 0x18
	private ColorTweenMode m_TweenMode; //Field offset: 0x28
	private float m_Duration; //Field offset: 0x2C
	private bool m_IgnoreTimeScale; //Field offset: 0x30

	public override float duration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public override bool ignoreTimeScale
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Color startColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Color targetColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public ColorTweenMode tweenMode
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_duration() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override bool get_ignoreTimeScale() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_startColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_targetColor() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public ColorTweenMode get_tweenMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetDuration() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool GetIgnoreTimescale() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_duration(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ignoreTimeScale(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_startColor(Color value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_targetColor(Color value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_tweenMode(ColorTweenMode value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Color>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	public override void TweenValue(float floatPercentage) { }

	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool ValidTarget() { }

}

