//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	wrapper_ncapi32.cs
//	<機能>			カスタ?APIDLLプ?ットフォー?呼び出し
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;
using System.Text;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		ncapi_wrapper
//	<機能>			カスタ?APIDLL(ncapi32.dll)のプ?ットフォー?呼び出しク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

public class ncapi_wrapper
{
	//*****************************************
	// ncapi32.dllのイ?ポート
	//*****************************************
	[DllImport("ncapi32.dll", EntryPoint = "melIoctl")]
	private static extern uint Import_melIoctl(IntPtr hWnd, int lAddress, int lFunction, IntPtr lpData);

	[DllImport("ncapi32.dll", EntryPoint = "melSetLocale")]
	private static extern uint Import_melSetLocale(IntPtr hWnd, uint dwLocale);

	[DllImport("ncapi32.dll", EntryPoint = "melGetBackLight")]
	private static extern uint Import_melGetBackLight(IntPtr hWnd, IntPtr lpdwLight);

	[DllImport("ncapi32.dll", EntryPoint = "melSetBackLight")]
	private static extern uint Import_melSetBackLight(IntPtr hWnd, uint dwLight);

	[DllImport("ncapi32.dll", EntryPoint = "melCancelCopyFile")]
	private static extern uint Import_melCancelCopyFile(IntPtr hWnd, int lCopyFileID);

	[DllImport("ncapi32.dll", EntryPoint = "melCloseDirectory")]
	private static extern uint Import_melCloseDirectory(IntPtr hWnd, uint lDirectoryId);

	[DllImport("ncapi32.dll", EntryPoint = "melCopyFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melCopyFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melCreateDirectory", CharSet = CharSet.Ansi)]
	private static extern uint Import_melCreateDirectory(IntPtr hWnd, string lpszDirectoryName);

	[DllImport("ncapi32.dll", EntryPoint = "melDeleteDirectory", CharSet = CharSet.Ansi)]
	private static extern uint Import_melDeleteDirectory(IntPtr hWnd, string lpszDirectoryName);

	[DllImport("ncapi32.dll", EntryPoint = "melDeleteFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melDeleteFile(IntPtr hWnd, string lpszFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melExecCopyFile")]
	private static extern uint Import_melExecCopyFile(IntPtr hWnd, int lCopyFileID);

	[DllImport("ncapi32.dll", EntryPoint = "melGetDiskFree", CharSet = CharSet.Ansi)]
	private static extern uint Import_melGetDiskFree(IntPtr hWnd, string lpszDirectoryName);

	[DllImport("ncapi32.dll", EntryPoint = "melGetDriveList", CharSet = CharSet.Ansi)]
	private static extern uint Import_melGetDriveList(IntPtr hWnd, StringBuilder lpszDriveList, int lBuffSize);

	[DllImport("ncapi32.dll", EntryPoint = "melOpenDirectory", CharSet = CharSet.Ansi)]
	private static extern uint Import_melOpenDirectory(IntPtr hWnd, string lpszDirectoryName, int lFileType);

	[DllImport("ncapi32.dll", EntryPoint = "melReadDirectory", CharSet = CharSet.Ansi)]
	private static extern uint Import_melReadDirectory(IntPtr hWnd, uint lDirectoryId, StringBuilder lpszFileInfo, int lBuffSize);

