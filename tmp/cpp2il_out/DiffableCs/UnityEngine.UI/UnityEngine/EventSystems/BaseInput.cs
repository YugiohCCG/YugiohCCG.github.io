namespace UnityEngine.EventSystems;

public class BaseInput : UIBehaviour
{

	public override Vector2 compositionCursorPos
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		 set { } //Length: 17
	}

	public override string compositionString
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public override IMECompositionMode imeCompositionMode
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
		 set { } //Length: 9
	}

	public override Vector2 mousePosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		 get { } //Length: 38
	}

	public override bool mousePresent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public override Vector2 mouseScrollDelta
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public override float mouseScrollDeltaPerTick
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public override int touchCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public override bool touchSupported
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BaseInput() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
	public override Vector2 get_compositionCursorPos() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public override string get_compositionString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
	public override IMECompositionMode get_imeCompositionMode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	public override Vector2 get_mousePosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool get_mousePresent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
	[DeduplicatedMethod]
	public override Vector2 get_mouseScrollDelta() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override float get_mouseScrollDeltaPerTick() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public override int get_touchCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool get_touchSupported() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[DeduplicatedMethod]
	public override float GetAxisRaw(string axisName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool GetButtonDown(string buttonName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool GetMouseButton(int button) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool GetMouseButtonDown(int button) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool GetMouseButtonUp(int button) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Touch))]
	[DeduplicatedMethod]
	public override Touch GetTouch(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "set_compositionCursorPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	public override void set_compositionCursorPos(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMECompositionMode)}, ReturnType = typeof(void))]
	public override void set_imeCompositionMode(IMECompositionMode value) { }

}

