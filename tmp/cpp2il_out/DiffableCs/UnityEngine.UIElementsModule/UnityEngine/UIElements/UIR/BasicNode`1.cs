namespace UnityEngine.UIElements.UIR;

internal class BasicNode : LinkedPoolItem<BasicNode`1<T>>
{
	public BasicNode<T> next; //Field offset: 0x0
	public T data; //Field offset: 0x0

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BasicNode`1() { }

	[CalledBy(Type = typeof(RenderChain), Member = "InsertExtraMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderChain), Member = "InsertTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(Texture), typeof(TextureId), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void InsertFirst(ref BasicNode<T>& first) { }

}

