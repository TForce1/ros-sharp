/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class GetParamNamesResponse : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "rosapi/GetParamNames";

        public string[] names;

        public GetParamNamesResponse()
        {
            this.names = new string[0];
        }

        public GetParamNamesResponse(string[] names)
        {
            this.names = names;
        }
    }
}