	[DllImport("ncapi32.dll", EntryPoint = "melRenameFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melRenameFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melStartCopyFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melStartCopyFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melStartCopyFileW", CharSet = CharSet.Unicode)]
	private static extern uint Import_melStartCopyFileW(IntPtr hWnd, string lpwszSrcFileName, string lpwszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melStartCopyFileEx", CharSet = CharSet.Ansi)]
	private static extern uint Import_melStartCopyFileEx(IntPtr hWnd, string lpszSrcFileName, string lpszHeaderFileName, string lpszFooterFileName, string lpszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melStartCopyFileExW", CharSet = CharSet.Unicode)]
	private static extern uint Import_melStartCopyFileExW(IntPtr hWnd, string lpwszSrcFileName, string lpwszHeaderFileName, string lpwszFooterFileName, string lpwszDstFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melFSCloseDirectory")]
	private static extern uint Import_melFSCloseDirectory(IntPtr hWnd, int lAddress, int lFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSCloseFile")]
	private static extern uint Import_melFSCloseFile(IntPtr hWnd, int lAddress, int lFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSCreateFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSCreateFile(IntPtr hWnd, int lAddress, string lpszFileName, int lFlag, IntPtr lpFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSFstatFile")]
	private static extern uint Import_melFSFstatFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpStat);

	[DllImport("ncapi32.dll", EntryPoint = "melFSIoctlFile")]
	private static extern uint Import_melFSIoctlFile(IntPtr hWnd, int lAddress, int lFd, int lCommand, IntPtr lpCtrlData, int lDataType);

	[DllImport("ncapi32.dll", EntryPoint = "melFSLseekFile")]
	private static extern uint Import_melFSLseekFile(IntPtr hWnd, int lAddress, int lFd, int lOffset, int lWhence, IntPtr lpResultOffset);

	[DllImport("ncapi32.dll", EntryPoint = "melFSOpenDirectory", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSOpenDirectory(IntPtr hWnd, int lAddress, string lpszDirName, IntPtr lpFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSOpenFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSOpenFile(IntPtr hWnd, int lAddress, string lpszFileName, int lFlag, int lMode, IntPtr lpFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSReadDirectory")]
	private static extern uint Import_melFSReadDirectory(IntPtr hWnd, int lAddress, int lFd, IntPtr pFSInfo);

	[DllImport("ncapi32.dll", EntryPoint = "melFSReadFile")]
	private static extern uint Import_melFSReadFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpReadData, int lReadType, IntPtr lpReadNos);

	[DllImport("ncapi32.dll", EntryPoint = "melFSRenameFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSRenameFile(IntPtr hWnd, int lAddress, string lpszOldFileName, string lpszNewFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melFSRemoveFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSRemoveFile(IntPtr hWnd, int lAddress, string lpszFileName);

	[DllImport("ncapi32.dll", EntryPoint = "melFSRewindDirectory")]
	private static extern uint Import_melFSRewindDirectory(IntPtr hWnd, int lAddress, int lFd);

	[DllImport("ncapi32.dll", EntryPoint = "melFSStatFile", CharSet = CharSet.Ansi)]
	private static extern uint Import_melFSStatFile(IntPtr hWnd, int lAddress, string lpszFileName, IntPtr lpStat);

	[DllImport("ncapi32.dll", EntryPoint = "melFSWriteFile")]
	private static extern uint Import_melFSWriteFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpWriteData, IntPtr lpWriteNos);

	[DllImport("ncapi32.dll", EntryPoint = "melCancelModal")]
	private static extern uint Import_melCancelModal(IntPtr hWnd, int lAddress, int lModalId);

	[DllImport("ncapi32.dll", EntryPoint = "melCancelLumpModal")]
	private static extern uint Import_melCancelLumpModal(IntPtr hWnd, int lAddress, int lCancelModalNos, IntPtr lpdwModalIdBuff, IntPtr lpdwCancelIdBuff);

	[DllImport("ncapi32.dll", EntryPoint = "melGetData")]
	private static extern uint Import_melGetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpGetData, int lGetType);

	[DllImport("ncapi32.dll", EntryPoint = "melGetLumpData")]
	private static extern uint Import_melGetLumpData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectTop, int lGetNos, IntPtr lpGetData, int lGetType);

	[DllImport("ncapi32.dll", EntryPoint = "melIsReadCacheEnable")]
	private static extern uint Import_melIsReadCacheEnable(IntPtr hWnd, int lAddress);

	[DllImport("ncapi32.dll", EntryPoint = "melReadCacheEnable")]
	private static extern uint Import_melReadCacheEnable(IntPtr hWnd, int lAddress, bool bEnable);

	[DllImport("ncapi32.dll", EntryPoint = "melReadModal")]
	private static extern uint Import_melReadModal(IntPtr hWnd, int lAddress, int lModalId, IntPtr lpReadData, int lReadType);

	[DllImport("ncapi32.dll", EntryPoint = "melRegisterLumpModal")]
	private static extern uint Import_melRegisterLumpModal(IntPtr hWnd, int lAddress, int lRegistModalNos, IntPtr lpModalDataBuff, IntPtr lpdwModalIdBuff);

	[DllImport("ncapi32.dll", EntryPoint = "melRegisterGetModal")]
	private static extern uint Import_melRegisterGetModal(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, int lDataType, int lPriority);

	[DllImport("ncapi32.dll", EntryPoint = "melSetData")]
	private static extern uint Import_melSetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpSetData, int lSetType);

	[DllImport("ncapi32.dll", EntryPoint = "melSafetySetData")]
	private static extern uint Import_melSafetySetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpSetData, int lSetType);

	[DllImport("ncapi32.dll", EntryPoint = "melSafetyGetData")]
	private static extern uint Import_melSafetyGetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpGetData, int lGetType);

	[DllImport("ncapi32.dll", EntryPoint = "melActivatePLC")]
	private static extern uint Import_melActivatePLC(IntPtr hWnd, int lAddress, int lActivePLC);

	[DllImport("ncapi32.dll", EntryPoint = "melGetCurrentAlarmMsg")]
	private static extern uint Import_melGetCurrentAlarmMsg(IntPtr hWnd, int lAddress, int lMsgNos, int lAlarmType, IntPtr lpAlarmMsg, int lReadType);

	[DllImport("ncapi32.dll", EntryPoint = "melGetCurrentAlarmMsgEx")]
	private static extern uint Import_melGetCurrentAlarmMsgEx(IntPtr hWnd, int lAddress, int lMsgNos, int lAlarmType, IntPtr lpAlarmMsg, int lReadType, int lExtInfo);

	[DllImport("ncapi32.dll", EntryPoint = "melGetCurrentPrgBlock")]
	private static extern uint Import_melGetCurrentPrgBlock(IntPtr hWnd, int lAddress, int lPrgBlockNos, IntPtr lpPrgBlock, int lReadType);

	[DllImport("ncapi32.dll", EntryPoint = "melSelectExecPrg")]
	private static extern uint Import_melSelectExecPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum);

	[DllImport("ncapi32.dll", EntryPoint = "melSelectExecPrgEx")]
	private static extern uint Import_melSelectExecPrgEx(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber, int lSelectType, int lParam);

	[DllImport("ncapi32.dll", EntryPoint = "melSelectRestartPrg")]
	private static extern uint Import_melSelectRestartPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber, int lSelectType);

	[DllImport("ncapi32.dll", EntryPoint = "melEntryCollationPrg")]
	private static extern uint Import_melEntryCollationPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber);

	[DllImport("ncapi32.dll", EntryPoint = "melSelectCheckPrg")]
	private static extern uint Import_melSelectCheckPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lReserve);

