#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t3275118058;
// System.Collections.Generic.List`1<UnityEngine.KeyCode>
struct List_1_t1652516284;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Duck_Behavior
struct  Duck_Behavior_t3020576596  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Duck_Behavior::playerSpeed
	float ___playerSpeed_2;
	// System.Single Duck_Behavior::currentSpeed
	float ___currentSpeed_3;
	// UnityEngine.Vector3 Duck_Behavior::lastMovement
	Vector3_t2243707580  ___lastMovement_4;
	// UnityEngine.Transform Duck_Behavior::laser
	Transform_t3275118058 * ___laser_5;
	// System.Single Duck_Behavior::laserDistance
	float ___laserDistance_6;
	// System.Single Duck_Behavior::timeBetweenFires
	float ___timeBetweenFires_7;
	// System.Single Duck_Behavior::timeTilNextFire
	float ___timeTilNextFire_8;
	// System.Collections.Generic.List`1<UnityEngine.KeyCode> Duck_Behavior::shootButton
	List_1_t1652516284 * ___shootButton_9;

public:
	inline static int32_t get_offset_of_playerSpeed_2() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___playerSpeed_2)); }
	inline float get_playerSpeed_2() const { return ___playerSpeed_2; }
	inline float* get_address_of_playerSpeed_2() { return &___playerSpeed_2; }
	inline void set_playerSpeed_2(float value)
	{
		___playerSpeed_2 = value;
	}

	inline static int32_t get_offset_of_currentSpeed_3() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___currentSpeed_3)); }
	inline float get_currentSpeed_3() const { return ___currentSpeed_3; }
	inline float* get_address_of_currentSpeed_3() { return &___currentSpeed_3; }
	inline void set_currentSpeed_3(float value)
	{
		___currentSpeed_3 = value;
	}

	inline static int32_t get_offset_of_lastMovement_4() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___lastMovement_4)); }
	inline Vector3_t2243707580  get_lastMovement_4() const { return ___lastMovement_4; }
	inline Vector3_t2243707580 * get_address_of_lastMovement_4() { return &___lastMovement_4; }
	inline void set_lastMovement_4(Vector3_t2243707580  value)
	{
		___lastMovement_4 = value;
	}

	inline static int32_t get_offset_of_laser_5() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___laser_5)); }
	inline Transform_t3275118058 * get_laser_5() const { return ___laser_5; }
	inline Transform_t3275118058 ** get_address_of_laser_5() { return &___laser_5; }
	inline void set_laser_5(Transform_t3275118058 * value)
	{
		___laser_5 = value;
		Il2CppCodeGenWriteBarrier(&___laser_5, value);
	}

	inline static int32_t get_offset_of_laserDistance_6() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___laserDistance_6)); }
	inline float get_laserDistance_6() const { return ___laserDistance_6; }
	inline float* get_address_of_laserDistance_6() { return &___laserDistance_6; }
	inline void set_laserDistance_6(float value)
	{
		___laserDistance_6 = value;
	}

	inline static int32_t get_offset_of_timeBetweenFires_7() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___timeBetweenFires_7)); }
	inline float get_timeBetweenFires_7() const { return ___timeBetweenFires_7; }
	inline float* get_address_of_timeBetweenFires_7() { return &___timeBetweenFires_7; }
	inline void set_timeBetweenFires_7(float value)
	{
		___timeBetweenFires_7 = value;
	}

	inline static int32_t get_offset_of_timeTilNextFire_8() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___timeTilNextFire_8)); }
	inline float get_timeTilNextFire_8() const { return ___timeTilNextFire_8; }
	inline float* get_address_of_timeTilNextFire_8() { return &___timeTilNextFire_8; }
	inline void set_timeTilNextFire_8(float value)
	{
		___timeTilNextFire_8 = value;
	}

	inline static int32_t get_offset_of_shootButton_9() { return static_cast<int32_t>(offsetof(Duck_Behavior_t3020576596, ___shootButton_9)); }
	inline List_1_t1652516284 * get_shootButton_9() const { return ___shootButton_9; }
	inline List_1_t1652516284 ** get_address_of_shootButton_9() { return &___shootButton_9; }
	inline void set_shootButton_9(List_1_t1652516284 * value)
	{
		___shootButton_9 = value;
		Il2CppCodeGenWriteBarrier(&___shootButton_9, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
