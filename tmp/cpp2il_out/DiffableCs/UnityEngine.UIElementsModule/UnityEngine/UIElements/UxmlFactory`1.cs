namespace UnityEngine.UIElements;

[Obsolete("UxmlFactory<TCreatedType> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlFactory : UxmlFactory<TCreatedType, UxmlTraits>
{

	[CalledBy(Type = typeof(UxmlFactory), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseUxmlFactory`2), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public UxmlFactory`1() { }

}

