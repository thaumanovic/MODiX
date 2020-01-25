﻿namespace Modix.Services.UserInfo
{
    internal class UserInfoParticipationDto
    {
        public UserInfoParticipationDto(int userRank, int totalNumberOfMessagesInPeriod,
            int totalNumberOfMessagesIn7Days, double averageMessagesSent, double percentile)
        {
            UserRank = userRank;
            TotalNumberOfMessagesInPeriod = totalNumberOfMessagesInPeriod;
            TotalNumberOfMessagesIn7Days = totalNumberOfMessagesIn7Days;
            AverageMessagesSent = averageMessagesSent;
            Percentile = percentile;
        }

        public int UserRank { get; }
        public int TotalNumberOfMessagesInPeriod { get; }
        public int TotalNumberOfMessagesIn7Days { get; }
        public double AverageMessagesSent { get; }
        public double Percentile { get; }

        public UserInfoParticipationTopChannelDto? TopChannelParticipation { get; set; }

        public class UserInfoParticipationTopChannelDto
        {
            public UserInfoParticipationTopChannelDto(ulong channelId, int numberOfMessages)
            {
                ChannelId = channelId;
                NumberOfMessages = numberOfMessages;
            }

            public ulong ChannelId { get; }
            public int NumberOfMessages { get; }
        }
    }
}
