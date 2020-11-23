
# On VM:

<li>install rosbridge_server</li>
<ol>
    <li>sudo apt-get install ros-< rosdistro >-rosbridge-suite</li>
    <li>source /opt/ros/<rosdistro>/setup.bash</li>
    <li>rospack profile</li>
</ol>

<li>roslaunch rosbridge_server rosbridge_websocket.launch</li>
<ol>
    <li>the launch file is here: sudo vi /opt/ros/melodic/share/rosbridge_server/launch/rosbridge_websocket.launch</li>
    <li>set the IP to the ip of the VM (not 127.0.0.1)</li>
    <li>might need to change the netwoek adapter of the VM from NAT to "custom" and choose VMnet8(NAT)</li>

</ol>
<li>rosrun rqt_graph rqt_graph</li>
<li>install talker</li>
<ol>
    <li>cd ~/catkin_ws/src/</li>
    <li>catkin_create_pkg beginner_tutorials std_msgs rospy roscpp</li>
    <li>cd beginner_tutorials/src</li>
    <li>download from: https://mega.nz/#!dsQ01CYa!llVkuQ-JhW9SlOwNBHMlKuv215Mks-DX1BO2g8hqdsg</li>
    <li>extract the archive ArchivosPY.tar.gz here</li>
    <li>cd ~/catkin_ws;catkin_make</li>
    <li>. ~/catkin_ws/devel/setup.bash</li>
    <li>rospack find beginner_tutorials</li>
    <li>rosrun beginner_tutorials talker.py</li>
</ol>
<li>disable VM firewall: sudo ufw disable</li>

# On windows: Unity

<li>Create unity world</li>
<ol>
    <li>Add ros connector</li>
    <ol>
        <li>in unity: Create empty object - ROSConnector</li>
        <li>add Component: Ros Connector</li>
        <ol>
            <li>protocol -> Web Socket Sharp</li>
            <li>Ros Bridge Server URl -> "ws://{RosBridge IP}:9090"</li>
        </ol>
        <li>add Component: Pose Stamped Subscriber</li>
        <ol>
            <li>Script -> "PoseStampedSubscriber"</li>
            <li>Topic -> "/chatter_"</li>
            <li>enter the script and make the following changes</li>
            <ol>
                <li>change all the poseStamped to pose</li>
                <li>change position to public</li>
                <li>remove PublishedTransform</li>
            </ol>
        </ol>
        <li>add depth camera</li>
        <ol>
            <li>enter: https://www.immersivelimit.com/tutorials/unity-depth-camera-simulation</li>
            <li>clone: https://github.com/immersive-limit/Unity-ComputerVisionSim</li>
            <li>from the Assets folder copy to your project: ImageSynthesis  </li>
            <li>add component to main camera - imageSynthesis  </li>
            <ol>
                <li>uber Replacement Shader -> UberReplacement </li>
                <li>Optical Flow Shader -> OpticalFlow </li>
                <li>edit the ImageSynthesis script so to replace the shader of the main camera with the DepthCompressed.
                "        SetupCameraWithReplacementShader(capturePasses[0].camera, uberReplacementShader, ReplacementMode.DepthCompressed, Color.white);" </li>
            </ol>
            <li>Publish depth</li>
            <ol>
                <li>add ImagePublisher component to ROSConnector</li>
                <li>set Topic to /depth/compressed</li>
                <li>set Image Camera to main Camera</li>
                <li>on VM: open RVIZ and add Image, choose /depth as topic and compressed as Transport Hint</li>
            </ol>
        </ol>
    </ol>
</ol>
