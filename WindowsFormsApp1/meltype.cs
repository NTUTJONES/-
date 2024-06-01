//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	meltype.cs
//	<機能>			データタイプ定義
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		meltype
//	<機能>			データタイプ定義ク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class meltype
{
	//******************************************************
	// ----- ?値型データタイプ定義 -----------------------
	//******************************************************
	public const int T_CHAR			= 0x1;				// 1バイト整?型
	public const int T_SHORT		= 0x2;				// 2バイト整?型
	public const int T_LONG			= 0x3;				// 4バイト整?型
	public const int T_DLONG		= 0x4;				// 8バイト整?型
	public const int T_DOUBLE		= 0x5;				// 実?型

	//******************************************************
	// ----- 文?型データタイプ定義 -----------------------
	//******************************************************
	public const int T_STR			= 0x10;				// 文?列型
	public const int T_DECSTR		= 0x11;				// 10進整?文?列型
	public const int T_HEXSTR		= 0x12;				// 16進?文?列型
	public const int T_BINSTR		= 0x13;				// 2進?文?列型
	public const int T_FLOATSTR		= 0x14;				// 実?文?列型
	public const int T_WSTR			= 0x15;				// 文?列型(UNICODE)
	public const int T_DECWSTR		= 0x16;				// 10進整?文?列型(UNICODE)
	public const int T_HEXWSTR		= 0x17;				// 16進?文?列型(UNICODE)
	public const int T_FLOATWSTR	= 0x19;				// 実?文?列型(UNICODE)
	// オプシ??定義
	public const int FSTR_FILL_ZERO = 0x1;				// 小??ゼ?詰めを行なう
	public const int FSTR_ADD_PLUS	= 0x2;				// 正の?の場?＋??を付ける

	//******************************************************
	// ----- 特殊型データタイプ定義 -----------------------
	//******************************************************
	public const int T_GETPRGBLOCK	= 0x102;			// 実行?プ?グ??取得用
	public const int T_BUFF			= 0x103;			// 汎用バッファ型

	//******************************************************
	// ----- NCファイ?システ?データタイプ定義 -----------
	//******************************************************
	public const int T_STAT			= 0x106;			// NCファイ?システ?情報取得用

	//******************************************************
	// ----- ア?ー??ッセージ取得用定義	-------------
	//******************************************************
	public const int T_ALARMMSG		= 0x108;			// ア?ー??ッセージ
	public const int T_ALARMMSG2	= 0x10e;			// ア?ー??ッセージ2

	//******************************************************
	// ----- チェック描画データ取得用定義	-------------
	//******************************************************
	public const int T_CHECKDRAW	= 0x109;			// 8軸分の描画データ取得
	public const int T_CHECKDRAW16	= 0x110;			// 16軸分の描画データ取得
	public const int T_CHECKDRAWQS	= 0x113;			// 16軸分の?速?ード用描画データ取得

	//******************************************************
	// ----- UNICODE用プ?グ??取得用定義	-------------
	//******************************************************
	public const int T_WGETPRGBLOCK = 0x10a;			// 実行?プ?グ??取得用(UNICODE)

	//******************************************************
	// ----- UNICODE用ア?ー??ッセージ取得用定義	-----
	//******************************************************
	public const int T_WALARMMSG	= 0x10c;			// ア?ー??ッセージ(UNICODE)
	public const int T_WALARMMSG2	= 0x10f;			// ア?ー??ッセージ2(UNICODE)

	//******************************************************
	//	ＮＣシ?ア?ポート環境設定用定義	-------------
	//******************************************************
	public const int T_SERIAL_SETUP = 0x10d;			// ＮＣシ?ア?ポート環境設定
}

//******************************************************
// ----- 文?型データタイプ定義	    -------------
//******************************************************
// 文?列型
[StructLayout(LayoutKind.Sequential)]
public struct STRINGTYPE				// used also as T_BUFF
{
	public int lBuffSize;
	public IntPtr lpszBuff;
}

// 実?文?列型
[StructLayout(LayoutKind.Sequential)]
public struct FLOATSTR
{
	public short nIntDataNos;			// 整????
	public short nDecDataNos;			// 小????
	public int lOption;					// オプシ??
	public int lBuffSize;				// データ領域のサイズ
	public IntPtr lpszBuff;				// データ領域のポイ?タ
}

// 実?文?列型(UNICODE)
[StructLayout(LayoutKind.Sequential)]
public struct FLOATWSTR
{
	public short nIntDataNos;			// 整????
	public short nDecDataNos;			// 小????
	public int lOption;					// オプシ??
	public int lBuffSize;				// データ領域のサイズ
	public IntPtr lpszBuff;				// データ領域のポイ?タ
}

//******************************************************
// ----- 特殊型データタイプ定義	-----------------------
//******************************************************
// 実行?プ?グ??取得用
[StructLayout(LayoutKind.Sequential)]
public struct GETPRGBLOCK
{
	public int lCurrentBlockNum;		// 実行?のブ?ック
										// (取得したデータ?のブ?ック)
										//	  0:運転?でない
										//	  1:1ブ?ック目
										//	  2:2ブ?ック目
	public int lPrgDataSize;			// lpszPrgDataのバッファサイズ
	public IntPtr lpszPrgData;			// プ?グ??を格納するバッファ
}

