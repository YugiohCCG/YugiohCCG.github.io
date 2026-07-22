namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[NativeType(CodegenOptions::Custom (1), "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct Burst
	{
		private float m_Time; //Field offset: 0x0
		private MinMaxCurveBlittable m_Count; //Field offset: 0x8
		private int m_RepeatCount; //Field offset: 0x28
		private float m_RepeatInterval; //Field offset: 0x2C
		private float m_InvProbability; //Field offset: 0x30

		public MinMaxCurve count
		{
			[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			 set { } //Length: 127
		}

		[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public void set_count(MinMaxCurve value) { }

	}

	internal struct ColorOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public MinMaxGradient color
		{
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			 set { } //Length: 218
		}

		[NativeName("Color")]
		private MinMaxGradientBlittable colorBlittable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			private set { } //Length: 66
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public void set_color(MinMaxGradient value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		private void set_colorBlittable(MinMaxGradientBlittable value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void set_colorBlittable_Injected(ref ColorOverLifetimeModule _unity_self, in MinMaxGradientBlittable value) { }

	}

	internal struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public int burstCount
		{
			[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public MinMaxCurve rateOverTime
		{
			[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			 set { } //Length: 191
		}

		[NativeName("RateOverTime")]
		private MinMaxCurveBlittable rateOverTimeBlittable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			private set { } //Length: 66
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal EmissionModule(ParticleSystem particleSystem) { }

		[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		public int get_burstCount() { }

		[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public Burst GetBurst(int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void GetBurst_Injected(ref EmissionModule _unity_self, int index, out Burst ret) { }

		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public void set_rateOverTime(MinMaxCurve value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		private void set_rateOverTimeBlittable(MinMaxCurveBlittable value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void set_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, in MinMaxCurveBlittable value) { }

		[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public void SetBurst(int index, Burst burst) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void SetBurst_Injected(ref EmissionModule _unity_self, int index, in Burst burst) { }

	}

	internal struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle; //Field offset: 0x0
		[NativeName("positionSet")]
		private bool m_PositionSet; //Field offset: 0x84
		[NativeName("velocitySet")]
		private bool m_VelocitySet; //Field offset: 0x85
		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[NativeName("rotationSet")]
		private bool m_RotationSet; //Field offset: 0x87
		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[NativeName("startSizeSet")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[NativeName("startColorSet")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	internal struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float duration
		{
			[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public bool loop
		{
			[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			 set { } //Length: 66
		}

		public int maxParticles
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			 set { } //Length: 64
		}

		public bool playOnAwake
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public ParticleSystemScalingMode scalingMode
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			 set { } //Length: 64
		}

		public ParticleSystemSimulationSpace simulationSpace
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public float simulationSpeed
		{
			[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
			[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			 set { } //Length: 67
		}

		public MinMaxGradient startColor
		{
			[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 326
			[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
			[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			[ContainsUnimplementedInstructions]
			 set { } //Length: 218
		}

		[NativeName("StartColor")]
		private MinMaxGradientBlittable startColorBlittable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 89
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			private set { } //Length: 66
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal MainModule(ParticleSystem particleSystem) { }

		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public float get_duration() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public int get_maxParticles() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public bool get_playOnAwake() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public ParticleSystemScalingMode get_scalingMode() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public ParticleSystemSimulationSpace get_simulationSpace() { }

		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public float get_simulationSpeed() { }

		[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		public MinMaxGradient get_startColor() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private MinMaxGradientBlittable get_startColorBlittable() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void get_startColorBlittable_Injected(ref MainModule _unity_self, out MinMaxGradientBlittable ret) { }

		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public void set_loop(bool value) { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public void set_maxParticles(int value) { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public void set_scalingMode(ParticleSystemScalingMode value) { }

		[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectHandler", Member = "ParseParticleData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParticleSystem), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		public void set_simulationSpeed(float value) { }

		[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Effects.EffectColor", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.EffectColor", Member = "DefineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public void set_startColor(MinMaxGradient value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		private void set_startColorBlittable(MinMaxGradientBlittable value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void set_startColorBlittable_Injected(ref MainModule _unity_self, in MinMaxGradientBlittable value) { }

	}

	internal struct MinMaxCurve
	{
		[SerializeField]
		internal ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[SerializeField]
		internal float m_CurveMultiplier; //Field offset: 0x4
		[SerializeField]
		internal AnimationCurve m_CurveMin; //Field offset: 0x8
		[SerializeField]
		internal AnimationCurve m_CurveMax; //Field offset: 0x10
		[SerializeField]
		internal float m_ConstantMin; //Field offset: 0x18
		[SerializeField]
		internal float m_ConstantMax; //Field offset: 0x1C

		public float constant
		{
			[CallerCount(Count = 57)]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public AnimationCurve curve
		{
			[CallerCount(Count = 206)]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public AnimationCurve curveMin
		{
			[CallerCount(Count = 27)]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public MinMaxCurve(float constant) { }

		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		public float get_constant() { }

		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		public AnimationCurve get_curve() { }

		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		public AnimationCurve get_curveMin() { }

		[CalledBy(Type = "Effects.CardCrack", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.FusionSummon+<SetMaterials>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.RitualSummon+<SetFlames>d__3", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.SynchroSummon+<SetLevel>d__2", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		public static MinMaxCurve op_Implicit(float constant) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	public struct MinMaxCurveBlittable
	{
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		private float m_CurveMultiplier; //Field offset: 0x4
		private IntPtr m_CurveMin; //Field offset: 0x8
		private IntPtr m_CurveMax; //Field offset: 0x10
		internal float m_ConstantMin; //Field offset: 0x18
		internal float m_ConstantMax; //Field offset: 0x1C

		[CallerCount(Count = 0)]
		internal static MinMaxCurveBlittable FromMixMaxCurve(in MinMaxCurve minMaxCurve) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public static MinMaxCurve op_Implicit(MinMaxCurveBlittable minMaxCurveBlittable) { }

		[CallerCount(Count = 0)]
		public static MinMaxCurveBlittable op_Implicit(MinMaxCurve minMaxCurve) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal static MinMaxCurve ToMinMaxCurve(in MinMaxCurveBlittable minMaxCurveBlittable) { }

	}

	internal struct MinMaxGradient
	{
		[SerializeField]
		internal ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[SerializeField]
		internal Gradient m_GradientMin; //Field offset: 0x8
		[SerializeField]
		internal Gradient m_GradientMax; //Field offset: 0x10
		[SerializeField]
		internal Color m_ColorMin; //Field offset: 0x18
		[SerializeField]
		internal Color m_ColorMax; //Field offset: 0x28

		public Color color
		{
			[CallerCount(Count = 21)]
			[DeduplicatedMethod]
			 get { } //Length: 11
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 set { } //Length: 8
		}

		public Color colorMax
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 set { } //Length: 8
		}

		public Color colorMin
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 set { } //Length: 8
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public MinMaxGradient(Color color) { }

		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		public Color get_color() { }

		[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public static MinMaxGradient op_Implicit(Color color) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public void set_color(Color value) { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public void set_colorMax(Color value) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public void set_colorMin(Color value) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	public struct MinMaxGradientBlittable
	{
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		private IntPtr m_GradientMin; //Field offset: 0x8
		private IntPtr m_GradientMax; //Field offset: 0x10
		private Color m_ColorMin; //Field offset: 0x18
		private Color m_ColorMax; //Field offset: 0x28

		[CallerCount(Count = 0)]
		internal static MinMaxGradientBlittable FromMixMaxGradient(in MinMaxGradient minMaxGradient) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		public static MinMaxGradient op_Implicit(MinMaxGradientBlittable minMaxGradientBlittable) { }

		[CallerCount(Count = 0)]
		public static MinMaxGradientBlittable op_Implicit(MinMaxGradient minMaxGradient) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal static MinMaxGradient ToMinMaxGradient(in MinMaxGradientBlittable minMaxGradientBlittable) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	internal struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private uint m_ParentRandomSeed; //Field offset: 0x68
		private float m_Lifetime; //Field offset: 0x6C
		private float m_StartLifetime; //Field offset: 0x70
		private int m_MeshIndex; //Field offset: 0x74
		private float m_EmitAccumulator0; //Field offset: 0x78
		private float m_EmitAccumulator1; //Field offset: 0x7C
		private uint m_Flags; //Field offset: 0x80

		public Vector3 angularVelocity3D
		{
			[CallerCount(Count = 0)]
			 set { } //Length: 55
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		public float lifetime
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public Vector3 position
		{
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			 get { } //Length: 18
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 15
		}

		public uint randomSeed
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public float remainingLifetime
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public float rotation
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 get { } //Length: 16
		}

		public Vector3 rotation3D
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 get { } //Length: 53
			[CallerCount(Count = 0)]
			 set { } //Length: 55
		}

		public Color32 startColor
		{
			[CallerCount(Count = 16)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public float startLifetime
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			 get { } //Length: 8
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public float startSize
		{
			[CallerCount(Count = 0)]
			 set { } //Length: 16
		}

		public Vector3 velocity
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 16
		}

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public Vector3 get_position() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public uint get_randomSeed() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public float get_remainingLifetime() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public float get_rotation() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public Vector3 get_rotation3D() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public float get_startLifetime() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public Color32 GetCurrentColor(ParticleSystem system) { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		public float GetCurrentSize(ParticleSystem system) { }

		[CallerCount(Count = 0)]
		public void set_angularVelocity3D(Vector3 value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_lifetime(float value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_position(Vector3 value) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public void set_randomSeed(uint value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_remainingLifetime(float value) { }

		[CallerCount(Count = 0)]
		public void set_rotation3D(Vector3 value) { }

		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		public void set_startColor(Color32 value) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public void set_startLifetime(float value) { }

		[CallerCount(Count = 0)]
		public void set_startSize(float value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_velocity(Vector3 value) { }

	}

	internal struct TextureSheetAnimationModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public ParticleSystemAnimationType animation
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public int cycleCount
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public bool enabled
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public MinMaxCurve frameOverTime
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
			 get { } //Length: 358
		}

		[NativeName("FrameOverTime")]
		private MinMaxCurveBlittable frameOverTimeBlittable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			private get { } //Length: 79
		}

		public int numTilesX
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public int numTilesY
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public int rowIndex
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public ParticleSystemAnimationRowMode rowMode
		{
			[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			 get { } //Length: 51
		}

		public MinMaxCurve startFrame
		{
			[CalledBy(Type = "Effects.CardCrack", Member = "Awake", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 3)]
			[ContainsInvalidInstructions]
			[ContainsUnimplementedInstructions]
			 set { } //Length: 264
		}

		[NativeName("StartFrame")]
		private MinMaxCurveBlittable startFrameBlittable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			[NativeThrows]
			private set { } //Length: 66
		}

		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal TextureSheetAnimationModule(ParticleSystem particleSystem) { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public ParticleSystemAnimationType get_animation() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public int get_cycleCount() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public bool get_enabled() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		public MinMaxCurve get_frameOverTime() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private MinMaxCurveBlittable get_frameOverTimeBlittable() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void get_frameOverTimeBlittable_Injected(ref TextureSheetAnimationModule _unity_self, out MinMaxCurveBlittable ret) { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		public int get_numTilesX() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Initialize", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public int get_numTilesY() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public int get_rowIndex() { }

		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public ParticleSystemAnimationRowMode get_rowMode() { }

		[CalledBy(Type = "Effects.CardCrack", Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsInvalidInstructions]
		[ContainsUnimplementedInstructions]
		public void set_startFrame(MinMaxCurve value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[NativeThrows]
		private void set_startFrameBlittable(MinMaxCurveBlittable value) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private static void set_startFrameBlittable_Injected(ref TextureSheetAnimationModule _unity_self, in MinMaxCurveBlittable value) { }

	}


	public ColorOverLifetimeModule colorOverLifetime
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public EmissionModule emission
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public bool isPlaying
	{
		[CalledBy(Type = "Effects.EdgeGlow", Member = "CalculateSizing", ReturnType = typeof(void))]
		[CalledBy(Type = "Effects.FusionSummon", Member = "<SetMaterials>b__2_0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Effects.RitualSummon", Member = "<SetFlames>b__3_0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Effects.SynchroSummon", Member = "<SetLevel>b__2_0", ReturnType = typeof(bool))]
		[CalledBy(Type = "Card.Template", Member = "ActivateChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SyncJobs(false)->IsPlaying")]
		 get { } //Length: 118
	}

	public bool isStopped
	{
		[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SyncJobs(false)->IsStopped")]
		 get { } //Length: 118
	}

	public MainModule main
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public TextureSheetAnimationModule textureSheetAnimation
	{
		[CallerCount(Count = 778)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 32
	}

	public float time
	{
		[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "StartParticleEmission", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeName("SyncJobs(false)->SetSecPosition")]
		 set { } //Length: 134
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ParticleSystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	public void Emit(int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Particle particle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Emit_Injected(IntPtr _unity_self, in EmitParams emitParams, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref Particle particle) { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ColorOverLifetimeModule get_colorOverLifetime() { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public EmissionModule get_emission() { }

	[CalledBy(Type = "Effects.EdgeGlow", Member = "CalculateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.FusionSummon", Member = "<SetMaterials>b__2_0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Effects.RitualSummon", Member = "<SetFlames>b__3_0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Effects.SynchroSummon", Member = "<SetLevel>b__2_0", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.Template", Member = "ActivateChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SyncJobs(false)->IsPlaying")]
	public bool get_isPlaying() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SyncJobs(false)->IsStopped")]
	public bool get_isStopped() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_isStopped_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public MainModule get_main() { }

	[CallerCount(Count = 778)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetParticleCurrentColor_Injected(IntPtr _unity_self, ref Particle particle, out Color32 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetParticleCurrentSize_Injected(IntPtr _unity_self, ref Particle particle) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Particle[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int GetParticles(out Particle[] particles) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParticleSystem), Member = "GetParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Particle[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	public int GetParticles(out Particle[] particles, int size) { }

	[CalledBy(Type = typeof(ParticleSystem), Member = "GetParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Particle[]), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ParticleSystem), Member = "GetParticles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Particle[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetOpponentFieldSpellState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.FieldBG", Member = "SetFieldSpellMaskState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "StartParticleEmission", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.CardCrack", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EdgeGlow", Member = "CalculateSizing", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.EffectPostEnabler", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Play() { }

	[CalledBy(Type = "Card.Template", Member = "ActivateChainOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(bool), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	public void Play(bool withChildren) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "StartParticleEmission", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeName("SyncJobs(false)->SetSecPosition")]
	public void set_time(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[CalledBy(Type = "Scenes.General.LifePoints", Member = "SetHourglassColor", ReturnType = typeof(void))]
	[CalledBy(Type = "Effects.CardCrack", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Stop() { }

	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "StopParticleEmission", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Extensions.UIParticleSystem", Member = "PauseParticleEmission", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	[CalledBy(Type = "Card.Template", Member = "DeactiveChainOrder", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void Stop(bool withChildren) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

}

