//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	wrapper_ncapi32.cs
//	<�@�\>			�J�X�^?APIDLL�v?�b�g�t�H�[?�Ăяo��
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;
using System.Text;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		ncapi_wrapper
//	<�@�\>			�J�X�^?APIDLL(ncapi32.dll)�̃v?�b�g�t�H�[?�Ăяo���N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

public class ncapi_wrapper
{
	//*****************************************
	// ncapi32.dll�̃C?�|�[�g
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
	//	<?�\�b�h��>		melIoctl
	//	<�@�\>				���ݒ�
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress		�A�h?�X
	//						int			lFunction		�t�@?�N�V??�R�[�h
	//						IntPtr		lpData			�f�[�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSetLocale
	//	<�@�\>				?�P�[?�̐ݒ�
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						uint		dwLocale		?�P�[?
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetBackLight
	//	<�@�\>				�o�b�N?�C�gON/OFF��Ԃ̎擾
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						IntPtr		lpdwLight		�o�b�N?�C�gON/OFF�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSetBackLight
	//	<�@�\>				�o�b�N?�C�gON/OFF��Ԃ̎擾
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						uint		dwLight			�o�b�N?�C�g
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCancelCopyFile
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[��?�f
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lCopyFileID		�R�s�[ID(melStartCopyFile�̖߂�l�Ŏ擾�����l)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCloseDirectory
	//	<�@�\>				melOpenDirectory�ŃI�[�v?�����f�B?�N�g?���N?�[�Y
	//					[��?]
	//						IntPtr		hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						uint		lDirectoryId	�N?�[�Y����f�B?�N�g?��ID
	//													(melOpenDirectory�œ���ꂽID)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCopyFile
	//	<�@�\>				�t�@�C?���R�s�[
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszSrcFileName		�R�s�[���t�@�C?��
	//						string		lpszDstFileName		�R�s�[��t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCreateDirectory
	//	<�@�\>				�f�B?�N�g?���쐬
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszDirectoryName	�f�B?�N�g?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melDeleteDirectory
	//	<�@�\>				�f�B?�N�g?����?
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszDirectoryName	�f�B?�N�g?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melDeleteFile
	//	<�@�\>				�t�@�C?����?
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszFileName		�t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melExecCopyFile
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[�����s
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lCopyFileID			�R�s�[ID(melStartCopyFile�̖߂�l�Ŏ擾�����l)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetDiskFree
	//	<�@�\>				�h?�C�u�܂��̓f�B?�N�g?�̋󂫗e�ʂ��擾
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszDirectoryName	�f�B?�N�g?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetDriveList
	//	<�@�\>				��?����Ă���NC���h?�C�u?�X�g�Ƃ��Ď擾
	//					[��?]
	//						IntPtr			hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						StringBuilder	lpszDriveList	�f�B?�N�g?��
	//						int				lBuffSize		�h?�C�u?�X�g�i�[�G?�A�̃T�C�Y(�o�C�g)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melOpenDirectory
	//	<�@�\>				�w�肵���f�B?�N�g?���I�[�v?
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszDirectoryName	�f�B?�N�g?��
	//						int			lFileType			melReadDirectory�œǂݏo���f�[�^�̃^�C�v��`�����w��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melReadDirectory
	//	<�@�\>				�f�B?�N�g?�̃t�@�C?����ǂݏo��
	//					[��?]
	//						IntPtr			hWnd			���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						uint			lDirectoryId	����ǂݏo���f�B?�N�g?��ID
	//														(melOpenDirectory�œ���ꂽID)
	//						StringBuilder	lpszFileInfo	�t�@�C?���i�[�G?�A�ւ̃|�C?�^
	//						int				lBuffSize		�t�@�C?���i�[�G?�A�̃T�C�Y(�o�C�g)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melRenameFile
	//	<�@�\>				�t�@�C?�����X�V
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszSrcFileName		?�t�@�C?��
	//						string		lpszDstFileName		�V�t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melStartCopyFile
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[���J�n
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszSrcFileName		�R�s�[���t�@�C?��
	//						string		lpszDstFileName		�R�s�[��t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melStartCopyFileW
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[���J�n(Unicode)
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpwszSrcFileName	�R�s�[���t�@�C?��(Unicode)
	//						string		lpwszDstFileName	�R�s�[��t�@�C?��(Unicode)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melStartCopyFileEx
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[���J�n
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpszSrcFileName		�R�s�[���t�@�C?��
	//						string		lpszHeaderFileName	�R�s�[���E�w�b�_�t�@�C?��
	//						string		lpszFooterFileName	�R�s�[���E�t�b�^�t�@�C?��
	//						string		lpszDstFileName		�R�s�[��t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melStartCopyFileExW
	//	<�@�\>				�t�@�C?�̃o�b�N�O?�E?�h�E�R�s�[���J�n(Unicode)
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						string		lpwszSrcFileName	�R�s�[���t�@�C?��(Unicode)
	//						string		lpwszHeaderFileName �R�s�[���E�w�b�_�t�@�C?��(Unicode)
	//						string		lpwszFooterFileName �R�s�[���E�t�b�^�t�@�C?��(Unicode)
	//						string		lpwszDstFileName	�R�s�[��t�@�C?��(Unicode)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSCloseDirectory
	//	<�@�\>				�f�B?�N�g?���N?�[�Y
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�N?�[�Y����f�B?�N�g?�̃f�B?�N�g?�f�B�X�N?�v�^
	//														(melFSOpenDirectory�œ���ꂽ�f�B?�N�g?�f�B�X�N?�v�^)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSCloseFile
	//	<�@�\>				�t�@�C?���N?�[�Y
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�N?�[�Y����t�@�C?�̃t�@�C?�f�B�X�N?�v�^
	//														(melFSOpenFile�œ���ꂽ�t�@�C?�f�B�X�N?�v�^)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSCreateFile
	//	<�@�\>				�t�@�C?���쐬
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						string		lpszFileName		�t�@�C?
	//						int			lFlag				�I�[�v?�A�N�Z�X�^�C�v
	//						IntPtr		lpFd				�t�@�C?�f�B�X�N?�v�^�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSFstatFile
	//	<�@�\>				�t�@�C?�����擾
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�t�@�C?�f�B�X�N?�v�^
	//														(melFSOpenFile�Ŏ擾�����t�@�C?�f�B�X�N?�v�^���w�肵�܂�)
	//						IntPtr		lpStat				�t�@�C?���i�[�G?�A(�\����FS_STAT)�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSIoctlFile
	//	<�@�\>				�e�f�o�C�X�̃t�@�C?���o�͏������s
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�t�@�C?�f�B�X�N?�v�^
	//						int			lCommand			�R�}?�h
	//						IntPtr		lpCtrlData			���o�̓f�[�^�̈�ւ̃|�C?�^
	//						int			lDataType			�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSLseekFile
	//	<�@�\>				�t�@�C?�̃V�[�N�|�C?�^���ړ�
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�t�@�C?�f�B�X�N?�v�^
	//														(melFSOpenFile�Ŏ擾�����t�@�C?�f�B�X�N?�v�^���w�肵�܂�)
	//						int			lOffset				�I�t�Z�b�g�l
	//						int			lWhence				�ړ�?�[�h
	//						IntPtr		lpResultOffset		�V�[�N?��(�t�@�C?�̐擪����̃o�C�g?)�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSOpenDirectory
	//	<�@�\>				�f�B?�N�g?���I�[�v?
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						string		lpszDirName			�f�B?�N�g?��
	//						IntPtr		lpFd				�f�B?�N�g?�f�B�X�N?�v�^�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSOpenFile
	//	<�@�\>				�t�@�C?���I�[�v?
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						string		lpszFileName		�t�@�C?��
	//						int			lFlag				�I�[�v?�A�N�Z�X�^�C�v
	//						int			lMode				0�ɌŒ�(���g�p)
	//						IntPtr		lpFd				�t�@�C?�f�B�X�N?�v�^�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSReadDirectory
	//	<�@�\>				�f�B?�N�g?�����擾
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�f�B?�N�g?�f�B�X�N?�v�^
	//						IntPtr		pFSInfo				�f�B?�N�g?�����i�[����G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSReadFile
	//	<�@�\>				�t�@�C?����f�[�^��ǂݏo��
	//					[��?]
	//						IntPtr		hWnd				���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress			�A�h?�X
	//						int			lFd					�f�B?�N�g?�f�B�X�N?�v�^
	//														(melFsOpenFile�Ŏ擾�����t�@�C?�f�B�X�N?�v�^���w�肵�܂�)
	//						IntPtr		lpReadData			�t�@�C?�f�[�^���i�[����G?�A�ւ̃|�C?�^
	//						int			lReadType			�f�[�^�^�C�v
	//						IntPtr		lpReadNos			?�[�h�L??�N�^?���i�[����G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSRenameFile
	//	<�@�\>				�t�@�C?���̕ύX
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						string		lpszOldFileName				?�t�@�C?��
	//						string		lpszNewFileName				�V�t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSRemoveFile
	//	<�@�\>				�t�@�C?�̍�?
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						string		lpszFileName				�t�@�C?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSRewindDirectory
	//	<�@�\>				�f�B?�N�g?���ǂݏo���ʒu��擪�ɖ߂�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lFd							�f�B?�N�g?�f�B�X�N?�v�^
	//																(melFSOpenDirectory�Ŏ擾�����f�B?�N�g?�f�B�X�N?�v�^���w�肵�܂�)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSStatFile
	//	<�@�\>				�t�@�C?�����擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						string		lpszFileName				�t�@�C?��
	//						IntPtr		lpStat						�t�@�C?���i�[�G?�A(�\����FS_STAT)�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melFSWriteFile
	//	<�@�\>				�t�@�C?��??��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lFd							�t�@�C?�f�B�X�N?�v�^
	//						IntPtr		lpWriteData					�t�@�C?�f�[�^���i�[���Ă���G?�A�ւ̃|�C?�^
	//						IntPtr		lpWriteNos					?�C�g�L??�N�^?�i�[�G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCancelModal
	//	<�@�\>				�f�[�^?���擾�E�ݒ�̓o�^����?
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lModalId					�o�^��?����f�[�^��ID(melRegisterGetModal�œ���ID)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCancelLumpModal
	//	<�@�\>				��?�̃f�[�^?���擾�E�ݒ�o�^����x�ɉ�?
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lCancelModalNos				�f�[�^?���擾�E�ݒ�̓o�^��?��?
	//						IntPtr		lpdwModalIdBuff				�o�^��?����f�[�^��ID���i�[����Ă���G?�A�ւ̃|�C?�^
	//						IntPtr		lpdwCancelIdBuff			�o�^��?����?�ʂ��i�[����G?�A�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetData
	//	<�@�\>				�f�[�^�̎擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectionNum				���敪��?
	//						int			lAxisFlag					���̎w��(�f�[�^�ɂ���Ă͕K�v)
	//						IntPtr		lpGetData					�f�[�^���i�[����G?�A�ւ̃|�C?�^
	//						int			lGetType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetLumpData
	//	<�@�\>				�A�������f�[�^�̈�?�擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectTop					���敪��?�̐擪
	//						int			lGetNos						�擾����A���f�[�^�̌�?
	//						IntPtr		lpGetData					�f�[�^���i�[����G?�A�ւ̃|�C?�^
	//						int			lGetType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melIsReadCacheEnable
	//	<�@�\>				�f�[�^?�[�h�L?�b�V?�̏�Ԃ��擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//					[�߂�l]
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
	//	<?�\�b�h��>		melReadCacheEnable
	//	<�@�\>				�f�[�^?�[�h�L?�b�V?�̗L��/������؂�ւ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						bool		bEnable						���
	//					[�߂�l]
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
	//	<?�\�b�h��>		melReadModal
	//	<�@�\>				�f�[�^��?���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lModalId					�擾����f�[�^��ID(melRegisterGetModal�œ�������)
	//						IntPtr		lpReadData					�f�[�^���i�[����G?�A�ւ̃|�C?�^
	//						int			lReadType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melRegisterLumpModal
	//	<�@�\>				��?�̃f�[�^?���擾�̓o�^
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lRegistModalNos				�f�[�^?���擾�E�ݒ���s���f�[�^�̓o�^��?
	//						IntPtr		lpModalDataBuff				�o�^����f�[�^�G?�A�ւ̃|�C?�^
	//						IntPtr		lpdwModalIdBuff				�o�^?��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melRegisterGetModal
	//	<�@�\>				��?�̃f�[�^?���擾�̓o�^
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectionNum				���敪��?
	//						int			lAxisFlag					���̎w��
	//						int			lDataType					�擾�f�[�^�^�C�v
	//						int			lPriority					�D��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSetData
	//	<�@�\>				�f�[�^�̐ݒ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectionNum				���敪��?
	//						int			lAxisFlag					���̎w��
	//						IntPtr		lpSetData					�f�[�^�G?�A�ւ̃|�C?�^
	//						int			lSetType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSafetySetData
	//	<�@�\>				���S�p??�[�^�f�[�^�̐ݒ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectionNum				���敪��?
	//						int			lAxisFlag					���̎w��
	//						IntPtr		lpSetData					�f�[�^�G?�A�ւ̃|�C?�^
	//						int			lSetType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSafetyGetData
	//	<�@�\>				���S�p??�[�^�f�[�^�̎擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lSectionNum					��敪��?
	//						int			lSubSectionNum				���敪��?
	//						int			lAxisFlag					���̎w��
	//						IntPtr		lpGetData					�f�[�^�G?�A�ւ̃|�C?�^
	//						int			lGetType					�f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melActivatePLC
	//	<�@�\>				PLC�v?�O??�̋N���A��~
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lActivePLC					PLC����?�[�h
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetCurrentAlarmMsg
	//	<�@�\>				���ݔ������Ă���A?�[??�b�Z�[�W���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lMsgNos						�擾����?�b�Z�[�W?
	//						IntPtr		lpAlarmMsg					?�b�Z�[�W���i�[����G?�A�ւ̃|�C?�^
	//						int			lReadType					lpAlarmMsg�̃f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetCurrentAlarmMsgEx
	//	<�@�\>				���ݔ������Ă���A?�[??�b�Z�[�W���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lMsgNos						�擾����?�b�Z�[�W?
	//						int			lAlarmType					�擾����A?�[?�̎��
	//						IntPtr		lpAlarmMsg					?�b�Z�[�W���i�[����G?�A�ւ̃|�C?�^
	//						int			lReadType					lpAlarmMsg�̃f�[�^�^�C�v
	//						int			lExtInfo					�g�����(0��ݒ�)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetCurrentPrgBlock
	//	<�@�\>				���ݎ��s����Ă���v?�O??���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lPrgBlockNos				�擾����u?�b�N?
	//						IntPtr		lpPrgBlock					�擾����v?�O??���i�[����G?�A�ւ̃|�C?�^
	//						int			lReadType					lpPrgBlock�̃f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSelectExecPrg
	//	<�@�\>				�^�]����v?�O??���T�[�`
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lpSelectPrg					�^�]�T�[�`����v?�O??�t�@�C?��
	//						IntPtr		lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�T�[�`����V�[�P?�X��?
	//						int			lBlockNum					�T�[�`����u?�b�N��?
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSelectExecPrgEx
	//	<�@�\>				�^�]����v?�O??���T�[�`
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lpSelectPrg					�^�]�T�[�`����v?�O??�t�@�C?��
	//						IntPtr		lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�T�[�`����V�[�P?�X��?
	//						int			lBlockNum					�T�[�`����u?�b�N��?
	//						int			lAppearanceNumber			���g�p(�K��0���w�肵�Ă�������)
	//						int			lSelectType					���g�p(�K��0���w�肵�Ă�������)
	//						int			lParam						���g�p(�K��0���w�肵�Ă�������)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSelectRestartPrg
	//	<�@�\>				�ĊJ����v?�O??���T�[�`
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpSelectPrg					�ĊJ�T�[�`����v?�O??�t�@�C?��
	//						int			lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�V�[�P?�X��?
	//						int			lBlockNum					�u?�b�N��?
	//						int			lAppearanceNumber			�J��Ԃ���?
	//						int			lSelectType					�T�[�`�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melEntryCollationPrg
	//	<�@�\>				��?��~����v?�O??��I��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpSelectPrg					��?��~�T�[�`����v?�O??�t�@�C?��
	//						int			lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�T�[�`����V�[�P?�X��?
	//						int			lBlockNum					�T�[�`����u?�b�N��?
	//						int			lAppearanceNumber			�J��Ԃ���?
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSelectCheckPrg
	//	<�@�\>				�O?�t�B�b�N�`�F�b�N�E���H?�ԎZ�o����v?�O??��I��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpSelectPrg					�`�F�b�N�T�[�`����v?�O??�t�@�C?��
	//						int			lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�T�[�`����V�[�P?�X��?
	//						int			lBlockNum					�T�[�`����u?�b�N��?
	//						int			lReserve					���g�p�ł��B(���0��ݒ�)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melEntryBottomCheckPrg
	//	<�@�\>				�O?�t�B�b�N�`�F�b�N�E���H?�ԎZ�o����v?�O??�̏I���ʒu��ݒ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpSelectPrg					�`�F�b�N�E���H?�ԎZ�o�̏I���ʒu�ƂȂ�v?�O??�t�@�C?��
	//						int			lDataType					lSelectPrg�̃f�[�^�^�C�v
	//						int			lSequenceNum				�I���ʒu�̃V�[�P?�X��?
	//						int			lBlockNum					�I���ʒu�̃u?�b�N��?
	//						int			lAppearanceNumber			�I���ʒu�̌J��Ԃ���?
	//					[�߂�l]
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
	//	<?�\�b�h��>		melResetCheckPrg
	//	<�@�\>				�O?�t�B�b�N�`�F�b�N�E���H?�ԎZ�o�̎��s��Ԃ���?
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//					[�߂�l]
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
	//	<?�\�b�h��>		melExecCheckPrg
	//	<�@�\>				�O?�t�B�b�N�`�F�b�N�E���H?�ԎZ�o����v?�O??��1�u?�b�N���s
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lCntrlFlag					����t?�O
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetDrawData
	//	<�@�\>				�O?�t�B�b�N�`�F�b�N�`��f�[�^���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpCheckDraw					�`�F�b�N�`��f�[�^���i�[����G?�A
	//						int			lDataType					lpCheckDraw�̃f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melOpenBuffEdit
	//	<�@�\>				�o�b�t�@�C��?�[�h���J�n
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetBuffEditPrgBlock
	//	<�@�\>				�o�b�t�@�C���ΏۂƂȂ���H�v?�O??���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						uint		dwBuffEditId				�o�b�t�@�C��ID
	//						int			lPrgBlockNos				�擾����u?�b�N?(�o�b�t�@�C���ΏۂƂȂ�u?�b�N?)
	//						IntPtr		lpPrgBlock					�擾����o�b�t�@�C���v?�O??���i�[����G?�A�̃|�C?�^
	//						int			lReadType					lpPrgBlock�̃f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSetBuffEditPrgBlock
	//	<�@�\>				�o�b�t�@�C���v?�O??��?��?��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						uint		dwBuffEditId				�o�b�t�@�C��ID
	//						IntPtr		lpPrgBlock					�o�b�t�@�C���v?�O??���i�[����G?�A�̃|�C?�^
	//						int			lWriteType					lpPrgBlock�̃f�[�^�^�C�v
	//					[�߂�l]
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
	//	<?�\�b�h��>		melCloseBuffEdit
	//	<�@�\>				�o�b�t�@�C��?�[�h���I��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						uint		dwBuffEditId				�o�b�t�@�C��ID
	//					[�߂�l]
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
	//	<?�\�b�h��>		melStateOfBuffEdit
	//	<�@�\>				�o�b�t�@�C���v?�O??��?��?�ݏ󋵂��擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						uint		dwBuffEditId				�o�b�t�@�C��ID
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSizeOfBuffEdit
	//	<�@�\>				�o�b�t�@�C���v?�O??��?��?�݉\�ȃf�[�^�T�C�Y���擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						uint		dwBuffEditId				�o�b�t�@�C��ID
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetExecPrgCallStack
	//	<�@�\>				���s?�v?�O???�X�g�̎擾
	//					[��?]
	//						IntPtr			hWnd					���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int				lAddress				�A�h?�X
	//						int				lOption					�I�v�V??
	//						StringBuilder	lpszPrgList				?�X�g�i�[��?��o�b�t�@�̃|�C?�^
	//						int				lBuffsize				?�X�g�i�[�o�b�t�@�̃T�C�Y
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSimuCtl
	//	<�@�\>				�V�~??�[�V??�̓�����̐ݒ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lFunction					�t�@?�N�V??�R�[�h
	//						IntPtr		lpData						�t�@?�N�V??�ʃf�[�^�̈�ւ̃|�C?�^
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSetSimuMode
	//	<�@�\>				�V�~??�[�V??�̊J�n?�ɁA
	//						PC���A�v?�P�[�V??����NC���ɑ΂��ăV�~??�[�V??�̊J�n��ʒm
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						int			lReadSystemNum				�V�~??�[�V??�f�[�^�擾�n?�A?�[�h�̎w��
	//					[�߂�l]
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
	//	<?�\�b�h��>		melRead3DSimuData
	//	<�@�\>				NC�V�X�e?����V�~??�[�V??�f�[�^���擾���܂�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lSimuID						�V�~??�[�V??ID(melSetSimuMode�Ŏ擾����ID)
	//						int			lBufferCount				���̌Ăяo���Ŏ擾����V�~??�[�V??�f�[�^�̍ő��?
	//						IntPtr		lpReadData					�V�~??�[�V??�f�[�^���i�[����̈�(SIMU_BUF_EXT�\����)�̃|�C?�^
	//						IntPtr		lDataSize					lpReadData�Ŋm�ۂ����̈�T�C�Y
	//					[�߂�l]
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
	//	<?�\�b�h��>		melResetSimuMode
	//	<�@�\>				�V�~??�[�V??�̏I��?�ɁA
	//						PC���A�v?�P�[�V??����NC�V�X�e?�ɑ΂��ăV�~??�[�V??�̏I����ʒm
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lSimuID						�V�~??�[�V??ID(melSetSimuMode�Ŏ擾����ID)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melSelectProcessTime
	//	<�@�\>				���H�\��?�Ԃ��Z�o����v?�O??��ݒ�
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						string		lpszCheckPrgName			���H�\��?�Ԃ��Z�o����v?�O??�t�@�C?��(�t?�p�X)
	//						int			lReserve					���g�p(���0��ݒ�)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melGetProcessTime
	//	<�@�\>				���H�\��?�Ԃ̎Z�o�󋵂Ɖ��H�\��?�Ԃ̎擾
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//						IntPtr		lpGetStatus					���H�\��?�Ԃ̓���󋵂��i�[����G?�A�ւ̃|�C?�^
	//						IntPtr		lpGetProcessTime			���H�\��?�Ԃ��i�[����G?�A�ւ̃|�C?�^
	//						int			lGetType					�f�[�^�^�C�v
	//						int			lReserve					���g�p(���0��ݒ�)
	//					[�߂�l]
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
	//	<?�\�b�h��>		melResetProcessTime
	//	<�@�\>				���H�\��?�Ԃ̎Z�o���I��
	//					[��?]
	//						IntPtr		hWnd						���E�B?�h�E�̃E�B?�h�E�n?�h?
	//						int			lAddress					�A�h?�X
	//					[�߂�l]
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