// 実行?プ?グ??取得用
[StructLayout(LayoutKind.Sequential)]
public struct BUFFTYPE
{
	public int lBuffSize;				// lpBuffのバッファサイズ
	public IntPtr lpBuff;				// バッファのポイ?タ
}

// melRegisterLumpModal用
[StructLayout(LayoutKind.Sequential)]
public struct REGLUMPMODAL
{
	public int lAddress;				// アド?ス
	public int lSectionNum;				// 大区分番?
	public int lSubSectionNum;			// 小区分番?
	public int lAxisFlag;				// 軸の指定
	public int lDataType;				// データタイプ
	public int lPriority;				// 優先?位
}

[StructLayout(LayoutKind.Explicit)]
public struct value
{
	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1280)]
	public sbyte[] cBuff;
	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 640)]
	public short[] nBuff;
	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 320)]
	public int[] lBuff;
}

// PLCデバイス一?設定タイプ(公開大区分M_SEC_PLC_DEV_XXX melSetData用
[StructLayout(LayoutKind.Sequential)]
public struct PLCDEV_LUMPTYPE
{
	public int lDataType;				// データタイプ
	public int lDataNos;				// ?き?みデータの個?
	public value value;
}

//******************************************************
// ----- ア?ー??ッセージ取得用定義	-------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct ALARMMSG
{
	public int lSystem;					// 取得ア?ー?の系?
	public int lAlarmType;				// 取得ア?ー?の詳細種別
	public int lBuffSize;				// lpszBuffのバッファサイズ
	public IntPtr lpszBuff;				// ?ッセージを格納する
										// バッファへのポイ?タ
}
//******************************************************
// ----- UNICODE用プ?グ??取得用	    -------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct WGETPRGBLOCK
{
	public int lCurrentBlockNum;		// 実行?のブ?ック
										// (取得したデータ?のブ?ック)
										//	  0:運転?でない
										//	  1:1ブ?ック目
										//	  2:2ブ?ック目
	public int lPrgDataSize;			// lpszPrgDataのバッファサイズ
	public IntPtr lpszPrgData;			// プ?グ??を格納するバッファ
}

//******************************************************
// ----- ア?ー??ッセージ取得用定義	-------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct WALARMMSG
{
	public int lSystem;					// 取得ア?ー?の系?
	public int lAlarmType;				// 取得ア?ー?の詳細種別
	public int lBuffSize;				// lpszBuffのバッファサイズ
	public IntPtr lpszBuff;				// ?ッセージを格納する
										// バッファへのポイ?タ
}

//******************************************************
// ----- ＮＣシ?ア?ポート環境設定用構造体 -------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct SERIAL_SETUP
{
	public int lBaudRate;				// ボー?ート設定
										//	110, 300, 600, 1200, 2400, 4800,
										//	9600, 19200
	public sbyte cByteSize;				// データビット長設定	7, 8
	public sbyte cParityBit;			// パ?ティビット設定
										//	0:無効（チェック無し）
										//	1:有効（チェック有り）
	public sbyte cEvenOdd;				// 奇?/偶?パ?ティ設定
										//	1:奇?チェック, 2:偶?チェック
	public sbyte cStopBit;				// ストップビット設定
										//	0:1bit, 1:1.5bit, 2:2bit
	public sbyte cHandShake;			// ハ?ドシェィク設定
										//	0:RTS/CTS方式
										//	1:ハ?ドシェイク無し
										//	2:DCコード方式
	public sbyte cDCcodeParity;			// DCコードパ?ティ設定
										//	0:Xon-offパ?ティ オフ
										//	1:Xon-offパ?ティ オ?
	public sbyte cDRoff;				// DRチェック無効 0:チェック有効 1:無効
	public sbyte cOutBufSize;			// 出力バッファサイズ
										//	0:250バイト
										//	1:1バイト
										//	2:4バイト
										//	3:8バイト
										//	4:16バイト
										//	5:64バイト
										//	その他:250バイト
	public int lTimeout;				// タイ?アウト?間 (x100ms)
	public sbyte cTermType;				// ターミネータタイプ設定	1:EOB, 3:EOR
	public sbyte cDC2DC4;				// DC2/DC4出力設定
										//	bit0: DC2コード出力
										//	bit1: DC4コード出力
	public sbyte cCRout;				// CR出力設定	0:未出力, 1:出力
	public sbyte cEIAout;				// EIA出力設定	0:ISO出力, 1:EIA出力
	public short nFeedChar;				// フィード?設定	0-250
	public sbyte cParityV;				// パ?ティVチェック設定
										//	0:チェック無し, 1:チェック有り
	public sbyte cAscii;				// データASCII設定
										//	0:ISO or EIA, 1:ASCII
	public sbyte cEIAcode1;				// '[' -> EIA代替コード設定
	public sbyte cEIAcode2;				// ']' -> EIA代替コード設定
	public sbyte cEIAcode3;				// '#' -> EIA代替コード設定
	public sbyte cEIAcode4;				// '*' -> EIA代替コード設定
	public sbyte cEIAcode5;				// '=' -> EIA代替コード設定
	public sbyte cEIAcode6;				// ':' -> EIA代替コード設定
	public sbyte cEIAcode7;				// '$' -> EIA代替コード設定
	public sbyte cEIAcode8;				// '!' -> EIA代替コード設定
}
