//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	melfstyp.cs
//	<�@�\>			melFs�֘A�̒�`(�J�X�^?API?�C�u?? �f�[�^�^�C�v��`)
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		melfstyp
//	<�@�\>			melFs�֘A�̒�`(�J�X�^?API?�C�u?? �f�[�^�^�C�v��`)�N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class melfstyp
{
	// ----- �m�b�t�@�C?�V�X�e?�A�N�Z�X�^�f�[�^�^�C�v��` -----
	// File mode (st_mode) bit masks
	public const int MM_S_IFDIR				= 0x4000;		// directory
	public const int MM_S_IFREG				= 0x8000;		// regular

	// ----- NC???�t�@�C?�V�X�e?�A�N�Z�X�R�}?�h��` -----
	// melFSCreateFile/melFSOpenFile
	public const int M_FSOPEN_RDONLY		= 0x0000;		// �ǂݎ���p�ɃI�[�v?����
	public const int M_FSOPEN_WRONLY		= 0x0001;		// ?��?�ݐ�p�ɃI�[�v?����
	public const int M_FSOPEN_RDWR			= 0x0002;		// �ǂݎ��^?��?�ݗp�ɃI�[�v?����
	public const int M_FSOPEN_CREAT			= 0x0200;		// open with file create
	public const int M_FSOPEN_TRUNC			= 0x0400;		// open with truncation

	// melFSIoctlFile
	public const int M_FSIOCTL_FREECHAR		= 0x0000;		// �t�@�C?�V�X�e?�̎c��??�̎擾
	public const int M_FSIOCTL_ENTRYCHAR	= 0x0001;		// �t�@�C?�V�X�e?�̓o�^��??�̎擾
	public const int M_FSIOCTL_FREEFILE		= 0x0002;		// �t�@�C?�V�X�e?�̃t�@�C?�c�{?�̎擾
	public const int M_FSIOCTL_ENTRYFILE	= 0x0003;		// �t�@�C?�V�X�e?�̃t�@�C?�o�^�{?�̎擾
	public const int M_FSIOCTL_RDFILECOM	= 0x0005;		// �t�@�C?�R??�g�̓ǂݏo��
	public const int M_FSIOCTL_WTFILECOM	= 0x0006;		// �t�@�C?�R??�g��?��?��
	public const int M_FSIOCTL_DISKFORMAT	= 0x0007;		// NC???�̃t�H�[�}�b�g
	public const int M_FSIOCTL_NOBOFOUT		= 0x0008;		// �o��?��BOF("%")���o�͂��Ȃ�
	public const int M_FSIOCTL_SIOINIT		= 0x0009;		// NC�V?�A?��?���ݒ�
	public const int M_FSIOCTL_SIOGETERR	= 0x000A;		// NC�V?�A?�̃G?�[�擾
	public const int M_FSIOCTL_SIOSTOP		= 0x000B;		// NC�V?�A?�̋�����~
	public const int M_FSIOCTL_READDIRSYS	= 0x000C;		// melFSReadDirectory()�Ŏ擾����n?�w��
	public const int M_FSIOCTL_FILETIMESET	= 0x000D;		// �t�@�C?��?�̐ݒ�
	public const int M_FSIOCTL_UPRO_ALLCLR	= 0x000E;		// ���H�v?�O??�S��?
	public const int M_FSIOCTL_MMAC_ALLCLR	= 0x000F;		// �@�B?�[�J�}�N?�S��?
	public const int M_FSIOCTL_FIXPRO_INIT	= 0x0010;		// �Œ�T�C�N??����
	public const int M_FSIOCTL_FREECHAR64	= 0x0011;		// �e�f�o�C�X�̋󂫗e�ʂ̎擾
	public const int M_FSIOCTL_ENTRYCHAR64	= 0x0012;		// �e�f�o�C�X�̎g�p�ʂ̎擾
	public const int M_FSIOCTL_TOTALCHAR64	= 0x0013;		// �e�f�o�C�X�̑S�̗e�ʂ̎擾
	public const int M_FSIOCTL_PRGCOMMENT	= 0x0016;		// ���H�v?�O??�R??�g�擾
	public const int M_FSIOCTL_CHKDEVLOCK	= 0x0018;		// �e�f�o�C�X��??��?�b�N��Ԃ̎擾
	public const int M_FSIOCTL_DISKFORMATEX = 0x001A;		// �t�@�C?�V�X�e?�t�H�[�}�b�g(�񓯊�)

	// melFSLseekFile
	public const int M_FSLSEEK_TOP			= 0x0000;		// �t�@�C?�̐擪����V�[�N
	public const int M_FSLSEEK_CURRENT		= 0x0001;		// �t�@�C?�̌��݈ʒu����V�[�N
	public const int M_FSLSEEK_END			= 0x0002;		// �t�@�C?�̍Ōォ��V�[�N

}

// ----- �m�b�t�@�C?�V�X�e?�A�N�Z�X�^�f�[�^�^�C�v��` -----
// �t�@�C?���
[StructLayout(LayoutKind.Sequential)]
public struct FS_STAT
{
	public int	 lMode;										// �t�@�C?�̑����ist_mode:MM_S_IFDIR:�f�B?�N�g?�j
	public int	 lFileSize;									// �t�@�C?�T�C�Y
	public short nYear;										// �t�@�C?�X�V���i�N�j
	public short nMonth;									// �t�@�C?�X�V���i?�j
	public short nDay;										// �t�@�C?�X�V���i���j
	public short nHour;										// �t�@�C?�X�V���i?�j
	public short nMinute;									// �t�@�C?�X�V���i���j
	public short nSecond;									// �t�@�C?�X�V���i�b�j
}
