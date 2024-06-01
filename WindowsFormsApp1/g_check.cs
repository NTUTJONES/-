//************************************************************************************* MELCO ******
//																						 (Nx)
//	<ファイ?名>	g_check.cs
//	<機能>			グ?フィックチェック用の定義ファイ?
//
//	COPYRIGHT (C) 2018 MITSUBISHI ELECTRIC CORPORATION
//	ALL RIGHTS RESERVED
//**************************************************************************************************

using System;
using System.Runtime.InteropServices;

//************************************************************************************* MELCO ******
//																						  (Nx)
//	<ク?ス名>		g_check
//	<機能>			グ?フィックチェック用の定義ク?ス
//		[引?]
//			なし
//
//**************************************************************************************************
// <--------------------------------  source  --------------------------------> // <----  ver. ---->

class g_check
{
	public const int MAX_SYS_AXIS	= 8;		// 系?内最大軸?
	public const int MAX_SYS_AXIS16 = 16;		// M8系?内最大軸?
}

// 形状情報(8軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct ShapeData							// 形状情報
{
	public short shape_mode;					// 形状?ード
												//	 0:形状指令なし、1:直線、
												//	 2:ＣＷ円弧、3:ＣＣＷ円弧、
												//	 4:ＣＷ渦巻き、5:ＣＣＷ渦巻き、
												//	 6:ＣＷヘ?カ?、7:ＣＣＷヘ?カ?、
												//	 8:ＣＷ渦巻きヘ?カ?、9:ＣＣＷ渦巻きヘ?カ?
	public short arc_plane_i;					// 円弧平面横軸
												// 円弧平面を構成する横軸の系?内軸番?
												//	 系?内第1軸:0、第２軸:1、...
	public short arc_plane_j;					// 円弧平面縦軸
												// 円弧平面を構成する縦軸の系?内軸番?
												//	 系?内第1軸:0、第２軸:1、...
	public short dummy;							// ダミー
	public short arc_pitch;						// 円弧繰り返し回?
	public short draw_axis_1;					// 描画対象第１軸
												//	 系?内第1軸:0、第２軸:1、...
	public short draw_axis_2;					// 描画対象第２軸
												//	 系?内第1軸:0、第２軸:1、...
	public short draw_axis_3;					// 描画対象第３軸
												//	 系?内第1軸:0、第２軸:1、...
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] start_point;				// 機械座標系始点	   MAX_SYS_AXIS：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] end_point;					// 機械座標系終点	   MAX_SYS_AXIS：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] work_coord_start_point;		// ?ーク座標系始点	   MAX_SYS_AXIS：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public double[] work_coord_end_point;		// ?ーク座標系終点	   MAX_SYS_AXIS：系?内軸?
	public double arc_center_point_h;			// 円弧横軸?心座標
	public double arc_center_point_v;			// 円弧縦軸?心座標
	public double radius;						// 半径
}

// 軌跡情報(8軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct PathData							// 形状情報
{
	public short move_mode;						// 動作?ード
												//	 0:移動なし、1:??り非補間、2:??り補間、
												//	 3:切削?り補間、4:ねじ切り補間、5:スキップ、
												//	 6:?ファ??ス点?帰
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public short[] dummy;						// ダミー
	public ShapeData shape_data;				// 形状情報
}

