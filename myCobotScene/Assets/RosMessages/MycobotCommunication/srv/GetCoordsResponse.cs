//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.MycobotCommunication
{
    [Serializable]
    public class GetCoordsResponse : Message
    {
        public const string k_RosMessageName = "mycobot_communication/GetCoords";
        public override string RosMessageName => k_RosMessageName;

        public float x;
        public float y;
        public float z;
        public float rx;
        public float ry;
        public float rz;

        public GetCoordsResponse()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
            this.rx = 0.0f;
            this.ry = 0.0f;
            this.rz = 0.0f;
        }

        public GetCoordsResponse(float x, float y, float z, float rx, float ry, float rz)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.rx = rx;
            this.ry = ry;
            this.rz = rz;
        }

        public static GetCoordsResponse Deserialize(MessageDeserializer deserializer) => new GetCoordsResponse(deserializer);

        private GetCoordsResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.x);
            deserializer.Read(out this.y);
            deserializer.Read(out this.z);
            deserializer.Read(out this.rx);
            deserializer.Read(out this.ry);
            deserializer.Read(out this.rz);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.x);
            serializer.Write(this.y);
            serializer.Write(this.z);
            serializer.Write(this.rx);
            serializer.Write(this.ry);
            serializer.Write(this.rz);
        }

        public override string ToString()
        {
            return "GetCoordsResponse: " +
            "\nx: " + x.ToString() +
            "\ny: " + y.ToString() +
            "\nz: " + z.ToString() +
            "\nrx: " + rx.ToString() +
            "\nry: " + ry.ToString() +
            "\nrz: " + rz.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
