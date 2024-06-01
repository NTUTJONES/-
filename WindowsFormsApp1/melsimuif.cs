//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	melsimuif.cs
//	<機能>			シミ??ーシ??IF用の定義ファイ?
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		melsimuif
//	<機能>			シミ??ーシ??IF用の定義ク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melsimuif
{
	public const int SIMU_SET_INTER_TYPE	= 1;				// PC-NC間の通信方法
	public const int SIMU_SET_COORD_TYPE	= 2;				// 取得する座標系
	public const int SIMU_SET_ACCUR_TYPE	= 3;				// 取得するデータの精度
	public const int SIMU_SET_CTL_ALL		= 4;				// 通信方式・座標系・精度を一?で指定
	public const int NORMAL_TYPE			= 0;				// 非同期通信タイプ/実軸機械座標系タイプ/終点保証タイプ
	public const int SYNC_COM_TYPE			= 1;				// 同期通信タイプ
	public const int PROGRAM_TYPE			= 1;				// プ?グ?ミ?グ座標系タイプ
	public const int ROTINTER_TYPE			= 1;				// 回転軸補間?精度タイプ
	public const int ALLINTER_TYPE			= 2;				// 全補間?精度タイプ

	public static int SIMU_CTL_INTER(int n)						// PC-NC間の通信方法
	{
		return ((int)((n << 0) & 0x000000ff));
	}

	public static int SIMU_CTL_COORD(int n)						// 取得する座標系
	{
		return ((int)((n << 8) & 0x0000ff00));
	}

	public static int SIMU_CTL_ACCUR(int n)						// 取得するデータの精度
	{
		return ((int)((n << 16) & 0x00ff0000));
	}

	public static int SETSIMU_READSYSTEMNUM(int n)				// 取得系?の指定
	{
		return ((int)((n << 0) & 0x000000ff));
	}

	public const int SETSIMU_SIMULATION_MODE = ((int)((0) << 16) & 0x00ff0000);		// シミ??ーシ???ード
	public const int SIMUBUF_AXISNO = (8);											// 軸?
}


//************************
// Simulation Data Table *
//************************
// 軸データ
[StructLayout(LayoutKind.Sequential)]
public struct SM_AXIS
{
	// 0x00
	public byte blkinf;			// ブ?ック情報
	public byte pilinf;			// 重畳同期情報
	public sbyte bsaxno;		// 基本軸情報
	public sbyte bsaxsys;		// 基本系?情報
	public sbyte pilbsaxno;		// 重畳同期軸情報
	public sbyte pilbsaxsys;	// 重畳同期系?情報
	public byte dec;			// 小?点以下??
	public sbyte axinf;			// 軸情報
	// 0x08
	public long simpos;			// 機械位置データ
	public long simmov;			// ブ?ック移動量
	// 0x18
}

// MSTB情報
[StructLayout(LayoutKind.Sequential)]
public struct SM_MTBF
{
	// 0x00
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] smmcod;		// Mコードデータ
	public int smtcod;			// Tコードデータ
	public int smbcod;			// Bコードデータ
	public short smmstf;		// MSTBフ?グ
	public short smmstf2;		// MSTBフ?グ2
	public uint speh_smtf;		// Sフ?グ
	// 0x20
}

// ブ?ック?間情報
[StructLayout(LayoutKind.Sequential)]
public struct SM_TIME
{
	// 0x00
	public int smstrtime;	// ブ?ック開始?間
	public int smendtime;	// ブ?ック終了?間
	// 0x08
}


// プ?グ??情報
[StructLayout(LayoutKind.Sequential)]
public struct SM_BLOCK
{
	// 0x00
	public int smprgno; // プ?グ??番?
	public int smblkno; // ブ?ック番?
	// 0x08
}

// シミ??ーシ??データ
[StructLayout(LayoutKind.Sequential)]
public struct SIMU_BUF
{
	// 0x00
	public sbyte ssysno;					// 系?番?
	public sbyte smspdmagn;					// 速度倍率
	public sbyte smprgdev;					// 実行?プ?グ?? デバイスID
	public byte movmod;						// 移動?ード
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] ssidmy1;					// ダミー
	public ushort thrdchkid;				// 3DチェックID番?
	// 0x08
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = melsimuif.SIMUBUF_AXISNO)]
	public SM_AXIS[] sm_axis;				// 軸データ(8軸に制限)
	// 0xC8
	public long crcentt;					// 円弧?心位置データ(円弧?さ)
	public long crcenth;					// 円弧?心位置データ(円弧横)
	public long crcentv;					// 円弧?心位置データ(円弧縦)
	public long smfeedrt;					// ?り速度
	public long smleadk;					// ?ード?減量
	public long smg16rd;					// G16平面円?半径
	public int smcrosfg;					// ク?ス軸フ?グ
	public int smpdmy3;						// ダミー
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
	public int[] smscod;					// Sコードデータ1(第１～10主軸)
	public int smcloop;						// 円弧回転?
	public sbyte smplane;					// 平面選択データ
	public sbyte smmilling;					// ミー??グ?ードデータ
	public sbyte smrdaxno;					// ?ード軸?
	public sbyte smpdmy2;					// ダミー
	public SM_MTBF sm_mtbf;					// MSTB情報
	public SM_TIME sm_time;					// ブ?ック?間情報
	public SM_BLOCK sm_block;				// プ?グ??情報
	// 0x160
}

// 拡張シミ??ーシ??データ
[StructLayout(LayoutKind.Sequential)]
public struct SIMU_BUF_EXT
{
	// 0x00
	public SIMU_BUF simu_buf;				// シミ??ーシ??データ
	// 0x160
	public int smodlflg;					// ?ーダ?情報
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] sincax;					// 傾斜軸制御軸番?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] shypax;					// 仮想座標制御軸番?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] soblax;					// 斜め座標制御軸番?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] smpdmy1;					// ダミー
	public int gsdmyl;						// ダミー
	public double svectt;					// 法線ベクト?(T)
	public double svecth;					// 法線ベクト?(H)
	public double svectv;					// 法線ベクト?(V)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] ssyncax;					// 工具主軸同期軸番?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public short[] ssyncrt;					// 工具主軸同期回転比
	public byte smexecsts;					// シミ??ーシ??実行?状態
	public byte stcpara_index;				// 使用?回転軸構成パ??ータ
	// 0x190
}
