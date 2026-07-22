namespace System.Runtime.Serialization;

internal class ObjectHolderListEnumerator
{
	private bool m_isFixupEnumerator; //Field offset: 0x10
	private ObjectHolderList m_list; //Field offset: 0x18
	private int m_startingVersion; //Field offset: 0x20
	private int m_currPos; //Field offset: 0x24

	internal ObjectHolder Current
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 52
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectHolder get_Current() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool MoveNext() { }

}

