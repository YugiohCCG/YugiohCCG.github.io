namespace UnityEngine.EventSystems;

public abstract class UIBehaviour : MonoBehaviour
{

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected UIBehaviour() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Awake() { }

	[CalledBy(Type = typeof(ScrollRect), Member = "IsActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	public override bool IsActive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool IsDestroyed() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnBeforeTransformParentChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnCanvasGroupChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnCanvasHierarchyChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnDestroy() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnDidApplyAnimationProperties() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnDisable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnEnable() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnRectTransformDimensionsChange() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void OnTransformParentChanged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Start() { }

}

