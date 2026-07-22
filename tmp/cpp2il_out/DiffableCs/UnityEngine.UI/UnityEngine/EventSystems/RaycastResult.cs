namespace UnityEngine.EventSystems;

public struct RaycastResult
{
	private GameObject m_GameObject; //Field offset: 0x0
	public BaseRaycaster module; //Field offset: 0x8
	public float distance; //Field offset: 0x10
	public float index; //Field offset: 0x14
	public int depth; //Field offset: 0x18
	public int sortingGroupID; //Field offset: 0x1C
	public int sortingGroupOrder; //Field offset: 0x20
	public int sortingLayer; //Field offset: 0x24
	public int sortingOrder; //Field offset: 0x28
	public Vector3 worldPosition; //Field offset: 0x2C
	public Vector3 worldNormal; //Field offset: 0x38
	public Vector2 screenPosition; //Field offset: 0x44
	public int displayIndex; //Field offset: 0x4C

	public GameObject gameObject
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public bool isValid
	{
		[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		 get { } //Length: 141
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public GameObject get_gameObject() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.InputSystemUIInputModule", Member = "ProcessPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.UI.PointerModel&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RaycastResult), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public bool get_isValid() { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_gameObject(GameObject value) { }

	[CalledBy(Type = typeof(PointerEventData), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastResult), Member = "get_isValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 29)]
	public virtual string ToString() { }

}

