using System.Windows.Forms;
using System.Drawing;

namespace Smart_AI_Creator
{
    public class DataHandler
    {
        public static void ShowEventType(ComboBox combobox, ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, Label l1, Label l2, Label l3, Label l4)
        {
            ((GroupBox)combobox.Parent).Reset();

            switch ((event_type)combobox.SelectedValue.ToUInt32())
            {
                case event_type.TIMER:
                case event_type.TIMER_OOC:
                case event_type.UPDATE:
                    l1.Text = "InitialMin (мs)";
                    l2.Text = "InitialMax (мs)";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.HP:
                case event_type.TARGET_HP:
                    l1.Text = "HPMax%";
                    l2.Text = "HPMin%";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.MANA:
                case event_type.TARGET_MANA:
                    l1.Text = "ManaMax%";
                    l2.Text = "ManaMin%";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.KILL:
                    l1.Text = "CooldownMin (мs)";
                    l2.Text = "CooldownMax (мs)";
                    l3.Text = "playerOnly2";
                    l4.Text = "creature entry3";
                    break;
                case event_type.TARGET_CASTING:
                    l1.Text = "RepeatMin  (мs)";
                    l2.Text = "RepeatMax  (мs)";
                    break;
                case event_type.SPELLHIT:
                case event_type.SPELLHIT_TARGET:
                    l1.Text = "SpellID";
                    l2.Text = "School";
                    l3.Text = "CooldownMin (мs)";
                    l4.Text = "CooldownMax (мs)";
                    break;
                case event_type.RANGE:
                    l1.Text = "MinDist";
                    l2.Text = "MaxDist";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.OOC_LOS:
                    l1.Text = "Hostile-or-Not";
                    cb1.SetEnumValues<TargetFrends>("", "", true);
                    l2.Text = "MaxAllowedRange";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.RESPAWN:
                    l1.Text = "Type";
                    l2.Text = "MapId";
                    l3.Text = "ZoneId";
                    break;
                case event_type.FRIENDLY_HP:
                    l1.Text = "HPDeficit";
                    l2.Text = "Radius";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.FRIENDLY_IS_CC:
                case event_type.IC_LOS:
                    l1.Text = "Radius";
                    l2.Text = "RepeatMin (мs)";
                    l3.Text = "RepeatMax (мs)";
                    break;
                case event_type.FRIENDLY_MISSING_BUFF:
                    l1.Text = "SpellId";
                    l2.Text = "Radius";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.SUMMONED_UNIT:
                case event_type.SUMMON_DESPAWNED:
                    l1.Text = "CreatureId";
                    l2.Text = "CooldownMin (ms)";
                    l3.Text = "CooldownMax (ms)";
                    break;
                case event_type.REWARD_QUEST:
                case event_type.ACCEPTED_QUEST:
                    l1.Text = "QuestID";
                    break;
                case event_type.RECEIVE_EMOTE:
                    l1.Text = "EmoteID";
                    l2.Text = "CooldownMin (ms)";
                    l3.Text = "CooldownMax (ms)";
                    l4.Text = "condition";
                    break;
                case event_type.HAS_AURA:
                case event_type.TARGET_BUFFED:
                    l1.Text = "SpellID";
                    l2.Text = "Stacks";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.PASSENGER_BOARDED:
                case event_type.PASSENGER_REMOVED:
                    l1.Text = "CooldownMin (ms)";
                    l2.Text = "CooldownMax (ms)";
                    break;
                case event_type.DAMAGED:
                case event_type.DAMAGED_TARGET:
                    l1.Text = "MinDmg";
                    l2.Text = "MaxDmg ";
                    l3.Text = "RepeatMin (мs)";
                    l4.Text = "RepeatMax (мs)";
                    break;
                case event_type.MOVEMENTINFORM:
                    l1.Text = "MovementType";
                    l2.Text = "PointID";
                    break;
                case event_type.DATA_SET:
                    l1.Text = "Field";
                    l2.Text = "Value";
                    l3.Text = "CooldownMin (ms)";
                    l4.Text = "CooldownMax (ms)";
                    break;
                case event_type.WAYPOINT_START:
                case event_type.WAYPOINT_REACHED:
                case event_type.WAYPOINT_PAUSED:
                case event_type.WAYPOINT_RESUMED:
                case event_type.WAYPOINT_STOPPED:
                case event_type.WAYPOINT_ENDED:
                    l1.Text = "PointID";
                    l2.Text = "PathID";
                    break;
                case event_type.TRANSPORT_ADDCREATURE:
                    l1.Text = "Entry";
                    break;
                case event_type.TRANSPORT_RELOCATE:
                    l1.Text = "PointID";
                    break;
                case event_type.INSTANCE_PLAYER_ENTER:
                    l1.Text = "Team";
                    l2.Text = "CooldownMin (ms)";
                    l3.Text = "CooldownMax (ms)";
                    break;
                case event_type.AREATRIGGER_ONTRIGGER:
                case event_type.TIMED_EVENT_TRIGGERED:
                    l1.Text = "TriggerID";
                    break;
                case event_type.TEXT_OVER:
                    l1.Text = "GroupId";
                    l2.Text = "CreatureId";
                    break;
                case event_type.RECEIVE_HEAL:
                    l1.Text = "MinHeal";
                    l2.Text = "MaxHeal";
                    l3.Text = "CooldownMin (ms)";
                    l4.Text = "CooldownMax (ms)";
                    break;
                case event_type.GOSSIP_SELECT:
                    l1.Text = "MenuID";
                    l2.Text = "ID";
                    break;
                case event_type.DUMMY_EFFECT:
                    l1.Text = "SpellID";
                    l2.Text = "EffectIndex";
                    break;
            }

            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
        }

