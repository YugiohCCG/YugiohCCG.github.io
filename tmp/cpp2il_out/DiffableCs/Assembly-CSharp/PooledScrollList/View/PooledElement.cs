namespace PooledScrollList.View;

[RequireComponent(typeof(IPooledView))]
[RequireComponent(typeof(RectTransform))]
public class PooledElement : MonoBehaviour
{
	private IPooledView _pooledView; //Field offset: 0x20
	private RectTransform _rectTransform; //Field offset: 0x28

	public IPooledData Data
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 136
		[CalledBy(Type = typeof(PooledScrollRectBase), Member = "UpdateActiveElements", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PooledScrollRectBase), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PooledElement))]
		[CalledBy(Type = typeof(PooledScrollRectController), Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 256
	}

	public IPooledView PooledView
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 85
	}

	public RectTransform RectTransform
	{
		[CalledBy(Type = typeof(PooledScrollRectBase), Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PooledScrollRectController), Member = "UpdateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 141
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PooledElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public IPooledData get_Data() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public IPooledView get_PooledView() { }

	[CalledBy(Type = typeof(PooledScrollRectBase), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "UpdateSizing", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public RectTransform get_RectTransform() { }

	[CalledBy(Type = typeof(PooledScrollRectBase), Member = "UpdateActiveElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectBase), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(PooledElement))]
	[CalledBy(Type = typeof(PooledScrollRectController), Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PooledScrollRectGridController), Member = "ReorientElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PooledScrollList.Controller.PooledScrollRectBase+ReorientMethod", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void set_Data(IPooledData value) { }

}

