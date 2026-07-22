namespace Unity.Burst.Intrinsics;

[BurstCompile]
public static class X86
{
	internal static class Avx
	{
		internal enum CMP
		{
			EQ_OQ = 0,
			LT_OS = 1,
			LE_OS = 2,
			UNORD_Q = 3,
			NEQ_UQ = 4,
			NLT_US = 5,
			NLE_US = 6,
			ORD_Q = 7,
			EQ_UQ = 8,
			NGE_US = 9,
			NGT_US = 10,
			FALSE_OQ = 11,
			NEQ_OQ = 12,
			GE_OS = 13,
			GT_OS = 14,
			TRUE_UQ = 15,
			EQ_OS = 16,
			LT_OQ = 17,
			LE_OQ = 18,
			UNORD_S = 19,
			NEQ_US = 20,
			NLT_UQ = 21,
			NLE_UQ = 22,
			ORD_S = 23,
			EQ_US = 24,
			NGE_UQ = 25,
			NGT_UQ = 26,
			FALSE_OS = 27,
			NEQ_OS = 28,
			GE_OQ = 29,
			GT_OQ = 30,
			TRUE_US = 31,
		}


		public static bool IsAvxSupported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 broadcast_ss(Void* ptr) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "cmp_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Sse2), Member = "cmpneq_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpeq_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmplt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmple_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpunord_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpnlt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpnle_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpord_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpnge_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpngt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpge_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse2), Member = "cmpgt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static v128 cmp_pd(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_cmp_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "cmp_ss", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmp_ps(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 cmp_sd(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx), Member = "cmp_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 cmp_ss(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsAvxSupported() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 maskload_pd(Void* mem_addr, v128 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 maskload_ps(Void* mem_addr, v128 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void maskstore_pd(Void* mem_addr, v128 mask, v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void maskstore_ps(Void* mem_addr, v128 mask, v128 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_add_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_add_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "addsub_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_addsub_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "addsub_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_addsub_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_and_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_and_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_andnot_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_andnot_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blend_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blend_pd(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blend_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blend_ps(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blendv_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blendv_pd(v256 a, v256 b, v256 mask) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blendv_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blendv_ps(v256 a, v256 b, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_broadcast_pd(Void* ptr) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcast_ps(Void* ptr) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcast_sd(Void* ptr) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcast_ss(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castpd_ps(v256 a) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castpd_si256(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castpd128_pd256(v128 a) { }

		[CallerCount(Count = 18)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_castpd256_pd128(v256 a) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castps_pd(v256 a) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castps_si256(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castps128_ps256(v128 a) { }

		[CallerCount(Count = 18)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_castps256_ps128(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castsi128_si256(v128 a) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castsi256_pd(v256 a) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_castsi256_ps(v256 a) { }

		[CallerCount(Count = 18)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_castsi256_si128(v256 a) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_ceil_pd(v256 val) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_ceil_ps(v256 val) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmp_pd(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx), Member = "cmp_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmp_ps(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi32_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi32_ps(v256 a) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cvtpd_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 mm256_cvtpd_epi32(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cvtpd_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 mm256_cvtpd_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cvtps_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cvtps_epi32(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtps_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static float mm256_cvtss_f32(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_cvttpd_epi32(v256 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_cvttps_epi32(v256 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_div_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_div_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "dp_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_dp_ps(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_extract_epi32(v256 a, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static long mm256_extract_epi64(v256 a, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_extractf128_pd(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_extractf128_ps(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mm256_extractf128_si256(v256 a, int imm8) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_floor_pd(v256 val) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_floor_ps(v256 val) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "hadd_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hadd_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "hadd_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hadd_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "hsub_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hsub_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse3), Member = "hsub_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hsub_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_insert_epi16(v256 a, int i, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_insert_epi32(v256 a, int i, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_insert_epi64(v256 a, long i, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_insert_epi8(v256 a, int i, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_insertf128_pd(v256 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_insertf128_ps(v256 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_insertf128_si256(v256 a, v128 b, int imm8) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_lddqu_si256(Void* mem_addr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_load_pd(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_load_ps(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_load_si256(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu_pd(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu_ps(Void* ptr) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu_si256(Void* ptr) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu2_m128(Void* hiaddr, Void* loaddr) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu2_m128d(Void* hiaddr, Void* loaddr) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_loadu2_m128i(Void* hiaddr, Void* loaddr) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_maskload_pd(Void* mem_addr, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_maskload_ps(Void* mem_addr, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void mm256_maskstore_pd(Void* mem_addr, v256 mask, v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void mm256_maskstore_ps(Void* mem_addr, v256 mask, v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "max_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v256 mm256_max_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "min_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v256 mm256_min_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_movedup_pd(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_movehdup_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_moveldup_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "movemask_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int mm256_movemask_pd(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_movemask_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_mul_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_mul_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_or_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_or_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_permute_pd(v256 a, int imm8) { }

		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse2), Member = "shuffle_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_permute_ps(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_permute2f128_pd(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_permute2f128_ps(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_permute2f128_si256(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permutevar_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permutevar_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_rcp_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_round_pd(v256 a, int rounding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "round_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_round_ps(v256 a, int rounding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse), Member = "rsqrt_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_rsqrt_ps(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_epi64x(long e3, long e2, long e1, long e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_set_m128(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_set_m128d(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_set_m128i(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_pd(double d, double c, double b, double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set1_epi16(short a) { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[DebuggerStepThrough]
		public static v256 mm256_set1_epi32(int a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set1_epi64x(long a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set1_epi8(byte a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_set1_pd(double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_set1_ps(float a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_setr_epi16(short e15_, short e14_, short e13_, short e12_, short e11_, short e10_, short e9_, short e8_, short e7_, short e6_, short e5_, short e4_, short e3_, short e2_, short e1_, short e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_setr_epi32(int e7, int e6, int e5, int e4, int e3, int e2, int e1, int e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setr_epi64x(long e3, long e2, long e1, long e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_setr_epi8(byte e31_, byte e30_, byte e29_, byte e28_, byte e27_, byte e26_, byte e25_, byte e24_, byte e23_, byte e22_, byte e21_, byte e20_, byte e19_, byte e18_, byte e17_, byte e16_, byte e15_, byte e14_, byte e13_, byte e12_, byte e11_, byte e10_, byte e9_, byte e8_, byte e7_, byte e6_, byte e5_, byte e4_, byte e3_, byte e2_, byte e1_, byte e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setr_m128(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setr_m128d(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setr_m128i(v128 hi, v128 lo) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setr_pd(double d, double c, double b, double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_setr_ps(float e7, float e6, float e5, float e4, float e3, float e2, float e1, float e0) { }

		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setzero_pd() { }

		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setzero_ps() { }

		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_setzero_si256() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "shuffle_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_shuffle_pd(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_shuffle_ps(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sqrt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sqrt_pd(v256 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 8)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_sqrt_ps(v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_store_pd(Void* ptr, v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_store_ps(Void* ptr, v256 val) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_store_si256(Void* ptr, v256 v) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu_pd(Void* ptr, v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu_ps(Void* ptr, v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu_si256(Void* ptr, v256 v) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu2_m128(Void* hiaddr, Void* loaddr, v256 val) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu2_m128d(Void* hiaddr, Void* loaddr, v256 val) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_storeu2_m128i(Void* hiaddr, Void* loaddr, v256 val) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_stream_pd(Void* mem_addr, v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_stream_ps(Void* mem_addr, v256 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_stream_si256(Void* mem_addr, v256 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_sub_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_sub_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testc_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testc_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "testc_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int mm256_testc_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testnzc_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testnzc_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "testz_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_1), Member = "testc_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int mm256_testnzc_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testz_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_testz_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "testz_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int mm256_testz_si256(v256 a, v256 b) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_undefined_pd() { }

		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_undefined_ps() { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 7)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_undefined_si256() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_unpackhi_pd(v256 a, v256 b) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_unpackhi_ps(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_unpacklo_pd(v256 a, v256 b) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_unpacklo_ps(v256 a, v256 b) { }

		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_xor_pd(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_xor_ps(v256 a, v256 b) { }

		[CallerCount(Count = 13327)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_zeroall() { }

		[CallerCount(Count = 13327)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void mm256_zeroupper() { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_zextpd128_pd256(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_zextps128_ps256(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_zextsi128_si256(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 permute_pd(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "shuffle_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 permute_ps(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 permutevar_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 permutevar_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		private static v128 Select4(v256 src1, v256 src2, int control) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testc_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testc_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testnzc_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testnzc_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testz_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testz_ps(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 undefined_pd() { }

		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 undefined_ps() { }

		[BurstTargetCpu(BurstTargetCpu::AVX (5))]
		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 undefined_si128() { }

	}

	internal static class Avx2
	{

		public static bool IsAvx2Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blend_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 blend_epi32(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 broadcastb_epi8(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 broadcastd_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 broadcastq_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 broadcastsd_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 broadcastss_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 broadcastw_epi16(v128 a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i64gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i64gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i64gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i64gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i64gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v256), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i64gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i64gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v256), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i64gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "i64gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i64gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i64gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "i64gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "i64gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i64gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i64gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "i64gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private static void EmulatedGather(T* dptr, Void* base_addr, Int64* indexPtr, int scale, int n, U* mask) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i32gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v128), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i32gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i32gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i32gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i32gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v128), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i32gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_mask_i32gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(Void*), typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mask_i32gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(Void*), typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "i32gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i32gather_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "i32gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "i32gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i32gather_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i32gather_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_i32gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "i32gather_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(long), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private static void EmulatedGather(T* dptr, Void* base_addr, Int32* indexPtr, int scale, int n, U* mask) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsAvx2Supported() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i32gather_epi32(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i32gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i32gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i32gather_ps(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i64gather_epi32(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i64gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i64gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 i64gather_ps(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i32gather_epi32(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i32gather_epi64(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i32gather_pd(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i32gather_ps(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i64gather_epi32(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i64gather_epi64(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i64gather_pd(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mask_i64gather_ps(v128 src, Void* base_addr, v128 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 maskload_epi32(Void* mem_addr, v128 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 maskload_epi64(Void* mem_addr, v128 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void maskstore_epi32(Void* mem_addr, v128 mask, v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void maskstore_epi64(Void* mem_addr, v128 mask, v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "abs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_abs_epi16(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "abs_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_abs_epi32(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "abs_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_abs_epi8(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "add_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_add_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_add_epi32(v256 a, v256 b) { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*", "System.Byte*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse2), Member = "add_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_add_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "add_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_add_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "adds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_adds_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "adds_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_adds_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "adds_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_adds_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "adds_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_adds_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "alignr_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_alignr_epi8(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_and_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_andnot_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "avg_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_avg_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "avg_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_avg_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blend_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blend_epi16(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blend_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blend_epi32(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "blendv_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_blendv_epi8(v256 a, v256 b, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_broadcastb_epi8(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcastd_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_broadcastq_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcastsd_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_broadcastsi128_si256(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_broadcastss_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_broadcastw_epi16(v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "slli_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_bslli_epi128(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srli_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_bsrli_epi128(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpeq_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpeq_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpeq_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpeq_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "cmpeq_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpeq_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpeq_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpeq_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpgt_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpgt_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpgt_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpgt_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpgt_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpgt_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "cmpgt_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_cmpgt_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi16_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi16_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi32_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi8_epi16(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi8_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepi8_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu16_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu16_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu32_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu8_epi16(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu8_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_cvtepu8_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static double mm256_cvtsd_f64(v256 a) { }

		[CallerCount(Count = 173)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int mm256_cvtsi256_si32(v256 a) { }

		[CallerCount(Count = 138)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long mm256_cvtsi256_si64(v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_extract_epi16(v256 a, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_extract_epi8(v256 a, int index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 mm256_extracti128_si256(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hadd_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hadd_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hadd_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hadd_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hadds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hadds_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hsub_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hsub_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hsub_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hsub_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "hsubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_hsubs_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i32gather_epi32(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i32gather_epi64(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i32gather_pd(Void* base_addr, v128 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i32gather_ps(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mm256_i64gather_epi32(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i64gather_epi64(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_i64gather_pd(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mm256_i64gather_ps(Void* base_addr, v256 vindex, int scale) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_inserti128_si256(v256 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "madd_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_madd_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "maddubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_maddubs_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i32gather_epi32(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i32gather_epi64(v256 src, Void* base_addr, v128 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i32gather_pd(v256 src, Void* base_addr, v128 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int32*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i32gather_ps(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mm256_mask_i64gather_epi32(v128 src, Void* base_addr, v256 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i64gather_epi64(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v256 mm256_mask_i64gather_pd(v256 src, Void* base_addr, v256 vindex, v256 mask, int scale) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Avx2), Member = "EmulatedGather", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "U"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(Void*), typeof(Int64*), typeof(int), typeof(int), "U*"}, ReturnType = typeof(void))]
		[DebuggerStepThrough]
		public static v128 mm256_mask_i64gather_ps(v128 src, Void* base_addr, v256 vindex, v128 mask, int scale) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_maskload_epi32(Void* mem_addr, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_maskload_epi64(Void* mem_addr, v256 mask) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void mm256_maskstore_epi32(Void* mem_addr, v256 mask, v256 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void mm256_maskstore_epi64(Void* mem_addr, v256 mask, v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "max_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "max_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "max_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "max_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "max_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epu32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "max_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_max_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "min_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "min_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "min_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "min_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "min_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epu32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "min_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_min_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int mm256_movemask_epi8(v256 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "mpsadbw_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mpsadbw_epu8(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "mul_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mul_epi32(v256 a, v256 b) { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*", "System.Byte*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse2), Member = "mul_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mul_epu32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "mulhi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mulhi_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "mulhi_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mulhi_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "mulhrs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mulhrs_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "mullo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mullo_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "mullo_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_mullo_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_or_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "packs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_packs_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "packs_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_packs_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "packus_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_packus_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "packus_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_packus_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_permute2x128_si256(v256 a, v256 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permute4x64_epi64(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permute4x64_pd(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permutevar8x32_epi32(v256 a, v256 idx) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_permutevar8x32_ps(v256 a, v256 idx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sad_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sad_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse2), Member = "shuffle_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_shuffle_epi32(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "shuffle_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_shuffle_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "shufflehi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_shufflehi_epi16(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "shufflelo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_shufflelo_epi16(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "sign_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sign_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "sign_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sign_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Ssse3), Member = "sign_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sign_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sll_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sll_epi16(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sll_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sll_epi32(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sll_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sll_epi64(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "slli_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_slli_epi16(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "slli_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_slli_epi32(v256 a, int imm8) { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Sse2), Member = "slli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_slli_epi64(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "slli_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_slli_si256(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_sllv_epi32(v256 a, v256 count) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_sllv_epi64(v256 a, v256 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sra_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sra_epi16(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sra_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sra_epi32(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srai_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srai_epi16(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srai_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srai_epi32(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v256 mm256_srav_epi32(v256 a, v256 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srl_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srl_epi16(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srl_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srl_epi32(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srl_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srl_epi64(v256 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srli_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srli_epi16(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srli_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srli_epi32(v256 a, int imm8) { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Sse2), Member = "srli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srli_epi64(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "srli_si128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_srli_si256(v256 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_srlv_epi32(v256 a, v256 count) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v256 mm256_srlv_epi64(v256 a, v256 count) { }

		[CallerCount(Count = 6)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_stream_load_si256(Void* mem_addr) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sub_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sub_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sub_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sub_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sub_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sub_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "sub_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_sub_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "subs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_subs_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "subs_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_subs_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "subs_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_subs_epu16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "subs_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_subs_epu8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "unpackhi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_unpackhi_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_unpackhi_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_unpackhi_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "unpackhi_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_unpackhi_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "unpacklo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_unpacklo_epi16(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v256 mm256_unpacklo_epi32(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_unpacklo_epi64(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse2), Member = "unpacklo_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v256 mm256_unpacklo_epi8(v256 a, v256 b) { }

		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v256 mm256_xor_si256(v256 a, v256 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 sllv_epi32(v128 a, v128 count) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 sllv_epi64(v128 a, v128 count) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srav_epi32(v128 a, v128 count) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 srlv_epi32(v128 a, v128 count) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 srlv_epi64(v128 a, v128 count) { }

	}

	internal static class Bmi1
	{

		public static bool IsBmi1Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint andn_u32(uint a, uint b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong andn_u64(ulong a, ulong b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint bextr_u32(uint a, uint start, uint len) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong bextr_u64(ulong a, uint start, uint len) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint bextr2_u32(uint a, uint control) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong bextr2_u64(ulong a, ulong control) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint blsi_u32(uint a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong blsi_u64(ulong a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint blsmsk_u32(uint a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong blsmsk_u64(ulong a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint blsr_u32(uint a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong blsr_u64(ulong a) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsBmi1Supported() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint tzcnt_u32(uint a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong tzcnt_u64(ulong a) { }

	}

	internal static class Bmi2
	{

		public static bool IsBmi2Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint bzhi_u32(uint a, uint index) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ulong bzhi_u64(ulong a, ulong index) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsBmi2Supported() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static uint mulx_u32(uint a, uint b, out uint hi) { }

		[CallerCount(Count = 45)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static ulong mulx_u64(ulong a, ulong b, out ulong hi) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static uint pdep_u32(uint a, uint mask) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static ulong pdep_u64(ulong a, ulong mask) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static uint pext_u32(uint a, uint mask) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static ulong pext_u64(ulong a, ulong mask) { }

	}

	public static class DoGetCSRTrampoline_0000012A$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(RoundingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MXCSRBits)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(F16C), Member = "cvtps_ph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(F16C), Member = "mm256_cvtps_ph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse), Member = "cvttss_si32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse), Member = "cvttss_si64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(X86), Member = "getcsr_raw", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(X86), Member = "DoGetCSRTrampoline", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(X86), Member = "get_MXCSR", ReturnType = typeof(MXCSRBits))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public static int Invoke() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class DoGetCSRTrampoline_0000012A$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 353)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public DoGetCSRTrampoline_0000012A$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(AsyncCallback unnamed_param_0, object unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Invoke() { }

	}

	public static class DoSetCSRTrampoline_00000129$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsUnknownMethods(Count = 4)]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[CalledBy(Type = typeof(RoundingScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MXCSRBits)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RoundingScope), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Sse), Member = "cvttss_si32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse), Member = "cvttss_si64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(X86), Member = "setcsr_raw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X86), Member = "DoSetCSRTrampoline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X86), Member = "set_MXCSR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MXCSRBits)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(BurstCompiler), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BurstCompiler), Member = "CompileFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Burst.FunctionPointer`1<T>")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public static void Invoke(int bits) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class DoSetCSRTrampoline_00000129$PostfixBurstDelegate : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public DoSetCSRTrampoline_00000129$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(int bits, AsyncCallback unnamed_param_1, object unnamed_param_2) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(int bits) { }

	}

	internal static class F16C
	{
		private static readonly UInt16[] BaseTable; //Field offset: 0x0
		private static readonly SByte[] ShiftTable; //Field offset: 0x8

		public static bool IsF16CSupported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		private static F16C() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(F16C), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static v128 cvtph_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[Calls(Type = typeof(F16C), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 cvtps_ph(v128 a, int rounding) { }

		[CalledBy(Type = typeof(F16C), Member = "cvtps_ph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(F16C), Member = "mm256_cvtps_ph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		private static ushort FloatToHalf(uint f, int rounding) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsF16CSupported() { }

		[CalledBy(Type = typeof(F16C), Member = "cvtph_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(F16C), Member = "mm256_cvtph_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 12)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		private static uint HalfToFloat(ushort h) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(F16C), Member = "HalfToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static v256 mm256_cvtph_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[Calls(Type = typeof(F16C), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 mm256_cvtps_ph(v256 a, int rounding) { }

	}

	internal static class Fma
	{
		private struct Union
		{
			public float f; //Field offset: 0x0
			public uint u; //Field offset: 0x0

		}


		public static bool IsFmaSupported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmadd_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmadd_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmadd_sd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmadd_ss(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmaddsub_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmaddsub_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		private static float FmaHelper(float a, float b, float c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmsub_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmsub_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmsub_sd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmsub_ss(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fmsubadd_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fmsubadd_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fnmadd_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fnmadd_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fnmadd_sd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fnmadd_ss(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		private static float FnmaHelper(float a, float b, float c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fnmsub_pd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fnmsub_ps(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 fnmsub_sd(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 fnmsub_ss(v128 a, v128 b, v128 c) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsFmaSupported() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fmadd_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fmadd_ps(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fmaddsub_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fmaddsub_ps(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fmsub_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fmsub_ps(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fmsubadd_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fmsubadd_ps(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fnmadd_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fnmadd_ps(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v256 mm256_fnmsub_pd(v256 a, v256 b, v256 c) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v256 mm256_fnmsub_ps(v256 a, v256 b, v256 c) { }

	}

	[Flags]
	internal enum MXCSRBits
	{
		FlushToZero = 32768,
		RoundingControlMask = 24576,
		RoundToNearest = 0,
		RoundDown = 8192,
		RoundUp = 16384,
		RoundTowardZero = 24576,
		PrecisionMask = 4096,
		UnderflowMask = 2048,
		OverflowMask = 1024,
		DivideByZeroMask = 512,
		DenormalOperationMask = 256,
		InvalidOperationMask = 128,
		ExceptionMask = 8064,
		DenormalsAreZeroes = 64,
		PrecisionFlag = 32,
		UnderflowFlag = 16,
		OverflowFlag = 8,
		DivideByZeroFlag = 4,
		DenormalFlag = 2,
		InvalidOperationFlag = 1,
		FlagMask = 63,
	}

	internal static class Popcnt
	{

		public static bool IsPopcntSupported
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 64
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static bool get_IsPopcntSupported() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int popcnt_u32(uint v) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int popcnt_u64(ulong v) { }

	}

	[Flags]
	internal enum RoundingMode
	{
		FROUND_TO_NEAREST_INT = 0,
		FROUND_TO_NEG_INF = 1,
		FROUND_TO_POS_INF = 2,
		FROUND_TO_ZERO = 3,
		FROUND_CUR_DIRECTION = 4,
		FROUND_RAISE_EXC = 0,
		FROUND_NO_EXC = 8,
		FROUND_NINT = 0,
		FROUND_FLOOR = 1,
		FROUND_CEIL = 2,
		FROUND_TRUNC = 3,
		FROUND_RINT = 4,
		FROUND_NEARBYINT = 12,
		FROUND_NINT_NOEXC = 8,
		FROUND_FLOOR_NOEXC = 9,
		FROUND_CEIL_NOEXC = 10,
		FROUND_TRUNC_NOEXC = 11,
		FROUND_RINT_NOEXC = 12,
	}

	public struct RoundingScope : IDisposable
	{
		private MXCSRBits OldBits; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		public RoundingScope(MXCSRBits roundingMode) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		public override void Dispose() { }

	}

	internal static class Sse
	{

		public static bool IsSseSupported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 add_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 add_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 and_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 andnot_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_ss(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpge_ps(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpge_ss(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_ps(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmple_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmple_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpneq_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpneq_ss(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnge_ps(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnge_ss(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpngt_ps(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpngt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnle_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnle_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnlt_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnlt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpord_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpord_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpunord_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpunord_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comieq_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comige_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comigt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comile_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comilt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comineq_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int cvt_ss2si(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtsi32_ss(v128 a, int b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtsi64_ss(v128 a, long b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static float cvtss_f32(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int cvtss_si32(v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static long cvtss_si64(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse), Member = "cvttss_si32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int cvtt_ss2si(v128 a) { }

		[CalledBy(Type = typeof(Sse), Member = "cvtt_ss2si", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cvttss_si32(v128 a) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static long cvttss_si64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 div_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 div_ss(v128 a, v128 b) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSseSupported() { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 18)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 load_ps(Void* ptr) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 18)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 loadu_ps(Void* ptr) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 loadu_si16(Void* mem_addr) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 loadu_si64(Void* mem_addr) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v128 max_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v128 max_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v128 min_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(float))]
		[DebuggerStepThrough]
		public static v128 min_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 move_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 movehl_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 movelh_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int movemask_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 mul_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 mul_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 or_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 rcp_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 rcp_ss(v128 a) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_rsqrt_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 rsqrt_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 rsqrt_ss(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_ps(float e3, float e2, float e1, float e0) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 set_ps1(float a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_ss(float a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 set1_ps(float a) { }

		[CallerCount(Count = 31)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 setr_ps(float e3, float e2, float e1, float e0) { }

		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 setzero_ps() { }

		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2ScrambleAcc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.xxHash3", Member = "Avx2Accumulate512", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt64*", "System.Byte*", "System.Byte*", "System.Byte*"}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		public static int SHUFFLE(int d, int c, int b, int a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 shuffle_ps(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sqrt_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sqrt_ss(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 9)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void store_ps(Void* ptr, v128 val) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 9)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void storeu_ps(Void* ptr, v128 val) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public static void storeu_si16(Void* mem_addr, v128 a) { }

		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void storeu_si64(Void* mem_addr, v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 9)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void stream_ps(Void* mem_addr, v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 sub_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 sub_ss(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static void TRANSPOSE4_PS(ref v128 row0, ref v128 row1, ref v128 row2, ref v128 row3) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomieq_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomige_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomigt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomile_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomilt_ss(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomineq_ss(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpackhi_ps(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpacklo_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 xor_ps(v128 a, v128 b) { }

	}

	internal static class Sse2
	{

		public static bool IsSse2Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CalledBy(Type = typeof(Avx2), Member = "mm256_add_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 add_epi16(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 add_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_add_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 add_epi64(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_add_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 add_epi8(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 add_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 add_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_adds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 adds_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_adds_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
		[DebuggerStepThrough]
		public static v128 adds_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_adds_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 adds_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_adds_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
		[DebuggerStepThrough]
		public static v128 adds_epu8(v128 a, v128 b) { }

		[CallerCount(Count = 10)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 and_pd(v128 a, v128 b) { }

		[CallerCount(Count = 10)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 and_si128(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 andnot_pd(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 andnot_si128(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_avg_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 avg_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_avg_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 avg_epu8(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static v128 bslli_si128(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static v128 bsrli_si128(v128 a, int imm8) { }

		[CallerCount(Count = 13327)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void clflush(Void* ptr) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpeq_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpeq_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpeq_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpge_pd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpge_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpgt_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpgt_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpgt_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_pd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmple_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmple_sd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_epi16(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_epi32(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmplt_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpneq_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpneq_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnge_pd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnge_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpngt_pd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpngt_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnle_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnle_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnlt_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpnlt_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(X86), Member = "IsNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[DebuggerStepThrough]
		public static v128 cmpord_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X86), Member = "IsNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[DebuggerStepThrough]
		public static v128 cmpord_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "cmp_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(X86), Member = "IsNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[DebuggerStepThrough]
		public static v128 cmpunord_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X86), Member = "IsNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[DebuggerStepThrough]
		public static v128 cmpunord_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comieq_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comige_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comigt_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comile_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comilt_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int comineq_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtepi32_pd(v128 a) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 cvtepi32_ps(v128 a) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_cvtpd_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v128 cvtpd_epi32(v128 a) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_cvtpd_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtpd_ps(v128 a) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_cvtps_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerStepThrough]
		public static v128 cvtps_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtps_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static double cvtsd_f64(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static int cvtsd_si32(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvtsd_si64(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvtsd_si64x(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtsd_ss(v128 a, v128 b) { }

		[CallerCount(Count = 173)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int cvtsi128_si32(v128 a) { }

		[CallerCount(Count = 138)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvtsi128_si64(v128 a) { }

		[CallerCount(Count = 138)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvtsi128_si64x(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtsi32_sd(v128 a, int b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtsi32_si128(int a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtsi64_sd(v128 a, long b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtsi64_si128(long a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtsi64x_sd(v128 a, long b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtsi64x_si128(long a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtss_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvttpd_epi32(v128 a) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 cvttps_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int cvttsd_si32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvttsd_si64(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static long cvttsd_si64x(v128 a) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 div_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 div_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static ushort extract_epi16(v128 a, int imm8) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSse2Supported() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 insert_epi16(v128 a, int i, int imm8) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 load_si128(Void* ptr) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 loadu_si128(Void* ptr) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static v128 loadu_si32(Void* mem_addr) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_madd_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 madd_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 max_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[DebuggerStepThrough]
		public static v128 max_epu8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_max_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 max_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 max_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), typeof(short)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 min_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[DebuggerStepThrough]
		public static v128 min_epu8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_min_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 min_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 min_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 move_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 move_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int movemask_epi8(v128 a) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_movemask_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static int movemask_pd(v128 a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mul_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mul_epu32(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 mul_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 mul_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mulhi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mulhi_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mulhi_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mulhi_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mullo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mullo_epi16(v128 a, v128 b) { }

		[CallerCount(Count = 9)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 or_pd(v128 a, v128 b) { }

		[CallerCount(Count = 9)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 or_si128(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_packs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
		[DebuggerStepThrough]
		public static v128 packs_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_packs_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 packs_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_packus_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
		[DebuggerStepThrough]
		public static v128 packus_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sad_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sad_epu8(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_epi32(int e3, int e2, int e1, int e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_epi64x(long e1, long e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_pd(double e1, double e0) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 set_pd1(double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set_sd(double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set1_epi16(short a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 set1_epi32(int a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 set1_epi64x(long a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static v128 set1_epi8(sbyte a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 set1_pd(double a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 setr_epi16(short e7, short e6, short e5, short e4, short e3, short e2, short e1, short e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 setr_epi32(int e3, int e2, int e1, int e0) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 setr_epi8(sbyte e15_, sbyte e14_, sbyte e13_, sbyte e12_, sbyte e11_, sbyte e10_, sbyte e9_, sbyte e8_, sbyte e7_, sbyte e6_, sbyte e5_, sbyte e4_, sbyte e3_, sbyte e2_, sbyte e1_, sbyte e0_) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 setr_pd(double e1, double e0) { }

		[CallerCount(Count = 3)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 setzero_si128() { }

		[CalledBy(Type = typeof(Avx), Member = "permute_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_permute_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_shuffle_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 5)]
		[DebuggerStepThrough]
		public static v128 shuffle_epi32(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_shuffle_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 shuffle_pd(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int SHUFFLE2(int x, int y) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_shufflehi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 shufflehi_epi16(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_shufflelo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 shufflelo_epi16(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sll_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 sll_epi16(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sll_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 sll_epi32(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sll_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 sll_epi64(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_slli_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 slli_epi16(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_slli_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 slli_epi32(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_slli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 slli_epi64(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_slli_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_bslli_epi128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerStepThrough]
		public static v128 slli_si128(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_sqrt_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sqrt_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sqrt_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sra_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 sra_epi16(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sra_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 sra_epi32(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srai_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srai_epi16(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srai_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srai_epi32(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srl_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 srl_epi16(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srl_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 srl_epi32(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srl_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v128)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[DebuggerStepThrough]
		public static v128 srl_epi64(v128 a, v128 count) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srli_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srli_epi16(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srli_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srli_epi32(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srli_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 srli_epi64(v128 a, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_srli_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_bsrli_epi128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerStepThrough]
		public static v128 srli_si128(v128 a, int imm8) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void store_si128(Void* ptr, v128 val) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void storeu_si128(Void* ptr, v128 val) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public static void storeu_si32(Void* mem_addr, v128 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void stream_pd(Void* mem_addr, v128 a) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void stream_si128(Void* mem_addr, v128 a) { }

		[CallerCount(Count = 11)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void stream_si32(Int32* mem_addr, int a) { }

		[CallerCount(Count = 26)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static void stream_si64(Int64* mem_addr, long a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sub_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sub_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sub_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sub_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sub_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sub_epi64(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sub_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sub_epi8(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 sub_pd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 sub_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_subs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 subs_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_subs_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
		[DebuggerStepThrough]
		public static v128 subs_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_subs_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 subs_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_subs_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
		[DebuggerStepThrough]
		public static v128 subs_epu8(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomieq_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomige_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomigt_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomile_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomilt_sd(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int ucomineq_sd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_unpackhi_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 unpackhi_epi16(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpackhi_epi32(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpackhi_epi64(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_unpackhi_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 unpackhi_epi8(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpackhi_pd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_unpacklo_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 unpacklo_epi16(v128 a, v128 b) { }

		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpacklo_epi32(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpacklo_epi64(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_unpacklo_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 unpacklo_epi8(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 unpacklo_pd(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 xor_pd(v128 a, v128 b) { }

		[CallerCount(Count = 4)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 xor_si128(v128 a, v128 b) { }

	}

	internal static class Sse3
	{

		public static bool IsSse3Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CalledBy(Type = typeof(Avx), Member = "mm256_addsub_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 addsub_pd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_addsub_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 addsub_ps(v128 a, v128 b) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSse3Supported() { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_hadd_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 hadd_pd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_hadd_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hadd_ps(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_hsub_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 hsub_pd(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_hsub_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hsub_ps(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 movedup_pd(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 movehdup_ps(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 moveldup_ps(v128 a) { }

	}

	internal static class Sse4_1
	{

		public static bool IsSse41Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CalledBy(Type = typeof(Avx2), Member = "mm256_blend_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 blend_epi16(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_blend_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 blend_pd(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_blend_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx2), Member = "blend_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Avx2), Member = "mm256_blend_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 5)]
		[DebuggerStepThrough]
		public static v128 blend_ps(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_blendv_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 blendv_epi8(v128 a, v128 b, v128 mask) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_blendv_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 blendv_pd(v128 a, v128 b, v128 mask) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_blendv_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 blendv_ps(v128 a, v128 b, v128 mask) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 ceil_pd(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 ceil_ps(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 ceil_sd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 ceil_ss(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpeq_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpeq_epi64(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtepi16_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepi16_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepi32_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepi8_epi16(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtepi8_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepi8_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtepu16_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepu16_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepu32_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepu8_epi16(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cvtepu8_epi32(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 cvtepu8_epi64(v128 a) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 dp_pd(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_dp_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 dp_ps(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int extract_epi32(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static long extract_epi64(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static byte extract_epi8(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static int extract_ps(v128 a, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static float extractf_ps(v128 a, int imm8) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 floor_pd(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 floor_ps(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 floor_sd(v128 a, v128 b) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 floor_ss(v128 a, v128 b) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSse41Supported() { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 insert_epi32(v128 a, int i, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 insert_epi64(v128 a, long i, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 insert_epi8(v128 a, byte i, int imm8) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static v128 insert_ps(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 max_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[DebuggerStepThrough]
		public static v128 max_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 max_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_max_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static v128 max_epu32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static v128 min_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[DebuggerStepThrough]
		public static v128 min_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 min_epu16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_min_epu32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static v128 min_epu32(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 minpos_epu16(v128 a) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int MK_INSERTPS_NDX(int srcField, int dstField, int zeroMask) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mpsadbw_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mpsadbw_epu8(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mul_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mul_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mullo_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mullo_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_packus_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_UnsignedInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
		[DebuggerStepThrough]
		public static v128 packus_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_round_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_ceil_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_floor_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 round_pd(v128 a, int rounding) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_round_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_ceil_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_floor_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 round_ps(v128 a, int rounding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[DebuggerStepThrough]
		public static v128 round_sd(v128 a, v128 b, int rounding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_1), Member = "RoundDImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 round_ss(v128 a, v128 b, int rounding) { }

		[CalledBy(Type = typeof(Sse4_1), Member = "floor_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "round_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "floor_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "ceil_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "round_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "floor_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "ceil_ps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "round_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "ceil_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "round_ss", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "floor_ss", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_1), Member = "ceil_ss", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private static double RoundDImpl(double d, int roundingMode) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerStepThrough]
		[DeduplicatedMethod]
		public static v128 stream_load_si128(Void* mem_addr) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int test_all_ones(v128 a) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int test_all_zeros(v128 a, v128 mask) { }

		[BurstTargetCpu(BurstTargetCpu::X64_SSE4 (4))]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int test_mix_ones_zeroes(v128 a, v128 mask) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_testc_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_testnzc_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int testc_si128(v128 a, v128 b) { }

		[CallerCount(Count = 0)]
		[DebuggerStepThrough]
		public static int testnzc_si128(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx), Member = "mm256_testz_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Avx), Member = "mm256_testnzc_si256", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int testz_si128(v128 a, v128 b) { }

	}

	internal static class Sse4_2
	{
		[Flags]
		internal enum SIDD
		{
			UBYTE_OPS = 0,
			UWORD_OPS = 1,
			SBYTE_OPS = 2,
			SWORD_OPS = 3,
			CMP_EQUAL_ANY = 0,
			CMP_RANGES = 4,
			CMP_EQUAL_EACH = 8,
			CMP_EQUAL_ORDERED = 12,
			POSITIVE_POLARITY = 0,
			NEGATIVE_POLARITY = 16,
			MASKED_POSITIVE_POLARITY = 32,
			MASKED_NEGATIVE_POLARITY = 48,
			LEAST_SIGNIFICANT = 0,
			MOST_SIGNIFICANT = 64,
			BIT_MASK = 0,
			UNIT_MASK = 64,
		}

		private struct StrBoolArray
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <Bits>e__FixedBuffer
			{
				public ushort FixedElementField; //Field offset: 0x0

			}

			[FixedBuffer(typeof(ushort), 16)]
			public <Bits>e__FixedBuffer Bits; //Field offset: 0x0

			[CalledBy(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CallerCount(Count = 5)]
			[ContainsUnimplementedInstructions]
			public bool GetBit(int aindex, int bindex) { }

			[CalledBy(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			public void SetBit(int aindex, int bindex, bool val) { }

		}

		private static readonly UInt32[] crctab; //Field offset: 0x0

		public static bool IsSse42Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private static Sse4_2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpestra(v128 a, int la, v128 b, int lb, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpestrc(v128 a, int la, v128 b, int lb, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(ushort)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(sbyte)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int cmpestri(v128 a, int la, v128 b, int lb, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int), typeof(v128), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStriOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private static int cmpestri_emulation(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(ushort)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int), typeof(sbyte)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpestrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 cmpestrm(v128 a, int la, v128 b, int lb, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestrm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int), typeof(v128), typeof(int), typeof(int)}, ReturnType = typeof(v128))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static v128 cmpestrm_emulation(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes, T allOnesT) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int cmpestro(v128 a, int la, v128 b, int lb, int imm8) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpestrs(v128 a, int la, v128 b, int lb, int imm8) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpestrz(v128 a, int la, v128 b, int lb, int imm8) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_cmpgt_epi64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static v128 cmpgt_epi64(v128 val1, v128 val2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpistra(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(ushort)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(sbyte)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(v128))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpistrc(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(ushort)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(sbyte)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int cmpistri(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStriOutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private static int cmpistri_emulation(T* a, T* b, int len, int imm8, int allOnes, T allOnesT) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(short)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(ushort)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(sbyte)}, ReturnType = typeof(v128))]
		[Calls(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(v128))]
		[DebuggerStepThrough]
		public static v128 cmpistrm(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistrm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistrc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static v128 cmpistrm_emulation(T* a, T* b, int len, int imm8, int allOnes, T allOnesT) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16*), typeof(int), typeof(Int16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int), typeof(UInt16*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(SByte*), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStrCmpIntRes2", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[DebuggerStepThrough]
		public static int cmpistro(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpistrs(v128 a, v128 b, int imm8) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16*), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Sse4_2), Member = "ComputeStringLength", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DebuggerStepThrough]
		public static int cmpistrz(v128 a, v128 b, int imm8) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestrm_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(v128))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestrc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int), typeof(v128), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int), typeof(v128), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(int), typeof(v128), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Byte>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Byte>))]
		[Calls(Type = typeof(StrBoolArray), Member = "SetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StrBoolArray), Member = "GetBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static int ComputeStrCmpIntRes2(T* a, int alen, T* b, int blen, int len, int imm8, int allOnes) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistrz", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistrs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistro", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistra", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private static int ComputeStringLength(T* ptr, int max) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "cmpistri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", "T*", typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Sse4_2), Member = "cmpestri_emulation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(int), "T*", typeof(int), typeof(int), typeof(int), typeof(int), "T"}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		private static int ComputeStriOutput(int len, int imm8, int intRes2) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private static v128 ComputeStrmOutput(int len, int imm8, T allOnesT, int intRes2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "crc32_u8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static uint crc32_u16(uint crc, ushort v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "crc32_u8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static uint crc32_u32(uint crc, uint v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "crc32_u8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		public static ulong crc32_u64(ulong crc_ul, ulong v) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sse4_2), Member = "crc32_u8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(byte)}, ReturnType = typeof(uint))]
		[DebuggerStepThrough]
		[Obsolete("Use the ulong version of this intrinsic instead.")]
		public static ulong crc32_u64(ulong crc_ul, long v) { }

		[CalledBy(Type = typeof(Sse4_2), Member = "crc32_u32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(Sse4_2), Member = "crc32_u16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(ushort)}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(Sse4_2), Member = "crc32_u64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(long)}, ReturnType = typeof(ulong))]
		[CalledBy(Type = typeof(Sse4_2), Member = "crc32_u64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 22)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerStepThrough]
		public static uint crc32_u8(uint crc, byte v) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSse42Supported() { }

	}

	internal static class Ssse3
	{

		public static bool IsSsse3Supported
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		[CalledBy(Type = typeof(Avx2), Member = "mm256_abs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 abs_epi16(v128 a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_abs_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 abs_epi32(v128 a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_abs_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 abs_epi8(v128 a) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_alignr_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256), typeof(int)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 alignr_epi8(v128 a, v128 b, int count) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public static bool get_IsSsse3Supported() { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hadd_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hadd_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hadd_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hadd_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hadds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 hadds_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hsub_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hsub_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hsub_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 hsub_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_hsubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 hsubs_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_maddubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(X86), Member = "Saturate_To_Int16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
		[DebuggerStepThrough]
		public static v128 maddubs_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_mulhrs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 mulhrs_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_shuffle_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 shuffle_epi8(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sign_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sign_epi16(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sign_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sign_epi32(v128 a, v128 b) { }

		[CalledBy(Type = typeof(Avx2), Member = "mm256_sign_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v256), typeof(v256)}, ReturnType = typeof(v256))]
		[CallerCount(Count = 2)]
		[DebuggerStepThrough]
		public static v128 sign_epi8(v128 a, v128 b) { }

	}


	public static MXCSRBits MXCSR
	{
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private static int BurstIntrinsicGetCSRFromManaged() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void BurstIntrinsicSetCSRFromManaged(int _) { }

	[BurstCompile(CompileSynchronously = True)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(DoGetCSRTrampoline_0000012A$PostfixBurstDelegate))]
	private static int DoGetCSRTrampoline() { }

	[BurstCompile(CompileSynchronously = True)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal static int DoGetCSRTrampoline$BurstManaged() { }

	[BurstCompile(CompileSynchronously = True)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[MonoPInvokeCallback(typeof(DoSetCSRTrampoline_00000129$PostfixBurstDelegate))]
	private static void DoSetCSRTrampoline(int bits) { }

	[BurstCompile(CompileSynchronously = True)]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	internal static void DoSetCSRTrampoline$BurstManaged(int bits) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	private static v128 GenericCSharpLoad(Void* ptr) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	private static void GenericCSharpStore(Void* ptr, v128 val) { }

	[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public static MXCSRBits get_MXCSR() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DoGetCSRTrampoline_0000012A$BurstDirectCall), Member = "Invoke", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	internal static int getcsr_raw() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsNaN(uint v) { }

	[CalledBy(Type = typeof(Sse2), Member = "cmpord_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "cmpunord_sd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "cmpord_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "cmpunord_pd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CallerCount(Count = 12)]
	[ContainsUnimplementedInstructions]
	private static bool IsNaN(ulong v) { }

	[CalledBy(Type = typeof(Sse2), Member = "adds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "subs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "packs_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Ssse3), Member = "hadds_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Ssse3), Member = "hsubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Ssse3), Member = "maddubs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CallerCount(Count = 9)]
	private static short Saturate_To_Int16(int val) { }

	[CalledBy(Type = typeof(Sse2), Member = "adds_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "subs_epi8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "packs_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CallerCount(Count = 4)]
	private static sbyte Saturate_To_Int8(int val) { }

	[CalledBy(Type = typeof(Sse2), Member = "adds_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "subs_epu16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse4_1), Member = "packus_epi32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CallerCount(Count = 10)]
	private static ushort Saturate_To_UnsignedInt16(int val) { }

	[CalledBy(Type = typeof(Sse2), Member = "adds_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "subs_epu8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CalledBy(Type = typeof(Sse2), Member = "packus_epi16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(v128), typeof(v128)}, ReturnType = typeof(v128))]
	[CallerCount(Count = 4)]
	private static byte Saturate_To_UnsignedInt8(int val) { }

	[BurstTargetCpu(BurstTargetCpu::X64_SSE2 (3))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public static void set_MXCSR(MXCSRBits value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DoSetCSRTrampoline_00000129$BurstDirectCall), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal static void setcsr_raw(int bits) { }

}

