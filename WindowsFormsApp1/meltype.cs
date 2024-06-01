//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	meltype.cs
//	<�@�\>			�f�[�^�^�C�v��`
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		meltype
//	<�@�\>			�f�[�^�^�C�v��`�N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class meltype
{
	//******************************************************
	// ----- ?�l�^�f�[�^�^�C�v��` -----------------------
	//******************************************************
	public const int T_CHAR			= 0x1;				// 1�o�C�g��?�^
	public const int T_SHORT		= 0x2;				// 2�o�C�g��?�^
	public const int T_LONG			= 0x3;				// 4�o�C�g��?�^
	public const int T_DLONG		= 0x4;				// 8�o�C�g��?�^
	public const int T_DOUBLE		= 0x5;				// ��?�^

	//******************************************************
	// ----- ��?�^�f�[�^�^�C�v��` -----------------------
	//******************************************************
	public const int T_STR			= 0x10;				// ��?��^
	public const int T_DECSTR		= 0x11;				// 10�i��?��?��^
	public const int T_HEXSTR		= 0x12;				// 16�i?��?��^
	public const int T_BINSTR		= 0x13;				// 2�i?��?��^
	public const int T_FLOATSTR		= 0x14;				// ��?��?��^
	public const int T_WSTR			= 0x15;				// ��?��^(UNICODE)
	public const int T_DECWSTR		= 0x16;				// 10�i��?��?��^(UNICODE)
	public const int T_HEXWSTR		= 0x17;				// 16�i?��?��^(UNICODE)
	public const int T_FLOATWSTR	= 0x19;				// ��?��?��^(UNICODE)
	// �I�v�V??��`
	public const int FSTR_FILL_ZERO = 0x1;				// ��??�[?�l�߂��s�Ȃ�
	public const int FSTR_ADD_PLUS	= 0x2;				// ����?�̏�?�{??��t����

	//******************************************************
	// ----- ����^�f�[�^�^�C�v��` -----------------------
	//******************************************************
	public const int T_GETPRGBLOCK	= 0x102;			// ���s?�v?�O??�擾�p
	public const int T_BUFF			= 0x103;			// �ėp�o�b�t�@�^

	//******************************************************
	// ----- NC�t�@�C?�V�X�e?�f�[�^�^�C�v��` -----------
	//******************************************************
	public const int T_STAT			= 0x106;			// NC�t�@�C?�V�X�e?���擾�p

	//******************************************************
	// ----- �A?�[??�b�Z�[�W�擾�p��`	-------------
	//******************************************************
	public const int T_ALARMMSG		= 0x108;			// �A?�[??�b�Z�[�W
	public const int T_ALARMMSG2	= 0x10e;			// �A?�[??�b�Z�[�W2

	//******************************************************
	// ----- �`�F�b�N�`��f�[�^�擾�p��`	-------------
	//******************************************************
	public const int T_CHECKDRAW	= 0x109;			// 8�����̕`��f�[�^�擾
	public const int T_CHECKDRAW16	= 0x110;			// 16�����̕`��f�[�^�擾
	public const int T_CHECKDRAWQS	= 0x113;			// 16������?��?�[�h�p�`��f�[�^�擾

	//******************************************************
	// ----- UNICODE�p�v?�O??�擾�p��`	-------------
	//******************************************************
	public const int T_WGETPRGBLOCK = 0x10a;			// ���s?�v?�O??�擾�p(UNICODE)

	//******************************************************
	// ----- UNICODE�p�A?�[??�b�Z�[�W�擾�p��`	-----
	//******************************************************
	public const int T_WALARMMSG	= 0x10c;			// �A?�[??�b�Z�[�W(UNICODE)
	public const int T_WALARMMSG2	= 0x10f;			// �A?�[??�b�Z�[�W2(UNICODE)

	//******************************************************
	//	�m�b�V?�A?�|�[�g���ݒ�p��`	-------------
	//******************************************************
	public const int T_SERIAL_SETUP = 0x10d;			// �m�b�V?�A?�|�[�g���ݒ�
}

