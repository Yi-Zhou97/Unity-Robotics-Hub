using System;
using System.Collections.Generic;
using System.Text;
using RosMessageGeneration;
using RosMessageTypes.Std;
using RosMessageTypes.Actionlib;

namespace RosMessageTypes.NiryoOne
{
    public class JoystickJointsActionResult : Message
    {
        public const string RosMessageName = "niryo_one_msgs/JoystickJointsActionResult";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public Header header { get; set; }
        public GoalStatus status { get; set; }
        public JoystickJointsResult result { get; set; }

        public JoystickJointsActionResult()
        {
            this.header = new Header();
            this.status = new GoalStatus();
            this.result = new JoystickJointsResult();
        }

        public JoystickJointsActionResult(Header header, GoalStatus status, JoystickJointsResult result)
        {
            this.header = header;
            this.status = status;
            this.result = result;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(header.SerializationStatements());
            listOfSerializations.AddRange(status.SerializationStatements());
            listOfSerializations.AddRange(result.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.header.Deserialize(data, offset);
            offset = this.status.Deserialize(data, offset);
            offset = this.result.Deserialize(data, offset);

            return offset;
        }

    }
}