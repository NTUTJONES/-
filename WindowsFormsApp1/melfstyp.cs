//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	melfstyp.cs
//	<機能>			melFs関連の定義(カスタ?API?イブ?? データタイプ定義)
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		melfstyp
//	<機能>			melFs関連の定義(カスタ?API?イブ?? データタイプ定義)ク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melfstyp
{
	// ----- ＮＣファイ?システ?アクセス型データタイプ定義 -----
	// File mode (st_mode) bit masks
	public const int MM_S_IFDIR				= 0x4000;		// directory
	public const int MM_S_IFREG				= 0x8000;		// regular

	// ----- NC???ファイ?システ?アクセスコマ?ド定義 -----
	// melFSCreateFile/melFSOpenFile
	public const int M_FSOPEN_RDONLY		= 0x0000;		// 読み取り専用にオープ?する
	public const int M_FSOPEN_WRONLY		= 0x0001;		// ?き?み専用にオープ?する
	public const int M_FSOPEN_RDWR			= 0x0002;		// 読み取り／?き?み用にオープ?する
	public const int M_FSOPEN_CREAT			= 0x0200;		// open with file create
	public const int M_FSOPEN_TRUNC			= 0x0400;		// open with truncation

	// melFSIoctlFile
	public const int M_FSIOCTL_FREECHAR		= 0x0000;		// ファイ?システ?の残文??の取得
	public const int M_FSIOCTL_ENTRYCHAR	= 0x0001;		// ファイ?システ?の登録文??の取得
	public const int M_FSIOCTL_FREEFILE		= 0x0002;		// ファイ?システ?のファイ?残本?の取得
	public const int M_FSIOCTL_ENTRYFILE	= 0x0003;		// ファイ?システ?のファイ?登録本?の取得
	public const int M_FSIOCTL_RDFILECOM	= 0x0005;		// ファイ?コ??トの読み出し
	public const int M_FSIOCTL_WTFILECOM	= 0x0006;		// ファイ?コ??トの?き?み
	public const int M_FSIOCTL_DISKFORMAT	= 0x0007;		// NC???のフォーマット
	public const int M_FSIOCTL_NOBOFOUT		= 0x0008;		// 出力?にBOF("%")を出力しない
	public const int M_FSIOCTL_SIOINIT		= 0x0009;		// NCシ?ア?の?期設定
	public const int M_FSIOCTL_SIOGETERR	= 0x000A;		// NCシ?ア?のエ?ー取得
	public const int M_FSIOCTL_SIOSTOP		= 0x000B;		// NCシ?ア?の強制停止
	public const int M_FSIOCTL_READDIRSYS	= 0x000C;		// melFSReadDirectory()で取得する系?指定
	public const int M_FSIOCTL_FILETIMESET	= 0x000D;		// ファイ?日?の設定
	public const int M_FSIOCTL_UPRO_ALLCLR	= 0x000E;		// 加工プ?グ??全消?
	public const int M_FSIOCTL_MMAC_ALLCLR	= 0x000F;		// 機械?ーカマク?全消?
	public const int M_FSIOCTL_FIXPRO_INIT	= 0x0010;		// 固定サイク??期化
	public const int M_FSIOCTL_FREECHAR64	= 0x0011;		// 各デバイスの空き容量の取得
	public const int M_FSIOCTL_ENTRYCHAR64	= 0x0012;		// 各デバイスの使用量の取得
	public const int M_FSIOCTL_TOTALCHAR64	= 0x0013;		// 各デバイスの全体容量の取得
	public const int M_FSIOCTL_PRGCOMMENT	= 0x0016;		// 加工プ?グ??コ??ト取得
	public const int M_FSIOCTL_CHKDEVLOCK	= 0x0018;		// 各デバイスの??み?ック状態の取得
	public const int M_FSIOCTL_DISKFORMATEX = 0x001A;		// ファイ?システ?フォーマット(非同期)

	// melFSLseekFile
	public const int M_FSLSEEK_TOP			= 0x0000;		// ファイ?の先頭からシーク
	public const int M_FSLSEEK_CURRENT		= 0x0001;		// ファイ?の現在位置からシーク
	public const int M_FSLSEEK_END			= 0x0002;		// ファイ?の最後からシーク

}

// ----- ＮＣファイ?システ?アクセス型データタイプ定義 -----
// ファイ?情報
[StructLayout(LayoutKind.Sequential)]
public struct FS_STAT
{
	public int	 lMode;										// ファイ?の属性（st_mode:MM_S_IFDIR:ディ?クト?）
	public int	 lFileSize;									// ファイ?サイズ
	public short nYear;										// ファイ?更新日（年）
	public short nMonth;									// ファイ?更新日（?）
	public short nDay;										// ファイ?更新日（日）
	public short nHour;										// ファイ?更新日（?）
	public short nMinute;									// ファイ?更新日（分）
	public short nSecond;									// ファイ?更新日（秒）
}
