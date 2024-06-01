//************************************************************************************* MELCO ******
//																						 (Nx)
//	<�t�@�C?��>	g_check.cs
//	<�@�\>			�O?�t�B�b�N�`�F�b�N�p�̒�`�t�@�C?
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<�N?�X��>		g_check
//	<�@�\>			�O?�t�B�b�N�`�F�b�N�p�̒�`�N?�X
//		[��?]
//			�Ȃ�
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class g_check
{
	public const int MAX_SYS_AXIS	= 8;		// �n?���ő厲?
	public const int MAX_SYS_AXIS16 = 16;		// M8�n?���ő厲?
}

// �`����(8�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct ShapeData							// �`����
{
	public short shape_mode;					// �`��?�[�h
												//	 0:�`��w�߂Ȃ��A1:�����A
												//	 2:�b�v�~�ʁA3:�b�b�v�~�ʁA
												//	 4:�b�v�Q�����A5:�b�b�v�Q�����A
												//	 6:�b�v�w?�J?�A7:�b�b�v�w?�J?�A
												//	 8:�b�v�Q�����w?�J?�A9:�b�b�v�Q�����w?�J?
	public short arc_plane_i;					// �~�ʕ��ʉ���
												// �~�ʕ��ʂ��\�����鉡���̌n?������?
												//	 �n?����1��:0�A��Q��:1�A...
	public short arc_plane_j;					// �~�ʕ��ʏc��
												// �~�ʕ��ʂ��\������c���̌n?������?
												//	 �n?����1��:0�A��Q��:1�A...
	public short dummy;							// �_�~�[
	public short arc_pitch;						// �~�ʌJ��Ԃ���?
	public short draw_axis_1;					// �`��Ώۑ�P��
												//	 �n?����1��:0�A��Q��:1�A...
	public short draw_axis_2;					// �`��Ώۑ�Q��
												//	 �n?����1��:0�A��Q��:1�A...
	public short draw_axis_3;					// �`��Ώۑ�R��
												//	 �n?����1��:0�A��Q��:1�A...
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] start_point;				// �@�B���W�n�n�_	   MAX_SYS_AXIS�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] end_point;					// �@�B���W�n�I�_	   MAX_SYS_AXIS�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] work_coord_start_point;		// ?�[�N���W�n�n�_	   MAX_SYS_AXIS�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] work_coord_end_point;		// ?�[�N���W�n�I�_	   MAX_SYS_AXIS�F�n?����?
	public double arc_center_point_h;			// �~�ʉ���?�S���W
	public double arc_center_point_v;			// �~�ʏc��?�S���W
	public double radius;						// ���a
}

// �O�Տ��(8�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct PathData							// �`����
{
	public short move_mode;						// ����?�[�h
												//	 0:�ړ��Ȃ��A1:??����ԁA2:??���ԁA
												//	 3:�؍�?���ԁA4:�˂��؂��ԁA5:�X�L�b�v�A
												//	 6:?�t�@??�X�_?�A
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public short[] dummy;						// �_�~�[
	public ShapeData shape_data;				// �`����
}