	[DllImport("ncapi32.dll", EntryPoint = "melEntryBottomCheckPrg")]
	private static extern uint Import_melEntryBottomCheckPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber);

	[DllImport("ncapi32.dll", EntryPoint = "melResetCheckPrg")]
	private static extern uint Import_melResetCheckPrg(IntPtr hWnd, int lAddress);

	[DllImport("ncapi32.dll", EntryPoint = "melExecCheckPrg")]
	private static extern uint Import_melExecCheckPrg(IntPtr hWnd, int lAddress, int lCntrlFlag);

	[DllImport("ncapi32.dll", EntryPoint = "melGetDrawData")]
	private static extern uint Import_melGetDrawData(IntPtr hWnd, int lAddress, IntPtr lpCheckDraw, int lDataType);

	[DllImport("ncapi32.dll", EntryPoint = "melOpenBuffEdit")]
	private static extern uint Import_melOpenBuffEdit(IntPtr hWnd, int lAddress);

	[DllImport("ncapi32.dll", EntryPoint = "melGetBuffEditPrgBlock")]
	private static extern uint Import_melGetBuffEditPrgBlock(IntPtr hWnd, int lAddress, uint dwBuffEditId, int lPrgBlockNos, IntPtr lpPrgBlock, int lReadType);

	[DllImport("ncapi32.dll", EntryPoint = "melSetBuffEditPrgBlock")]
	private static extern uint Import_melSetBuffEditPrgBlock(IntPtr hWnd, int lAddress, uint dwBuffEditId, IntPtr lpPrgBlock, int lWriteType);

	[DllImport("ncapi32.dll", EntryPoint = "melCloseBuffEdit")]
	private static extern uint Import_melCloseBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId);

	[DllImport("ncapi32.dll", EntryPoint = "melStateOfBuffEdit")]
	private static extern uint Import_melStateOfBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId);

	[DllImport("ncapi32.dll", EntryPoint = "melSizeOfBuffEdit")]
	private static extern uint Import_melSizeOfBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId);

	[DllImport("ncapi32.dll", EntryPoint = "melGetExecPrgCallStack", CharSet = CharSet.Ansi)]
	private static extern uint Import_melGetExecPrgCallStack(IntPtr hWnd, int lAddress, int lOption, StringBuilder lpszPrgList, int lBuffsize);

	[DllImport("ncapi32.dll", EntryPoint = "melSimuCtl")]
	private static extern uint Import_melSimuCtl(IntPtr hWnd, int lAddress, int lFunction, IntPtr lpData);

	[DllImport("ncapi32.dll", EntryPoint = "melSetSimuMode")]
	private static extern uint Import_melSetSimuMode(IntPtr hWnd, int lAddress, int lReadSystemNum);

	[DllImport("ncapi32.dll", EntryPoint = "melRead3DSimuData")]
	private static extern uint Import_melRead3DSimuData(IntPtr hWnd, int lSimuID, int lBufferCount, IntPtr lpReadData, int lDataSize);

	[DllImport("ncapi32.dll", EntryPoint = "melResetSimuMode")]
	private static extern uint Import_melResetSimuMode(IntPtr hWnd, int lSimuID);

	[DllImport("ncapi32.dll", EntryPoint = "melSelectProcessTime", CharSet = CharSet.Ansi)]
	private static extern uint Import_melSelectProcessTime(IntPtr hWnd, int lAddress, string lpszCheckPrgName, int lReserve);

	[DllImport("ncapi32.dll", EntryPoint = "melGetProcessTime")]
	private static extern uint Import_melGetProcessTime(IntPtr hWnd, int lAddress, IntPtr lpGetStatus, IntPtr lpGetProcessTime, int lGetType, int lReserve);

	[DllImport("ncapi32.dll", EntryPoint = "melResetProcessTime")]
	private static extern uint Import_melResetProcessTime(IntPtr hWnd, int lAddress);


	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melIoctl
	//	<機能>				環境設定
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress		アド?ス
	//						int			lFunction		ファ?クシ??コード
	//						IntPtr		lpData			データ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melIoctl(IntPtr hWnd, int lAddress, int lFunction, IntPtr lpData)
	{
		uint lStatus;
		lStatus = Import_melIoctl(hWnd, lAddress, lFunction, lpData);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSetLocale
	//	<機能>				?ケー?の設定
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						uint		dwLocale		?ケー?
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSetLocale(IntPtr hWnd, uint dwLocale)
	{
		uint lStatus;
		lStatus = Import_melSetLocale(hWnd, dwLocale);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetBackLight
	//	<機能>				バック?イトON/OFF状態の取得
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						IntPtr		lpdwLight		バック?イトON/OFF格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetBackLight(IntPtr hWnd, IntPtr lpdwLight)
	{
		uint lStatus;
		lStatus = Import_melGetBackLight(hWnd, lpdwLight);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSetBackLight
	//	<機能>				バック?イトON/OFF状態の取得
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						uint		dwLight			バック?イト
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSetBackLight(IntPtr hWnd, uint dwLight)
	{
		uint lStatus;
		lStatus = Import_melSetBackLight(hWnd, dwLight);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCancelCopyFile
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを?断
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lCopyFileID		コピーID(melStartCopyFileの戻り値で取得した値)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCancelCopyFile(IntPtr hWnd, int lCopyFileID)
	{
		uint lStatus;
		lStatus = Import_melCancelCopyFile(hWnd, lCopyFileID);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCloseDirectory
	//	<機能>				melOpenDirectoryでオープ?したディ?クト?をク?ーズ
	//					[引?]
	//						IntPtr		hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						uint		lDirectoryId	ク?ーズするディ?クト?のID
	//													(melOpenDirectoryで得られたID)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCloseDirectory(IntPtr hWnd, uint lDirectoryId)
	{
		uint lStatus;
		lStatus = Import_melCloseDirectory(hWnd, lDirectoryId);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCopyFile
	//	<機能>				ファイ?をコピー
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszSrcFileName		コピー元ファイ?名
	//						string		lpszDstFileName		コピー先ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCopyFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melCopyFile(hWnd, lpszSrcFileName, lpszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCreateDirectory
	//	<機能>				ディ?クト?を作成
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszDirectoryName	ディ?クト?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCreateDirectory(IntPtr hWnd, string lpszDirectoryName)
	{
		uint lStatus;
		lStatus = Import_melCreateDirectory(hWnd, lpszDirectoryName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melDeleteDirectory
	//	<機能>				ディ?クト?を削?
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszDirectoryName	ディ?クト?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melDeleteDirectory(IntPtr hWnd, string lpszDirectoryName)
	{
		uint lStatus;
		lStatus = Import_melDeleteDirectory(hWnd, lpszDirectoryName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melDeleteFile
	//	<機能>				ファイ?を削?
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszFileName		ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melDeleteFile(IntPtr hWnd, string lpszFileName)
	{
		uint lStatus;
		lStatus = Import_melDeleteFile(hWnd, lpszFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melExecCopyFile
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを実行
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lCopyFileID			コピーID(melStartCopyFileの戻り値で取得した値)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melExecCopyFile(IntPtr hWnd, int lCopyFileID)
	{
		uint lStatus;
		lStatus = Import_melExecCopyFile(hWnd, lCopyFileID);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetDiskFree
	//	<機能>				ド?イブまたはディ?クト?の空き容量を取得
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszDirectoryName	ディ?クト?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetDiskFree(IntPtr hWnd, string lpszDirectoryName)
	{
		uint lStatus;
		lStatus = Import_melGetDiskFree(hWnd, lpszDirectoryName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetDriveList
	//	<機能>				実?されているNCをド?イブ?ストとして取得
	//					[引?]
	//						IntPtr			hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						StringBuilder	lpszDriveList	ディ?クト?名
	//						int				lBuffSize		ド?イブ?スト格納エ?アのサイズ(バイト)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetDriveList(IntPtr hWnd, StringBuilder lpszDriveList, int lBuffSize)
	{
		uint lStatus;

		lStatus = Import_melGetDriveList(hWnd, lpszDriveList, lBuffSize);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melOpenDirectory
	//	<機能>				指定したディ?クト?をオープ?
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszDirectoryName	ディ?クト?名
	//						int			lFileType			melReadDirectoryで読み出すデータのタイプや形式を指定
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melOpenDirectory(IntPtr hWnd, string lpszDirectoryName, int lFileType)
	{
		uint lStatus;
		lStatus = Import_melOpenDirectory(hWnd, lpszDirectoryName, lFileType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melReadDirectory
	//	<機能>				ディ?クト?のファイ?情報を読み出し
	//					[引?]
	//						IntPtr			hWnd			自ウィ?ドウのウィ?ドウハ?ド?
	//						uint			lDirectoryId	情報を読み出すディ?クト?のID
	//														(melOpenDirectoryで得られたID)
	//						StringBuilder	lpszFileInfo	ファイ?情報格納エ?アへのポイ?タ
	//						int				lBuffSize		ファイ?情報格納エ?アのサイズ(バイト)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melReadDirectory(IntPtr hWnd, uint lDirectoryId, StringBuilder lpszFileInfo, int lBuffSize)
	{
		uint lStatus;
		lStatus = Import_melReadDirectory(hWnd, lDirectoryId, lpszFileInfo, lBuffSize);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melRenameFile
	//	<機能>				ファイ?名を更新
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszSrcFileName		?ファイ?名
	//						string		lpszDstFileName		新ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melRenameFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melRenameFile(hWnd, lpszSrcFileName, lpszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melStartCopyFile
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを開始
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszSrcFileName		コピー元ファイ?名
	//						string		lpszDstFileName		コピー先ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melStartCopyFile(IntPtr hWnd, string lpszSrcFileName, string lpszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melStartCopyFile(hWnd, lpszSrcFileName, lpszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melStartCopyFileW
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを開始(Unicode)
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpwszSrcFileName	コピー元ファイ?名(Unicode)
	//						string		lpwszDstFileName	コピー先ファイ?名(Unicode)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melStartCopyFileW(IntPtr hWnd, string lpwszSrcFileName, string lpwszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melStartCopyFileW(hWnd, lpwszSrcFileName, lpwszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melStartCopyFileEx
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを開始
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpszSrcFileName		コピー元ファイ?名
	//						string		lpszHeaderFileName	コピー元・ヘッダファイ?名
	//						string		lpszFooterFileName	コピー元・フッタファイ?名
	//						string		lpszDstFileName		コピー先ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melStartCopyFileEx(IntPtr hWnd, string lpszSrcFileName, string lpszHeaderFileName, string lpszFooterFileName, string lpszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melStartCopyFileEx(hWnd, lpszSrcFileName, lpszHeaderFileName, lpszFooterFileName, lpszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melStartCopyFileExW
	//	<機能>				ファイ?のバックグ?ウ?ド・コピーを開始(Unicode)
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						string		lpwszSrcFileName	コピー元ファイ?名(Unicode)
	//						string		lpwszHeaderFileName コピー元・ヘッダファイ?名(Unicode)
	//						string		lpwszFooterFileName コピー元・フッタファイ?名(Unicode)
	//						string		lpwszDstFileName	コピー先ファイ?名(Unicode)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melStartCopyFileExW(IntPtr hWnd, string lpwszSrcFileName, string lpwszHeaderFileName, string lpwszFooterFileName, string lpwszDstFileName)
	{
		uint lStatus;
		lStatus = Import_melStartCopyFileExW(hWnd, lpwszSrcFileName, lpwszHeaderFileName, lpwszFooterFileName, lpwszDstFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSCloseDirectory
	//	<機能>				ディ?クト?をク?ーズ
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ク?ーズするディ?クト?のディ?クト?ディスク?プタ
	//														(melFSOpenDirectoryで得られたディ?クト?ディスク?プタ)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSCloseDirectory(IntPtr hWnd, int lAddress, int lFd)
	{
		uint lStatus;
		lStatus = Import_melFSCloseDirectory(hWnd, lAddress, lFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSCloseFile
	//	<機能>				ファイ?をク?ーズ
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ク?ーズするファイ?のファイ?ディスク?プタ
	//														(melFSOpenFileで得られたファイ?ディスク?プタ)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSCloseFile(IntPtr hWnd, int lAddress, int lFd)
	{
		uint lStatus;
		lStatus = Import_melFSCloseFile(hWnd, lAddress, lFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSCreateFile
	//	<機能>				ファイ?を作成
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						string		lpszFileName		ファイ?
	//						int			lFlag				オープ?アクセスタイプ
	//						IntPtr		lpFd				ファイ?ディスク?プタ格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSCreateFile(IntPtr hWnd, int lAddress, string lpszFileName, int lFlag, IntPtr lpFd)
	{
		uint lStatus;
		lStatus = Import_melFSCreateFile(hWnd, lAddress, lpszFileName, lFlag, lpFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSFstatFile
	//	<機能>				ファイ?情報を取得
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ファイ?ディスク?プタ
	//														(melFSOpenFileで取得したファイ?ディスク?プタを指定します)
	//						IntPtr		lpStat				ファイ?情報格納エ?ア(構造体FS_STAT)へのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSFstatFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpStat)
	{
		uint lStatus;
		lStatus = Import_melFSFstatFile(hWnd, lAddress, lFd, lpStat);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSIoctlFile
	//	<機能>				各デバイスのファイ?入出力情報を実行
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ファイ?ディスク?プタ
	//						int			lCommand			コマ?ド
	//						IntPtr		lpCtrlData			入出力データ領域へのポイ?タ
	//						int			lDataType			データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSIoctlFile(IntPtr hWnd, int lAddress, int lFd, int lCommand, IntPtr lpCtrlData, int lDataType)
	{
		uint lStatus;
		lStatus = Import_melFSIoctlFile(hWnd, lAddress, lFd, lCommand, lpCtrlData, lDataType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSLseekFile
	//	<機能>				ファイ?のシークポイ?タを移動
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ファイ?ディスク?プタ
	//														(melFSOpenFileで取得したファイ?ディスク?プタを指定します)
	//						int			lOffset				オフセット値
	//						int			lWhence				移動?ード
	//						IntPtr		lpResultOffset		シーク?果(ファイ?の先頭からのバイト?)格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSLseekFile(IntPtr hWnd, int lAddress, int lFd, int lOffset, int lWhence, IntPtr lpResultOffset)
	{
		uint lStatus;
		lStatus = Import_melFSLseekFile(hWnd, lAddress, lFd, lOffset, lWhence, lpResultOffset);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSOpenDirectory
	//	<機能>				ディ?クト?をオープ?
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						string		lpszDirName			ディ?クト?名
	//						IntPtr		lpFd				ディ?クト?ディスク?プタ格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSOpenDirectory(IntPtr hWnd, int lAddress, string lpszDirName, IntPtr lpFd)
	{
		uint lStatus;
		lStatus = Import_melFSOpenDirectory(hWnd, lAddress, lpszDirName, lpFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSOpenFile
	//	<機能>				ファイ?をオープ?
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						string		lpszFileName		ファイ?名
	//						int			lFlag				オープ?アクセスタイプ
	//						int			lMode				0に固定(未使用)
	//						IntPtr		lpFd				ファイ?ディスク?プタ格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSOpenFile(IntPtr hWnd, int lAddress, string lpszFileName, int lFlag, int lMode, IntPtr lpFd)
	{
		uint lStatus;
		lStatus = Import_melFSOpenFile(hWnd, lAddress, lpszFileName, lFlag, lMode, lpFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSReadDirectory
	//	<機能>				ディ?クト?情報を取得
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ディ?クト?ディスク?プタ
	//						IntPtr		pFSInfo				ディ?クト?情報を格納するエ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSReadDirectory(IntPtr hWnd, int lAddress, int lFd, IntPtr pFSInfo)
	{
		uint lStatus;
		lStatus = Import_melFSReadDirectory(hWnd, lAddress, lFd, pFSInfo);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSReadFile
	//	<機能>				ファイ?からデータを読み出し
	//					[引?]
	//						IntPtr		hWnd				自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress			アド?ス
	//						int			lFd					ディ?クト?ディスク?プタ
	//														(melFsOpenFileで取得したファイ?ディスク?プタを指定します)
	//						IntPtr		lpReadData			ファイ?データを格納するエ?アへのポイ?タ
	//						int			lReadType			データタイプ
	//						IntPtr		lpReadNos			?ードキ??クタ?を格納するエ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSReadFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpReadData, int lReadType, IntPtr lpReadNos)
	{
		uint lStatus;
		lStatus = Import_melFSReadFile(hWnd, lAddress, lFd, lpReadData, lReadType, lpReadNos);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSRenameFile
	//	<機能>				ファイ?名の変更
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						string		lpszOldFileName				?ファイ?名
	//						string		lpszNewFileName				新ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSRenameFile(IntPtr hWnd, int lAddress, string lpszOldFileName, string lpszNewFileName)
	{
		uint lStatus;
		lStatus = Import_melFSRenameFile(hWnd, lAddress, lpszOldFileName, lpszNewFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSRemoveFile
	//	<機能>				ファイ?の削?
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						string		lpszFileName				ファイ?名
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSRemoveFile(IntPtr hWnd, int lAddress, string lpszFileName)
	{
		uint lStatus;
		lStatus = Import_melFSRemoveFile(hWnd, lAddress, lpszFileName);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSRewindDirectory
	//	<機能>				ディ?クト?情報読み出し位置を先頭に戻す
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lFd							ディ?クト?ディスク?プタ
	//																(melFSOpenDirectoryで取得したディ?クト?ディスク?プタを指定します)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSRewindDirectory(IntPtr hWnd, int lAddress, int lFd)
	{
		uint lStatus;
		lStatus = Import_melFSRewindDirectory(hWnd, lAddress, lFd);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSStatFile
	//	<機能>				ファイ?情報を取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						string		lpszFileName				ファイ?名
	//						IntPtr		lpStat						ファイ?情報格納エ?ア(構造体FS_STAT)へのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSStatFile(IntPtr hWnd, int lAddress, string lpszFileName, IntPtr lpStat)
	{
		uint lStatus;
		lStatus = Import_melFSStatFile(hWnd, lAddress, lpszFileName, lpStat);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melFSWriteFile
	//	<機能>				ファイ?の??み
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lFd							ファイ?ディスク?プタ
	//						IntPtr		lpWriteData					ファイ?データを格納しているエ?アへのポイ?タ
	//						IntPtr		lpWriteNos					?イトキ??クタ?格納エ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melFSWriteFile(IntPtr hWnd, int lAddress, int lFd, IntPtr lpWriteData, IntPtr lpWriteNos)
	{
		uint lStatus;
		lStatus = Import_melFSWriteFile(hWnd, lAddress, lFd, lpWriteData, lpWriteNos);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCancelModal
	//	<機能>				データ?速取得・設定の登録を解?
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lModalId					登録解?するデータのID(melRegisterGetModalで得たID)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCancelModal(IntPtr hWnd, int lAddress, int lModalId)
	{
		uint lStatus;
		lStatus = Import_melCancelModal(hWnd, lAddress, lModalId);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCancelLumpModal
	//	<機能>				複?のデータ?速取得・設定登録を一度に解?
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lCancelModalNos				データ?速取得・設定の登録解?個?
	//						IntPtr		lpdwModalIdBuff				登録解?するデータのIDが格納されているエ?アへのポイ?タ
	//						IntPtr		lpdwCancelIdBuff			登録解?した?果を格納するエ?アへのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCancelLumpModal(IntPtr hWnd, int lAddress, int lCancelModalNos, IntPtr lpdwModalIdBuff, IntPtr lpdwCancelIdBuff)
	{
		uint lStatus;
		lStatus = Import_melCancelLumpModal(hWnd, lAddress, lCancelModalNos, lpdwModalIdBuff, lpdwCancelIdBuff);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetData
	//	<機能>				データの取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectionNum				小区分番?
	//						int			lAxisFlag					軸の指定(データによっては必要)
	//						IntPtr		lpGetData					データを格納するエ?アへのポイ?タ
	//						int			lGetType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpGetData, int lGetType)
	{
		uint lStatus;
		lStatus = Import_melGetData(hWnd, lAddress, lSectionNum, lSubSectionNum, lAxisFlag, lpGetData, lGetType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetLumpData
	//	<機能>				連続したデータの一?取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectTop					小区分番?の先頭
	//						int			lGetNos						取得する連続データの個?
	//						IntPtr		lpGetData					データを格納するエ?アへのポイ?タ
	//						int			lGetType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetLumpData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectTop, int lGetNos, IntPtr lpGetData, int lGetType)
	{
		uint lStatus;
		lStatus = Import_melGetLumpData(hWnd, lAddress, lSectionNum, lSubSectTop, lGetNos, lpGetData, lGetType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melIsReadCacheEnable
	//	<機能>				データ?ードキ?ッシ?の状態を取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melIsReadCacheEnable(IntPtr hWnd, int lAddress)
	{
		uint lStatus;
		lStatus = Import_melIsReadCacheEnable(hWnd, lAddress);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melReadCacheEnable
	//	<機能>				データ?ードキ?ッシ?の有効/無効を切り替え
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						bool		bEnable						状態
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melReadCacheEnable(IntPtr hWnd, int lAddress, bool bEnable)
	{
		uint lStatus;
		lStatus = Import_melReadCacheEnable(hWnd, lAddress, bEnable);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melReadModal
	//	<機能>				データの?速取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lModalId					取得するデータのID(melRegisterGetModalで得たもの)
	//						IntPtr		lpReadData					データを格納するエ?アへのポイ?タ
	//						int			lReadType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melReadModal(IntPtr hWnd, int lAddress, int lModalId, IntPtr lpReadData, int lReadType)
	{
		uint lStatus;
		lStatus = Import_melReadModal(hWnd, lAddress, lModalId, lpReadData, lReadType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melRegisterLumpModal
	//	<機能>				複?のデータ?速取得の登録
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lRegistModalNos				データ?速取得・設定を行うデータの登録個?
	//						IntPtr		lpModalDataBuff				登録するデータエ?アへのポイ?タ
	//						IntPtr		lpdwModalIdBuff				登録?果
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melRegisterLumpModal(IntPtr hWnd, int lAddress, int lRegistModalNos, IntPtr lpModalDataBuff, IntPtr lpdwModalIdBuff)
	{
		uint lStatus;
		lStatus = Import_melRegisterLumpModal(hWnd, lAddress, lRegistModalNos, lpModalDataBuff, lpdwModalIdBuff);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melRegisterGetModal
	//	<機能>				複?のデータ?速取得の登録
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectionNum				小区分番?
	//						int			lAxisFlag					軸の指定
	//						int			lDataType					取得データタイプ
	//						int			lPriority					優先
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melRegisterGetModal(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, int lDataType, int lPriority)
	{
		uint lStatus;
		lStatus = Import_melRegisterGetModal(hWnd, lAddress, lSectionNum, lSubSectionNum, lAxisFlag, lDataType, lPriority);
		return (lStatus);
	}


	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSetData
	//	<機能>				データの設定
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectionNum				小区分番?
	//						int			lAxisFlag					軸の指定
	//						IntPtr		lpSetData					データエ?アへのポイ?タ
	//						int			lSetType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpSetData, int lSetType)
	{
		uint lStatus;
		lStatus = Import_melSetData(hWnd, lAddress, lSectionNum, lSubSectionNum, lAxisFlag, lpSetData, lSetType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSafetySetData
	//	<機能>				安全パ??ータデータの設定
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectionNum				小区分番?
	//						int			lAxisFlag					軸の指定
	//						IntPtr		lpSetData					データエ?アへのポイ?タ
	//						int			lSetType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSafetySetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpSetData, int lSetType)
	{
		uint lStatus;
		lStatus = Import_melSafetySetData(hWnd, lAddress, lSectionNum, lSubSectionNum, lAxisFlag, lpSetData, lSetType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSafetyGetData
	//	<機能>				安全パ??ータデータの取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lSectionNum					大区分番?
	//						int			lSubSectionNum				小区分番?
	//						int			lAxisFlag					軸の指定
	//						IntPtr		lpGetData					データエ?アへのポイ?タ
	//						int			lGetType					データタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSafetyGetData(IntPtr hWnd, int lAddress, int lSectionNum, int lSubSectionNum, int lAxisFlag, IntPtr lpGetData, int lGetType)
	{
		uint lStatus;
		lStatus = Import_melSafetyGetData(hWnd, lAddress, lSectionNum, lSubSectionNum, lAxisFlag, lpGetData, lGetType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melActivatePLC
	//	<機能>				PLCプ?グ??の起動、停止
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lActivePLC					PLC動作?ード
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melActivatePLC(IntPtr hWnd, int lAddress, int lActivePLC)
	{
		uint lStatus;
		lStatus = Import_melActivatePLC(hWnd, lAddress, lActivePLC);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetCurrentAlarmMsg
	//	<機能>				現在発生しているア?ー??ッセージを取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lMsgNos						取得する?ッセージ?
	//						IntPtr		lpAlarmMsg					?ッセージを格納するエ?アへのポイ?タ
	//						int			lReadType					lpAlarmMsgのデータタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetCurrentAlarmMsg(IntPtr hWnd, int lAddress, int lMsgNos, int lAlarmType, IntPtr lpAlarmMsg, int lReadType)
	{
		uint lStatus;
		lStatus = Import_melGetCurrentAlarmMsg(hWnd, lAddress, lMsgNos, lAlarmType, lpAlarmMsg, lReadType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetCurrentAlarmMsgEx
	//	<機能>				現在発生しているア?ー??ッセージを取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lMsgNos						取得する?ッセージ?
	//						int			lAlarmType					取得するア?ー?の種類
	//						IntPtr		lpAlarmMsg					?ッセージを格納するエ?アへのポイ?タ
	//						int			lReadType					lpAlarmMsgのデータタイプ
	//						int			lExtInfo					拡張情報(0を設定)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetCurrentAlarmMsgEx(IntPtr hWnd, int lAddress, int lMsgNos, int lAlarmType, IntPtr lpAlarmMsg, int lReadType, int lExtInfo)
	{
		uint lStatus;
		lStatus = Import_melGetCurrentAlarmMsgEx(hWnd, lAddress, lMsgNos, lAlarmType, lpAlarmMsg, lReadType, lExtInfo);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetCurrentPrgBlock
	//	<機能>				現在実行されているプ?グ??を取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lPrgBlockNos				取得するブ?ック?
	//						IntPtr		lpPrgBlock					取得するプ?グ??を格納するエ?アへのポイ?タ
	//						int			lReadType					lpPrgBlockのデータタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetCurrentPrgBlock(IntPtr hWnd, int lAddress, int lPrgBlockNos, IntPtr lpPrgBlock, int lReadType)
	{
		uint lStatus;
		lStatus = Import_melGetCurrentPrgBlock(hWnd, lAddress, lPrgBlockNos, lpPrgBlock, lReadType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSelectExecPrg
	//	<機能>				運転するプ?グ??をサーチ
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lpSelectPrg					運転サーチするプ?グ??ファイ?名
	//						IntPtr		lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				サーチするシーケ?ス番?
	//						int			lBlockNum					サーチするブ?ック番?
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSelectExecPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum)
	{
		uint lStatus;
		lStatus = Import_melSelectExecPrg(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSelectExecPrgEx
	//	<機能>				運転するプ?グ??をサーチ
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lpSelectPrg					運転サーチするプ?グ??ファイ?名
	//						IntPtr		lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				サーチするシーケ?ス番?
	//						int			lBlockNum					サーチするブ?ック番?
	//						int			lAppearanceNumber			未使用(必ず0を指定してください)
	//						int			lSelectType					未使用(必ず0を指定してください)
	//						int			lParam						未使用(必ず0を指定してください)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSelectExecPrgEx(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber, int lSelectType, int lParam)
	{
		uint lStatus;
		lStatus = Import_melSelectExecPrgEx(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum, lAppearanceNumber, lSelectType, lParam);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSelectRestartPrg
	//	<機能>				再開するプ?グ??をサーチ
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpSelectPrg					再開サーチするプ?グ??ファイ?名
	//						int			lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				シーケ?ス番?
	//						int			lBlockNum					ブ?ック番?
	//						int			lAppearanceNumber			繰り返し回?
	//						int			lSelectType					サーチタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSelectRestartPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber, int lSelectType)
	{
		uint lStatus;
		lStatus = Import_melSelectRestartPrg(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum, lAppearanceNumber, lSelectType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melEntryCollationPrg
	//	<機能>				照?停止するプ?グ??を選択
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpSelectPrg					照?停止サーチするプ?グ??ファイ?名
	//						int			lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				サーチするシーケ?ス番?
	//						int			lBlockNum					サーチするブ?ック番?
	//						int			lAppearanceNumber			繰り返し回?
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melEntryCollationPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber)
	{
		uint lStatus;
		lStatus = Import_melEntryCollationPrg(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum, lAppearanceNumber);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSelectCheckPrg
	//	<機能>				グ?フィックチェック・加工?間算出するプ?グ??を選択
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpSelectPrg					チェックサーチするプ?グ??ファイ?名
	//						int			lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				サーチするシーケ?ス番?
	//						int			lBlockNum					サーチするブ?ック番?
	//						int			lReserve					未使用です。(常に0を設定)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSelectCheckPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lReserve)
	{
		uint lStatus;
		lStatus = Import_melSelectCheckPrg(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum, lReserve);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melEntryBottomCheckPrg
	//	<機能>				グ?フィックチェック・加工?間算出するプ?グ??の終了位置を設定
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpSelectPrg					チェック・加工?間算出の終了位置となるプ?グ??ファイ?名
	//						int			lDataType					lSelectPrgのデータタイプ
	//						int			lSequenceNum				終了位置のシーケ?ス番?
	//						int			lBlockNum					終了位置のブ?ック番?
	//						int			lAppearanceNumber			終了位置の繰り返し回?
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melEntryBottomCheckPrg(IntPtr hWnd, int lAddress, IntPtr lpSelectPrg, int lDataType, int lSequenceNum, int lBlockNum, int lAppearanceNumber)
	{
		uint lStatus;
		lStatus = Import_melEntryBottomCheckPrg(hWnd, lAddress, lpSelectPrg, lDataType, lSequenceNum, lBlockNum, lAppearanceNumber);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melResetCheckPrg
	//	<機能>				グ?フィックチェック・加工?間算出の実行状態を解?
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melResetCheckPrg(IntPtr hWnd, int lAddress)
	{
		uint lStatus;
		lStatus = Import_melResetCheckPrg(hWnd, lAddress);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melExecCheckPrg
	//	<機能>				グ?フィックチェック・加工?間算出するプ?グ??を1ブ?ック実行
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lCntrlFlag					制御フ?グ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melExecCheckPrg(IntPtr hWnd, int lAddress, int lCntrlFlag)
	{
		uint lStatus;
		lStatus = Import_melExecCheckPrg(hWnd, lAddress, lCntrlFlag);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetDrawData
	//	<機能>				グ?フィックチェック描画データを取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpCheckDraw					チェック描画データを格納するエ?ア
	//						int			lDataType					lpCheckDrawのデータタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetDrawData(IntPtr hWnd, int lAddress, IntPtr lpCheckDraw, int lDataType)
	{
		uint lStatus;
		lStatus = Import_melGetDrawData(hWnd, lAddress, lpCheckDraw, lDataType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melOpenBuffEdit
	//	<機能>				バッファ修正?ードを開始
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melOpenBuffEdit(IntPtr hWnd, int lAddress)
	{
		uint lStatus;
		lStatus = Import_melOpenBuffEdit(hWnd, lAddress);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetBuffEditPrgBlock
	//	<機能>				バッファ修正対象となる加工プ?グ??を取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						uint		dwBuffEditId				バッファ修正ID
	//						int			lPrgBlockNos				取得するブ?ック?(バッファ修正対象となるブ?ック?)
	//						IntPtr		lpPrgBlock					取得するバッファ修正プ?グ??を格納するエ?アのポイ?タ
	//						int			lReadType					lpPrgBlockのデータタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetBuffEditPrgBlock(IntPtr hWnd, int lAddress, uint dwBuffEditId, int lPrgBlockNos, IntPtr lpPrgBlock, int lReadType)
	{
		uint lStatus;
		lStatus = Import_melGetBuffEditPrgBlock(hWnd, lAddress, dwBuffEditId, lPrgBlockNos, lpPrgBlock, lReadType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSetBuffEditPrgBlock
	//	<機能>				バッファ修正プ?グ??の?き?み
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						uint		dwBuffEditId				バッファ修正ID
	//						IntPtr		lpPrgBlock					バッファ修正プ?グ??を格納するエ?アのポイ?タ
	//						int			lWriteType					lpPrgBlockのデータタイプ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSetBuffEditPrgBlock(IntPtr hWnd, int lAddress, uint dwBuffEditId, IntPtr lpPrgBlock, int lWriteType)
	{
		uint lStatus;
		lStatus = Import_melSetBuffEditPrgBlock(hWnd, lAddress, dwBuffEditId, lpPrgBlock, lWriteType);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melCloseBuffEdit
	//	<機能>				バッファ修正?ードを終了
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						uint		dwBuffEditId				バッファ修正ID
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melCloseBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId)
	{
		uint lStatus;
		lStatus = Import_melCloseBuffEdit(hWnd, lAddress, dwBuffEditId);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melStateOfBuffEdit
	//	<機能>				バッファ修正プ?グ??の?き?み状況を取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						uint		dwBuffEditId				バッファ修正ID
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melStateOfBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId)
	{
		uint lStatus;
		lStatus = Import_melStateOfBuffEdit(hWnd, lAddress, dwBuffEditId);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSizeOfBuffEdit
	//	<機能>				バッファ修正プ?グ??の?き?み可能なデータサイズを取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						uint		dwBuffEditId				バッファ修正ID
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSizeOfBuffEdit(IntPtr hWnd, int lAddress, uint dwBuffEditId)
	{
		uint lStatus;
		lStatus = Import_melSizeOfBuffEdit(hWnd, lAddress, dwBuffEditId);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetExecPrgCallStack
	//	<機能>				実行?プ?グ???ストの取得
	//					[引?]
	//						IntPtr			hWnd					自ウィ?ドウのウィ?ドウハ?ド?
	//						int				lAddress				アド?ス
	//						int				lOption					オプシ??
	//						StringBuilder	lpszPrgList				?スト格納文?列バッファのポイ?タ
	//						int				lBuffsize				?スト格納バッファのサイズ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetExecPrgCallStack(IntPtr hWnd, int lAddress, int lOption, StringBuilder lpszPrgList, int lBuffsize)
	{
		uint lStatus;
		lStatus = Import_melGetExecPrgCallStack(hWnd, lAddress, lOption, lpszPrgList, lBuffsize);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSimuCtl
	//	<機能>				シミ??ーシ??の動作環境の設定
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lFunction					ファ?クシ??コード
	//						IntPtr		lpData						ファ?クシ??別データ領域へのポイ?タ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSimuCtl(IntPtr hWnd, int lAddress, int lFunction, IntPtr lpData)
	{
		uint lStatus;
		lStatus = Import_melSimuCtl(hWnd, lAddress, lFunction, lpData);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSetSimuMode
	//	<機能>				シミ??ーシ??の開始?に、
	//						PC側アプ?ケーシ??からNC側に対してシミ??ーシ??の開始を通知
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						int			lReadSystemNum				シミ??ーシ??データ取得系?、?ードの指定
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSetSimuMode(IntPtr hWnd, int lAddress, int lReadSystemNum)
	{
		uint lStatus;
		lStatus = Import_melSetSimuMode(hWnd, lAddress, lReadSystemNum);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melRead3DSimuData
	//	<機能>				NCシステ?からシミ??ーシ??データを取得します
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lSimuID						シミ??ーシ??ID(melSetSimuModeで取得したID)
	//						int			lBufferCount				一回の呼び出しで取得するシミ??ーシ??データの最大個?
	//						IntPtr		lpReadData					シミ??ーシ??データを格納する領域(SIMU_BUF_EXT構造体)のポイ?タ
	//						IntPtr		lDataSize					lpReadDataで確保した領域サイズ
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melRead3DSimuData(IntPtr hWnd, int lSimuID, int lBufferCount, IntPtr lpReadData, int lDataSize)
	{
		uint lStatus;
		lStatus = Import_melRead3DSimuData(hWnd, lSimuID, lBufferCount, lpReadData, lDataSize);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melResetSimuMode
	//	<機能>				シミ??ーシ??の終了?に、
	//						PC側アプ?ケーシ??からNCシステ?に対してシミ??ーシ??の終了を通知
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lSimuID						シミ??ーシ??ID(melSetSimuModeで取得したID)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melResetSimuMode(IntPtr hWnd, int lSimuID)
	{
		uint lStatus;
		lStatus = Import_melResetSimuMode(hWnd, lSimuID);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melSelectProcessTime
	//	<機能>				加工予測?間を算出するプ?グ??を設定
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						string		lpszCheckPrgName			加工予測?間を算出するプ?グ??ファイ?名(フ?パス)
	//						int			lReserve					未使用(常に0を設定)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melSelectProcessTime(IntPtr hWnd, int lAddress, string lpszCheckPrgName, int lReserve)
	{
		uint lStatus;
		lStatus = Import_melSelectProcessTime(hWnd, lAddress, lpszCheckPrgName, lReserve);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melGetProcessTime
	//	<機能>				加工予測?間の算出状況と加工予測?間の取得
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//						IntPtr		lpGetStatus					加工予測?間の動作状況を格納するエ?アへのポイ?タ
	//						IntPtr		lpGetProcessTime			加工予測?間を格納するエ?アへのポイ?タ
	//						int			lGetType					データタイプ
	//						int			lReserve					未使用(常に0を設定)
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melGetProcessTime(IntPtr hWnd, int lAddress, IntPtr lpGetStatus, IntPtr lpGetProcessTime, int lGetType, int lReserve)
	{
		uint lStatus;
		lStatus = Import_melGetProcessTime(hWnd, lAddress, lpGetStatus, lpGetProcessTime, lGetType, lReserve);
		return (lStatus);
	}

	//************************************************************************************* MELCO ******
	//																						(Nx)
	//	<?ソッド名>		melResetProcessTime
	//	<機能>				加工予測?間の算出を終了
	//					[引?]
	//						IntPtr		hWnd						自ウィ?ドウのウィ?ドウハ?ド?
	//						int			lAddress					アド?ス
	//					[戻り値]
	//						uint
	//
	//**************************************************************************************************
	public static uint melResetProcessTime(IntPtr hWnd, int lAddress)
	{
		uint lStatus;
		lStatus = Import_melResetProcessTime(hWnd, lAddress);
		return (lStatus);
	}

}
