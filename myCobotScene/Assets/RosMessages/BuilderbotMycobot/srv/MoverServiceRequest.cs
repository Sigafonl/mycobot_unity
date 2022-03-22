//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.BuilderbotMycobot
{
    [Serializable]
    public class MoverServiceRequest : Message
    {
        public const string k_RosMessageName = "builderbot_mycobot/MoverService";
        public override string RosMessageName => k_RosMessageName;

        public MyCobotMoveitJointsMsg joints_input;
        public Geometry.PoseMsg pick_pose;
        public Geometry.PoseMsg place_pose;

        public MoverServiceRequest()
        {
            this.joints_input = new MyCobotMoveitJointsMsg();
            this.pick_pose = new Geometry.PoseMsg();
            this.place_pose = new Geometry.PoseMsg();
        }

        public MoverServiceRequest(MyCobotMoveitJointsMsg joints_input, Geometry.PoseMsg pick_pose, Geometry.PoseMsg place_pose)
        {
            this.joints_input = joints_input;
            this.pick_pose = pick_pose;
            this.place_pose = place_pose;
        }

        public static MoverServiceRequest Deserialize(MessageDeserializer deserializer) => new MoverServiceRequest(deserializer);

        private MoverServiceRequest(MessageDeserializer deserializer)
        {
            this.joints_input = MyCobotMoveitJointsMsg.Deserialize(deserializer);
            this.pick_pose = Geometry.PoseMsg.Deserialize(deserializer);
            this.place_pose = Geometry.PoseMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.joints_input);
            serializer.Write(this.pick_pose);
            serializer.Write(this.place_pose);
        }

        public override string ToString()
        {
            return "MoverServiceRequest: " +
            "\njoints_input: " + joints_input.ToString() +
            "\npick_pose: " + pick_pose.ToString() +
            "\nplace_pose: " + place_pose.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
