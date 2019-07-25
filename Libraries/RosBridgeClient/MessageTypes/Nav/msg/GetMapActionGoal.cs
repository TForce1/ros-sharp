/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Nav
{
    public class GetMapActionGoal : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "nav_msgs/GetMapActionGoal";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header;
        public GoalID goal_id;
        public GetMapGoal goal;

        public GetMapActionGoal()
        {
            this.header = new Header();
            this.goal_id = new GoalID();
            this.goal = new GetMapGoal();
        }

        public GetMapActionGoal(Header header, GoalID goal_id, GetMapGoal goal)
        {
            this.header = header;
            this.goal_id = goal_id;
            this.goal = goal;
        }
    }
}
