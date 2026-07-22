namespace UnityEngine.UIElements;

public abstract class TreeViewController : BaseTreeViewController
{

	protected TreeView treeView
	{
		[CalledBy(Type = typeof(TreeViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(TreeViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TreeViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		 get { } //Length: 114
	}

	[CalledBy(Type = typeof(DefaultTreeViewController`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseTreeViewController), Member = ".ctor", ReturnType = typeof(void))]
	protected TreeViewController() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	protected virtual void BindItem(VisualElement element, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void DestroyItem(VisualElement element) { }

	[CalledBy(Type = typeof(TreeViewController), Member = "MakeItem", ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(TreeViewController), Member = "BindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = "UnbindItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TreeViewController), Member = "DestroyItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	protected TreeView get_treeView() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[Calls(Type = typeof(Label), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected virtual VisualElement MakeItem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TreeViewController), Member = "get_treeView", ReturnType = typeof(TreeView))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void UnbindItem(VisualElement element, int index) { }

}

