//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	melncapi.cs
//	<�@�\>			�R�}?�h��`
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		melncapi
//	<�@�\>			�R�}?�h��`�N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melncapi
{
	// ----- NC API�Ŏg�p����}�N?	 -------------------
	// -- �A�h?�X�֘A --
	public static int ADR_SYSTEM(int n)									// �n?�i�O?�[�v��?�j�̎w��
	{
		return ((int)((n << 8) & 0x0000ff00));
	}

	public static int ADR_MACHINE(int n)								// �R?�g?�[?�̎w��
	{
		return ((int)((n << 24) & 0xff000000));
	}

	public const int ADR_FORCE_WRITE   = (((1) << 18) & 0x00040000);	// ����?��?��?�[�h�̎w��
	public const int ADR_BASE_SYSTEM   = (((0) << 16) & 0x00ff0000);	// ��{�n?�̎w��
	public const int ADR_CROSS_CURRENT = (((1) << 16) & 0x00ff0000);	// �N?�X�J??�g�n?�̎w��

	public static int ADR_GROUND(int n)									// �O??�h(FORE/BACK)�̎w��
	{
		return ((int)((n << 20 ) & 0x00f00000));
	}

	// ----- �e�R�}?�h�Ŏg�p����}�N?	 -------------------
	// -- System�֘A --
	// melIoctl
	public const int DEV_SET_RTIMEOUT				= 0x001;			// ?�[�h�^�C?�A�E�g�̐ݒ�
	public const int DEV_SET_WTIMEOUT				= 0x002;			// ?�C�g�^�C?�A�E�g�̐ݒ�
	public const int DEV_SET_COMMTIMEOUT			= 0x005;			// �ʐM�^�C?�A�E�g�l�ݒ�
	public const int DEV_GET_COMMTIMEOUT			= 0x006;			// �ʐM�^�C?�A�E�g�l�擾
	public const int DEV_SET_COMMCONFIRMTIMEOUT		= 0x008;			// NC�ڑ��m�F�̒ʐM�^�C?�A�E�g�l�̐ݒ�
	public const int DEV_GET_COMMCONFIRMTIMEOUT		= 0x009;			// NC�ڑ��m�F�̒ʐM�^�C?�A�E�g�l�̎擾
	public const int DEV_GET_COMMADDRESS			= 0xFEF;			// melcfg.ini��IP�A�h?�X�擾�A�h?�X�擾
	public const int DEV_SET_COMMADDRESS			= 0xFFF;			// �A�h?�X�ݒ�
	public const int DEV_SET_EXCLUSIVETIMEOUT		= 0x00F;			// �r������^�C?�A�E�g?�Ԑݒ�
	public const int DEV_GET_EXCLUSIVETIMEOUT		= 0x010;			// �r������^�C?�A�E�g?�Ԏ擾
	public const int DEV_SET_REMOTEMODE				= 0x103;			// ?�u?��?�[�h�̐ݒ�
	public const int DEV_GET_REMOTEMODE				= 0x104;			// ?�u?��?�[�h�̎擾
	public const int DEV_SET_CONNECTTIMEOUT			= 0x105;			// �ڑ��^�C?�A�E�g�l�̐ݒ�
	public const int DEV_GET_CONNECTTIMEOUT			= 0x106;			// �ڑ��^�C?�A�E�g�l�̎擾
	public const int DEV_SET_CACHEMAX				= 0x107;			// �f�[�^?�[�h�L?�b�V?�f�[�^�ő��?�ݒ�
	public const int DEV_GET_CACHEMAX				= 0x108;			// �f�[�^?�[�h�L?�b�V?�f�[�^�ő��?�擾
	public const int DEV_SET_PD_ENABLE				= 0x10B;			// PC�_�C?�N�g�^�]�@�\�g�p�L���̐ݒ�
	public const int DEV_SET_LOGTYPE				= 0x111;			// �ُ�ʒm���@�̐ݒ�
	public const int DEV_GET_LOGTYPE				= 0x112;			// �ُ�ʒm���@�̎擾
	public const int DEV_SET_LOGDIR					= 0x113;			// �ُ�ʒm?�O�t�@�C?�o�͐�̐ݒ�
	public const int DEV_GET_LOGDIR					= 0x114;			// �ُ�ʒm?�O�t�@�C?�o�͐�̎擾
	public const int CMD_ENABLE_BACKGROUND			= 0x1001;			// �o�b�N�O?�E?�h�`�F�b�N�@�\
	public const int CMD_NC_DISCONNECT				= 0x1002;			// �w�肵��NC�Ƃ̐ڑ���ؒf����

	// DEV_SET_COMMADDRESS�ADEV_GET_COMMADDRESS�p
	public const int DEVICETYPE_TCP					= 4;				// TCP�\�P�b�g�o�R

	// melActiveatePLC
	public const int M_OPE_ACTPLC_TRUE				= 0x01;				// PLC�N��
	public const int M_OPE_ACTPLC_FALSE				= 0x00;				// PLC��~

	// melGetCurrentAlarmMsg, melGetAlarmMsg
	public const int M_ALM_ALL_ALARM				= 0x000;			// �A?�[?��ނ̋�ʂȂ�
	public const int M_ALM_NC_ALARM					= 0x100;			// NC�A?�[?
	public const int M_ALM_STOP_CODE				= 0x200;			// �X�g�b�v�R�[�h
	public const int M_ALM_PLC_ALARM				= 0x300;			// PLC�A?�[??�b�Z�[�W
	public const int M_ALM_OPE_MSG					= 0x400;			// �I�y?�[�^?�b�Z�[�W
	public const int M_ALM_NC_AUX					= 0x10C;			// ��?��NC�A?�[?

	// -- ?�P�[?�ݒ� --
	// melSetLocale/melGetLocale
	public const int LANG_JA						= 0x40000411;		// ���{
	public const int LANG_EN						= 0x40000409;		// �A??�J
	public const int LANG_DE						= 0x40000407;		// �h�C�c
	public const int LANG_IT						= 0x40000410;		// �C�^?�A
	public const int LANG_FR						= 0x4000040C;		// �t??�X
	public const int LANG_ES						= 0x4000040A;		// �X�y�C?
	public const int LANG_TW						= 0x40000404;		// ��p
	public const int LANG_CN						= 0x40000804;		// ??
	public const int LANG_KO						= 0x40000412;		// ��?
	public const int LANG_PT						= 0x40000816;		// �|?�g�K?
	public const int LANG_HU						= 0x4000040E;		// �n?�K?�[
	public const int LANG_NL						= 0x40000413;		// �I??�_
	public const int LANG_SV						= 0x4000041D;		// �X�E�F�[�f?
	public const int LANG_PL						= 0x40000415;		// �|�[??�h
	public const int LANG_TR						= 0x4000041F;		// �g?�R
	public const int LANG_RU						= 0x40000419;		// ?�V�A
	public const int LANG_CZ						= 0x40000405;		// �`�F�R
	public const int LANG_DA						= 0x40000406;		// 26:�f?�}�[�N
	public const int LANG_FI						= 0x4000040B;		// 27:�t�B???�h
	public const int LANG_RO						= 0x40000418;		// 28:?�[�}�j�A
	public const int LANG_SL						= 0x40000424;		// 29:�X?�x�j�A
	public const int LANG_BG						= 0x40000402;		// 30:�u?�K?�A
}