// チェック描画情報(8軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDraw							// 形状情報
{
	public short exec_status;					// ブ?ック実行状態
												//	 0:停止?、?期状態
												//	 1:実行?（?セット起動?、ブ?ック実行?）
												//	 2:プ?グ??完了
												//	 3:M0/M1ブ?ック停止?
												//	 4:エ?ー
	public short abs_inc;						// 絶対?分Ｇ?ーダ?
												//	 0:絶対(G90)、1:?分(G91)
	public short fix_cycle;						// 固定サイク?Ｇ?ーダ?(マシセ?)
												//	 0:G70、1:G71、2:G72、3:G73、4:G74、5:G75、
												//	 6:G76、7:G77、8:G78、9:G79、10:G80、11:G81、
												//	 12:G82、13:G83、14:G84、15:G85、16:G86、17:G87、
												//	 18:G88、19:G89
	public short tool_compen;					// 工具補正Ｇ?ーダ?
												//	 0:G40、1:G41、2:G42
	public short current_work_coord_sys;		// 現在の?ーク座標系
												//	 0:G54、1:G55、2:G56、3:G57、4:G58、5:G59
												//	 6:G54.1P1
	public short process_info;					// 加工情報 0：通常 1：ミー??グ
												//			2：円?補間? 3：傾斜面加工指令?
	public sbyte surface_speed_ctr;				// 0:通常 1:周速一定制御?
	public sbyte feed_info;						// 0:?分?り? 1:?回転?り?
												//	 ねじ切り?は1固定とする。
												//	 同期タップ?も1とするが、
												//	 #1268(bit2)=1(同期タップ?分?り有効)の場?は、
												//	 Gグ?ープ5(G94/G95)?ーダ?に従う。
												//	 非同期タップ?は、常にGグ?ープ5?ーダ?に従う。
	public sbyte unmodal_gcode_flg;				// ア??ーダ?Gコードフ?グ
												//	 bit0：工具軸方向 Gコード指令ブ?ック
												//			 (G53.1/G53.6)
												//	 bit1～bit7：空き(0)
	public sbyte modal_gcode_flag;				// ?ーダ?Gコードフ?グ
												//	 bit0:M/Lプ?グ??動的切り替え
												//			 OFF:無効(G189)、ON:有効(G188)
	public PathData tool_path_data;				// 工具?心軌跡情報
	public PathData prg_path_data;				// プ?グ???心軌跡情報
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;						// Mコード	 0x80000000：指令なし、左記以外：Mコード
	public int t_code;							// Tコード	 0x80000000：指令なし、左記以外：Tコード
	public int d_number;						// Mコード	 指令有/無：mstb_cmd(bit0～bit3)参照
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public int[] h_number;						// Tコード	 指令有/無：mstb_cmd(bit8)参照
	public int f_modal;							// F?ーダ?
	public short mstb_cmd;						// １ブ?ック内でのM、T指令有/無
												//	 0：指令なし／1：指令?り
												//	   bit0 ：Mコード1指令有無
												//	   bit1 ：Mコード2指令有無
												//	   bit2 ：Mコード3指令有無
												//	   bit3 ：Mコード4指令有無
												//	   bit4～bit7：空き
												//	   bit8 ：Tコード指令有無
												//	   bit9～bit15：空き
	public byte path_info;						// 軌跡情報
												//	 BIT0: 補正前仕上げ形状表示 ?
												//	 BIT1: 補正前仕上げ形状表示 サイク?指令点と始点/終点間の移動
												//	 BIT2～7: 未使用
	public sbyte dummy1;						//	dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS)]
	public short[] tool_offset;					// 工具長補正G?ーダ? 0:G43、1:G44、2:G49
	public double cylnd_radius;					// 円?半径(制御単位)
												//	 イニシ??イ?チ?、25.4倍された値となります。
	public int spdl_speed;						// 周速一定制御ON?は周速度(m/min)のS指令値、
												// OFF?は主軸(S)指令回転速度(rev/min)
												//	 指令なしの場?は0
												//	 イニシ??イ?チ(#1041=1)?、周速度は(feet/min)
												//	 ※イニシ??イ?チ、またはG20指令?、
												//	   変換誤差が?ります。
												//
												//	 複?主軸制御Ⅰ?(ext36(bit0)=0)、
												//	 ・第1主軸制御?ード?(G43.1)の場?
												//		 第1主軸の周速度、または回転速度。
												//	 ・選択主軸制御?ード?(G44.1)の場?
												//		 選択主軸番?(#1534 SnG44.1)に設定された
												//		 主軸の周速度、または回転速度。
												//	 ・全主軸同?制御?ード?(G47.1)の場?
												//		 主軸(S)指令の周速度、または回転速度。
												//	 複?主軸制御Ⅱ?(ext36(bit0)=1)、
												//		 最後に指令したS指令の周速度、または回転速度
	public int spdl_clamp_speed;				// 最?主軸ク??プ回転速度(rev/min)
												// G92(主軸ク??プ速度)のS、またはQ指令値
												//	 (GコードはGコード系列で異なる)
												//	 (?期値はク??プ最大値99999999)
												//	 指令なしの場?は?期値と同一
												//	 ※複?主軸制御Ⅱの?、最後に指令した
												//	 ク??プ速度となる
	public double feed;							// ?分?り速度(mm/min)、または、
												// ?回転?り速度(mm/rev)のF指令値
												//	 ねじ切り・同期タップ?はF、またはE指令値となる。
												//	 (E指令が山?指定の場?、ピッチ変換後の値)
												//	 指令なしの場?は0
												//	 イニシ??イ?チ(#1041=1)?は、
												//	 ?分?り速度(inch/min)、
												//	 ?回転?り速度(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;						// 空き(24 -> 8)
}

