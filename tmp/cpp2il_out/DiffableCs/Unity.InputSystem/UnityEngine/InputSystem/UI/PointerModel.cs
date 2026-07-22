namespace UnityEngine.InputSystem.UI;

internal struct PointerModel
{
	internal struct ButtonState
	{
		private bool m_IsPressed; //Field offset: 0x0
		private FramePressState m_FramePressState; //Field offset: 0x4
		private float m_PressTime; //Field offset: 0x8
		private RaycastResult m_PressRaycast; //Field offset: 0x10
		private GameObject m_PressObject; //Field offset: 0x60
		private GameObject m_RawPressObject; //Field offset: 0x68
		private GameObject m_LastPressObject; //Field offset: 0x70
		private GameObject m_DragObject; //Field offset: 0x78
		private Vector2 m_PressPosition; //Field offset: 0x80
		private float m_ClickTime; //Field offset: 0x88
		private int m_ClickCount; //Field offset: 0x8C
		private bool m_Dragging; //Field offset: 0x90
		private bool m_ClickedOnSameGameObject; //Field offset: 0x91
		private bool m_IgnoreNextClick; //Field offset: 0x92

		public bool clickedOnSameGameObject
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 7
		}

		public bool ignoreNextClick
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 7
		}

		public bool isPressed
		{
			[CallerCount(Count = 89)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			 set { } //Length: 66
		}

		public float pressTime
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public bool wasPressedThisFrame
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 17
		}

		public bool wasReleasedThisFrame
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 17
		}

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ButtonState&), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointerButtonDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ButtonState&), typeof(ExtendedPointerEventData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public void CopyPressStateFrom(PointerEventData eventData) { }

		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerModel&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void CopyPressStateTo(PointerEventData eventData) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool get_clickedOnSameGameObject() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool get_ignoreNextClick() { }

		[CallerCount(Count = 89)]
		[DeduplicatedMethod]
		public bool get_isPressed() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_pressTime() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_wasPressedThisFrame() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_wasReleasedThisFrame() { }

		[CallerCount(Count = 0)]
		public void OnEndFrame() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_clickedOnSameGameObject(bool value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_ignoreNextClick(bool value) { }

		[CallerCount(Count = 0)]
		public void set_isPressed(bool value) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public void set_pressTime(float value) { }

	}

	public bool changedThisFrame; //Field offset: 0x0
	public ButtonState leftButton; //Field offset: 0x8
	public ButtonState rightButton; //Field offset: 0xA0
	public ButtonState middleButton; //Field offset: 0x138
	public ExtendedPointerEventData eventData; //Field offset: 0x1D0
	private Vector2 m_ScreenPosition; //Field offset: 0x1D8
	private Vector2 m_ScrollDelta; //Field offset: 0x1E0
	private Vector3 m_WorldPosition; //Field offset: 0x1E8
	private Quaternion m_WorldOrientation; //Field offset: 0x1F4
	private float m_Pressure; //Field offset: 0x204
	private float m_AzimuthAngle; //Field offset: 0x208
	private float m_AltitudeAngle; //Field offset: 0x20C
	private float m_Twist; //Field offset: 0x210
	private Vector2 m_Radius; //Field offset: 0x214

	public float altitudeAngle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public float azimuthAngle
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public UIPointerType pointerType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public float pressure
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public Vector2 radius
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 81
	}

	public Vector2 screenPosition
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 81
	}

	public Vector2 scrollDelta
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 81
	}

	public float twist
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 9
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 27
	}

	public Quaternion worldOrientation
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 14
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 95
	}

	public Vector3 worldPosition
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 103
	}

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "AllocatePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(UIPointerType), typeof(InputControl), typeof(InputDevice), typeof(InputControl)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PointerModel(ExtendedPointerEventData eventData) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "FilterPointerStatesByType", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void CopyTouchOrPenStateFrom(PointerEventData eventData) { }

	[CallerCount(Count = 0)]
	public float get_altitudeAngle() { }

	[CallerCount(Count = 0)]
	public float get_azimuthAngle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public UIPointerType get_pointerType() { }

	[CallerCount(Count = 0)]
	public float get_pressure() { }

	[CallerCount(Count = 0)]
	public Vector2 get_radius() { }

	[CallerCount(Count = 0)]
	public Vector2 get_screenPosition() { }

	[CallerCount(Count = 0)]
	public Vector2 get_scrollDelta() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_twist() { }

	[CallerCount(Count = 0)]
	public Quaternion get_worldOrientation() { }

	[CallerCount(Count = 0)]
	public Vector3 get_worldPosition() { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "Process", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void OnFrameFinished() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_altitudeAngle(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_azimuthAngle(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_pressure(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_radius(Vector2 value) { }

	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "GetPointerStateIndexFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(bool)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystemUIInputModule), Member = "OnPointCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void set_screenPosition(Vector2 value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_scrollDelta(Vector2 value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_twist(float value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_worldOrientation(Quaternion value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public void set_worldPosition(Vector3 value) { }

}

