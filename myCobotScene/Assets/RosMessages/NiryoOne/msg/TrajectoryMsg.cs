//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.NiryoOne
{
    [Serializable]
    public class TrajectoryMsg : Message
    {
        public const string k_RosMessageName = "niryo_one_msgs/Trajectory";
        public override string RosMessageName => k_RosMessageName;

        public int id;
        public string name;
        public string description;
        public TrajectoryPlanMsg trajectory_plan;

        public TrajectoryMsg()
        {
            this.id = 0;
            this.name = "";
            this.description = "";
            this.trajectory_plan = new TrajectoryPlanMsg();
        }

        public TrajectoryMsg(int id, string name, string description, TrajectoryPlanMsg trajectory_plan)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.trajectory_plan = trajectory_plan;
        }

        public static TrajectoryMsg Deserialize(MessageDeserializer deserializer) => new TrajectoryMsg(deserializer);

        private TrajectoryMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.id);
            deserializer.Read(out this.name);
            deserializer.Read(out this.description);
            this.trajectory_plan = TrajectoryPlanMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.id);
            serializer.Write(this.name);
            serializer.Write(this.description);
            serializer.Write(this.trajectory_plan);
        }

        public override string ToString()
        {
            return "TrajectoryMsg: " +
            "\nid: " + id.ToString() +
            "\nname: " + name.ToString() +
            "\ndescription: " + description.ToString() +
            "\ntrajectory_plan: " + trajectory_plan.ToString();
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