// 形状情報				   (16軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct ShapeData16						// 形状情報
{
	public short shape_mode;					// 形状?ード
												//	 0:形状指令なし、1:直線、
												//	 2:ＣＷ円弧、3:ＣＣＷ円弧、
												//	 4:ＣＷ渦巻き、5:ＣＣＷ渦巻き、
												//	 6:ＣＷヘ?カ?、7:ＣＣＷヘ?カ?、
												//	 8:ＣＷ渦巻きヘ?カ?、9:ＣＣＷ渦巻きヘ?カ?
	public short arc_plane_i;					// 円弧平面横軸
												// 円弧平面を構成する横軸の系?内軸番?
												//	 系?内第1軸:0、第２軸:1、...
	public short arc_plane_j;					// 円弧平面縦軸
												// 円弧平面を構成する縦軸の系?内軸番?
												//	 系?内第1軸:0、第２軸:1、...
	public short dummy;							// ダミー
	public short arc_pitch;						// 円弧繰り返し回?
	public short draw_axis_1;					// 描画対象第１軸
												//	 系?内第1軸:0、第２軸:1、...
	public short draw_axis_2;					// 描画対象第２軸
												//	 系?内第1軸:0、第２軸:1、...
	public short draw_axis_3;					// 描画対象第３軸
												//	 系?内第1軸:0、第２軸:1、...
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] start_point;				// 機械座標系始点	   MAX_SYS_AXIS16：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] end_point;					// 機械座標系終点	   MAX_SYS_AXIS16：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] work_coord_start_point;		// ?ーク座標系始点	  MAX_SYS_AXIS16：系?内軸?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public double[] work_coord_end_point;		// ?ーク座標系終点	  MAX_SYS_AXIS16：系?内軸?
	public double arc_center_point_h;			// 円弧横軸?心座標
	public double arc_center_point_v;			// 円弧縦軸?心座標
	public double radius;						// 半径
}

// 軌跡情報				   (16軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct PathData16					// 形状情報
{
	public short move_mode;					// 動作?ード
											//	 0:移動なし、1:??り非補間、2:??り補間、
											//	 3:切削?り補間、4:ねじ切り補間、5:スキップ、
											//	 6:?ファ??ス点?帰
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public short[] dummy;					// ダミー
	public ShapeData16 shape_data;			// 形状情報
}

