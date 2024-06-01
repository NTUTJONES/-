//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	melncapi.cs
//	<機能>			コマ?ド定義
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		melncapi
//	<機能>			コマ?ド定義ク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melncapi
{
	// ----- NC APIで使用するマク?	 -------------------
	// -- アド?ス関連 --
	public static int ADR_SYSTEM(int n)									// 系?（グ?ープ番?）の指定
	{
		return ((int)((n << 8) & 0x0000ff00));
	}

	public static int ADR_MACHINE(int n)								// コ?ト?ー?の指定
	{
		return ((int)((n << 24) & 0xff000000));
	}

	public const int ADR_FORCE_WRITE   = (((1) << 18) & 0x00040000);	// 強制?き?み?ードの指定
	public const int ADR_BASE_SYSTEM   = (((0) << 16) & 0x00ff0000);	// 基本系?の指定
	public const int ADR_CROSS_CURRENT = (((1) << 16) & 0x00ff0000);	// ク?スカ??ト系?の指定

	public static int ADR_GROUND(int n)									// グ??ド(FORE/BACK)の指定
	{
		return ((int)((n << 20 ) & 0x00f00000));
	}

	// ----- 各コマ?ドで使用するマク?	 -------------------
	// -- System関連 --
	// melIoctl
	public const int DEV_SET_RTIMEOUT				= 0x001;			// ?ードタイ?アウトの設定
	public const int DEV_SET_WTIMEOUT				= 0x002;			// ?イトタイ?アウトの設定
	public const int DEV_SET_COMMTIMEOUT			= 0x005;			// 通信タイ?アウト値設定
	public const int DEV_GET_COMMTIMEOUT			= 0x006;			// 通信タイ?アウト値取得
	public const int DEV_SET_COMMCONFIRMTIMEOUT		= 0x008;			// NC接続確認の通信タイ?アウト値の設定
	public const int DEV_GET_COMMCONFIRMTIMEOUT		= 0x009;			// NC接続確認の通信タイ?アウト値の取得
	public const int DEV_GET_COMMADDRESS			= 0xFEF;			// melcfg.iniのIPアド?ス取得アド?ス取得
	public const int DEV_SET_COMMADDRESS			= 0xFFF;			// アド?ス設定
	public const int DEV_SET_EXCLUSIVETIMEOUT		= 0x00F;			// 排他制御タイ?アウト?間設定
	public const int DEV_GET_EXCLUSIVETIMEOUT		= 0x010;			// 排他制御タイ?アウト?間取得
	public const int DEV_SET_REMOTEMODE				= 0x103;			// ?隔?作?ードの設定
	public const int DEV_GET_REMOTEMODE				= 0x104;			// ?隔?作?ードの取得
	public const int DEV_SET_CONNECTTIMEOUT			= 0x105;			// 接続タイ?アウト値の設定
	public const int DEV_GET_CONNECTTIMEOUT			= 0x106;			// 接続タイ?アウト値の取得
	public const int DEV_SET_CACHEMAX				= 0x107;			// データ?ードキ?ッシ?データ最大個?設定
	public const int DEV_GET_CACHEMAX				= 0x108;			// データ?ードキ?ッシ?データ最大個?取得
	public const int DEV_SET_PD_ENABLE				= 0x10B;			// PCダイ?クト運転機能使用有無の設定
	public const int DEV_SET_LOGTYPE				= 0x111;			// 異常通知方法の設定
	public const int DEV_GET_LOGTYPE				= 0x112;			// 異常通知方法の取得
	public const int DEV_SET_LOGDIR					= 0x113;			// 異常通知?グファイ?出力先の設定
	public const int DEV_GET_LOGDIR					= 0x114;			// 異常通知?グファイ?出力先の取得
	public const int CMD_ENABLE_BACKGROUND			= 0x1001;			// バックグ?ウ?ドチェック機能
	public const int CMD_NC_DISCONNECT				= 0x1002;			// 指定したNCとの接続を切断する

	// DEV_SET_COMMADDRESS、DEV_GET_COMMADDRESS用
	public const int DEVICETYPE_TCP					= 4;				// TCPソケット経由

	// melActiveatePLC
	public const int M_OPE_ACTPLC_TRUE				= 0x01;				// PLC起動
	public const int M_OPE_ACTPLC_FALSE				= 0x00;				// PLC停止

	// melGetCurrentAlarmMsg, melGetAlarmMsg
	public const int M_ALM_ALL_ALARM				= 0x000;			// ア?ー?種類の区別なし
	public const int M_ALM_NC_ALARM					= 0x100;			// NCア?ー?
	public const int M_ALM_STOP_CODE				= 0x200;			// ストップコード
	public const int M_ALM_PLC_ALARM				= 0x300;			// PLCア?ー??ッセージ
	public const int M_ALM_OPE_MSG					= 0x400;			// オペ?ータ?ッセージ
	public const int M_ALM_NC_AUX					= 0x10C;			// 補?軸NCア?ー?

	// -- ?ケー?設定 --
	// melSetLocale/melGetLocale
	public const int LANG_JA						= 0x40000411;		// 日本
	public const int LANG_EN						= 0x40000409;		// ア??カ
	public const int LANG_DE						= 0x40000407;		// ドイツ
	public const int LANG_IT						= 0x40000410;		// イタ?ア
	public const int LANG_FR						= 0x4000040C;		// フ??ス
	public const int LANG_ES						= 0x4000040A;		// スペイ?
	public const int LANG_TW						= 0x40000404;		// 台湾
	public const int LANG_CN						= 0x40000804;		// ??
	public const int LANG_KO						= 0x40000412;		// 韓?
	public const int LANG_PT						= 0x40000816;		// ポ?トガ?
	public const int LANG_HU						= 0x4000040E;		// ハ?ガ?ー
	public const int LANG_NL						= 0x40000413;		// オ??ダ
	public const int LANG_SV						= 0x4000041D;		// スウェーデ?
	public const int LANG_PL						= 0x40000415;		// ポー??ド
	public const int LANG_TR						= 0x4000041F;		// ト?コ
	public const int LANG_RU						= 0x40000419;		// ?シア
	public const int LANG_CZ						= 0x40000405;		// チェコ
	public const int LANG_DA						= 0x40000406;		// 26:デ?マーク
	public const int LANG_FI						= 0x4000040B;		// 27:フィ???ド
	public const int LANG_RO						= 0x40000418;		// 28:?ーマニア
	public const int LANG_SL						= 0x40000424;		// 29:ス?ベニア
	public const int LANG_BG						= 0x40000402;		// 30:ブ?ガ?ア
}

// ----- DEV_SET_COMMADDRESS、DEV_GET_COMMADDRESS用 -------------------
// ISA
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_ISA
{
	public uint dwDeviceType;					//デバイス種別
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// PCI
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_PCI
{
	public uint dwDeviceType;					//デバイス種別
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// COM
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_COM
{
	public uint dwDeviceType;					//デバイス種別
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// TCP
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct MELDEVICEDATA_TCP
{
	public uint dwDeviceType;					//デバイス種別
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
	public string IPAddr;
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
	public sbyte[] dummy;
}

// MAC
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_MAC
{
	public uint dwDeviceType;					//デバイス種別
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// GOT
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_GOT
{
	public uint dwDeviceType;					//デバイス種別
	public uint dwChannel;
	public uint dwNetworkNo;
	public uint dwPcNo;
	public uint dwMultiCpuNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public sbyte[] dummy;
}

// ----- DEV_SET_CACHEMAX, DEV_GET_CACHEMAX用 -------------------
[StructLayout(LayoutKind.Sequential)]
public struct MELCACHEMAXDATA
{
	public uint dwCacheCount;					//?ードキ?ッシ?最大登録?
	public uint dwCacheCancelUnit;				//?ードキ?ッシ?解?個?
}
