// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the SOLOROCKETLEAGUELOGIC_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// SOLOROCKETLEAGUELOGIC_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#define DLL_EXPORT __declspec(dllexport)


//extern DLL_EXPORT int nSoloRocketLeagueLogic;

//DLL_EXPORT int fnSoloRocketLeagueLogic(void);

DLL_EXPORT int getScore();
DLL_EXPORT void setScore(int amount);


