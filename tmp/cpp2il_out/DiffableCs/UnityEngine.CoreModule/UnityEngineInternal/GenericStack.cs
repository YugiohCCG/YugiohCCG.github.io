namespace UnityEngineInternal;

public class GenericStack : Stack
{

	[CalledBy(Type = "UnityEngine.GUI", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUILayoutUtility+LayoutCache", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	public GenericStack() { }

}