// �`�F�b�N�`����(8�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDraw							// �`����
{
	public short exec_status;					// �u?�b�N���s���
												//	 0:��~?�A?�����
												//	 1:���s?�i?�Z�b�g�N��?�A�u?�b�N���s?�j
												//	 2:�v?�O??����
												//	 3:M0/M1�u?�b�N��~?
												//	 4:�G?�[
	public short abs_inc;						// ���?���f?�[�_?
												//	 0:���(G90)�A1:?��(G91)
	public short fix_cycle;						// �Œ�T�C�N?�f?�[�_?(�}�V�Z?)
												//	 0:G70�A1:G71�A2:G72�A3:G73�A4:G74�A5:G75�A
												//	 6:G76�A7:G77�A8:G78�A9:G79�A10:G80�A11:G81�A
												//	 12:G82�A13:G83�A14:G84�A15:G85�A16:G86�A17:G87�A
												//	 18:G88�A19:G89
	public short tool_compen;					// �H��␳�f?�[�_?
												//	 0:G40�A1:G41�A2:G42
	public short current_work_coord_sys;		// ���݂�?�[�N���W�n
												//	 0:G54�A1:G55�A2:G56�A3:G57�A4:G58�A5:G59
												//	 6:G54.1P1
	public short process_info;					// ���H��� 0�F�ʏ� 1�F�~�[??�O
												//			2�F�~?���? 3�F�X�Ζʉ��H�w��?
	public sbyte surface_speed_ctr;				// 0:�ʏ� 1:������萧��?
	public sbyte feed_info;						// 0:?��?��? 1:?��]?��?
												//	 �˂��؂�?��1�Œ�Ƃ���B
												//	 �����^�b�v?��1�Ƃ��邪�A
												//	 #1268(bit2)=1(�����^�b�v?��?��L��)�̏�?�́A
												//	 G�O?�[�v5(G94/G95)?�[�_?�ɏ]���B
												//	 �񓯊��^�b�v?�́A���G�O?�[�v5?�[�_?�ɏ]���B
	public sbyte unmodal_gcode_flg;				// �A??�[�_?G�R�[�h�t?�O
												//	 bit0�F�H����� G�R�[�h�w�߃u?�b�N
												//			 (G53.1/G53.6)
												//	 bit1�`bit7�F��(0)
	public sbyte modal_gcode_flag;				// ?�[�_?G�R�[�h�t?�O
												//	 bit0:M/L�v?�O??���I�؂�ւ�
												//			 OFF:����(G189)�AON:�L��(G188)
	public PathData tool_path_data;				// �H��?�S�O�Տ��
	public PathData prg_path_data;				// �v?�O???�S�O�Տ��
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;						// M�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FM�R�[�h
	public int t_code;							// T�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FT�R�[�h
	public int d_number;						// M�R�[�h	 �w�ߗL/���Fmstb_cmd(bit0�`bit3)�Q��
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public int[] h_number;						// T�R�[�h	 �w�ߗL/���Fmstb_cmd(bit8)�Q��
	public int f_modal;							// F?�[�_?
	public short mstb_cmd;						// �P�u?�b�N���ł�M�AT�w�ߗL/��
												//	 0�F�w�߂Ȃ��^1�F�w��?��
												//	   bit0 �FM�R�[�h1�w�ߗL��
												//	   bit1 �FM�R�[�h2�w�ߗL��
												//	   bit2 �FM�R�[�h3�w�ߗL��
												//	   bit3 �FM�R�[�h4�w�ߗL��
												//	   bit4�`bit7�F��
												//	   bit8 �FT�R�[�h�w�ߗL��
												//	   bit9�`bit15�F��
	public byte path_info;						// �O�Տ��
												//	 BIT0: �␳�O�d�グ�`��\�� ?
												//	 BIT1: �␳�O�d�グ�`��\�� �T�C�N?�w�ߓ_�Ǝn�_/�I�_�Ԃ̈ړ�
												//	 BIT2�`7: ���g�p
	public sbyte dummy1;						//	dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public short[] tool_offset;					// �H��␳G?�[�_? 0:G43�A1:G44�A2:G49
	public double cylnd_radius;					// �~?���a(����P��)
												//	 �C�j�V??�C?�`?�A25.4�{���ꂽ�l�ƂȂ�܂��B
	public int spdl_speed;						// ������萧��ON?�͎����x(m/min)��S�w�ߒl�A
												// OFF?�͎厲(S)�w�߉�]���x(rev/min)
												//	 �w�߂Ȃ��̏�?��0
												//	 �C�j�V??�C?�`(#1041=1)?�A�����x��(feet/min)
												//	 ���C�j�V??�C?�`�A�܂���G20�w��?�A
												//	   �ϊ��덷��?��܂��B
												//
												//	 ��?�厲����T?(ext36(bit0)=0)�A
												//	 �E��1�厲����?�[�h?(G43.1)�̏�?
												//		 ��1�厲�̎����x�A�܂��͉�]���x�B
												//	 �E�I���厲����?�[�h?(G44.1)�̏�?
												//		 �I���厲��?(#1534 SnG44.1)�ɐݒ肳�ꂽ
												//		 �厲�̎����x�A�܂��͉�]���x�B
												//	 �E�S�厲��?����?�[�h?(G47.1)�̏�?
												//		 �厲(S)�w�߂̎����x�A�܂��͉�]���x�B
												//	 ��?�厲����U?(ext36(bit0)=1)�A
												//		 �Ō�Ɏw�߂���S�w�߂̎����x�A�܂��͉�]���x
	public int spdl_clamp_speed;				// ��?�厲�N??�v��]���x(rev/min)
												// G92(�厲�N??�v���x)��S�A�܂���Q�w�ߒl
												//	 (G�R�[�h��G�R�[�h�n��ňقȂ�)
												//	 (?���l�̓N??�v�ő�l99999999)
												//	 �w�߂Ȃ��̏�?��?���l�Ɠ���
												//	 ����?�厲����U��?�A�Ō�Ɏw�߂���
												//	 �N??�v���x�ƂȂ�
	public double feed;							// ?��?�葬�x(mm/min)�A�܂��́A
												// ?��]?�葬�x(mm/rev)��F�w�ߒl
												//	 �˂��؂�E�����^�b�v?��F�A�܂���E�w�ߒl�ƂȂ�B
												//	 (E�w�߂��R?�w��̏�?�A�s�b�`�ϊ���̒l)
												//	 �w�߂Ȃ��̏�?��0
												//	 �C�j�V??�C?�`(#1041=1)?�́A
												//	 ?��?�葬�x(inch/min)�A
												//	 ?��]?�葬�x(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;						// ��(24 -> 8)
}

