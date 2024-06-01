//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	melsimuif.cs
//	<�@�\>			�V�~??�[�V??IF�p�̒�`�t�@�C?
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		melsimuif
//	<�@�\>			�V�~??�[�V??IF�p�̒�`�N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melsimuif
{
	public const int SIMU_SET_INTER_TYPE	= 1;				// PC-NC�Ԃ̒ʐM���@
	public const int SIMU_SET_COORD_TYPE	= 2;				// �擾������W�n
	public const int SIMU_SET_ACCUR_TYPE	= 3;				// �擾����f�[�^�̐��x
	public const int SIMU_SET_CTL_ALL		= 4;				// �ʐM�����E���W�n�E���x����?�Ŏw��
	public const int NORMAL_TYPE			= 0;				// �񓯊��ʐM�^�C�v/�����@�B���W�n�^�C�v/�I�_�ۏ؃^�C�v
	public const int SYNC_COM_TYPE			= 1;				// �����ʐM�^�C�v
	public const int PROGRAM_TYPE			= 1;				// �v?�O?�~?�O���W�n�^�C�v
	public const int ROTINTER_TYPE			= 1;				// ��]�����?���x�^�C�v
	public const int ALLINTER_TYPE			= 2;				// �S���?���x�^�C�v

	public static int SIMU_CTL_INTER(int n)						// PC-NC�Ԃ̒ʐM���@
	{
		return ((int)((n << 0) & 0x000000ff));
	}

	public static int SIMU_CTL_COORD(int n)						// �擾������W�n
	{
		return ((int)((n << 8) & 0x0000ff00));
	}

	public static int SIMU_CTL_ACCUR(int n)						// �擾����f�[�^�̐��x
	{
		return ((int)((n << 16) & 0x00ff0000));
	}

	public static int SETSIMU_READSYSTEMNUM(int n)				// �擾�n?�̎w��
	{
		return ((int)((n << 0) & 0x000000ff));
	}

	public const int SETSIMU_SIMULATION_MODE = ((int)((0) << 16) & 0x00ff0000);		// �V�~??�[�V???�[�h
	public const int SIMUBUF_AXISNO = (8);											// ��?
}


//************************
// Simulation Data Table *
//************************
// ���f�[�^
[StructLayout(LayoutKind.Sequential)]
public struct SM_AXIS
{
	// 0x00
	public byte blkinf;			// �u?�b�N���
	public byte pilinf;			// �d���������
	public sbyte bsaxno;		// ��{�����
	public sbyte bsaxsys;		// ��{�n?���
	public sbyte pilbsaxno;		// �d�����������
	public sbyte pilbsaxsys;	// �d�������n?���
	public byte dec;			// ��?�_�ȉ�??
	public sbyte axinf;			// �����
	// 0x08
	public long simpos;			// �@�B�ʒu�f�[�^
	public long simmov;			// �u?�b�N�ړ���
	// 0x18
}

// MSTB���
[StructLayout(LayoutKind.Sequential)]
public struct SM_MTBF
{
	// 0x00
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] smmcod;		// M�R�[�h�f�[�^
	public int smtcod;			// T�R�[�h�f�[�^
	public int smbcod;			// B�R�[�h�f�[�^
	public short smmstf;		// MSTB�t?�O
	public short smmstf2;		// MSTB�t?�O2
	public uint speh_smtf;		// S�t?�O
	// 0x20
}

// �u?�b�N?�ԏ��
[StructLayout(LayoutKind.Sequential)]
public struct SM_TIME
{
	// 0x00
	public int smstrtime;	// �u?�b�N�J�n?��
	public int smendtime;	// �u?�b�N�I��?��
	// 0x08
}


// �v?�O??���
[StructLayout(LayoutKind.Sequential)]
public struct SM_BLOCK
{
	// 0x00
	public int smprgno; // �v?�O??��?
	public int smblkno; // �u?�b�N��?
	// 0x08
}

// �V�~??�[�V??�f�[�^
[StructLayout(LayoutKind.Sequential)]
public struct SIMU_BUF
{
	// 0x00
	public sbyte ssysno;					// �n?��?
	public sbyte smspdmagn;					// ���x�{��
	public sbyte smprgdev;					// ���s?�v?�O?? �f�o�C�XID
	public byte movmod;						// �ړ�?�[�h
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] ssidmy1;					// �_�~�[
	public ushort thrdchkid;				// 3D�`�F�b�NID��?
	// 0x08
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = melsimuif.SIMUBUF_AXISNO)]
	public SM_AXIS[] sm_axis;				// ���f�[�^(8���ɐ���)
	// 0xC8
	public long crcentt;					// �~��?�S�ʒu�f�[�^(�~��?��)
	public long crcenth;					// �~��?�S�ʒu�f�[�^(�~�ʉ�)
	public long crcentv;					// �~��?�S�ʒu�f�[�^(�~�ʏc)
	public long smfeedrt;					// ?�葬�x
	public long smleadk;					// ?�[�h?����
	public long smg16rd;					// G16���ʉ~?���a
	public int smcrosfg;					// �N?�X���t?�O
	public int smpdmy3;						// �_�~�[
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
	public int[] smscod;					// S�R�[�h�f�[�^1(��P�`10�厲)
	public int smcloop;						// �~�ʉ�]?
	public sbyte smplane;					// ���ʑI���f�[�^
	public sbyte smmilling;					// �~�[??�O?�[�h�f�[�^
	public sbyte smrdaxno;					// ?�[�h��?
	public sbyte smpdmy2;					// �_�~�[
	public SM_MTBF sm_mtbf;					// MSTB���
	public SM_TIME sm_time;					// �u?�b�N?�ԏ��
	public SM_BLOCK sm_block;				// �v?�O??���
	// 0x160
}

// �g���V�~??�[�V??�f�[�^
[StructLayout(LayoutKind.Sequential)]
public struct SIMU_BUF_EXT
{
	// 0x00
	public SIMU_BUF simu_buf;				// �V�~??�[�V??�f�[�^
	// 0x160
	public int smodlflg;					// ?�[�_?���
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] sincax;					// �X�Ύ����䎲��?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] shypax;					// ���z���W���䎲��?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] soblax;					// �΂ߍ��W���䎲��?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] smpdmy1;					// �_�~�[
	public int gsdmyl;						// �_�~�[
	public double svectt;					// �@���x�N�g?(T)
	public double svecth;					// �@���x�N�g?(H)
	public double svectv;					// �@���x�N�g?(V)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] ssyncax;					// �H��厲��������?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public short[] ssyncrt;					// �H��厲������]��
	public byte smexecsts;					// �V�~??�[�V??���s?���
	public byte stcpara_index;				// �g�p?��]���\���p??�[�^
	// 0x190
}
