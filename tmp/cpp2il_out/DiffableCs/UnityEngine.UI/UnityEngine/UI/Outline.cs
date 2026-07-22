namespace UnityEngine.UI;

[AddComponentMenu("UI/Effects/Outline", 81)]
public class Outline : Shadow
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shadow), Member = ".ctor", ReturnType = typeof(void))]
	protected Outline() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(Shadow), Member = "ApplyShadowZeroAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(Color32), typeof(int), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SplitUIVertexStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void ModifyMesh(VertexHelper vh) { }

}