// �`����				   (16�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct ShapeData16						// �`����
{
	public short shape_mode;					// �`��?�[�h
												//	 0:�`��w�߂Ȃ��A1:�����A
												//	 2:�b�v�~�ʁA3:�b�b�v�~�ʁA
												//	 4:�b�v�Q�����A5:�b�b�v�Q�����A
												//	 6:�b�v�w?�J?�A7:�b�b�v�w?�J?�A
												//	 8:�b�v�Q�����w?�J?�A9:�b�b�v�Q�����w?�J?
	public short arc_plane_i;					// �~�ʕ��ʉ���
												// �~�ʕ��ʂ��\�����鉡���̌n?������?
												//	 �n?����1��:0�A��Q��:1�A...
	public short arc_plane_j;					// �~�ʕ��ʏc��
												// �~�ʕ��ʂ��\������c���̌n?������?
												//	 �n?����1��:0�A��Q��:1�A...
	public short dummy;							// �_�~�[
	public short arc_pitch;						// �~�ʌJ��Ԃ���?
	public short draw_axis_1;					// �`��Ώۑ�P��
												//	 �n?����1��:0�A��Q��:1�A...
	public short draw_axis_2;					// �`��Ώۑ�Q��
												//	 �n?����1��:0�A��Q��:1�A...
	public short draw_axis_3;					// �`��Ώۑ�R��
												//	 �n?����1��:0�A��Q��:1�A...
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] start_point;				// �@�B���W�n�n�_	   MAX_SYS_AXIS16�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] end_point;					// �@�B���W�n�I�_	   MAX_SYS_AXIS16�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] work_coord_start_point;		// ?�[�N���W�n�n�_	  MAX_SYS_AXIS16�F�n?����?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] work_coord_end_point;		// ?�[�N���W�n�I�_	  MAX_SYS_AXIS16�F�n?����?
	public double arc_center_point_h;			// �~�ʉ���?�S���W
	public double arc_center_point_v;			// �~�ʏc��?�S���W
	public double radius;						// ���a
}

// �O�Տ��				   (16�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct PathData16					// �`����
{
	public short move_mode;					// ����?�[�h
											//	 0:�ړ��Ȃ��A1:??����ԁA2:??���ԁA
											//	 3:�؍�?���ԁA4:�˂��؂��ԁA5:�X�L�b�v�A
											//	 6:?�t�@??�X�_?�A
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public short[] dummy;					// �_�~�[
	public ShapeData16 shape_data;			// �`����
}

