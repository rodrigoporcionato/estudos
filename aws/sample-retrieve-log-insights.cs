using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;

namespace LogInsights
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var client = new AmazonCloudWatchLogsClient("xxxxxxx", "xxxxxx");

            string groupName = "/xxxxx";

            var describreLogStreamRequest = new DescribeLogStreamsRequest()
            {
                 LogGroupName = groupName,
                 Descending = true
            };

            var describeLogStreamsResult = client.DescribeLogStreams(describreLogStreamRequest);

            foreach (var stream in describeLogStreamsResult.LogStreams) 
            {
                var eventsRequest = new GetLogEventsRequest()
                {
                    StartTime = DateTime.Now.AddDays(-1),
                    EndTime = DateTime.Now,
                    LogStreamName = stream.LogStreamName,
                    LogGroupName = describreLogStreamRequest.LogGroupName,
                };
                var result = client.GetLogEvents(eventsRequest);
                foreach (var events in result.Events)
                {
                    Console.WriteLine(events.Timestamp + "  - " + events.Message);
                }
            }
        }
    }
}
