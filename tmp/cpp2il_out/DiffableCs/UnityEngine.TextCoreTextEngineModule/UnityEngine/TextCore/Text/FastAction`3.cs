namespace UnityEngine.TextCore.Text;

public class FastAction
{
	private LinkedList<Action`3<A, B, C>> delegates; //Field offset: 0x0
	private Dictionary<Action`3<A, B, C>, LinkedListNode`1<Action`3<A, B, C>>> lookup; //Field offset: 0x0

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public FastAction`3() { }

}

