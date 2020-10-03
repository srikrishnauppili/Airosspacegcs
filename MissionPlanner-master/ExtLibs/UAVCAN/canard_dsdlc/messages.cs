using System; namespace UAVCAN {public partial class uavcan { public static readonly (Type,UInt16, ulong)[] MSG_INFO = {(typeof(uavcan_equipment_actuator_ArrayCommand), 1010, 0xD8A7486238EC3AF3),
(typeof(uavcan_equipment_actuator_Status), 1011, 0x5E9BBA44FAF1EA04),
(typeof(uavcan_equipment_ahrs_Solution), 1000, 0x72A63A3C6F41FA9B),
(typeof(uavcan_equipment_ahrs_MagneticFieldStrength), 1001, 0xE2A7D4A9460BC2F2),
(typeof(uavcan_equipment_ahrs_MagneticFieldStrength2), 1002, 0xB6AC0C442430297E),
(typeof(uavcan_equipment_ahrs_RawIMU), 1003, 0x8280632C40E574B5),
(typeof(uavcan_equipment_air_data_TrueAirspeed), 1020, 0x306F69E0A591AFAA),
(typeof(uavcan_equipment_air_data_IndicatedAirspeed), 1021, 0xA1892D72AB8945F),
(typeof(uavcan_equipment_air_data_AngleOfAttack), 1025, 0xD5513C3F7AFAC74E),
(typeof(uavcan_equipment_air_data_Sideslip), 1026, 0x7B48E55FCFF42A57),
(typeof(uavcan_equipment_air_data_RawAirData), 1027, 0xC77DF38BA122F5DA),
(typeof(uavcan_equipment_air_data_StaticPressure), 1028, 0xCDC7C43412BDC89A),
(typeof(uavcan_equipment_air_data_StaticTemperature), 1029, 0x49272A6477D96271),
(typeof(uavcan_equipment_camera_gimbal_AngularCommand), 1040, 0x4AF6E57B2B2BE29C),
(typeof(uavcan_equipment_camera_gimbal_GEOPOICommand), 1041, 0x9371428A92F01FD6),
(typeof(uavcan_equipment_camera_gimbal_Status), 1044, 0xB9F127865BE0D61E),
(typeof(uavcan_equipment_device_Temperature), 1110, 0x70261C28A94144C6),
(typeof(uavcan_equipment_esc_RawCommand), 1030, 0x217F5C87D7EC951D),
(typeof(uavcan_equipment_esc_RPMCommand), 1031, 0xCE0F9F621CF7E70B),
(typeof(uavcan_equipment_esc_Status), 1034, 0xA9AF28AEA2FBB254),
(typeof(uavcan_equipment_gnss_Fix), 1060, 0x54C1572B9E07F297),
(typeof(uavcan_equipment_gnss_Auxiliary), 1061, 0x9BE8BDC4C3DBBFD2),
(typeof(uavcan_equipment_gnss_RTCMStream), 1062, 0x1F56030ECB171501),
(typeof(uavcan_equipment_gnss_Fix2), 1063, 0xCA41E7000F37435F),
(typeof(uavcan_equipment_hardpoint_Command), 1070, 0xA1A036268B0C3455),
(typeof(uavcan_equipment_hardpoint_Status), 1071, 0x624A519D42553D82),
(typeof(uavcan_equipment_ice_FuelTankStatus), 1129, 0x286B4A387BA84BC4),
(typeof(uavcan_equipment_ice_reciprocating_Status), 1120, 0xD38AA3EE75537EC6),
(typeof(uavcan_equipment_indication_BeepCommand), 1080, 0xBE9EA9FEC2B15D52),
(typeof(uavcan_equipment_indication_LightsCommand), 1081, 0x2031D93C8BDD1EC4),
(typeof(uavcan_equipment_power_PrimaryPowerSupplyStatus), 1090, 0xBBA05074AD757480),
(typeof(uavcan_equipment_power_CircuitStatus), 1091, 0x8313D33D0DDDA115),
(typeof(uavcan_equipment_power_BatteryInfo), 1092, 0x249C26548A711966),
(typeof(uavcan_equipment_range_sensor_Measurement), 1050, 0x68FFFE70FC771952),
(typeof(uavcan_equipment_safety_ArmingStatus), 1100, 0x8700F375556A8003),
(typeof(uavcan_navigation_GlobalNavigationSolution), 2000, 0x463B10CCCBE51C3D),
(typeof(uavcan_olliw_storm32_Control), 28300, 0xBF15FB6305CE5599),
(typeof(uavcan_olliw_storm32_Status), 28301, 0xFD38D6AA0F5099A5),
(typeof(uavcan_olliw_storm32_Command), 28302, 0x49874D32ADB9DA75),
(typeof(uavcan_olliw_storm32_CommandAck), 28303, 0x883EA85F57ACBBBD),
(typeof(uavcan_olliw_uc4h_GenericBatteryInfo), 28310, 0x4711AD8CBD503D5),
(typeof(uavcan_olliw_uc4h_Notify), 28340, 0x69BC2CB0D471C96F),
(typeof(uavcan_olliw_uc4h_Distance), 28350, 0xE12C901C6174B583),
(typeof(uavcan_protocol_GetNodeInfo_req), 1, 0xEE468A8121C46A9E),
(typeof(uavcan_protocol_GetNodeInfo_res), 1, 0xEE468A8121C46A9E),
(typeof(uavcan_protocol_GetDataTypeInfo_req), 2, 0x1B283338A7BED2D8),
(typeof(uavcan_protocol_GetDataTypeInfo_res), 2, 0x1B283338A7BED2D8),
(typeof(uavcan_protocol_NodeStatus), 341, 0xF0868D0C1A7C6F1),
(typeof(uavcan_protocol_GetTransportStats_req), 4, 0xBE6F76A7EC312B04),
(typeof(uavcan_protocol_GetTransportStats_res), 4, 0xBE6F76A7EC312B04),
(typeof(uavcan_protocol_GlobalTimeSync), 4, 0x20271116A793C2DB),
(typeof(uavcan_protocol_Panic), 5, 0x8B79B4101811C1D7),
(typeof(uavcan_protocol_RestartNode_req), 5, 0x569E05394A3017F0),
(typeof(uavcan_protocol_RestartNode_res), 5, 0x569E05394A3017F0),
(typeof(uavcan_protocol_AccessCommandShell_req), 6, 0x59276B5921C9246E),
(typeof(uavcan_protocol_AccessCommandShell_res), 6, 0x59276B5921C9246E),
(typeof(uavcan_protocol_debug_KeyValue), 16370, 0xE02F25D6E0C98AE0),
(typeof(uavcan_protocol_debug_LogMessage), 16383, 0xD654A48E0C049D75),
(typeof(uavcan_protocol_dynamic_node_id_Allocation), 1, 0xB2A812620A11D40),
(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_req), 30, 0x8032C7097B48A3CC),
(typeof(uavcan_protocol_dynamic_node_id_server_AppendEntries_res), 30, 0x8032C7097B48A3CC),
(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_req), 31, 0xCDDE07BB89A56356),
(typeof(uavcan_protocol_dynamic_node_id_server_RequestVote_res), 31, 0xCDDE07BB89A56356),
(typeof(uavcan_protocol_dynamic_node_id_server_Discovery), 390, 0x821AE2F525F69F21),
(typeof(uavcan_protocol_enumeration_Begin_req), 15, 0x196AE06426A3B5D8),
(typeof(uavcan_protocol_enumeration_Begin_res), 15, 0x196AE06426A3B5D8),
(typeof(uavcan_protocol_enumeration_Indication), 380, 0x884CB63050A84F35),
(typeof(uavcan_protocol_file_BeginFirmwareUpdate_req), 40, 0xB7D725DF72724126),
(typeof(uavcan_protocol_file_BeginFirmwareUpdate_res), 40, 0xB7D725DF72724126),
(typeof(uavcan_protocol_file_GetInfo_req), 45, 0x5004891EE8A27531),
(typeof(uavcan_protocol_file_GetInfo_res), 45, 0x5004891EE8A27531),
(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_req), 46, 0x8C46E8AB568BDA79),
(typeof(uavcan_protocol_file_GetDirectoryEntryInfo_res), 46, 0x8C46E8AB568BDA79),
(typeof(uavcan_protocol_file_Delete_req), 47, 0x78648C99170B47AA),
(typeof(uavcan_protocol_file_Delete_res), 47, 0x78648C99170B47AA),
(typeof(uavcan_protocol_file_Read_req), 48, 0x8DCDCA939F33F678),
(typeof(uavcan_protocol_file_Read_res), 48, 0x8DCDCA939F33F678),
(typeof(uavcan_protocol_file_Write_req), 49, 0x515AA1DC77E58429),
(typeof(uavcan_protocol_file_Write_res), 49, 0x515AA1DC77E58429),
(typeof(uavcan_protocol_param_ExecuteOpcode_req), 10, 0x3B131AC5EB69D2CD),
(typeof(uavcan_protocol_param_ExecuteOpcode_res), 10, 0x3B131AC5EB69D2CD),
(typeof(uavcan_protocol_param_GetSet_req), 11, 0xA7B622F939D1A4D5),
(typeof(uavcan_protocol_param_GetSet_res), 11, 0xA7B622F939D1A4D5),
(typeof(org_cubepilot_uwb_Observation), 20759, 0x817EABC2996B0D62),
(typeof(com_hex_equipment_flow_Measurement), 20200, 0x6A908866BCB49C18),
(typeof(com_hex_equipment_gnss_BodyPosition), 20210, 0x68DD4C23FEC97050),
(typeof(com_hex_equipment_gnss_MovingBaseFix), 20211, 0x22930B91F2563B98),
(typeof(ardupilot_equipment_trafficmonitor_TrafficReport), 20790, 0x68E45DB60B6981F8),
(typeof(ardupilot_indication_SafetyState), 20000, 0xE965701A95A1A6A1),
(typeof(ardupilot_indication_Button), 20001, 0x645A46EFBA7466E),
};}}