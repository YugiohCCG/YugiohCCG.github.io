namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	public override bool Equals(MaterialEffectPlayable other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override PlayableHandle GetHandle() { }

}

