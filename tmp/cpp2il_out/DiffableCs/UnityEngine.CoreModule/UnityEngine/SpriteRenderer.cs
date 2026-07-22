namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; //Field offset: 0x18

	public Color color
	{
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass0_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass1_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass3_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass0_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass1_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass3_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass0_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass1_0", Member = "<DOFade>b__0", ReturnType = typeof(Color))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass3_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOBlendableColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Color), typeof(float)}, ReturnType = "DG.Tweening.Tweener")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Color get_color() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<System.Object>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private void InvokeSpriteChanged() { }

	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass0_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass1_0", Member = "<DOFade>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite+<>c__DisplayClass3_0", Member = "<DOBlendableColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.DOTweenModuleSprite", Member = "DOGradientColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Gradient), typeof(float)}, ReturnType = "DG.Tweening.Sequence")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_color(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

}