// �`�F�b�N�`����		 (16�����̕`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDraw16					// �`����
{
	public short exec_status;				// �u?�b�N���s���
											//	 0:��~?�A?�����
											//	 1:���s?�i?�Z�b�g�N��?�A�u?�b�N���s?�j
											//	 2:�v?�O??����
											//	 3:M0/M1�u?�b�N��~?
											//	 4:�G?�[
	public short abs_inc;					// ���?���f?�[�_?
											//	 0:���(G90)�A1:?��(G91)
	public short fix_cycle;					// �Œ�T�C�N?�f?�[�_?(�}�V�Z?)
											//	 0:G70�A1:G71�A2:G72�A3:G73�A4:G74�A5:G75�A
											//	 6:G76�A7:G77�A8:G78�A9:G79�A10:G80�A11:G81�A
											//	 12:G82�A13:G83�A14:G84�A15:G85�A16:G86�A17:G87�A
											//	 18:G88�A19:G89
	public short tool_compen;				// �H��␳�f?�[�_?
											//	 0:G40�A1:G41�A2:G42
	public short current_work_coord_sys;	// ���݂�?�[�N���W�n
											//	 0:G54�A1:G55�A2:G56�A3:G57�A4:G58�A5:G59
											//	 6:G54.1P1
	public short process_info;				// ���H��� 0�F�ʏ� 1�F�~�[??�O
											//			2�F�~?���? 3�F�X�Ζʉ��H�w��?
	public sbyte surface_speed_ctr;			// 0:�ʏ� 1:������萧��?
	public sbyte feed_info;					// 0:?��?��? 1:?��]?��?
											//	 �˂��؂�?��1�Œ�Ƃ���B
											//	 �����^�b�v?��1�Ƃ��邪�A
											//	 #1268(bit2)=1(�����^�b�v?��?��L��)�̏�?�́A
											//	 G�O?�[�v5(G94/G95)?�[�_?�ɏ]���B
											//	 �񓯊��^�b�v?�́A���G�O?�[�v5?�[�_?�ɏ]���B
	public sbyte unmodal_gcode_flg;			// �A??�[�_?G�R�[�h�t?�O
											//	 bit0�F�H����� G�R�[�h�w�߃u?�b�N
											//			  (G53.1/G53.6)
											//	 bit1�`bit7�F��(0)
	public sbyte modal_gcode_flag;			// ?�[�_?G�R�[�h�t?�O
											//	 bit0:M/L�v?�O??���I�؂�ւ�
											//			 OFF:����(G189)�AON:�L��(G188)
	public PathData16 tool_path_data;		// �H��?�S�O�Տ��
	public PathData16 prg_path_data;		// �v?�O???�S�O�Տ��
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;					// M�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FM�R�[�h
	public int t_code;						// T�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FT�R�[�h
	public int d_number;					// �H��a�␳��??�[�_?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public int[] h_number;					// T�R�[�h	 �w�ߗL/���Fmstb_cmd(bit8)�Q��
	public int f_modal;						// F?�[�_?
	public short mstb_cmd;					// �P�u?�b�N���ł�M�AT�w�ߗL/��
											//	 0�F�w�߂Ȃ��^1�F�w��?��
											//	   bit0 �FM�R�[�h1�w�ߗL��
											//	   bit1 �FM�R�[�h2�w�ߗL��
											//	   bit2 �FM�R�[�h3�w�ߗL��
											//	   bit3 �FM�R�[�h4�w�ߗL��
											//	   bit4�`bit7�F��
											//	   bit8 �FT�R�[�h�w�ߗL��
											//	   bit9�`bit15�F��
	public short dummy1;					// dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public short[] tool_offset;				// �H��␳G?�[�_? 0:G43�A1:G44�A2:G49
	public double cylnd_radius;				// �~?���a(����P��)
											//	 �C�j�V??�C?�`?�A25.4�{���ꂽ�l�ƂȂ�܂��B
	public int spdl_speed;					// ������萧��ON?�͎����x(m/min)��S�w�ߒl�A
											// OFF?�͎厲(S)�w�߉�]���x(rev/min)
											//	 �w�߂Ȃ��̏�?��0
											//	 �C�j�V??�C?�`(#1041=1)?�A�����x��(feet/min)
											//	 ���C�j�V??�C?�`�A�܂���G20�w��?�A
											//	   �ϊ��덷��?��܂��B
											//
											//	 ��?�厲����T?(ext36(bit0)=0)�A
											//	 �E��1�厲����?�[�h?(G43.1)�̏�?
											//		 ��1�厲�̎����x�A�܂��͉�]���x�B
											//	 �E�I���厲����?�[�h?(G44.1)�̏�?
											//		 �I���厲��?(#1534 SnG44.1)�ɐݒ肳�ꂽ
											//		 �厲�̎����x�A�܂��͉�]���x�B
											//	 �E�S�厲��?����?�[�h?(G47.1)�̏�?
											//		 �厲(S)�w�߂̎����x�A�܂��͉�]���x�B
											//	 ��?�厲����U?(ext36(bit0)=1)�A
											//		 �Ō�Ɏw�߂���S�w�߂̎����x�A�܂��͉�]���x
	public int spdl_clamp_speed;			// ��?�厲�N??�v��]���x(rev/min)
											// G92(�厲�N??�v���x)��S�A�܂���Q�w�ߒl
											//	 (G�R�[�h��G�R�[�h�n��ňقȂ�)
											//	 (?���l�̓N??�v�ő�l99999999)
											//	 �w�߂Ȃ��̏�?��?���l�Ɠ���
											//	 ����?�厲����U��?�A�Ō�Ɏw�߂���
											//	 �N??�v���x�ƂȂ�
	public double feed;						// ?��?�葬�x(mm/min)�A�܂��́A
											// ?��]?�葬�x(mm/rev)��F�w�ߒl
											//	 �˂��؂�E�����^�b�v?��F�A�܂���E�w�ߒl�ƂȂ�B
											//	 (E�w�߂��R?�w��̏�?�A�s�b�`�ϊ���̒l)
											//	 �w�߂Ȃ��̏�?��0
											//	 �C�j�V??�C?�`(#1041=1)?�́A
											//	 ?��?�葬�x(inch/min)�A
											//	 ?��]?�葬�x(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;					// ��(24 -> 8)
}

