namespace UnityEngine.Rendering;

public sealed class ListChangedEventArgs : EventArgs
{
	public readonly int index; //Field offset: 0x0
	public readonly T item; //Field offset: 0x0

	[CalledBy(Type = typeof(ObservableList`1), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ListChangedEventHandler`1<T>", typeof(int), "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Container), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.ObservableList`1<UnityEngine.Rendering.DebugUI+Widget>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ListChangedEventArgs`1(int index, T item) { }

}