// チェック描画情報		 (16軸分の描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDraw16					// 形状情報
{
	public short exec_status;				// ブ?ック実行状態
											//	 0:停止?、?期状態
											//	 1:実行?（?セット起動?、ブ?ック実行?）
											//	 2:プ?グ??完了
											//	 3:M0/M1ブ?ック停止?
											//	 4:エ?ー
	public short abs_inc;					// 絶対?分Ｇ?ーダ?
											//	 0:絶対(G90)、1:?分(G91)
	public short fix_cycle;					// 固定サイク?Ｇ?ーダ?(マシセ?)
											//	 0:G70、1:G71、2:G72、3:G73、4:G74、5:G75、
											//	 6:G76、7:G77、8:G78、9:G79、10:G80、11:G81、
											//	 12:G82、13:G83、14:G84、15:G85、16:G86、17:G87、
											//	 18:G88、19:G89
	public short tool_compen;				// 工具補正Ｇ?ーダ?
											//	 0:G40、1:G41、2:G42
	public short current_work_coord_sys;	// 現在の?ーク座標系
											//	 0:G54、1:G55、2:G56、3:G57、4:G58、5:G59
											//	 6:G54.1P1
	public short process_info;				// 加工情報 0：通常 1：ミー??グ
											//			2：円?補間? 3：傾斜面加工指令?
	public sbyte surface_speed_ctr;			// 0:通常 1:周速一定制御?
	public sbyte feed_info;					// 0:?分?り? 1:?回転?り?
											//	 ねじ切り?は1固定とする。
											//	 同期タップ?も1とするが、
											//	 #1268(bit2)=1(同期タップ?分?り有効)の場?は、
											//	 Gグ?ープ5(G94/G95)?ーダ?に従う。
											//	 非同期タップ?は、常にGグ?ープ5?ーダ?に従う。
	public sbyte unmodal_gcode_flg;			// ア??ーダ?Gコードフ?グ
											//	 bit0：工具軸方向 Gコード指令ブ?ック
											//			  (G53.1/G53.6)
											//	 bit1～bit7：空き(0)
	public sbyte modal_gcode_flag;			// ?ーダ?Gコードフ?グ
											//	 bit0:M/Lプ?グ??動的切り替え
											//			 OFF:無効(G189)、ON:有効(G188)
	public PathData16 tool_path_data;		// 工具?心軌跡情報
	public PathData16 prg_path_data;		// プ?グ???心軌跡情報
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;					// Mコード	 0x80000000：指令なし、左記以外：Mコード
	public int t_code;						// Tコード	 0x80000000：指令なし、左記以外：Tコード
	public int d_number;					// 工具径補正番??ーダ?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public int[] h_number;					// Tコード	 指令有/無：mstb_cmd(bit8)参照
	public int f_modal;						// F?ーダ?
	public short mstb_cmd;					// １ブ?ック内でのM、T指令有/無
											//	 0：指令なし／1：指令?り
											//	   bit0 ：Mコード1指令有無
											//	   bit1 ：Mコード2指令有無
											//	   bit2 ：Mコード3指令有無
											//	   bit3 ：Mコード4指令有無
											//	   bit4～bit7：空き
											//	   bit8 ：Tコード指令有無
											//	   bit9～bit15：空き
	public short dummy1;					// dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public short[] tool_offset;				// 工具長補正G?ーダ? 0:G43、1:G44、2:G49
	public double cylnd_radius;				// 円?半径(制御単位)
											//	 イニシ??イ?チ?、25.4倍された値となります。
	public int spdl_speed;					// 周速一定制御ON?は周速度(m/min)のS指令値、
											// OFF?は主軸(S)指令回転速度(rev/min)
											//	 指令なしの場?は0
											//	 イニシ??イ?チ(#1041=1)?、周速度は(feet/min)
											//	 ※イニシ??イ?チ、またはG20指令?、
											//	   変換誤差が?ります。
											//
											//	 複?主軸制御Ⅰ?(ext36(bit0)=0)、
											//	 ・第1主軸制御?ード?(G43.1)の場?
											//		 第1主軸の周速度、または回転速度。
											//	 ・選択主軸制御?ード?(G44.1)の場?
											//		 選択主軸番?(#1534 SnG44.1)に設定された
											//		 主軸の周速度、または回転速度。
											//	 ・全主軸同?制御?ード?(G47.1)の場?
											//		 主軸(S)指令の周速度、または回転速度。
											//	 複?主軸制御Ⅱ?(ext36(bit0)=1)、
											//		 最後に指令したS指令の周速度、または回転速度
	public int spdl_clamp_speed;			// 最?主軸ク??プ回転速度(rev/min)
											// G92(主軸ク??プ速度)のS、またはQ指令値
											//	 (GコードはGコード系列で異なる)
											//	 (?期値はク??プ最大値99999999)
											//	 指令なしの場?は?期値と同一
											//	 ※複?主軸制御Ⅱの?、最後に指令した
											//	 ク??プ速度となる
	public double feed;						// ?分?り速度(mm/min)、または、
											// ?回転?り速度(mm/rev)のF指令値
											//	 ねじ切り・同期タップ?はF、またはE指令値となる。
											//	 (E指令が山?指定の場?、ピッチ変換後の値)
											//	 指令なしの場?は0
											//	 イニシ??イ?チ(#1041=1)?は、
											//	 ?分?り速度(inch/min)、
											//	 ?回転?り速度(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;					// 空き(24 -> 8)
}