// �`�F�b�N�`����		 (16�����̃`�F�b�N?��?�[�h�p�`��f�[�^)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDrawQS					// �`����
{
	public short exec_status;				// �u?�b�N���s���
											//	 0:��~?�A?�����
											//	 1:���s?�i?�Z�b�g�N��?�A�u?�b�N���s?�j
											//	 2:�v?�O??����
											//	 3:M0/M1�u?�b�N��~?
											//	 4:�G?�[
	public short abs_inc;					// ���?���f?�[�_?
											//	 0:���(G90)�A1:?��(G91)
	public short fix_cycle;					// �Œ�T�C�N?�f?�[�_?(�}�V�Z?)
											//	 0:G70�A1:G71�A2:G72�A3:G73�A4:G74�A5:G75�A
											//	 6:G76�A7:G77�A8:G78�A9:G79�A10:G80�A11:G81�A
											//	 12:G82�A13:G83�A14:G84�A15:G85�A16:G86�A17:G87�A
											//	 18:G88�A19:G89
	public short tool_compen;				// �H��␳�f?�[�_?
											//	 0:G40�A1:G41�A2:G42
	public short current_work_coord_sys;	// ���݂�?�[�N���W�n
											//	 0:G54�A1:G55�A2:G56�A3:G57�A4:G58�A5:G59
											//	 6:G54.1P1
	public short process_info;				// ���H��� 0�F�ʏ� 1�F�~�[??�O
											//			2�F�~?���? 3�F�X�Ζʉ��H�w��?
	public sbyte surface_speed_ctr;			// 0:�ʏ� 1:������萧��?
	public sbyte feed_info;					// 0:?��?��? 1:?��]?��?
											//	 �˂��؂�?��1�Œ�Ƃ���B
											//	 �����^�b�v?��1�Ƃ��邪�A
											//	 #1268(bit2)=1(�����^�b�v?��?��L��)�̏�?�́A
											//	 G�O?�[�v5(G94/G95)?�[�_?�ɏ]���B
											//	 �񓯊��^�b�v?�́A���G�O?�[�v5?�[�_?�ɏ]���B
	public sbyte unmodal_gcode_flg;			// �A??�[�_?G�R�[�h�t?�O
											//	 bit0�F�H����� G�R�[�h�w�߃u?�b�N
											//			  (G53.1/G53.6)
											//	 bit1�`bit7�F��(0)
	public sbyte modal_gcode_flag;			// ?�[�_?G�R�[�h�t?�O
											//	 bit0:M/L�v?�O??���I�؂�ւ�
											//			 OFF:����(G189)�AON:�L��(G188)
	public PathData16 tool_path_data;		// �H��?�S�O�Տ��
	public PathData16 prg_path_data;		// �v?�O???�S�O�Տ��
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;					// M�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FM�R�[�h
	public int t_code;						// T�R�[�h	 0x80000000�F�w�߂Ȃ��A���L�ȊO�FT�R�[�h
	public int d_number;					// �H��a�␳��??�[�_?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public int[] h_number;					// T�R�[�h	 �w�ߗL/���Fmstb_cmd(bit8)�Q��
	public int f_modal;						// F?�[�_?
	public short mstb_cmd;					// �P�u?�b�N���ł�M�AT�w�ߗL/��
											//	 0�F�w�߂Ȃ��^1�F�w��?��
											//	   bit0 �FM�R�[�h1�w�ߗL��
											//	   bit1 �FM�R�[�h2�w�ߗL��
											//	   bit2 �FM�R�[�h3�w�ߗL��
											//	   bit3 �FM�R�[�h4�w�ߗL��
											//	   bit4�`bit7�F��
											//	   bit8 �FT�R�[�h�w�ߗL��
											//	   bit9�`bit15�F��
	public short dummy1;					// dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public short[] tool_offset;				// �H��␳G?�[�_? 0:G43�A1:G44�A2:G49
	public double cylnd_radius;				// �~?���a(����P��)
											//	 �C�j�V??�C?�`?�A25.4�{���ꂽ�l�ƂȂ�܂��B
	public int spdl_speed;					// ������萧��ON?�͎����x(m/min)��S�w�ߒl�A
											// OFF?�͎厲(S)�w�߉�]���x(rev/min)
											//	 �w�߂Ȃ��̏�?��0
											//	 �C�j�V??�C?�`(#1041=1)?�A�����x��(feet/min)
											//	 ���C�j�V??�C?�`�A�܂���G20�w��?�A
											//	   �ϊ��덷��?��܂��B
											//
											//	 ��?�厲����T?(ext36(bit0)=0)�A
											//	 �E��1�厲����?�[�h?(G43.1)�̏�?
											//		 ��1�厲�̎����x�A�܂��͉�]���x�B
											//	 �E�I���厲����?�[�h?(G44.1)�̏�?
											//		 �I���厲��?(#1534 SnG44.1)�ɐݒ肳�ꂽ
											//		 �厲�̎����x�A�܂��͉�]���x�B
											//	 �E�S�厲��?����?�[�h?(G47.1)�̏�?
											//		 �厲(S)�w�߂̎����x�A�܂��͉�]���x�B
											//	 ��?�厲����U?(ext36(bit0)=1)�A
											//		 �Ō�Ɏw�߂���S�w�߂̎����x�A�܂��͉�]���x
	public int spdl_clamp_speed;			// ��?�厲�N??�v��]���x(rev/min)
											// G92(�厲�N??�v���x)��S�A�܂���Q�w�ߒl
											//	 (G�R�[�h��G�R�[�h�n��ňقȂ�)
											//	 (?���l�̓N??�v�ő�l99999999)
											//	 �w�߂Ȃ��̏�?��?���l�Ɠ���
											//	 ����?�厲����U��?�A�Ō�Ɏw�߂���
											//	 �N??�v���x�ƂȂ�
	public double feed;						// ?��?�葬�x(mm/min)�A�܂��́A
											// ?��]?�葬�x(mm/rev)��F�w�ߒl
											//	 �˂��؂�E�����^�b�v?��F�A�܂���E�w�ߒl�ƂȂ�B
											//	 (E�w�߂��R?�w��̏�?�A�s�b�`�ϊ���̒l)
											//	 �w�߂Ȃ��̏�?��0
											//	 �C�j�V??�C?�`(#1041=1)?�́A
											//	 ?��?�葬�x(inch/min)�A
											//	 ?��]?�葬�x(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;					// ��(24 -> 8)
	public short sToolType;					// �H����
	public short sToolUsage;				// �H��p�r
	public short sToolDir;					// �H�����
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] dummy3;					// �_�~�[
	public double dToolWidth;				// �H��?(�H��a)
	public double dCutWidth;				// �n��?
	public double dToolAngle;				// �H��??�p
	public double dCutAngle;				// �n��p
	public double dTopAngle;				// ��[�p
	public uint lAdrFlag;					// �Œ�T�C�N?�w�߃A�h?�X�̃f�[�^�L���r�b�g�t?�O
											//	 BIT0�F�A�h?�XA�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT1�F�A�h?�XD�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT2�F�A�h?�XF�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT3�F�A�h?�XI�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT4�F�A�h?�XJ�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT5�F�A�h?�XK�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT6�F�A�h?�XP�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT7�F�A�h?�XQ�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT8�F�A�h?�XR�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT9�F�A�h?�XZ�̃f�[�^�L��(0�F���A1�F�L)
											//	 BIT10�`32�F�\��
	public sbyte cDrill_axis;				// ??�����n?������?(�����l:-1)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public sbyte[] dummy4;					// �_�~�[
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public double[] dAdrData;				// �Œ�T�C�N?�w�߃A�h?�X�̃f�[�^
											//	 [0]�A�h?�XA�̃f�[�^
											//	 [1]�A�h?�XD�̃f�[�^
											//	 [2]�A�h?�XF�̃f�[�^
											//	 [3]�A�h?�XI�̃f�[�^
											//	 [4]�A�h?�XJ�̃f�[�^
											//	 [5]�A�h?�XK�̃f�[�^
											//	 [6]�A�h?�XP�̃f�[�^
											//	 [7]�A�h?�XQ�̃f�[�^
											//	 [8]�A�h?�XR�̃f�[�^
											//	 [9]�A�h?�XZ�̃f�[�^
											//	 [10]�`[15]�\��
}
