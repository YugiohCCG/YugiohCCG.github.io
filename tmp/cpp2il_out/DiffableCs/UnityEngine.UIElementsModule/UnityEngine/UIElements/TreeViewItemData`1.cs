namespace UnityEngine.UIElements;

[IsReadOnly]
public struct TreeViewItemData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly int <id>k__BackingField; //Field offset: 0x0
	[CreateProperty]
	private readonly T m_Data; //Field offset: 0x0
	private readonly IList<TreeViewItemData`1<T>> m_Children; //Field offset: 0x0

	public IEnumerable<TreeViewItemData`1<T>> children
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public T data
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int id
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public IEnumerable<TreeViewItemData`1<T>> get_children() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T get_data() { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_id() { }

}