// チェック描画情報		 (16軸分のチェック?速?ード用描画データ)
[StructLayout(LayoutKind.Sequential)]
public struct CheckDrawQS					// 形状情報
{
	public short exec_status;				// ブ?ック実行状態
											//	 0:停止?、?期状態
											//	 1:実行?（?セット起動?、ブ?ック実行?）
											//	 2:プ?グ??完了
											//	 3:M0/M1ブ?ック停止?
											//	 4:エ?ー
	public short abs_inc;					// 絶対?分Ｇ?ーダ?
											//	 0:絶対(G90)、1:?分(G91)
	public short fix_cycle;					// 固定サイク?Ｇ?ーダ?(マシセ?)
											//	 0:G70、1:G71、2:G72、3:G73、4:G74、5:G75、
											//	 6:G76、7:G77、8:G78、9:G79、10:G80、11:G81、
											//	 12:G82、13:G83、14:G84、15:G85、16:G86、17:G87、
											//	 18:G88、19:G89
	public short tool_compen;				// 工具補正Ｇ?ーダ?
											//	 0:G40、1:G41、2:G42
	public short current_work_coord_sys;	// 現在の?ーク座標系
											//	 0:G54、1:G55、2:G56、3:G57、4:G58、5:G59
											//	 6:G54.1P1
	public short process_info;				// 加工情報 0：通常 1：ミー??グ
											//			2：円?補間? 3：傾斜面加工指令?
	public sbyte surface_speed_ctr;			// 0:通常 1:周速一定制御?
	public sbyte feed_info;					// 0:?分?り? 1:?回転?り?
											//	 ねじ切り?は1固定とする。
											//	 同期タップ?も1とするが、
											//	 #1268(bit2)=1(同期タップ?分?り有効)の場?は、
											//	 Gグ?ープ5(G94/G95)?ーダ?に従う。
											//	 非同期タップ?は、常にGグ?ープ5?ーダ?に従う。
	public sbyte unmodal_gcode_flg;			// ア??ーダ?Gコードフ?グ
											//	 bit0：工具軸方向 Gコード指令ブ?ック
											//			  (G53.1/G53.6)
											//	 bit1～bit7：空き(0)
	public sbyte modal_gcode_flag;			// ?ーダ?Gコードフ?グ
											//	 bit0:M/Lプ?グ??動的切り替え
											//			 OFF:無効(G189)、ON:有効(G188)
	public PathData16 tool_path_data;		// 工具?心軌跡情報
	public PathData16 prg_path_data;		// プ?グ???心軌跡情報
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public int[] m_code;					// Mコード	 0x80000000：指令なし、左記以外：Mコード
	public int t_code;						// Tコード	 0x80000000：指令なし、左記以外：Tコード
	public int d_number;					// 工具径補正番??ーダ?
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public int[] h_number;					// Tコード	 指令有/無：mstb_cmd(bit8)参照
	public int f_modal;						// F?ーダ?
	public short mstb_cmd;					// １ブ?ック内でのM、T指令有/無
											//	 0：指令なし／1：指令?り
											//	   bit0 ：Mコード1指令有無
											//	   bit1 ：Mコード2指令有無
											//	   bit2 ：Mコード3指令有無
											//	   bit3 ：Mコード4指令有無
											//	   bit4～bit7：空き
											//	   bit8 ：Tコード指令有無
											//	   bit9～bit15：空き
	public short dummy1;					// dummy
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = g_check.MAX_SYS_AXIS16)]
	public short[] tool_offset;				// 工具長補正G?ーダ? 0:G43、1:G44、2:G49
	public double cylnd_radius;				// 円?半径(制御単位)
											//	 イニシ??イ?チ?、25.4倍された値となります。
	public int spdl_speed;					// 周速一定制御ON?は周速度(m/min)のS指令値、
											// OFF?は主軸(S)指令回転速度(rev/min)
											//	 指令なしの場?は0
											//	 イニシ??イ?チ(#1041=1)?、周速度は(feet/min)
											//	 ※イニシ??イ?チ、またはG20指令?、
											//	   変換誤差が?ります。
											//
											//	 複?主軸制御Ⅰ?(ext36(bit0)=0)、
											//	 ・第1主軸制御?ード?(G43.1)の場?
											//		 第1主軸の周速度、または回転速度。
											//	 ・選択主軸制御?ード?(G44.1)の場?
											//		 選択主軸番?(#1534 SnG44.1)に設定された
											//		 主軸の周速度、または回転速度。
											//	 ・全主軸同?制御?ード?(G47.1)の場?
											//		 主軸(S)指令の周速度、または回転速度。
											//	 複?主軸制御Ⅱ?(ext36(bit0)=1)、
											//		 最後に指令したS指令の周速度、または回転速度
	public int spdl_clamp_speed;			// 最?主軸ク??プ回転速度(rev/min)
											// G92(主軸ク??プ速度)のS、またはQ指令値
											//	 (GコードはGコード系列で異なる)
											//	 (?期値はク??プ最大値99999999)
											//	 指令なしの場?は?期値と同一
											//	 ※複?主軸制御Ⅱの?、最後に指令した
											//	 ク??プ速度となる
	public double feed;						// ?分?り速度(mm/min)、または、
											// ?回転?り速度(mm/rev)のF指令値
											//	 ねじ切り・同期タップ?はF、またはE指令値となる。
											//	 (E指令が山?指定の場?、ピッチ変換後の値)
											//	 指令なしの場?は0
											//	 イニシ??イ?チ(#1041=1)?は、
											//	 ?分?り速度(inch/min)、
											//	 ?回転?り速度(inch/rev)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public sbyte[] dummy2;					// 空き(24 -> 8)
	public short sToolType;					// 工具種別
	public short sToolUsage;				// 工具用途
	public short sToolDir;					// 工具方向
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public sbyte[] dummy3;					// ダミー
	public double dToolWidth;				// 工具?(工具径)
	public double dCutWidth;				// 刃先?
	public double dToolAngle;				// 工具??角
	public double dCutAngle;				// 刃先角
	public double dTopAngle;				// 先端角
	public uint lAdrFlag;					// 固定サイク?指令アド?スのデータ有無ビットフ?グ
											//	 BIT0：アド?スAのデータ有無(0：無、1：有)
											//	 BIT1：アド?スDのデータ有無(0：無、1：有)
											//	 BIT2：アド?スFのデータ有無(0：無、1：有)
											//	 BIT3：アド?スIのデータ有無(0：無、1：有)
											//	 BIT4：アド?スJのデータ有無(0：無、1：有)
											//	 BIT5：アド?スKのデータ有無(0：無、1：有)
											//	 BIT6：アド?スPのデータ有無(0：無、1：有)
											//	 BIT7：アド?スQのデータ有無(0：無、1：有)
											//	 BIT8：アド?スRのデータ有無(0：無、1：有)
											//	 BIT9：アド?スZのデータ有無(0：無、1：有)
											//	 BIT10～32：予備
	public sbyte cDrill_axis;				// ??け軸系?内軸番?(無効値:-1)
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	public sbyte[] dummy4;					// ダミー
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public double[] dAdrData;				// 固定サイク?指令アド?スのデータ
											//	 [0]アド?スAのデータ
											//	 [1]アド?スDのデータ
											//	 [2]アド?スFのデータ
											//	 [3]アド?スIのデータ
											//	 [4]アド?スJのデータ
											//	 [5]アド?スKのデータ
											//	 [6]アド?スPのデータ
											//	 [7]アド?スQのデータ
											//	 [8]アド?スRのデータ
											//	 [9]アド?スZのデータ
											//	 [10]～[15]予備
}
