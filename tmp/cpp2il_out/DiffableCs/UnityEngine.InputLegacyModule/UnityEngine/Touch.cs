namespace UnityEngine;

[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch
{
	private int m_FingerId; //Field offset: 0x0
	private Vector2 m_Position; //Field offset: 0x4
	private Vector2 m_RawPosition; //Field offset: 0xC
	private Vector2 m_PositionDelta; //Field offset: 0x14
	private float m_TimeDelta; //Field offset: 0x1C
	private int m_TapCount; //Field offset: 0x20
	private TouchPhase m_Phase; //Field offset: 0x24
	private TouchType m_Type; //Field offset: 0x28
	private float m_Pressure; //Field offset: 0x2C
	private float m_maximumPossiblePressure; //Field offset: 0x30
	private float m_Radius; //Field offset: 0x34
	private float m_RadiusVariance; //Field offset: 0x38
	private float m_AltitudeAngle; //Field offset: 0x3C
	private float m_AzimuthAngle; //Field offset: 0x40

	public float altitudeAngle
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float azimuthAngle
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Vector2 deltaPosition
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float deltaTime
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public int fingerId
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public float maximumPossiblePressure
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public TouchPhase phase
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTouchEvents>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), "System.ValueTuple`2<Touch, Nullable`1<Int32>>"}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "MakeTouchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		 get { } //Length: 6
	}

	public Vector2 position
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 21
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float pressure
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float radius
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float radiusVariance
	{
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Vector2 rawPosition
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		 get { } //Length: 21
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		 set { } //Length: 5
	}

	public int tapCount
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public TouchType type
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public float get_altitudeAngle() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public float get_azimuthAngle() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public Vector2 get_deltaPosition() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public float get_deltaTime() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_fingerId() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public float get_maximumPossiblePressure() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<ProcessTouchEvents>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), "System.ValueTuple`2<Touch, Nullable`1<Int32>>"}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "MakeTouchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), "UnityEngine.EventModifiers", typeof(int)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.EventSystems.PointerInputModule", Member = "GetTouchPointerEventData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touch), typeof(Boolean&), typeof(Boolean&)}, ReturnType = "UnityEngine.EventSystems.PointerEventData")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "CheckTouchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	public TouchPhase get_phase() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public Vector2 get_position() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public float get_pressure() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public float get_radius() { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public float get_radiusVariance() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	public Vector2 get_rawPosition() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public int get_tapCount() { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public TouchType get_type() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_deltaPosition(Vector2 value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_position(Vector2 value) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	public void set_rawPosition(Vector2 value) { }

}