//******************************************************
// ----- ��?�^�f�[�^�^�C�v��`	    -------------
//******************************************************
// ��?��^
[StructLayout(LayoutKind.Sequential)]
public struct STRINGTYPE				// used also as T_BUFF
{
	public int lBuffSize;
	public IntPtr lpszBuff;
}

// ��?��?��^
[StructLayout(LayoutKind.Sequential)]
public struct FLOATSTR
{
	public short nIntDataNos;			// ��????
	public short nDecDataNos;			// ��????
	public int lOption;					// �I�v�V??
	public int lBuffSize;				// �f�[�^�̈�̃T�C�Y
	public IntPtr lpszBuff;				// �f�[�^�̈�̃|�C?�^
}

// ��?��?��^(UNICODE)
[StructLayout(LayoutKind.Sequential)]
public struct FLOATWSTR
{
	public short nIntDataNos;			// ��????
	public short nDecDataNos;			// ��????
	public int lOption;					// �I�v�V??
	public int lBuffSize;				// �f�[�^�̈�̃T�C�Y
	public IntPtr lpszBuff;				// �f�[�^�̈�̃|�C?�^
}

//******************************************************
// ----- ����^�f�[�^�^�C�v��`	-----------------------
//******************************************************
// ���s?�v?�O??�擾�p
[StructLayout(LayoutKind.Sequential)]
public struct GETPRGBLOCK
{
	public int lCurrentBlockNum;		// ���s?�̃u?�b�N
										// (�擾�����f�[�^?�̃u?�b�N)
										//	  0:�^�]?�łȂ�
										//	  1:1�u?�b�N��
										//	  2:2�u?�b�N��
	public int lPrgDataSize;			// lpszPrgData�̃o�b�t�@�T�C�Y
	public IntPtr lpszPrgData;			// �v?�O??���i�[����o�b�t�@
}

// ���s?�v?�O??�擾�p
[StructLayout(LayoutKind.Sequential)]
public struct BUFFTYPE
{
	public int lBuffSize;				// lpBuff�̃o�b�t�@�T�C�Y
	public IntPtr lpBuff;				// �o�b�t�@�̃|�C?�^
}

