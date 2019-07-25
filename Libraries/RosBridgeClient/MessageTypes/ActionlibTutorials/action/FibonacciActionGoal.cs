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

namespace RosSharp.RosBridgeClient.MessageTypes.ActionlibTutorials
{
    public class FibonacciActionGoal : ActionGoal<FibonacciGoal>
    {
        [JsonIgnore]
        public const string RosMessageName = "actionlib_tutorials/FibonacciActionGoal";

        public FibonacciActionGoal() : base()
        {
            this.goal = new FibonacciGoal();
        }

        public FibonacciActionGoal(Header header, GoalID goal_id, FibonacciGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}
