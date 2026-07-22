namespace DG.Tweening.Plugins.Core;

internal static class PluginsManager
{
	private static ITweenPlugin _floatPlugin; //Field offset: 0x0
	private const int _MaxCustomPlugins = 20; //Field offset: 0x0
	private static ITweenPlugin _doublePlugin; //Field offset: 0x8
	private static ITweenPlugin _intPlugin; //Field offset: 0x10
	private static ITweenPlugin _uintPlugin; //Field offset: 0x18
	private static ITweenPlugin _longPlugin; //Field offset: 0x20
	private static ITweenPlugin _ulongPlugin; //Field offset: 0x28
	private static ITweenPlugin _vector2Plugin; //Field offset: 0x30
	private static ITweenPlugin _vector3Plugin; //Field offset: 0x38
	private static ITweenPlugin _vector4Plugin; //Field offset: 0x40
	private static ITweenPlugin _quaternionPlugin; //Field offset: 0x48
	private static ITweenPlugin _colorPlugin; //Field offset: 0x50
	private static ITweenPlugin _rectPlugin; //Field offset: 0x58
	private static ITweenPlugin _rectOffsetPlugin; //Field offset: 0x60
	private static ITweenPlugin _stringPlugin; //Field offset: 0x68
	private static ITweenPlugin _vector3ArrayPlugin; //Field offset: 0x70
	private static ITweenPlugin _color2Plugin; //Field offset: 0x78
	private static Dictionary<Type, ITweenPlugin> _customPlugins; //Field offset: 0x80

	[CalledBy(Type = typeof(CirclePlugin), Member = "Get", ReturnType = typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>))]
	[CalledBy(Type = typeof(PathPlugin), Member = "Get", ReturnType = typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin() { }

	[CalledBy(Type = typeof(Tweener), Member = "Setup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "TPlugOptions"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<T1, T2, TPlugOptions>", "DG.Tweening.Core.DOGetter`1<T1>", "DG.Tweening.Core.DOSetter`1<T1>", "T2", typeof(float), "DG.Tweening.Plugins.Core.ABSTweenPlugin`3<T1, T2, TPlugOptions>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FloatPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(IntPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector4Plugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffsetPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UintPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Color2Plugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2Plugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(LongPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UlongPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(DoublePlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3ArrayPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3Plugin), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Debugger), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Tween)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QuaternionPlugin), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin() { }

	[CalledBy(Type = typeof(DOTween), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	internal static void PurgeAll() { }

}