// melRegisterLumpModal�p
[StructLayout(LayoutKind.Sequential)]
public struct REGLUMPMODAL
{
	public int lAddress;				// �A�h?�X
	public int lSectionNum;				// ��敪��?
	public int lSubSectionNum;			// ���敪��?
	public int lAxisFlag;				// ���̎w��
	public int lDataType;				// �f�[�^�^�C�v
	public int lPriority;				// �D��?��
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

// PLC�f�o�C�X��?�ݒ�^�C�v(���J��敪M_SEC_PLC_DEV_XXX melSetData�p
[StructLayout(LayoutKind.Sequential)]
public struct PLCDEV_LUMPTYPE
{
	public int lDataType;				// �f�[�^�^�C�v
	public int lDataNos;				// ?��?�݃f�[�^�̌�?
	public value value;
}

//******************************************************
// ----- �A?�[??�b�Z�[�W�擾�p��`	-------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct ALARMMSG
{
	public int lSystem;					// �擾�A?�[?�̌n?
	public int lAlarmType;				// �擾�A?�[?�̏ڍ׎��
	public int lBuffSize;				// lpszBuff�̃o�b�t�@�T�C�Y
	public IntPtr lpszBuff;				// ?�b�Z�[�W���i�[����
										// �o�b�t�@�ւ̃|�C?�^
}
//******************************************************
// ----- UNICODE�p�v?�O??�擾�p	    -------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct WGETPRGBLOCK
{
	public int lCurrentBlockNum;		// ���s?�̃u?�b�N
										// (�擾�����f�[�^?�̃u?�b�N)
										//	  0:�^�]?�łȂ�
										//	  1:1�u?�b�N��
										//	  2:2�u?�b�N��
	public int lPrgDataSize;			// lpszPrgData�̃o�b�t�@�T�C�Y
	public IntPtr lpszPrgData;			// �v?�O??���i�[����o�b�t�@
}

//******************************************************
// ----- �A?�[??�b�Z�[�W�擾�p��`	-------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct WALARMMSG
{
	public int lSystem;					// �擾�A?�[?�̌n?
	public int lAlarmType;				// �擾�A?�[?�̏ڍ׎��
	public int lBuffSize;				// lpszBuff�̃o�b�t�@�T�C�Y
	public IntPtr lpszBuff;				// ?�b�Z�[�W���i�[����
										// �o�b�t�@�ւ̃|�C?�^
}

//******************************************************
// ----- �m�b�V?�A?�|�[�g���ݒ�p�\���� -------------
//******************************************************
[StructLayout(LayoutKind.Sequential)]
public struct SERIAL_SETUP
{
	public int lBaudRate;				// �{�[?�[�g�ݒ�
										//	110, 300, 600, 1200, 2400, 4800,
										//	9600, 19200
	public sbyte cByteSize;				// �f�[�^�r�b�g���ݒ�	7, 8
	public sbyte cParityBit;			// �p?�e�B�r�b�g�ݒ�
										//	0:�����i�`�F�b�N�����j
										//	1:�L���i�`�F�b�N�L��j
	public sbyte cEvenOdd;				// ��?/��?�p?�e�B�ݒ�
										//	1:��?�`�F�b�N, 2:��?�`�F�b�N
	public sbyte cStopBit;				// �X�g�b�v�r�b�g�ݒ�
										//	0:1bit, 1:1.5bit, 2:2bit
	public sbyte cHandShake;			// �n?�h�V�F�B�N�ݒ�
										//	0:RTS/CTS����
										//	1:�n?�h�V�F�C�N����
										//	2:DC�R�[�h����
	public sbyte cDCcodeParity;			// DC�R�[�h�p?�e�B�ݒ�
										//	0:Xon-off�p?�e�B �I�t
										//	1:Xon-off�p?�e�B �I?
	public sbyte cDRoff;				// DR�`�F�b�N���� 0:�`�F�b�N�L�� 1:����
	public sbyte cOutBufSize;			// �o�̓o�b�t�@�T�C�Y
										//	0:250�o�C�g
										//	1:1�o�C�g
										//	2:4�o�C�g
										//	3:8�o�C�g
										//	4:16�o�C�g
										//	5:64�o�C�g
										//	���̑�:250�o�C�g
	public int lTimeout;				// �^�C?�A�E�g?�� (x100ms)
	public sbyte cTermType;				// �^�[�~�l�[�^�^�C�v�ݒ�	1:EOB, 3:EOR
	public sbyte cDC2DC4;				// DC2/DC4�o�͐ݒ�
										//	bit0: DC2�R�[�h�o��
										//	bit1: DC4�R�[�h�o��
	public sbyte cCRout;				// CR�o�͐ݒ�	0:���o��, 1:�o��
	public sbyte cEIAout;				// EIA�o�͐ݒ�	0:ISO�o��, 1:EIA�o��
	public short nFeedChar;				// �t�B�[�h?�ݒ�	0-250
	public sbyte cParityV;				// �p?�e�BV�`�F�b�N�ݒ�
										//	0:�`�F�b�N����, 1:�`�F�b�N�L��
	public sbyte cAscii;				// �f�[�^ASCII�ݒ�
										//	0:ISO or EIA, 1:ASCII
	public sbyte cEIAcode1;				// '[' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode2;				// ']' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode3;				// '#' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode4;				// '*' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode5;				// '=' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode6;				// ':' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode7;				// '$' -> EIA��փR�[�h�ݒ�
	public sbyte cEIAcode8;				// '!' -> EIA��փR�[�h�ݒ�
}
