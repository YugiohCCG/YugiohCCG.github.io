namespace UnityEngine.Rendering;

[DefaultMember("Item")]
public class ObservableList : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private IList<T> m_List; //Field offset: 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemAdded; //Field offset: 0x0
	[CompilerGenerated]
	private ListChangedEventHandler<T> ItemRemoved; //Field offset: 0x0

	public event ListChangedEventHandler<T> ItemAdded
	{
		[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 158
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 158
	}

	public event ListChangedEventHandler<T> ItemRemoved
	{
		[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 add { } //Length: 158
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 remove { } //Length: 158
	}

	public override int Count
	{
		[CalledBy(Type = typeof(Container), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Container), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Container), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Table), Member = "get_VisibleColumns", ReturnType = typeof(Boolean[]))]
		[CalledBy(Type = typeof(RenderingLayerField), Member = "GenerateQueryPath", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Panel), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IContainer), typeof(Transform), typeof(DebugUIHandlerWidget), typeof(DebugUIHandlerWidget&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebugUIHandlerRow), Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 70
	}

	public override bool IsReadOnly
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override T Item
	{
		[CallerCount(Count = 40)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 268
	}

	[CalledBy(Type = typeof(DebugDisplayStats`1), Member = "BuildProfilingSamplerWidgetList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TProfileId>"}, ReturnType = typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>))]
	[CalledBy(Type = typeof(Container), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderingLayerField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ObservableList`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ObservableList`1(int capacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public ObservableList`1(IEnumerable<T> collection) { }

	[CallerCount(Count = 181)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override void Add(T item) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsUI+<>c__DisplayClass3_0", Member = "<RegisterDebug>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugDisplaySettingsData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "RegisterDebug", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphDebugParams), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Panel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "RegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public void Add(T[] items) { }

	[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void add_ItemAdded(ListChangedEventHandler<T> value) { }

	[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void add_ItemRemoved(ListChangedEventHandler<T> value) { }

	[CalledBy(Type = typeof(RenderingLayerField), Member = "Resize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool Contains(T item) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[CalledBy(Type = typeof(Container), Member = "set_panel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Panel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Container), Member = "GenerateQueryPath", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Container), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Table), Member = "get_VisibleColumns", ReturnType = typeof(Boolean[]))]
	[CalledBy(Type = typeof(RenderingLayerField), Member = "GenerateQueryPath", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "SetDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Panel), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DebugUIHandlerCanvas), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IContainer), typeof(Transform), typeof(DebugUIHandlerWidget), typeof(DebugUIHandlerWidget&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugUIHandlerRow), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override T get_Item(int index) { }

	[CalledBy(Type = typeof(DebugManager), Member = "TogglePersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Widget), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebugManager), Member = "GetItemsFromContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Flags), typeof(IContainer)}, ReturnType = typeof(Widget[]))]
	[CalledBy(Type = typeof(DebugManager), Member = "GetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IContainer)}, ReturnType = typeof(Widget))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override IEnumerator<T> GetEnumerator() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int IndexOf(T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void Insert(int index, T item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ListChangedEventArgs`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void OnEvent(ListChangedEventHandler<T> e, int index, T item) { }

	[CalledBy(Type = typeof(CameraSwitcher), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SettingsPanel), Member = "Refresh", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override bool Remove(T item) { }

	[CalledBy(Type = typeof(DebugDisplaySettingsUI), Member = "UnregisterDebug", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "UnregisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraphDebugParams), Member = "UnRegisterDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderGraph), Member = "UnRegisterDebug", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public int Remove(T[] items) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void remove_ItemAdded(ListChangedEventHandler<T> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void remove_ItemRemoved(ListChangedEventHandler<T> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override void RemoveAt(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void set_Item(int index, T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