        public static void ShowTargetType(ComboBox combobox, ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, ComboBox cb5, ComboBox cb6, ComboBox cb7,
            Label l1, Label l2, Label l3, Label l4, Label l5, Label l6, Label l7)
        {
            ((GroupBox)combobox.Parent).Reset();

            switch ((target_type)combobox.SelectedValue.ToUInt32())
            {
                case target_type.POSITION:
                    l4.Text = "TagetPostionX";
                    l5.Text = "TagetPostionZ";
                    l6.Text = "TagetPostionY";
                    l7.Text = "TagetPostionO";
                    break;
                case target_type.CREATURE_RANGE:
                    l1.Text = "CreatureEntry";
                    l2.Text = "minDist";
                    l3.Text = "maxDist";
                    break;
                case target_type.CREATURE_GUID:
                case target_type.GAMEOBJECT_GUID:
                    l1.Text = "Guid";
                    l2.Text = "Entry";
                    break;
                case target_type.CREATURE_DISTANCE:
                    l1.Text = "CreatureEntry";
                    l2.Text = "maxDist";
                    break;
                case target_type.STORED:
                    l1.Text = "ID";
                    break;
                case target_type.GAMEOBJECT_RANGE:
                    l1.Text = "GoEntry";
                    l2.Text = "minDist";
                    l3.Text = "maxDist";
                    break;
                case target_type.GAMEOBJECT_DISTANCE:
                    l1.Text = "GoEntry";
                    l2.Text = "maxDist";
                    break;
                case target_type.PLAYER_RANGE:
                    l1.Text = "minDist";
                    l2.Text = "maxDist";
                    break;
                case target_type.PLAYER_DISTANCE:
                    l1.Text = "maxDist";
                    break;
                case target_type.CLOSEST_CREATURE:
                    l1.Text = "CreatureEntry";
                    break;
                case target_type.CLOSEST_GAMEOBJECT:
                    l1.Text = "GoEntry";
                    break;
            }

            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
            cb5.Visible = l5.Text != string.Empty;
            cb6.Visible = l6.Text != string.Empty;
            cb7.Visible = l7.Text != string.Empty;
        }

