namespace UnityEngine.InputForUI;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct EventModifiers
{
	[Flags]
	internal enum Modifiers
	{
		LeftShift = 1,
		RightShift = 2,
		Shift = 3,
		LeftCtrl = 4,
		RightCtrl = 8,
		Ctrl = 12,
		LeftAlt = 16,
		RightAlt = 32,
		Alt = 48,
		LeftMeta = 64,
		RightMeta = 128,
		Meta = 192,
		CapsLock = 256,
		Numlock = 512,
		FunctionKey = 1024,
		Numeric = 2048,
	}

	private uint _state; //Field offset: 0x0

	public bool isAltPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 7
	}

	public bool isCapsLockEnabled
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool isCtrlPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 7
	}

	public bool isFunctionKeyPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool isMetaPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool isNumericPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 10
	}

	public bool isShiftPressed
	{
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static void Append(ref string str, string value) { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_isAltPressed() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isCapsLockEnabled() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_isCtrlPressed() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isFunctionKeyPressed() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_isMetaPressed() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_isNumericPressed() { }

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "GetModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(EventModifiers))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEvent), typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool get_isShiftPressed() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool IsPressed(Modifiers mod) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void Reset() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void SetPressed(Modifiers modifier, bool pressed) { }

	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	public virtual string ToString() { }

}

