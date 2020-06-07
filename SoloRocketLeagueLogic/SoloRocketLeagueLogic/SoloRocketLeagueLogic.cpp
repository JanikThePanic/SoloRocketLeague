// SoloRocketLeagueLogic.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "SoloRocketLeagueLogic.h"

int currentScore = 0;

DLL_EXPORT int getScore()
{
	return currentScore;
}

DLL_EXPORT void setScore(int amount)
{
	currentScore = amount;
}