        public static void ShowActionType(ComboBox combobox, ComboBox cb1, ComboBox cb2, ComboBox cb3, ComboBox cb4, ComboBox cb5, ComboBox cb6,
            Label l1, Label l2, Label l3, Label l4, Label l5, Label l6)
        {
            ((GroupBox)combobox.Parent).Reset();

            switch ((action_type)combobox.SelectedValue.ToUInt32())
            {
                case action_type.TALK:
                    l1.Text = "GroupID";
                    l2.Text = "Duration Before Triggered";
                    break;
                case action_type.SET_FACTION:
                    l1.Text = "	FactionID ";
                    break;
                case action_type.MORPH_TO_ENTRY_OR_MODEL:
                case action_type.MOUNT_TO_ENTRY_OR_MODEL:
                    l1.Text = "Entry";
                    l2.Text = "ModelID";
                    break;
                case action_type.SOUND:
                    l1.Text = "SoundId";
                    l2.Text = "TextRange";
                    break;
                case action_type.PLAY_EMOTE:
                case action_type.SET_EMOTE_STATE:
                    l1.Text = "EmoteId";
                    break;
                case action_type.ADD_QUEST:
                case action_type.FAIL_QUEST:
                case action_type.CALL_AREAEXPLOREDOREVENTHAPPENS:
                case action_type.CALL_GROUPEVENTHAPPENS:
                    l1.Text = "QuestID";
                    break;
                case action_type.SET_REACT_STATE:
                    l1.Text = "State";
                    cb1.SetEnumValues<ReactStates>("", "", true);
                    break;
                case action_type.RANDOM_EMOTE:
                    l1.Text = "EmoteId1";
                    l2.Text = "EmoteId2";
                    l3.Text = "EmoteId3";
                    break;
                case action_type.CAST:
                case action_type.INVOKER_CAST:
                    l1.Text = "SpellId";
                    l2.Text = "CastFlags";
                    cb2.SetEnumValues<CastFlags>("", "", true);
                    break;
                case action_type.SUMMON_CREATURE:
                    l1.Text = "CreatureID";
                    l2.Text = "SummonType";
                    cb2.SetEnumValues<SummonTypes>("", "", true);
                    l3.Text = "Duration(ms)";
                    l4.Text = "StorageID (always 0)";
                    cb4.SelectedText = "0";
                    l5.Text = "AttackInvoker";
                    break;
                case action_type.THREAT_ALL_PCT:
                case action_type.THREAT_SINGLE_PCT:
                    l1.Text = "Threat%";
                    break;
                case action_type.SEND_CASTCREATUREORGO:
                    l1.Text = "QuestID";
                    l2.Text = "SpellID";
                    break;
                case action_type.SET_UNIT_FLAG:
                case action_type.REMOVE_UNIT_FLAG:
                    l1.Text = "UnitFlag";   //add enum
                    break;
                case action_type.AUTO_ATTACK:
                    l1.Text = "AllowAttackState";
                    break;
                case action_type.ALLOW_COMBAT_MOVEMENT:
                    l1.Text = "AllowCombatMovement";
                    break;
                case action_type.SET_EVENT_PHASE:
                case action_type.SET_INGAME_PHASE_MASK:
                    l1.Text = "PhaseMask";  //Implement
                    break;
                case action_type.INC_EVENT_PHASE:
                    l1.Text = "Increment";
                    l1.Text = "Decrement";
                    break;
                case action_type.CALL_CASTEDCREATUREORGO:
                    l1.Text = "Entry";
                    l2.Text = "SpellID";
                    break;
                case action_type.REMOVEAURASFROMSPELL:
                    l1.Text = "SpellId";
                    break;
                case action_type.FOLLOW:
                    l1.Text = "Distance";
                    l2.Text = "Angle";
                    l3.Text = "EndCreatureEntry";
                    l4.Text = "Credit";
                    l5.Text = "CreditType";
                    break;
                case action_type.RANDOM_PHASE:
                    l1.Text = "PhaseMask1";  //Implement
                    l2.Text = "PhaseMask2";  //Implement
                    l3.Text = "PhaseMask3";  //Implement
                    break;
                case action_type.RANDOM_PHASE_RANGE:
                    l1.Text = "PhaseMask_Min";  //Implement
                    l2.Text = "PhaseMask_max";  //Implement
                    break;
                case action_type.CALL_KILLEDMONSTER:
                    l1.Text = "CreatureId";
                    break;
                case action_type.SET_INST_DATA:
                case action_type.SET_DATA:
                    l1.Text = "Field";
                    l2.Text = "Data";
                    break;
                case action_type.SET_INST_DATA64:
                    l1.Text = "Field";
                    break;
                case action_type.UPDATE_TEMPLATE:
                    l1.Text = "Entry";
                    l2.Text = "Team";
                    break;
                case action_type.CALL_FOR_HELP:
                    l1.Text = "Radius";
                    break;
                case action_type.SET_SHEATH:
                    l1.Text = "Sheath";
                    cb1.SetEnumValues<Sheath>("", "", true);
                    break;
                case action_type.FORCE_DESPAWN:
                case action_type.WP_PAUSE:
                    l1.Text = "Timer";
                    break;
                case action_type.SET_INVINCIBILITY_HP_LEVEL:
                    l1.Text = "MinHpValue";
                    break;
                case action_type.MOVE_FORWARD:
                case action_type.RANDOM_MOVE:
                    l1.Text = "Distance";
                    break;
                case action_type.SET_VISIBILITY:
                case action_type.SET_RUN:
                case action_type.SET_FLY:
                case action_type.SET_SWIM:
                    l1.Text = "0/1";        //unknown
                    break;
                case action_type.SUMMON_GO:
                    l1.Text = "Entry";
                    l2.Text = "DespawnTime(ms)";
                    break;
                case action_type.ACTIVATE_TAXI:
                    l1.Text = "TaxiID";
                    break;
                case action_type.WP_START:
                    l1.Text = "Run/Walk";
                    l2.Text = "WayPointEntry";
                    l3.Text = "CanRepeat";
                    l4.Text = "QuestEntry";
                    l5.Text = "DespawnTime";
                    l5.Text = "ReactState";
                    cb5.SetEnumValues<ReactStates>("", "", true);
                    break;
                case action_type.WP_STOP:
                    l1.Text = "DespawnTime";
                    l2.Text = "QuestEntry";
                    l3.Text = "Fail";       // true/false
                    break;
                case action_type.ADD_ITEM:
                case action_type.REMOVE_ITEM:
                    l1.Text = "ItemEntry";
                    l2.Text = "Count";
                    break;
                case action_type.INSTALL_AI_TEMPLATE:
                    l1.Text = "AITemplateID";
                    break;
                case action_type.TELEPORT:
                    l1.Text = "MapID";
                    break;
                case action_type.STORE_VARIABLE_DECIMAL:
                    l1.Text = "varID";
                    l2.Text = "number";
                    break;
                case action_type.STORE_TARGET_LIST:
                    l1.Text = "varID";
                    break;
                case action_type.CREATE_TIMED_EVENT:
                    l1.Text = "ID";
                    l2.Text = "InitialMin";
                    l3.Text = "InitialMax";
                    l4.Text = "RepeatMin";
                    l5.Text = "RepeatMax";
                    l6.Text = "Chance";
                    break;
                case action_type.PLAYMOVIE:
                    l1.Text = "Entry";
                    break;
                case action_type.EQUIP:
                    l1.Text = "EquipID";
                    l2.Text = "Slotmask";
                    l3.Text = "slot1";
                    l4.Text = "slot2";
                    l5.Text = "slot3";
                    break;
                case action_type.TRIGGER_TIMED_EVENT:
                case action_type.REMOVE_TIMED_EVENT:
                    l1.Text = "ID";
                    break;
                case action_type.ADD_AURA:
                    l1.Text = "SpellID";
                    l2.Text = "Targets";
                    break;
                case action_type.ENTER_VEHICLE:
                    l1.Text = "SeatID";
                    break;
                case action_type.CALL_TIMED_ACTIONLIST:
                    l1.Text = "ID";
                    l2.Text = "StopAfterCombat";    // true/false
                    l3.Text = "TimerUpdateType";    // (0-OOC,1-IC,2-ALWAYS) 
                    break;
                case action_type.SET_NPC_FLAG:
                case action_type.ADD_NPC_FLAG:
                case action_type.REMOVE_NPC_FLAG:
                    l1.Text = "NPCFlag";
                    break;
                case action_type.SIMPLE_TALK:
                    l1.Text = "GroupID";
                    break;
                case action_type.CROSS_CAST:
                    l1.Text = "SpellId";
                    l2.Text = "CastFlags";
                    cb2.SetEnumValues<CastFlags>("", "", true);
                    l3.Text = "CasterTargetType";
                    l4.Text = "CasterTargetParam1";
                    l5.Text = "CasterTargetParam2";
                    l6.Text = "CasterTargetParam3";
                    break;
                case action_type.SET_UNIT_FIELD_BYTES_1:
                case action_type.REMOVE_UNIT_FIELD_BYTES_1:
                    l1.Text = "Value";
                    break;
                case action_type.INTERRUPT_SPELL:
                    l1.Text = "WithDelay";  //bool
                    l2.Text = "SpellId";
                    l3.Text = "WithInstant";    //bool
                    break;
                case action_type.SEND_GO_CUSTOM_ANIM:
                    l1.Text = "AnimProgress";
                    break;
                case action_type.SET_DYNAMIC_FLAG:
                case action_type.ADD_DYNAMIC_FLAG:
                case action_type.REMOVE_DYNAMIC_FLAG:
                    l1.Text = "DynamicFlag";   //enum
                    break;
            }

            cb1.Visible = l1.Text != string.Empty;
            cb2.Visible = l2.Text != string.Empty;
            cb3.Visible = l3.Text != string.Empty;
            cb4.Visible = l4.Text != string.Empty;
            cb5.Visible = l5.Text != string.Empty;
            cb6.Visible = l6.Text != string.Empty;
        }
    }
}