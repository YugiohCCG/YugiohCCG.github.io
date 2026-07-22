namespace UnityEngine.UI.CoroutineTween;

internal struct FloatTween : ITweenValue
{
	internal class FloatTweenCallback : UnityEvent<Single>
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public FloatTweenCallback() { }

	}

	private FloatTweenCallback m_Target; //Field offset: 0x0
	private float m_StartValue; //Field offset: 0x8
	private float m_TargetValue; //Field offset: 0xC
	private float m_Duration; //Field offset: 0x10
	private bool m_IgnoreTimeScale; //Field offset: 0x14

	public override float duration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public override bool ignoreTimeScale
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float startValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float targetValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddOnChangedCallback(UnityAction<Single> callback) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override float get_duration() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_ignoreTimeScale() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_startValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_targetValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetDuration() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool GetIgnoreTimescale() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_duration(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_ignoreTimeScale(bool value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_startValue(float value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_targetValue(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public override void TweenValue(float floatPercentage) { }

	[CallerCount(Count = 11)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool ValidTarget() { }

}

