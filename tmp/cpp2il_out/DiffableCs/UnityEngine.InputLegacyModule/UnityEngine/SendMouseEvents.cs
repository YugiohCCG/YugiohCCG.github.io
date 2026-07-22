namespace UnityEngine;

internal class SendMouseEvents
{
	private struct HitInfo
	{
		public GameObject target; //Field offset: 0x0
		public Camera camera; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		public static bool Compare(HitInfo lhs, HitInfo rhs) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		public static bool op_Implicit(HitInfo exists) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void SendMessage(string name) { }

	}

	private static bool s_MouseUsed; //Field offset: 0x0
	private static readonly HitInfo[] m_LastHit; //Field offset: 0x8
	private static readonly HitInfo[] m_MouseDownHit; //Field offset: 0x10
	private static readonly HitInfo[] m_CurrentHit; //Field offset: 0x18
	private static Camera[] m_Cameras; //Field offset: 0x20
	public static Func<KeyValuePair`2<Int32, Vector2>> s_GetMouseState; //Field offset: 0x28
	private static Vector2 s_MousePosition; //Field offset: 0x30
	private static bool s_MouseButtonPressedThisFrame; //Field offset: 0x38
	private static bool s_MouseButtonIsPressed; //Field offset: 0x39

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static SendMouseEvents() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Camera), Member = "get_eventMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Display), Member = "get_systemHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Display), Member = "get_systemWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_targetTexture", ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SendMouseEvents), Member = "UpdateMouse", ReturnType = typeof(void))]
	[Calls(Type = typeof(SendMouseEvents), Member = "SendEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(HitInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Display), Member = "RelativeMouseAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_clearFlags", ReturnType = typeof(CameraClearFlags))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	private static void DoSendMouseEvents(int skipRTCameras) { }

	[CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(SendMessageOptions)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private static void SendEvents(int i, HitInfo hit) { }

	[CallerCount(Count = 0)]
	[RequiredByNativeCode]
	private static void SetMouseMoved() { }

	[CalledBy(Type = typeof(SendMouseEvents), Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private static void UpdateMouse() { }

}