// ----- DEV_SET_COMMADDRESS�ADEV_GET_COMMADDRESS�p -------------------
// ISA
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_ISA
{
	public uint dwDeviceType;					//�f�o�C�X���
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// PCI
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_PCI
{
	public uint dwDeviceType;					//�f�o�C�X���
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// COM
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_COM
{
	public uint dwDeviceType;					//�f�o�C�X���
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// TCP
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct MELDEVICEDATA_TCP
{
	public uint dwDeviceType;					//�f�o�C�X���
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
	public uint dwDeviceType;					//�f�o�C�X���
	public int lPortNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
	public sbyte[] dummy;
}

// GOT
[StructLayout(LayoutKind.Sequential)]
public struct MELDEVICEDATA_GOT
{
	public uint dwDeviceType;					//�f�o�C�X���
	public uint dwChannel;
	public uint dwNetworkNo;
	public uint dwPcNo;
	public uint dwMultiCpuNo;
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public sbyte[] dummy;
}

// ----- DEV_SET_CACHEMAX, DEV_GET_CACHEMAX�p -------------------
[StructLayout(LayoutKind.Sequential)]
public struct MELCACHEMAXDATA
{
	public uint dwCacheCount;					//?�[�h�L?�b�V?�ő�o�^?
	public uint dwCacheCancelUnit;				//?�[�h�L?�b�V?��?��?
}
