namespace UnityEngine.TextCore.Text;

public class FastAction
{
	private LinkedList<Action> delegates; //Field offset: 0x10
	private Dictionary<Action, LinkedListNode`1<Action>> lookup; //Field offset: 0x18

	[CalledBy(Type = typeof(TextEventManager), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public FastAction() { }

}

