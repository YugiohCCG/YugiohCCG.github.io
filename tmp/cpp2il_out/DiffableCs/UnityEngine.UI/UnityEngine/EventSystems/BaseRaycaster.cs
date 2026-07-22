namespace UnityEngine.EventSystems;

public abstract class BaseRaycaster : UIBehaviour
{
	private BaseRaycaster m_RootRaycaster; //Field offset: 0x20

	public abstract Camera eventCamera
	{
		 get { } //Length: 0
	}

	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public override int priority
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override int renderOrderPriority
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public BaseRaycaster rootRaycaster
	{
		[CalledBy(Type = typeof(EventSystem), Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastResult), typeof(RaycastResult)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 178
	}

	public override int sortOrderPriority
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected BaseRaycaster() { }

	public abstract Camera get_eventCamera() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override int get_priority() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_renderOrderPriority() { }

	[CalledBy(Type = typeof(EventSystem), Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RaycastResult), typeof(RaycastResult)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 3)]
	public BaseRaycaster get_rootRaycaster() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_sortOrderPriority() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnCanvasHierarchyChanged() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDisable() { }

	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnTransformParentChanged() { }

	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public virtual string ToString() { }

}

