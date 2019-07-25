/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class RegionOfInterest : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "sensor_msgs/RegionOfInterest";

        //  This message is used to specify a region of interest within an image.
        // 
        //  When used to specify the ROI setting of the camera when the image was
        //  taken, the height and width fields should either match the height and
        //  width fields for the associated image; or height = width = 0
        //  indicates that the full resolution image was captured.
        public uint x_offset;
        //  Leftmost pixel of the ROI
        //  (0 if the ROI includes the left edge of the image)
        public uint y_offset;
        //  Topmost pixel of the ROI
        //  (0 if the ROI includes the top edge of the image)
        public uint height;
        //  Height of ROI
        public uint width;
        //  Width of ROI
        //  True if a distinct rectified ROI should be calculated from the "raw"
        //  ROI in this message. Typically this should be False if the full image
        //  is captured (ROI not used), and True if a subwindow is captured (ROI
        //  used).
        public bool do_rectify;

        public RegionOfInterest()
        {
            this.x_offset = 0;
            this.y_offset = 0;
            this.height = 0;
            this.width = 0;
            this.do_rectify = false;
        }

        public RegionOfInterest(uint x_offset, uint y_offset, uint height, uint width, bool do_rectify)
        {
            this.x_offset = x_offset;
            this.y_offset = y_offset;
            this.height = height;
            this.width = width;
            this.do_rectify = do_rectify;
        }
    }
}
