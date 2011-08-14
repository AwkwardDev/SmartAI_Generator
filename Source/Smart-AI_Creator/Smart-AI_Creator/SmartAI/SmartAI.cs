using System;

namespace Smart_AI_Creator
{
    public class SmartAI
    {
        public int EntryOrGuid;
        public int SourceType;
        public int ID;
        public int Link;
        public int EventType;
        public int EventPhaseMask;
        public int EventChance;
        public int EventFlags;
        public int[] EventParam;
        public int ActionType;
        public int[] ActionParam;
        public int TargetType;
        public int[] TargetParam;
        public float TargetX;
        public float TargetY;
        public float TargetZ;
        public float TargetO;
        public string Comment;

        public SmartAI()
        {
            EventParam = new int[4];
            ActionParam = new int[6];
            TargetParam = new int[3];
        }

        public string[] ToArray()
        {
            return new[]
            {
                EntryOrGuid.ToString(),
                SourceType.ToString(),
                ID.ToString(),
                Link.ToString(),
                EventType.ToString(),
                EventPhaseMask.ToString(),
                EventChance.ToString(),
                EventFlags.ToString(),
                EventParam[0].ToString(),
                EventParam[1].ToString(),
                EventParam[2].ToString(),
                EventParam[3].ToString(),
                ActionType.ToString(),
                ActionParam[0].ToString(),
                ActionParam[1].ToString(),
                ActionParam[2].ToString(),
                ActionParam[3].ToString(),
                ActionParam[4].ToString(),
                ActionParam[5].ToString(),
                TargetType.ToString(),
                TargetParam[0].ToString(),
                TargetParam[1].ToString(),
                TargetParam[2].ToString(),
                TargetX.ToString(),
                TargetY.ToString(),
                TargetZ.ToString(),
                TargetO.ToString(),
                Comment
            };
        }
    }
}